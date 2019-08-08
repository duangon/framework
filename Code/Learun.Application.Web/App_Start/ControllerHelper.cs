using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web.Mvc;

namespace Learun.Application.Web
{
    public class ControllerHelper
    {
        /// <summary>
        /// 通过反射得到所有可用的action
        /// </summary>
        /// <returns></returns>
        public static string GetControllerAndAction()
        {
            //创建控制器类型列表
            List<Type> controllerTypes = new List<Type>();

            //加载程序集
            var assembly = Assembly.GetExecutingAssembly();

            //获取程序集下所有的类，通过Linq筛选继承IController类的所有类型
            controllerTypes.AddRange(assembly.GetTypes().Where(type => typeof(IController).IsAssignableFrom(type) && type.Name != "ErrorController"));

            //创建动态字符串，拼接json数据    注：现在json类型传递数据比较流行，比xml简洁
            StringBuilder jsonBuilder = new StringBuilder();
            jsonBuilder.Append("[");

            //遍历控制器类
            foreach (var controller in controllerTypes)
            {
                jsonBuilder.Append("{\"controllerName\":\"");
                jsonBuilder.Append(controller.Name);
                jsonBuilder.Append("\",\"controllerDesc\":\"");
                jsonBuilder.Append((controller.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute) == null ? "" : (controller.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute).Description);

                //获取对控制器的描述Description
                jsonBuilder.Append("\",\"action\":[");

                //获取控制器下所有返回类型为ActionResult的方法，对MVC的权限控制只要限制所以的前后台交互请求就行，统一为ActionResult
                var actions = controller.GetMethods().Where(method => method.ReturnType.Name == "ActionResult");
                foreach (var action in actions)
                {
                    jsonBuilder.Append("{\"actionName\":\"");
                    jsonBuilder.Append(action.Name);
                    jsonBuilder.Append("\",\"actionDesc\":\"");
                    jsonBuilder.Append((action.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute) == null ? "" : (action.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute).Description);    //获取对Action的描述
                    jsonBuilder.Append("\"},");
                }
                jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
                jsonBuilder.Append("]},");
            }
            jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
            jsonBuilder.Append("]");
            return jsonBuilder.ToString();
        }

        /// <summary>
        /// 通过反射得到所有可用的action
        /// </summary>
        /// <returns></returns>
        public static List<string> GetALLPageByReflection()
        {
            List<string> actions = new List<string>();
            var asm = System.Reflection.Assembly.GetExecutingAssembly();
            System.Collections.Generic.List<Type> typeList = new List<Type>();
            var types = asm.GetTypes();
            foreach (Type type in types)
            {
                string s = type.FullName.ToLower();
                if (type.Name.StartsWith("AccountCont")) continue;
                //if (s.StartsWith("mvctmm.controllers.") && s.EndsWith("controller"))
                if (s.EndsWith("controller"))
                    typeList.Add(type);
            }
            typeList.Sort(delegate (Type type1, Type type2) { return type1.FullName.CompareTo(type2.FullName); });
            foreach (Type type in typeList)
            {
                //Response.Write(type.Name.Replace("Controller","") + "<br/>\n");
                //System.Reflection.MemberInfo[] members = type.FindMembers(System.Reflection.MemberTypes.Method,
                //System.Reflection.BindingFlags.Public |
                //System.Reflection.BindingFlags.Static |
                //System.Reflection.BindingFlags.NonPublic |        //【位屏蔽】
                //System.Reflection.BindingFlags.Instance |
                //System.Reflection.BindingFlags.DeclaredOnly,
                //Type.FilterName, "*");
                MethodInfo[] members = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                foreach (var m in members)
                {
                    if (m.DeclaringType.Attributes.HasFlag(System.Reflection.TypeAttributes.Public) != true)
                        continue;
                    string areas = "";
                    if (type.FullName.Contains(".Areas.")) {
                        int begin = type.FullName.IndexOf(".Areas.") + 7;
                        int end = type.FullName.Substring(begin).IndexOf(".");
                        areas = "/" + type.FullName.Substring(begin, end);
                    }
                    string controller = type.Name.Replace("Controller", "");
                    string action = m.Name;
                    string url = areas + "/" + controller + "/" + action;
                    var param = m.GetParameters();
                    if (param.Length > 0) {
                        url += " [";
                    }
                    for (int i = 0; i < param.Length; i++)
                    {
                        if (i != 0) {
                            url += ", ";
                        }
                        url += $"{param[i].ParameterType.Name} {param[i].Name}";
                    }
                    if (param.Length > 0)
                    {
                        url += "]";
                    }
                    actions.Add(url);
                }
            }
            return actions;
        }
    }
}