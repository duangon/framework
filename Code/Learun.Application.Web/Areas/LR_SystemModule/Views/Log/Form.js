﻿/*
 * 版 本 Learun-ADMS V7.0.0 鞍钢矿业敏捷开发框架(http://www.learun.cn)
 * Copyright (c) 2013-2018 鞍钢矿业信息技术有限公司
 * 创建人：鞍钢矿业-前端开发组
 * 日 期：2017.04.11
 * 描 述：清空日志管理	
 */
var categoryId = request('categoryId');
var acceptClick;
var bootstrap = function ($, learun) {
    "use strict";

    var page = {
        init: function () {
            $('#keepTime').lrselect({maxHeight:75,placeholder:false}).lrselectSet(7);
        }
    };
    // 保存数据
    acceptClick = function (callBack) {
        if (!$('#form').lrValidform()) {
            return false;
        }
        var postData = $('#form').lrGetFormData();
        postData['categoryId'] = categoryId;
        $.lrSaveForm('/LR_SystemModule/Log/SaveRemoveLog', postData, function (res) {
            // 保存成功后才回调
            if (!!callBack) {
                callBack();
            }
        });
    };
    page.init();
}