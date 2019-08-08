﻿//(function (l, t, o) {
//    var m = l([]),
//        q = l.resize = l.extend(l.resize, {}),
//        u,
//        w = "setTimeout",
//        v = "resize",
//        p = v + "-special-event",
//        n = "delay",
//        r = "throttleWindow";
//    q[n] = 250;
//    q[r] = true;
//    l.event.special[v] = {
//        setup: function () {
//            if (!q[r] && this[w]) {
//                return false
//            }
//            var a = l(this);
//            m = m.add(a);
//            l.data(this, p, {
//                w: a.width(),
//                h: a.height()
//            });
//            if (m.length === 1) {
//                s()
//            }
//        },
//        teardown: function () {
//            if (!q[r] && this[w]) {
//                return false
//            }
//            var a = l(this);
//            m = m.not(a);
//            a.removeData(p);
//            if (!m.length) {
//                clearTimeout(u)
//            }
//        },
//        add: function (a) {
//            if (!q[r] && this[w]) {
//                return false
//            }
//            var c;
//            function b(h, d, e) {
//                var f = l(this),
//                    g = l.data(this, p);
//                g.w = d !== o ? d : f.width();
//                g.h = e !== o ? e : f.height();
//                c.apply(this, arguments)
//            }
//            if (l.isFunction(a)) {
//                c = a;
//                return b
//            } else {
//                c = a.handler;
//                a.handler = b
//            }
//        }
//    };
//    function s() {
//        u = t[w](function () {
//            m.each(function () {
//                var c = l(this),
//                    b = c.width(),
//                    a = c.height(),
//                    d = l.data(this, p);
//                if (b !== d.w || a !== d.h) {
//                    c.trigger(v, [d.w = b, d.h = a])
//                }
//            });
//            s()
//        },
//            q[n])
//    }
//})(jQuery, this);



(function (a) {
    var l = ["wheel", "mousewheel", "DOMMouseScroll", "MozMousePixelScroll"],
        k = ("onwheel" in document || document.documentMode >= 9) ? ["wheel"] : ["mousewheel", "DomMouseScroll", "MozMousePixelScroll"],
        h = Array.prototype.slice,
        f,
        d;
    if (a.event.fixHooks) {
        for (var c = l.length; c;) {
            a.event.fixHooks[l[--c]] = a.event.mouseHooks
        }
    }
    var j = a.event.special.mousewheel = {
        setup: function () {
            if (this.addEventListener) {
                for (var m = k.length; m;) {
                    this.addEventListener(k[--m], b, false)
                }
            } else {
                this.onmousewheel = b
            }
            a.data(this, "mousewheel-line-height", j.getLineHeight(this));
            a.data(this, "mousewheel-page-height", j.getPageHeight(this))
        },
        teardown: function () {
            if (this.removeEventListener) {
                for (var m = k.length; m;) {
                    this.removeEventListener(k[--m], b, false)
                }
            } else {
                this.onmousewheel = null
            }
        },
        getLineHeight: function (i) {
            return parseInt(a(i)["offsetParent" in a.fn ? "offsetParent" : "parent"]().css("fontSize"), 10)
        },
        getPageHeight: function (i) {
            return a(i).height()
        },
        settings: {
            adjustOldDeltas: true
        }
    };
    a.fn.extend({
        mousewheel: function (i) {
            return i ? this.bind("mousewheel", i) : this.trigger("mousewheel")
        },
        unmousewheel: function (i) {
            return this.unbind("mousewheel", i)
        }
    });
    function b(q) {
        var s = q || window.event,
            m = h.call(arguments, 1),
            n = 0,
            o = 0,
            p = 0,
            i = 0;
        q = a.event.fix(s);
        q.type = "mousewheel";
        if ("detail" in s) {
            p = s.detail * -1
        }
        if ("wheelDelta" in s) {
            p = s.wheelDelta
        }
        if ("wheelDeltaY" in s) {
            p = s.wheelDeltaY
        }
        if ("wheelDeltaX" in s) {
            o = s.wheelDeltaX * -1
        }
        if ("axis" in s && s.axis === s.HORIZONTAL_AXIS) {
            o = p * -1;
            p = 0
        }
        n = p === 0 ? o : p;
        if ("deltaY" in s) {
            p = s.deltaY * -1;
            n = p
        }
        if ("deltaX" in s) {
            o = s.deltaX;
            if (p === 0) {
                n = o * -1
            }
        }
        if (p === 0 && o === 0) {
            return
        }
        if (s.deltaMode === 1) {
            var r = a.data(this, "mousewheel-line-height");
            n *= r;
            p *= r;
            o *= r
        } else {
            if (s.deltaMode === 2) {
                var t = a.data(this, "mousewheel-page-height");
                n *= t;
                p *= t;
                o *= t
            }
        }
        i = Math.max(Math.abs(p), Math.abs(o));
        if (!d || i < d) {
            d = i;
            if (g(s, i)) {
                d /= 40
            }
        }
        if (g(s, i)) {
            n /= 40;
            o /= 40;
            p /= 40
        }
        n = Math[n >= 1 ? "floor" : "ceil"](n / d);
        o = Math[o >= 1 ? "floor" : "ceil"](o / d);
        p = Math[p >= 1 ? "floor" : "ceil"](p / d);
        q.deltaX = o;
        q.deltaY = p;
        q.deltaFactor = d;
        q.deltaMode = 0;
        m.unshift(q, n, o, p);
        if (f) {
            clearTimeout(f)
        }
        f = setTimeout(e, 200);
        return (a.event.dispatch || a.event.handle).apply(this, m)
    }
    function e() {
        d = null
    }
    function g(m, i) {
        return j.settings.adjustOldDeltas && m.type === "mousewheel" && i % 120 === 0
    }
})(window.jQuery);



(function (a, c, e) {
    var b = null;
    var d = {
        init: function (j, l) {
            var o = j.attr("id");
            if (!o) {
                o = "LR_" + c.newGuid();
                j.attr("id", o)
            }
            j.addClass("lr-scroll-wrap");
            var f = j.children();
            var i = a('<div class="lr-scroll-box" id="' + o + '_box" ></div>');
            j.append(i);
            i.append(f);
            var k = a('<div class="lr-scroll-vertical"   ><div class="lr-scroll-vertical-block" id="' + o + '_vertical"></div></div>');
            j.append(k);
            var g = a('<div class="lr-scroll-horizontal" ><div class="lr-scroll-horizontal-block" id="' + o + '_horizontal"></div></div>');
            j.append(g);
            if (b === null) {
                b = a('<div style="-moz-user-select: none;-webkit-user-select: none;-ms-user-select: none;-khtml-user-select: none;user-select: none;display: none;position: fixed;top: 0;left: 0;width: 100%;height: 100%;z-index: 9999;cursor: pointer;" ></div>');
                a("body").append(b)
            }
            var p = i.innerHeight();
            var q = i.innerWidth();
            var n = j.height();
            var r = j.width();
            var m = {
                id: o,
                sy: 0,
                sx: 0,
                sh: p,
                sw: q,
                h: n,
                w: r,
                yh: 0,
                xw: 0,
                callback: l
            };
            j[0].op = m;
            d.update(j);
            d.bindEvent(j, i, k, g);
            i = null;
            f = null;
            k = null;
            g = null;
            j = null
        },
        bindEvent: function (h, g, i, f) {
            h.resize(function () {
                var j = a(this);
                var l = j[0].op;
                var k = j.height();
                var m = j.width();
                if (k != l.h) {
                    l.h = k;
                    d.updateY(j)
                }
                if (m != l.w) {
                    l.w = m;
                    d.updateX(j)
                }
                j = null
            });
            g.resize(function () {
                var k = a(this);
                var j = k.parent();
                var l = j[0].op;
                var m = k.innerHeight();
                var n = k.innerWidth();
                if (m != l.sh) {
                    l.sh = m;
                    d.updateY(j)
                }
                if (n != l.sw) {
                    l.sw = n;
                    d.updateX(j)
                }
                k = null;
                j = null
            });
            h.mousewheel(function (p, m, n, o) {
                var k = 4 + (Math.abs(m) - 1) * 0.8;
                var j = a(this);
                var q = j[0].op;
                var l = m * k;
                if (q.sh > q.h) {
                    q.oldsy = q.sy;
                    q.sy = q.sy - l;
                    d.moveY(j, true);
                    j = null;
                    return false
                } else {
                    if (q.sw > q.w) {
                        q.oldsx = q.sx;
                        q.sx = q.sx - l;
                        d.moveX(j, true);
                        j = null;
                        return false
                    }
                }
            });
            i.find(".lr-scroll-vertical-block").on("mousedown",
                function (k) {
                    b.show();
                    var j = a(this).parent().parent();
                    var l = j[0].op;
                    l.isYMousedown = true;
                    l.yMousedown = k.pageY;
                    j.addClass("lr-scroll-active");
                    j = null
                });
            f.find(".lr-scroll-horizontal-block").on("mousedown",
                function (k) {
                    b.show();
                    var j = a(this).parent().parent();
                    var l = j[0].op;
                    l.isXMousedown = true;
                    l.xMousedown = k.pageX;
                    j.addClass("lr-scroll-active");
                    j = null
                });
            top.$(document).on("mousemove", {
                $obj: h
            },
                function (l) {
                    var m = l.data.$obj[0].op;
                    if (m.isYMousedown) {
                        var o = l.pageY;
                        var k = o - m.yMousedown;
                        m.yMousedown = o;
                        m.oldsy = m.sy;
                        m.blockY = m.blockY + k;
                        if ((m.blockY + m.yh) > m.h) {
                            m.blockY = m.h - m.yh
                        }
                        if (m.blockY < 0) {
                            m.blockY = 0
                        }
                        d.getY(m);
                        d.moveY(l.data.$obj)
                    } else {
                        if (m.isXMousedown) {
                            var m = l.data.$obj[0].op;
                            var n = l.pageX;
                            var j = n - m.xMousedown;
                            m.xMousedown = n;
                            m.oldsx = m.sx;
                            m.blockX = m.blockX + j;
                            if ((m.blockX + m.xw) > m.w) {
                                m.blockX = m.w - m.xw
                            }
                            if (m.blockX < 0) {
                                m.blockX = 0
                            }
                            d.getX(m);
                            d.moveX(l.data.$obj)
                        }
                    }
                }).on("mouseup", {
                    $obj: h
                },
                    function (j) {
                        j.data.$obj[0].op.isYMousedown = false;
                        j.data.$obj[0].op.isXMousedown = false;
                        b.hide();
                        j.data.$obj.removeClass("lr-scroll-active")
                    })
        },
        update: function (f) {
            d.updateY(f);
            d.updateX(f)
        },
        updateY: function (g) {
            var k = g[0].op;
            var f = g.find("#" + k.id + "_box");
            var h = g.find("#" + k.id + "_vertical");
            if (k.sh > k.h) {
                if ((k.sh - k.sy) < k.h) {
                    var i = 0;
                    k.sy = k.sh - k.h;
                    if (k.sy < 0) {
                        k.sy = 0
                    } else {
                        i = 0 - k.sy
                    }
                    f.css("top", i + "px")
                }
                var l = parseInt(k.h * k.h / k.sh);
                l = (l < 30 ? 30 : l);
                k.yh = l;
                var j = parseInt(k.sy * (k.h - l) / (k.sh - k.h));
                if ((j + l) > k.h) {
                    j = k.h - l
                }
                if (j < 0) {
                    j = 0
                }
                k.blockY = j;
                h.css({
                    top: j + "px",
                    height: l + "px"
                })
            } else {
                k.blockY = 0;
                k.sy = 0;
                f.css("top", "0px");
                h.css({
                    top: "0px",
                    height: "0px"
                })
            }
            k.callback && k.callback(k.sx, k.sy);
            f = null;
            h = null
        },
        updateX: function (h) {
            var k = h[0].op;
            var g = h.find("#" + k.id + "_box");
            var f = h.find("#" + k.id + "_horizontal");
            if (k.sw > k.w) {
                if ((k.sw - k.sx) < k.w) {
                    var i = 0;
                    k.sx = k.sw - k.w;
                    if (k.sx < 0) {
                        k.sx = 0
                    } else {
                        i = 0 - k.sx
                    }
                    g.css("left", i + "px")
                }
                var l = parseInt(k.w * k.w / k.sw);
                l = (l < 30 ? 30 : l);
                k.xw = l;
                var j = parseInt(k.sx * (k.w - l) / (k.sw - k.w));
                if ((j + l) > k.w) {
                    j = k.w - l
                }
                if (j < 0) {
                    j = 0
                }
                k.blockX = j;
                f.css({
                    left: j + "px",
                    width: l + "px"
                })
            } else {
                k.sx = 0;
                k.blockX = 0;
                g.css("left", "0px");
                f.css({
                    left: "0px",
                    width: "0px"
                })
            }
            k.callback && k.callback(k.sx, k.sy);
            g = null;
            f = null
        },
        moveY: function (g, k) {
            var l = g[0].op;
            var f = g.find("#" + l.id + "_box");
            var h = g.find("#" + l.id + "_vertical");
            var i = 0;
            if (l.sy < 0) {
                l.sy = 0
            } else {
                if (l.sy + l.h > l.sh) {
                    l.sy = l.sh - l.h;
                    i = 0 - l.sy
                } else {
                    i = 0 - l.sy
                }
            }
            if (k) {
                var j = d.getBlockY(l);
                if (j == 0 && l.sy != 0) {
                    l.sy = 0;
                    i = 0
                }
                l.blockY = j;
                f.css({
                    top: i + "px"
                });
                h.css({
                    top: j + "px"
                })
            } else {
                f.css({
                    top: i + "px"
                });
                h.css({
                    top: l.blockY + "px"
                })
            }
            l.callback && l.callback(l.sx, l.sy);
            f = null;
            h = null
        },
        moveX: function (h, k) {
            var l = h[0].op;
            var g = h.find("#" + l.id + "_box");
            var f = h.find("#" + l.id + "_horizontal");
            var i = 0;
            if (l.sx < 0) {
                l.sx = 0
            } else {
                if (l.sx + l.w > l.sw) {
                    l.sx = l.sw - l.w;
                    i = 0 - l.sx
                } else {
                    i = 0 - l.sx
                }
            }
            if (k) {
                var j = d.getBlockX(l);
                if (j == 0 && l.sx != 0) {
                    l.sx = 0;
                    i = 0
                }
                l.blockX = j;
                g.css({
                    left: i + "px"
                });
                f.css({
                    left: j + "px"
                })
            } else {
                g.css({
                    left: i + "px"
                });
                f.css({
                    left: l.blockX + "px"
                })
            }
            l.callback && l.callback(l.sx, l.sy);
            g = null;
            f = null
        },
        getBlockY: function (g) {
            var f = parseFloat(g.sy * (g.h - g.yh) / (g.sh - g.h));
            if ((f + g.yh) > g.h) {
                f = g.h - g.yh
            }
            if (f < 0) {
                f = 0
            }
            return f
        },
        getY: function (f) {
            f.sy = parseInt(f.blockY * (f.sh - f.h) / (f.h - f.yh));
            if ((f.sy + f.h) > f.sh) {
                f.sy = f.sh - f.h
            }
            if (f.sy < 0) {
                f.sy = 0
            }
        },
        getBlockX: function (g) {
            var f = parseFloat(g.sx * (g.w - g.xw) / (g.sw - g.w));
            if ((f + g.xw) > g.w) {
                f = g.w - g.xw
            }
            if (f < 0) {
                f = 0
            }
            return f
        },
        getX: function (f) {
            f.sx = parseInt(f.blockX * (f.sw - f.w) / (f.w - f.xw));
            if ((f.sx + f.w) > f.sw) {
                f.sx = f.sw - f.w
            }
            if (f.sx < 0) {
                f.sx = 0
            }
        },
    };
    a.fn.lrscroll = function (f) {
        a(this).each(function () {
            var g = a(this);
            d.init(g, f)
        })
    };
    a.fn.lrscrollSet = function (h, g) {
        switch (h) {
            case "moveRight":
                var f = a(this);
                setTimeout(function () {
                    var i = f[0].op;
                    i.oldsx = i.sx;
                    i.sx = i.sw - i.w;
                    d.moveX(f, true);
                    f = null
                },
                    250);
                break;
            case "moveBottom":
                var f = a(this);
                setTimeout(function () {
                    var i = f[0].op;
                    i.oldsy = i.sx;
                    i.sy = i.sh - i.h;
                    d.moveY(f, true);
                    f = null
                },
                    250);
                break
        }
    }
})(window.jQuery, top.learun, window);
$(function () {
    var f = {};
    var d = {};
    function e(h) {
        if (h.length > 0) {
            $("#lr_target_content").lrscroll();
            var g = $("#lr_target_content .lr-scroll-box");
            $.each(h,
                function (j, k) {
                    f[k.F_Id] = k;
                    var i = '                    <div class="task-stat" data-Id="' + k.F_Id + '">                        <div class="visual">                            <i class="' + k.F_Icon + '"></i>                        </div>                        <div class="iconbg">                            <i class="' + k.F_Icon + '"></i>                        </div>                        <div class="number" data-value="' + k.F_Id + '"></div>                        <div class="desc">' + k.F_Name + "</div>                    </div>";
                    g.append(i);
                    top.learun.httpAsync("GET", top.$.rootUrl + "/LR_Desktop/DTTarget/GetSqlData", {
                        Id: k.F_Id
                    },
                        function (l) {
                            if (l) {
                                g.find('[data-value="' + l.Id + '"]').text(l.value)
                            }
                        })
                });
            g.find(".task-stat").on("click",
                function () {
                    var i = $(this).attr("data-Id");
                    top.learun.frameTab.open({
                        F_ModuleId: i,
                        F_FullName: f[i].F_Name,
                        F_UrlAddress: f[i].F_Url
                    });
                    return false
                })
        }
    }
    function c(h) {
        if (h.length > 0) {
            $("#lr_desktop_list").lrscroll();
            var g = $("#lr_desktop_list .lr-scroll-box");
            $.each(h,
                function (j, k) {
                    d[k.F_Id] = k;
                    var i = '                <div class="lr-desktop-list"  data-Id="' + k.F_Id + '">                    <div class="title">                        ' + k.F_Name + '                        <span class="menu" title="更多">                            <span class="point"></span>                            <span class="point"></span>                            <span class="point"></span>                        </span>                    </div>                    <div class="content" data-value="' + k.F_Id + '">                    </div>                </div>';
                    g.append(i);
                    top.learun.httpAsync("GET", top.$.rootUrl + "/LR_Desktop/DTList/GetSqlData", {
                        Id: k.F_Id
                    },
                        function (m) {
                            if (m) {
                                var l = g.find('[data-value="' + m.Id + '"]');
                                $.each(m.value,
                                    function (p, q) {
                                        var o = '                            <div class="lr-list-line">                                <div class="point"></div>                                <div class="text">' + q.f_title + '</div>                                <div class="date">' + q.f_time + "</div>                            </div>";
                                        var n = $(o);
                                        n[0].item = q;
                                        l.append(n)
                                    });
                                l.find(".lr-list-line").on("click",
                                    function () {
                                        var n = $(this).parent();
                                        var o = n.attr("data-value");
                                        var p = $(this)[0].item;
                                        if (d[o].F_ItemUrl) {
                                            top.learun.frameTab.open({
                                                F_ModuleId: "dtlist" + p.f_id,
                                                F_FullName: p.f_title,
                                                F_UrlAddress: d[o].F_ItemUrl + p.f_id
                                            })
                                        } else {
                                            top["dtlist" + p.f_id] = p;
                                            top.learun.frameTab.open({
                                                F_ModuleId: "dtlist" + p.f_id,
                                                F_FullName: p.f_title,
                                                F_UrlAddress: "/Utility/ListContentIndex?id=" + p.f_id
                                            })
                                        }
                                        return false
                                    })
                            }
                        })
                });
            g.find(".lr-desktop-list .menu").on("click",
                function () {
                    var i = $(this).parents(".lr-desktop-list");
                    var j = i.attr("data-Id");
                    top.learun.frameTab.open({
                        F_ModuleId: j,
                        F_FullName: d[j].F_Name,
                        F_UrlAddress: d[j].F_Url
                    });
                    return false
                })
        }
    }
    var b = {};
    function a(h) {
        if (h.length > 0) {
            $("#lr_desktop_chart").lrscroll();
            var g = $("#lr_desktop_chart>.lr-scroll-box");
            $.each(h,
                function (j, k) {
                    var i = '                <div class="lr-desktop-chart">                    <div class="title">' + k.F_Name + '</div>                    <div class="content" id="' + k.F_Id + '"  data-type="' + k.F_Type + '"></div>                </div>';
                    g.append(i);
                    b[k.F_Id] = echarts.init(document.getElementById(k.F_Id));
                    top.learun.httpAsync("GET", top.$.rootUrl + "/LR_Desktop/DTChart/GetSqlData", {
                        Id: k.F_Id
                    },
                        function (l) {
                            if (l) {
                                var o = $("#" + l.Id).attr("data-type");
                                var m = [];
                                var p = [];
                                $.each(l.value,
                                    function (q, r) {
                                        m.push(r.name);
                                        p.push(r.value)
                                    });
                                var n = {};
                                switch (o) {
                                    case "0":
                                        n.tooltip = {
                                            trigger: "item",
                                            formatter: "{a} <br/>{b} : {c} ({d}%)"
                                        };
                                        n.legend = {
                                            bottom: "bottom",
                                            data: m
                                        };
                                        n.series = [{
                                            name: "占比",
                                            type: "pie",
                                            radius: "75%",
                                            center: ["50%", "50%"],
                                            label: {
                                                normal: {
                                                    formatter: "{b}:{c}: ({d}%)",
                                                    textStyle: {
                                                        fontWeight: "normal",
                                                        fontSize: 12,
                                                        color: "#333"
                                                    }
                                                }
                                            },
                                            data: l.value,
                                            itemStyle: {
                                                emphasis: {
                                                    shadowBlur: 10,
                                                    shadowOffsetX: 0,
                                                    shadowColor: "rgba(0, 0, 0, 0.5)"
                                                }
                                            }
                                        }];
                                        n.color = ["#df4d4b", "#304552", "#52bbc8", "rgb(224,134,105)", "#8dd5b4", "#5eb57d", "#d78d2f"];
                                        break;
                                    case "1":
                                        n.tooltip = {
                                            trigger: "axis"
                                        };
                                        n.grid = {
                                            bottom: "8%",
                                            containLabel: true
                                        };
                                        n.xAxis = {
                                            type: "category",
                                            boundaryGap: false,
                                            data: m
                                        };
                                        n.yAxis = {
                                            type: "value"
                                        };
                                        n.series = [{
                                            type: "line",
                                            data: p
                                        }];
                                        break;
                                    case "2":
                                        n.tooltip = {
                                            trigger: "axis"
                                        };
                                        n.grid = {
                                            bottom: "8%",
                                            containLabel: true
                                        };
                                        n.xAxis = {
                                            type: "category",
                                            boundaryGap: false,
                                            data: m
                                        };
                                        n.yAxis = {
                                            type: "value"
                                        };
                                        n.series = [{
                                            type: "bar",
                                            data: p
                                        }];
                                        break
                                }
                                b[l.Id].setOption(n)
                            }
                        })
                });
            window.onresize = function (i) {
                $.each(b,
                    function (j, k) {
                        k.resize(i)
                    })
            }
        }
    }
    //top.learun.clientdata.getAsync("desktop", {
    //    callback: function (g) {
    //        console.log(g);
    //        e(g.target || []);
    //        c(g.list || []);
    //        a(g.chart || [])
    //    }
    //})
});