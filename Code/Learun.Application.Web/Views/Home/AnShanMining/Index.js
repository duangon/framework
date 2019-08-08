var bootstrap = function (a, h) {
    var i = {
        init: function () {
            this.load();
            this.bind()
        },
        load: function () {
            var A = h.clientdata.get(["modulesTree"]);
            var B = "0";
            var z = A[B] || [];
            var o = a('<ul class="lr-first-menu-list"></ul>');
            for (var t = 0,
                w = z.length; t < w; t++) {
                var u = z[t];
                if (u.F_IsMenu == 1) {
                    var n = a("<li></li>");
                    if (!!u.F_Description) {
                        n.attr("title", u.F_Description)
                    }
                    var y = '<a id="' + u.F_ModuleId + '" href="javascript:void(0);" class="lr-menu-item2">';
                    y += '<i class="' + u.F_Icon + ' lr-menu-item-icon"></i>';
                    y += '<span class="lr-menu-item-text">' + u.F_FullName + "</span>";
                    y += '<span class="lr-menu-item-arrow"><i class="fa fa-angle-left"></i></span></a>';
                    n.append(y);
                    var F = A[u.F_ModuleId] || [];
                    var q = a('<ul class="lr-second-menu-list"></ul>');
                    var E = false;
                    for (var v = 0,
                        G = F.length; v < G; v++) {
                        var C = F[v];
                        if (C.F_IsMenu == 1) {
                            E = true;
                            var p = a("<li></li>");
                            if (!!C.F_Description) {
                                p.attr("title", C.F_Description)
                            }
                            var D = '<a id="' + C.F_ModuleId + '" href="javascript:void(0);" class="lr-menu-item" >';
                            D += '<i class="' + C.F_Icon + ' lr-menu-item-icon"></i>';
                            D += '<span class="lr-menu-item-text">' + C.F_FullName + "</span>";
                            D += "</a>";
                            p.append(D);
                            var K = A[C.F_ModuleId] || [];
                            var s = a('<ul class="lr-three-menu-list"></ul>');
                            var J = false;
                            for (var x = 0,
                                L = K.length; x < L; x++) {
                                var H = K[x];
                                if (H.F_IsMenu == 1) {
                                    J = true;
                                    var r = a("<li></li>");
                                    r.attr("title", H.F_FullName);
                                    var I = '<a id="' + H.F_ModuleId + '" href="javascript:void(0);" class="lr-menu-item" >';
                                    I += '<i class="' + H.F_Icon + ' lr-menu-item-icon"></i>';
                                    I += '<span class="lr-menu-item-text">' + H.F_FullName + "</span>";
                                    I += "</a>";
                                    r.append(I);
                                    s.append(r)
                                }
                            }
                            if (J) {
                                p.addClass("lr-meun-had");
                                p.find("a").append('<span class="lr-menu-item-arrow"><i class="fa fa-angle-left"></i></span>');
                                p.append(s)
                            }
                            q.append(p)
                        }
                    }
                    if (E) {
                        n.append(q)
                    }
                    o.append(n)
                }
            }
            a("#lr_frame_menu").html(o);
            a(".lr-menu-item-text").each(function () {
                var m = a(this);
                var M = m.text();
                h.language.get(M,
                    function (N) {
                        m.text(N);
                        m.parent().parent().attr("title", N)
                    })
            })
        },
        bind: function () {
            a("#lr_frame_menu").lrscroll();
            a("#lr_frame_menu_btn").on("click",
                function () {
                    var m = a("body");
                    if (m.hasClass("lr-menu-closed")) {
                        m.removeClass("lr-menu-closed")
                    } else {
                        m.addClass("lr-menu-closed")
                    }
                });
            a("#lr_frame_menu a").hover(function () {
                if (a("body").hasClass("lr-menu-closed")) {
                    var m = a(this).attr("id");
                    var n = a("#" + m + ">span").text();
                    layer.tips(n, a(this))
                }
            },
                function () {
                    if (a("body").hasClass("lr-menu-closed")) {
                        layer.closeAll("tips")
                    }
                });
            a(".lr-frame-personCenter .dropdown-toggle").hover(function () {
                if (a("body").hasClass("lr-menu-closed")) {
                    var m = a(this).text();
                    layer.tips(m, a(this))
                }
            },
                function () {
                    if (a("body").hasClass("lr-menu-closed")) {
                        layer.closeAll("tips")
                    }
                });
            a("#lr_frame_menu a").on("click",
                function () {
                    var m = a(this);
                    var p = m.attr("id");
                    var o = h.clientdata.get(["modulesMap", p]);
                    switch (o.F_Target) {
                        case "iframe":
                            if (h.validator.isNotNull(o.F_UrlAddress).code) {
                                h.frameTab.open(o)
                            } else { }
                            break;
                        case "expand":
                            var n = m.next();
                            if (n.is(":visible")) {
                                n.slideUp(500,
                                    function () {
                                        m.removeClass("open")
                                    })
                            } else {
                                if (n.hasClass("lr-second-menu-list")) {
                                    a("#lr_frame_menu .lr-second-menu-list").slideUp(300,
                                        function () {
                                            a(this).prev().removeClass("open")
                                        })
                                } else {
                                    n.parents(".lr-second-menu-list").find(".lr-three-menu-list").slideUp(300,
                                        function () {
                                            a(this).prev().removeClass("open")
                                        })
                                }
                                n.slideDown(300,
                                    function () {
                                        m.addClass("open")
                                    })
                            }
                            break
                    }
                });
        }
    };
    i.init();
};