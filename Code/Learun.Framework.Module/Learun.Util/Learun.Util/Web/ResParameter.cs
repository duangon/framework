namespace Learun.Util
{
    /// <summary>



    /// 日 期：2017.03.08
    /// 接口响应数据
    /// </summary>
    public class ResParameter
    {
        /// <summary>
        /// 接口响应码
        /// </summary>
        public ResponseCode code { get; set; }
        /// <summary>
        /// 接口响应消息
        /// </summary>
        public string info { get; set; }
        /// <summary>
        /// 接口响应数据
        /// </summary>
        public object data { get; set; }
    }


    public class ResParameterExt
    {
        /// <summary>
        /// 接口响应码
        /// </summary>
        public ResponseCode code { get; set; }
        /// <summary>
        /// 接口响应消息
        /// </summary>
        public string info { get; set; }
        /// <summary>
        /// 接口响应数据
        /// </summary>
        public object data { get; set; }


        public object descri  { get; set; }


        public object extra_data { get; set; }

        public string message { get; set; }

        public int success { get; set; } = 1;
    }
}
