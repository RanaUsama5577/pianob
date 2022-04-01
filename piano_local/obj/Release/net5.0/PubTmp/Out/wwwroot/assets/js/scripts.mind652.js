/*!
 * Joo Template
 * Niche Multi-Purpose HTML Template.
 *
 * @package   Joo_Template
 * @author    Jozoor [jozoor.com]
 * @link      https://themeforest.net/user/jozoor/portfolio
 * @copyright 2019 Jozoor [jozoor.com]
 * @license   https://themeforest.net/licenses/standard
 *
 */

if (
    ((function (a, e, s, n) {
        "use strict";
        var r,
            o,
            l,
            d = {},
            t = "scrollbar",
            i = "owl-scroll-handle",
            c = "owl-scroll-handle-dragged",
            u = a("<div>").addClass(i),
            h = a("<div>").addClass("owl-scroll-progress"),
            p = a("<div>").addClass("owl-scrollbar").append(u),
            f = new H(p[0]),
            g = new H(u[0]),
            m = new H(h[0]),
            v = 0,
            y = 0,
            w = "mousemove." + t + " mouseup." + t,
            _ = "touchmove." + t + " touchend." + t,
            b = "click." + t,
            x = ["INPUT", "SELECT", "BUTTON", "TEXTAREA"],
            T = ["overflow", "position"],
            C = ["position", "webkitTransform", "msTransform", "transform", "left", "top", "width", "height"],
            k = 0,
            S = 0,
            j = 1,
            L = 0,
            O = { released: 1, init: 0 },
            P = { start: 0, end: 0, cur: 0, index: 0 },
            R = Math.abs,
            I = Math.sqrt,
            A = Math.pow,
            Q = Math.round;
        Math.max, Math.min;
        !(function () {
            var n = ["", "Webkit", "Moz", "ms", "O"],
                r = s.createElement("div");
            function e(e) {
                for (var t = 0, i = n.length; t < i; t++) {
                    var a = n[t] ? n[t] + e.charAt(0).toUpperCase() + e.slice(1) : e;
                    if (null !== r.style[a]) return a;
                }
            }
            (o = e("transform")), (l = e("perspective") ? "translateZ(0) " : "");
        })();
        var M = function (e) {
            (this.initialized = !1),
                (this._core = e),
                (this.options = {}),
                (this._handlers = {
                    "initialized.owl.carousel refreshed.owl.carousel resized.owl.carousel": a.proxy(function (e) {
                        e.namespace &&
                            this._core.settings.scrollbarType &&
                            function (e) {
                                if (this.initialized) return;
                                var t;
                                this._core.$element.append(p),
                                    u.css({ cursor: "pointer" }),
                                    f.save.apply(f, T),
                                    u.on("touchstart.scrollbar mousedown.scrollbar", { source: i }, z),
                                    (v = p.width()),
                                    (k = e.item.count),
                                    (S = e.page.size),
                                    (j = v / (k - S + 1)),
                                    (L = this._core.options.smartSpeed),
                                    (P.start = 0),
                                    (P.cur = 0),
                                    "progress" === d.scrollbarType ? (p.prepend(h), (y = B(e.item.index)), (t = u.width()), m.save.apply(g, C), h.width(y)) : ((t = j), g.save.apply(g, C), u.width(t));
                                (P.end = v - t), (this.initialized = !0);
                            }.call(this, e);
                    }, this),
                    "translate.owl.carousel": a.proxy(function (e) {
                        e.namespace && this._core.settings.scrollbarType && V.call(this, e);
                    }, this),
                    "drag.owl.carousel": a.proxy(function (e) {
                        e.namespace && this._core.settings.scrollbarType && ((O.init = 1), V.call(this, e));
                    }, this),
                    "dragged.owl.carousel": a.proxy(function (e) {
                        e.namespace && this._core.settings.scrollbarType && (O.init = 0);
                    }, this),
                }),
                (r = this._core = e),
                (this.options = a.extend(M.Defaults, this._core.options)),
                this._core.$element.on(this._handlers),
                (d = this.options);
        };
        function z(e) {
            var t,
                i = "touchstart" === e.type;
            e.data.source;
            O.init ||
                (!i && ((t = e.target), ~a.inArray(t.nodeName, x))) ||
                (i || W(e),
                u.css({ transition: "" }),
                h.css({ transition: "" }),
                (O.released = 0),
                (O.init = 0),
                (O.$source = a(e.target)),
                (O.touch = i),
                (O.pointer = i ? e.originalEvent.touches[0] : e),
                (O.initX = O.pointer.pageX),
                (O.initY = O.pointer.pageY),
                (O.path = 0),
                (O.delta = 0),
                (O.locked = 0),
                (O.pathToLock = 0),
                a(s).on(i ? _ : w, D),
                u.addClass(c));
        }
        function D(e) {
            (O.released = "mouseup" === e.type || "touchend" === e.type),
                (O.pointer = O.touch ? e.originalEvent[O.released ? "changedTouches" : "touches"][0] : e),
                (O.pathX = O.pointer.pageX - O.initX),
                (O.pathY = O.pointer.pageY - O.initY),
                (O.path = I(A(O.pathX, 2) + A(O.pathY, 2))),
                (O.delta = O.pathX + P.cur);
            var t = 0;
            if (O.released || !(O.path < 1)) {
                if (!O.init) {
                    if (O.path < d.scrollDragThreshold) return O.released ? F() : n;
                    if (!(R(O.pathX) > R(O.pathY))) return F();
                    O.init = 1;
                }
                switch ((W(e), !O.locked && O.path > O.pathToLock && O.slidee && ((O.locked = 1), O.$source.on(b, E)), O.released && F(), d.scrollbarType)) {
                    case "scroll":
                        (t = N(O.delta, P.start, P.end)), o ? (u[0].style[o] = l + "translateX(" + t + "px)") : (u[0].style.left = t + "px");
                        break;
                    case "progress":
                        (t = N(O.delta, P.start, P.end)), (h[0].style.width = t + "px"), (u[0].style.left = t + "px");
                }
                O.current = t;
                var i = Q(O.current / j);
                i != P.index && ((P.index = i), r.$element.trigger("to.owl.carousel", [i, L, !0]));
            }
        }
        function F() {
            (O.released = !0),
                a(s).off(O.touch ? _ : w, D),
                u.removeClass(c),
                setTimeout(function () {
                    O.$source.off(b, E);
                }),
                (P.cur = O.current),
                (O.init = 0);
        }
        function E(e) {
            W(e, 1), a(this).off(e.type, E);
        }
        function N(e, t, i) {
            return e < t ? t : i < e ? i : e;
        }
        function H(t) {
            var i = {
                style: {},
                save: function () {
                    if (t && t.nodeType) {
                        for (var e = 0; e < arguments.length; e++) i.style[arguments[e]] = t.style[arguments[e]];
                        return i;
                    }
                },
                restore: function () {
                    if (t && t.nodeType) {
                        for (var e in i.style) i.style.hasOwnProperty(e) && (t.style[e] = i.style[e]);
                        return i;
                    }
                },
            };
            return i;
        }
        function W(e, t) {
            e.preventDefault(), t && e.stopPropagation();
        }
        function B() {
            var e = r.relative(r.current());
            return e < k - S ? j * e : v;
        }
        function V(e) {
            var t, i;
            if (u.length && 0 === O.init)
                switch ((u.css({ transition: "all " + L / 1e3 + "s ease-in-out" }), h.css({ transition: "all " + L / 1e3 + "s ease-in-out" }), d.scrollbarType)) {
                    case "scroll":
                        (t = 0 === (i = r.relative(r.current())) ? 0 : i < k - S ? j * i : v - j), (P.cur = t), o ? (u[0].style[o] = l + "translateX(" + t + "px)") : (u[0].style.left = t + "px");
                        break;
                    case "progress":
                        (t = B()), (P.cur = t), (h[0].style.width = t + "px"), (u[0].style.left = t + "px");
                }
        }
        (M.Defaults = { scrollbarType: "scroll", scrollDragThreshold: 3, scrollbarHandleSize: 10 }),
            (M.prototype.destroy = function () {
                var e, t;
                for (e in this._handlers) this._core.$element.off(e, this._handlers[e]);
                for (t in Object.getOwnPropertyNames(this)) "function" != typeof this[t] && (this[t] = null);
            }),
            (a.fn.owlCarousel.Constructor.Plugins.Scrollbar = M);
    })(window.Zepto || window.jQuery, window, document),
    (function (l, e, t, i) {
        "use strict";
        l(t).ready(function () {
            l(".owl-carousel");
            var e = l(".owl-carousel.dots"),
                t = l(".owl-carousel.no-dots"),
                i = l(".owl-carousel.navs"),
                a = (l(".owl-carousel.scrollbar"), l("html").attr("dir")),
                n = !1;
            (l("body").hasClass("rtl") || l("html").hasClass("rtl") || "rtl" == a) && (n = !0);
            var r = { rtl: n, items: 1, loop: !0, smartSpeed: 1e3, autoplay: !0, autoplayTimeout: 8e3, autoplaySpeed: 1e3, autoplayHoverPause: !0 },
                s = { rtl: n, items: 1, nav: !0, dots: !1, navText: !1, loop: !0, smartSpeed: 1e3, autoplay: !0, autoplayTimeout: 8e3, autoplaySpeed: 1e3, autoplayHoverPause: !0 },
                o = { rtl: n, dots: !1, items: 1, loop: !0, smartSpeed: 1e3, autoplay: !0, autoplayTimeout: 7e3, autoplaySpeed: 1e3, autoplayHoverPause: !0 };
            e.show(),
                t.show(),
                i.show(),
                e.length &&
                    e.each(function () {
                        l(this).hasClass("carousel-items-2") &&
                            l(this).owlCarousel({
                                rtl: n,
                                items: 2,
                                margin: 30,
                                loop: !0,
                                smartSpeed: 1e3,
                                autoplay: !0,
                                autoplayTimeout: 8e3,
                                autoplaySpeed: 1e3,
                                autoplayHoverPause: !0,
                                responsive: { 0: { items: 1, margin: 0 }, 769: { items: 2, margin: 30 }, 1088: { items: 2, margin: 30 }, 1280: { items: 2, margin: 30 } },
                            }),
                            l(this).hasClass("carousel-items-3") &&
                                l(this).owlCarousel({
                                    rtl: n,
                                    items: 3,
                                    margin: 30,
                                    loop: !0,
                                    smartSpeed: 1e3,
                                    autoplay: !0,
                                    autoplayTimeout: 8e3,
                                    autoplaySpeed: 1e3,
                                    autoplayHoverPause: !0,
                                    responsive: { 0: { items: 1, margin: 0 }, 769: { items: 3, margin: 30 }, 1088: { items: 3, margin: 30 }, 1280: { items: 3, margin: 30 } },
                                }),
                            l(this).hasClass("carousel-items-4") &&
                                l(this).owlCarousel({
                                    rtl: n,
                                    items: 4,
                                    margin: 30,
                                    loop: !0,
                                    smartSpeed: 1e3,
                                    autoplay: !0,
                                    autoplayTimeout: 8e3,
                                    autoplaySpeed: 1e3,
                                    autoplayHoverPause: !0,
                                    responsive: { 0: { items: 1, margin: 0 }, 769: { items: 3, margin: 30 }, 1088: { items: 3, margin: 30 }, 1280: { items: 4, margin: 30 } },
                                }),
                            l(this).hasClass("carousel-items-5") &&
                                l(this).owlCarousel({
                                    rtl: n,
                                    items: 5,
                                    margin: 30,
                                    loop: !0,
                                    smartSpeed: 1e3,
                                    autoplay: !0,
                                    autoplayTimeout: 8e3,
                                    autoplaySpeed: 1e3,
                                    autoplayHoverPause: !0,
                                    responsive: { 0: { items: 1, margin: 0 }, 769: { items: 3, margin: 30 }, 1088: { items: 3, margin: 30 }, 1280: { items: 5, margin: 30 } },
                                }),
                            l(this).hasClass("carousel-items-6") &&
                                l(this).owlCarousel({
                                    rtl: n,
                                    items: 6,
                                    margin: 30,
                                    loop: !0,
                                    smartSpeed: 1e3,
                                    autoplay: !0,
                                    autoplayTimeout: 8e3,
                                    autoplaySpeed: 1e3,
                                    autoplayHoverPause: !0,
                                    responsive: { 0: { items: 1, margin: 0 }, 769: { items: 3, margin: 30 }, 1088: { items: 3, margin: 30 }, 1280: { items: 6, margin: 30 } },
                                }),
                            l(this).owlCarousel(r);
                    }),
                i.length &&
                    i.each(function () {
                        l(this).hasClass("carousel-items-2") &&
                            (l(this).hasClass("no-margin")
                                ? l(this).owlCarousel({
                                      rtl: n,
                                      items: 2,
                                      margin: 0,
                                      nav: !0,
                                      dots: !1,
                                      navText: !1,
                                      loop: !0,
                                      smartSpeed: 1e3,
                                      autoplay: !0,
                                      autoplayTimeout: 8e3,
                                      autoplaySpeed: 1e3,
                                      autoplayHoverPause: !0,
                                      responsive: { 0: { items: 1 }, 1088: { items: 2 } },
                                  })
                                : l(this).owlCarousel({
                                      rtl: n,
                                      items: 2,
                                      margin: 30,
                                      nav: !0,
                                      dots: !1,
                                      navText: !1,
                                      loop: !0,
                                      smartSpeed: 1e3,
                                      autoplay: !0,
                                      autoplayTimeout: 8e3,
                                      autoplaySpeed: 1e3,
                                      autoplayHoverPause: !0,
                                      responsive: { 0: { items: 1, margin: 0 }, 1088: { items: 2, margin: 30 } },
                                  })),
                            l(this).hasClass("carousel-items-3") &&
                                (l(this).hasClass("no-margin")
                                    ? l(this).owlCarousel({
                                          rtl: n,
                                          items: 3,
                                          margin: 0,
                                          nav: !0,
                                          dots: !1,
                                          navText: !1,
                                          loop: !0,
                                          smartSpeed: 1e3,
                                          autoplay: !0,
                                          autoplayTimeout: 8e3,
                                          autoplaySpeed: 1e3,
                                          autoplayHoverPause: !0,
                                          responsive: { 0: { items: 1 }, 769: { items: 3 }, 1088: { items: 3 }, 1280: { items: 3 } },
                                      })
                                    : l(this).owlCarousel({
                                          rtl: n,
                                          items: 3,
                                          margin: 30,
                                          nav: !0,
                                          dots: !1,
                                          navText: !1,
                                          loop: !0,
                                          smartSpeed: 1e3,
                                          autoplay: !0,
                                          autoplayTimeout: 8e3,
                                          autoplaySpeed: 1e3,
                                          autoplayHoverPause: !0,
                                          responsive: { 0: { items: 1, margin: 0 }, 769: { items: 3 }, 1088: { items: 3 }, 1280: { items: 3 } },
                                      })),
                            l(this).hasClass("carousel-items-4") &&
                                (l(this).hasClass("no-margin")
                                    ? l(this).owlCarousel({
                                          rtl: n,
                                          items: 4,
                                          margin: 0,
                                          nav: !0,
                                          dots: !1,
                                          navText: !1,
                                          loop: !0,
                                          smartSpeed: 1e3,
                                          autoplay: !0,
                                          autoplayTimeout: 8e3,
                                          autoplaySpeed: 1e3,
                                          autoplayHoverPause: !0,
                                          responsive: { 0: { items: 1 }, 769: { items: 3 }, 1088: { items: 3 }, 1280: { items: 4 } },
                                      })
                                    : l(this).owlCarousel({
                                          rtl: n,
                                          items: 4,
                                          margin: 30,
                                          nav: !0,
                                          dots: !1,
                                          navText: !1,
                                          loop: !0,
                                          smartSpeed: 1e3,
                                          autoplay: !0,
                                          autoplayTimeout: 8e3,
                                          autoplaySpeed: 1e3,
                                          autoplayHoverPause: !0,
                                          responsive: { 0: { items: 1, margin: 0 }, 769: { items: 3 }, 1088: { items: 3 }, 1280: { items: 4 } },
                                      })),
                            l(this).hasClass("carousel-items-5") &&
                                (l(this).hasClass("no-margin")
                                    ? l(this).owlCarousel({
                                          rtl: n,
                                          items: 5,
                                          margin: 0,
                                          nav: !0,
                                          dots: !1,
                                          navText: !1,
                                          loop: !0,
                                          smartSpeed: 1e3,
                                          autoplay: !0,
                                          autoplayTimeout: 8e3,
                                          autoplaySpeed: 1e3,
                                          autoplayHoverPause: !0,
                                          responsive: { 0: { items: 1 }, 769: { items: 3 }, 1088: { items: 3 }, 1280: { items: 5 } },
                                      })
                                    : l(this).owlCarousel({
                                          rtl: n,
                                          items: 5,
                                          margin: 30,
                                          nav: !0,
                                          dots: !1,
                                          navText: !1,
                                          loop: !0,
                                          smartSpeed: 1e3,
                                          autoplay: !0,
                                          autoplayTimeout: 8e3,
                                          autoplaySpeed: 1e3,
                                          autoplayHoverPause: !0,
                                          responsive: { 0: { items: 1, margin: 0 }, 769: { items: 3 }, 1088: { items: 3 }, 1280: { items: 5 } },
                                      })),
                            l(this).hasClass("carousel-items-6") &&
                                (l(this).hasClass("no-margin")
                                    ? l(this).owlCarousel({
                                          rtl: n,
                                          items: 6,
                                          margin: 0,
                                          nav: !0,
                                          dots: !1,
                                          navText: !1,
                                          loop: !0,
                                          smartSpeed: 1e3,
                                          autoplay: !0,
                                          autoplayTimeout: 8e3,
                                          autoplaySpeed: 1e3,
                                          autoplayHoverPause: !0,
                                          responsive: { 0: { items: 1 }, 769: { items: 3 }, 1088: { items: 3 }, 1280: { items: 6 } },
                                      })
                                    : l(this).owlCarousel({
                                          rtl: n,
                                          items: 6,
                                          margin: 30,
                                          nav: !0,
                                          dots: !1,
                                          navText: !1,
                                          loop: !0,
                                          smartSpeed: 1e3,
                                          autoplay: !0,
                                          autoplayTimeout: 8e3,
                                          autoplaySpeed: 1e3,
                                          autoplayHoverPause: !0,
                                          responsive: { 0: { items: 1, margin: 0 }, 769: { items: 3 }, 1088: { items: 3 }, 1280: { items: 6 } },
                                      })),
                            l(this).owlCarousel(s);
                    }),
                t.length &&
                    t.each(function () {
                        l(this).hasClass("carousel-items-2") &&
                            (l(this).hasClass("no-margin")
                                ? l(this).owlCarousel({
                                      rtl: n,
                                      dots: !1,
                                      items: 2,
                                      margin: 0,
                                      loop: !0,
                                      smartSpeed: 1e3,
                                      autoplay: !0,
                                      autoplayTimeout: 7e3,
                                      autoplaySpeed: 1e3,
                                      autoplayHoverPause: !0,
                                      responsive: { 0: { items: 1 }, 1088: { items: 2 } },
                                  })
                                : l(this).owlCarousel({
                                      rtl: n,
                                      dots: !1,
                                      items: 2,
                                      margin: 30,
                                      loop: !0,
                                      smartSpeed: 1e3,
                                      autoplay: !0,
                                      autoplayTimeout: 7e3,
                                      autoplaySpeed: 1e3,
                                      autoplayHoverPause: !0,
                                      responsive: { 0: { items: 1, margin: 0 }, 1088: { items: 2 } },
                                  })),
                            l(this).hasClass("carousel-items-3") &&
                                (l(this).hasClass("no-margin")
                                    ? l(this).owlCarousel({
                                          rtl: n,
                                          dots: !1,
                                          items: 3,
                                          margin: 0,
                                          loop: !0,
                                          smartSpeed: 1e3,
                                          autoplay: !0,
                                          autoplayTimeout: 7e3,
                                          autoplaySpeed: 1e3,
                                          autoplayHoverPause: !0,
                                          responsive: { 0: { items: 1 }, 769: { items: 3 }, 1088: { items: 3 }, 1280: { items: 3 } },
                                      })
                                    : l(this).owlCarousel({
                                          rtl: n,
                                          dots: !1,
                                          items: 3,
                                          margin: 30,
                                          loop: !0,
                                          smartSpeed: 1e3,
                                          autoplay: !0,
                                          autoplayTimeout: 7e3,
                                          autoplaySpeed: 1e3,
                                          autoplayHoverPause: !0,
                                          responsive: { 0: { items: 1, margin: 0 }, 769: { items: 3 }, 1088: { items: 3 }, 1280: { items: 3 } },
                                      })),
                            l(this).hasClass("carousel-items-4") &&
                                (l(this).hasClass("no-margin")
                                    ? l(this).owlCarousel({
                                          rtl: n,
                                          dots: !1,
                                          items: 4,
                                          margin: 0,
                                          loop: !0,
                                          smartSpeed: 1e3,
                                          autoplay: !0,
                                          autoplayTimeout: 7e3,
                                          autoplaySpeed: 1e3,
                                          autoplayHoverPause: !0,
                                          responsive: { 0: { items: 1 }, 769: { items: 3 }, 1088: { items: 4 }, 1280: { items: 4 } },
                                      })
                                    : l(this).owlCarousel({
                                          rtl: n,
                                          dots: !1,
                                          items: 4,
                                          margin: 30,
                                          loop: !0,
                                          smartSpeed: 1e3,
                                          autoplay: !0,
                                          autoplayTimeout: 7e3,
                                          autoplaySpeed: 1e3,
                                          autoplayHoverPause: !0,
                                          responsive: { 0: { items: 1, margin: 0 }, 769: { items: 3 }, 1088: { items: 4 }, 1280: { items: 4 } },
                                      })),
                            l(this).hasClass("carousel-items-5") &&
                                (l(this).hasClass("no-margin")
                                    ? l(this).owlCarousel({
                                          rtl: n,
                                          dots: !1,
                                          items: 5,
                                          margin: 0,
                                          loop: !0,
                                          smartSpeed: 1e3,
                                          autoplay: !0,
                                          autoplayTimeout: 7e3,
                                          autoplaySpeed: 1e3,
                                          autoplayHoverPause: !0,
                                          responsive: { 0: { items: 1 }, 769: { items: 3 }, 1088: { items: 3 }, 1280: { items: 5 } },
                                      })
                                    : l(this).owlCarousel({
                                          rtl: n,
                                          dots: !1,
                                          items: 5,
                                          margin: 30,
                                          loop: !0,
                                          smartSpeed: 1e3,
                                          autoplay: !0,
                                          autoplayTimeout: 7e3,
                                          autoplaySpeed: 1e3,
                                          autoplayHoverPause: !0,
                                          responsive: { 0: { items: 1, margin: 0 }, 769: { items: 3 }, 1088: { items: 3 }, 1280: { items: 5 } },
                                      })),
                            l(this).hasClass("carousel-items-6") &&
                                (l(this).hasClass("no-margin")
                                    ? l(this).owlCarousel({
                                          rtl: n,
                                          dots: !1,
                                          items: 6,
                                          margin: 0,
                                          loop: !0,
                                          smartSpeed: 1e3,
                                          autoplay: !0,
                                          autoplayTimeout: 7e3,
                                          autoplaySpeed: 1e3,
                                          autoplayHoverPause: !0,
                                          responsive: { 0: { items: 1 }, 769: { items: 3 }, 1088: { items: 3 }, 1280: { items: 6 } },
                                      })
                                    : l(this).owlCarousel({
                                          rtl: n,
                                          dots: !1,
                                          items: 6,
                                          margin: 30,
                                          loop: !0,
                                          smartSpeed: 1e3,
                                          autoplay: !0,
                                          autoplayTimeout: 7e3,
                                          autoplaySpeed: 1e3,
                                          autoplayHoverPause: !0,
                                          responsive: { 0: { items: 1, margin: 0 }, 769: { items: 3 }, 1088: { items: 3 }, 1280: { items: 6 } },
                                      })),
                            l(this).owlCarousel(o);
                    });
        });
    })(jQuery, window, document),
    (function (e, t, i, a) {
        "use strict";
        e(i).ready(function () {
            if (e(".animated-typing").length) {
                if (e("#typed").length) new Typed("#typed", { stringsElement: "#typed-strings", typeSpeed: 30, backSpeed: 30, backDelay: 500, startDelay: 1e3, loop: !0 });
                if (e("#typed-intro").length) new Typed("#typed-intro", { stringsElement: "#typed-strings-intro", typeSpeed: 150, backSpeed: 150, backDelay: 800, startDelay: 800, loop: !0 });
                if (e("#typed-1").length) new Typed("#typed-1", { stringsElement: "#typed-strings-1", typeSpeed: 30, backSpeed: 30, backDelay: 500, startDelay: 1e3, loop: !0, cursorChar: "_", shuffle: !0 });
                if (e("#typed-2").length) new Typed("#typed-2", { strings: ["npm install^1000\n`installing components...`^1000\n`Fetching from source...`"], typeSpeed: 40, backSpeed: 20, backDelay: 500, startDelay: 1e3, loop: !0 });
            }
        });
    })(jQuery, window, document),
    (function (e, t, i, a) {
        "use strict";
        e(document).ready(function () {
            bulmaCalendar.attach('[type="date"]');
        });
    })(jQuery, window),
    (function (h, p, f, g) {
        "use strict";
        h(f).ready(function () {
            var e, o, t, i, a;
            if (h(".charts").length) {
                (p.chartColors = { red: "rgb(255, 99, 132)", orange: "rgb(255, 159, 64)", yellow: "rgb(255, 205, 86)", green: "rgb(75, 192, 192)", blue: "rgb(54, 162, 235)", purple: "rgb(153, 102, 255)", grey: "rgb(201, 203, 207)" }),
                    (o = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"]),
                    (t = ["#4dc9f6", "#f67019", "#f53794", "#537bc4", "#acc236", "#166a8f", "#00a950", "#58595b", "#8549ba"]),
                    (i = (e = this).Samples || (e.Samples = {})),
                    (a = e.Color),
                    (i.utils = {
                        srand: function (e) {
                            this._seed = e;
                        },
                        rand: function (e, t) {
                            var i = this._seed;
                            return (e = e === g ? 0 : e), (t = t === g ? 1 : t), (this._seed = (9301 * i + 49297) % 233280), e + (this._seed / 233280) * (t - e);
                        },
                        numbers: function (e) {
                            var t,
                                i,
                                a = e || {},
                                n = a.min || 0,
                                r = a.max || 1,
                                s = a.from || [],
                                o = a.count || 8,
                                l = a.decimals || 8,
                                d = a.continuity || 1,
                                c = Math.pow(10, l) || 0,
                                u = [];
                            for (t = 0; t < o; ++t) (i = (s[t] || 0) + this.rand(n, r)), this.rand() <= d ? u.push(Math.round(c * i) / c) : u.push(null);
                            return u;
                        },
                        labels: function (e) {
                            var t,
                                i = e || {},
                                a = i.min || 0,
                                n = i.max || 100,
                                r = (n - a) / (i.count || 8),
                                s = i.decimals || 8,
                                o = Math.pow(10, s) || 0,
                                l = i.prefix || "",
                                d = [];
                            for (t = a; t < n; t += r) d.push(l + Math.round(o * t) / o);
                            return d;
                        },
                        months: function (e) {
                            var t,
                                i,
                                a = e || {},
                                n = a.count || 12,
                                r = a.section,
                                s = [];
                            for (t = 0; t < n; ++t) (i = o[Math.ceil(t) % 12]), s.push(i.substring(0, r));
                            return s;
                        },
                        color: function (e) {
                            return t[e % t.length];
                        },
                        transparentize: function (e, t) {
                            var i = t === g ? 0.5 : 1 - t;
                            return a(e).alpha(i).rgbString();
                        },
                    }),
                    (p.randomScalingFactor = function () {
                        return Math.round(i.utils.rand(-100, 100));
                    }),
                    i.utils.srand(Date.now());
                var n = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
                    r = {
                        type: "line",
                        data: {
                            labels: ["January", "February", "March", "April", "May", "June", "July"],
                            datasets: [
                                {
                                    label: "My First dataset",
                                    backgroundColor: p.chartColors.red,
                                    borderColor: p.chartColors.red,
                                    data: [randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor()],
                                    fill: !1,
                                },
                                {
                                    label: "My Second dataset",
                                    fill: !1,
                                    backgroundColor: p.chartColors.blue,
                                    borderColor: p.chartColors.blue,
                                    data: [randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor()],
                                },
                            ],
                        },
                        options: {
                            responsive: !0,
                            title: { display: !0, text: "Chart.js Line Chart" },
                            tooltips: { mode: "index", intersect: !1 },
                            hover: { mode: "nearest", intersect: !0 },
                            scales: { xAxes: [{ display: !0, scaleLabel: { display: !0, labelString: "Month" } }], yAxes: [{ display: !0, scaleLabel: { display: !0, labelString: "Value" } }] },
                        },
                    };
                f.getElementById("randomizeData").addEventListener("click", function () {
                    r.data.datasets.forEach(function (e) {
                        e.data = e.data.map(function () {
                            return randomScalingFactor();
                        });
                    }),
                        p.myLine.update();
                });
                var s = Object.keys(p.chartColors);
                f.getElementById("addDataset").addEventListener("click", function () {
                    for (var e = s[r.data.datasets.length % s.length], t = p.chartColors[e], i = { label: "Dataset " + r.data.datasets.length, backgroundColor: t, borderColor: t, data: [], fill: !1 }, a = 0; a < r.data.labels.length; ++a)
                        i.data.push(randomScalingFactor());
                    r.data.datasets.push(i), p.myLine.update();
                }),
                    f.getElementById("addData").addEventListener("click", function () {
                        if (0 < r.data.datasets.length) {
                            var e = n[r.data.labels.length % n.length];
                            r.data.labels.push(e),
                                r.data.datasets.forEach(function (e) {
                                    e.data.push(randomScalingFactor());
                                }),
                                p.myLine.update();
                        }
                    }),
                    f.getElementById("removeDataset").addEventListener("click", function () {
                        r.data.datasets.splice(0, 1), p.myLine.update();
                    }),
                    f.getElementById("removeData").addEventListener("click", function () {
                        r.data.labels.splice(-1, 1),
                            r.data.datasets.forEach(function (e) {
                                e.data.pop();
                            }),
                            p.myLine.update();
                    });
                var l = Chart.helpers.color,
                    d = {
                        labels: ["January", "February", "March", "April", "May", "June", "July"],
                        datasets: [
                            {
                                label: "Dataset 1",
                                backgroundColor: l(p.chartColors.red).alpha(0.5).rgbString(),
                                borderColor: p.chartColors.red,
                                borderWidth: 1,
                                data: [randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor()],
                            },
                            {
                                label: "Dataset 2",
                                backgroundColor: l(p.chartColors.blue).alpha(0.5).rgbString(),
                                borderColor: p.chartColors.blue,
                                borderWidth: 1,
                                data: [randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor()],
                            },
                        ],
                    };
                f.getElementById("randomizeData-bar").addEventListener("click", function () {
                    var t = Math.random() < 0.2;
                    d.datasets.forEach(function (e) {
                        e.data = e.data.map(function () {
                            return t ? 0 : randomScalingFactor();
                        });
                    }),
                        p.myBar.update();
                }),
                    f.getElementById("addDataset-bar").addEventListener("click", function () {
                        for (
                            var e = s[d.datasets.length % s.length], t = p.chartColors[e], i = { label: "Dataset " + (d.datasets.length + 1), backgroundColor: l(t).alpha(0.5).rgbString(), borderColor: t, borderWidth: 1, data: [] }, a = 0;
                            a < d.labels.length;
                            ++a
                        )
                            i.data.push(randomScalingFactor());
                        d.datasets.push(i), p.myBar.update();
                    }),
                    f.getElementById("addData-bar").addEventListener("click", function () {
                        if (0 < d.datasets.length) {
                            var e = n[d.labels.length % n.length];
                            d.labels.push(e);
                            for (var t = 0; t < d.datasets.length; ++t) d.datasets[t].data.push(randomScalingFactor());
                            p.myBar.update();
                        }
                    }),
                    f.getElementById("removeDataset-bar").addEventListener("click", function () {
                        d.datasets.pop(), p.myBar.update();
                    }),
                    f.getElementById("removeData-bar").addEventListener("click", function () {
                        d.labels.splice(-1, 1),
                            d.datasets.forEach(function (e) {
                                e.data.pop();
                            }),
                            p.myBar.update();
                    }),
                    (randomScalingFactor = function () {
                        return Math.round(100 * Math.random());
                    });
                var c = {
                    type: "pie",
                    data: {
                        datasets: [
                            {
                                data: [randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor()],
                                backgroundColor: [p.chartColors.red, p.chartColors.orange, p.chartColors.yellow, p.chartColors.green, p.chartColors.blue],
                                label: "Dataset 1",
                            },
                        ],
                        labels: ["Red", "Orange", "Yellow", "Green", "Blue"],
                    },
                    options: { responsive: !0 },
                };
                f.getElementById("randomizeData-pie").addEventListener("click", function () {
                    c.data.datasets.forEach(function (e) {
                        e.data = e.data.map(function () {
                            return randomScalingFactor();
                        });
                    }),
                        p.myPie.update();
                }),
                    f.getElementById("addDataset-pie").addEventListener("click", function () {
                        for (var e = { backgroundColor: [], data: [], label: "New dataset " + c.data.datasets.length }, t = 0; t < c.data.labels.length; ++t) {
                            e.data.push(randomScalingFactor());
                            var i = s[t % s.length],
                                a = p.chartColors[i];
                            e.backgroundColor.push(a);
                        }
                        c.data.datasets.push(e), p.myPie.update();
                    }),
                    f.getElementById("removeDataset-pie").addEventListener("click", function () {
                        c.data.datasets.splice(0, 1), p.myPie.update();
                    });
                var u = {
                    type: "doughnut",
                    data: {
                        datasets: [
                            {
                                data: [randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor()],
                                backgroundColor: [p.chartColors.red, p.chartColors.orange, p.chartColors.yellow, p.chartColors.green, p.chartColors.blue],
                                label: "Dataset 1",
                            },
                        ],
                        labels: ["Red", "Orange", "Yellow", "Green", "Blue"],
                    },
                    options: { responsive: !0, legend: { position: "top" }, title: { display: !0, text: "Chart.js Doughnut Chart" }, animation: { animateScale: !0, animateRotate: !0 } },
                };
                f.getElementById("randomizeData-doughnut").addEventListener("click", function () {
                    u.data.datasets.forEach(function (e) {
                        e.data = e.data.map(function () {
                            return randomScalingFactor();
                        });
                    }),
                        p.myDoughnut.update();
                }),
                    f.getElementById("addDataset-doughnut").addEventListener("click", function () {
                        for (var e = { backgroundColor: [], data: [], label: "New dataset " + u.data.datasets.length }, t = 0; t < u.data.labels.length; ++t) {
                            e.data.push(randomScalingFactor());
                            var i = s[t % s.length],
                                a = p.chartColors[i];
                            e.backgroundColor.push(a);
                        }
                        u.data.datasets.push(e), p.myDoughnut.update();
                    }),
                    f.getElementById("addData-doughnut").addEventListener("click", function () {
                        if (0 < u.data.datasets.length) {
                            u.data.labels.push("data #" + u.data.labels.length);
                            var e = s[u.data.datasets[0].data.length % s.length],
                                t = p.chartColors[e];
                            u.data.datasets.forEach(function (e) {
                                e.data.push(randomScalingFactor()), e.backgroundColor.push(t);
                            }),
                                p.myDoughnut.update();
                        }
                    }),
                    f.getElementById("removeDataset-doughnut").addEventListener("click", function () {
                        u.data.datasets.splice(0, 1), p.myDoughnut.update();
                    }),
                    f.getElementById("removeData-doughnut").addEventListener("click", function () {
                        u.data.labels.splice(-1, 1),
                            u.data.datasets.forEach(function (e) {
                                e.data.pop(), e.backgroundColor.pop();
                            }),
                            p.myDoughnut.update();
                    }),
                    f.getElementById("changeCircleSize").addEventListener("click", function () {
                        p.myDoughnut.options.circumference === Math.PI
                            ? ((p.myDoughnut.options.circumference = 2 * Math.PI), (p.myDoughnut.options.rotation = -Math.PI / 2))
                            : ((p.myDoughnut.options.circumference = Math.PI), (p.myDoughnut.options.rotation = -Math.PI)),
                            p.myDoughnut.update();
                    }),
                    (p.onload = function () {
                        var e = f.getElementById("line-chart").getContext("2d");
                        p.myLine = new Chart(e, r);
                        var t = f.getElementById("bar-chart").getContext("2d");
                        p.myBar = new Chart(t, { type: "bar", data: d, options: { responsive: !0, legend: { position: "top" }, title: { display: !0, text: "Chart.js Bar Chart" } } });
                        var i = f.getElementById("pie-chart").getContext("2d");
                        p.myPie = new Chart(i, c);
                        var a = f.getElementById("doughnut-chart").getContext("2d");
                        p.myDoughnut = new Chart(a, u);
                    });
            }
        });
    })(jQuery, window, document),
    (function (n, e, t, i) {
        "use strict";
        n(t).ready(function () {
            var e = n(".counter"),
                t = n(".countdown-time"),
                i = n("html").attr("dir"),
                a = !1;
            (n("body").hasClass("rtl") || n("html").hasClass("rtl") || "rtl" == i) && (a = !0),
                e.length && e.counterUp({ time: 1e3, delay: 10, beginAt: 1 }),
                t.length &&
                    t.each(function () {
                        a ? n(this).countDown({ with_separators: !1, label_dd: "أيام", label_hh: "ساعات", label_mm: "دقائق", label_ss: "ثوانى" }) : n(this).countDown({ with_separators: !1 });
                    });
        });
    })(jQuery, window, document),
    (function (i, e, t, a) {
        "use strict";
        i(t).ready(function () {
            i(".flexslider");
            var e = i(".flexslider.thumbnails"),
                t = i(".flexslider.intro");
            e.show(), t.show(), e.length && e.flexslider({ animation: "slide", controlNav: "thumbnails" }), t.length && t.flexslider({ animation: "slide" });
        });
    })(jQuery, window, document),
    (function (s, e, t, i) {
        "use strict";
        s(t).ready(function () {
            var e = s("body"),
                t = (s("body.rtl"), e.find("#footer-wrap")),
                i = e.find("#footer-bottom-wrap"),
                a = e.find("#content-main-wrap"),
                n = e.find("#content-footer-wrap"),
                r = e.find("#footer-top-wrap");
            e.hasClass("footer-reveal") &&
                (t.length && i.length && (t.css("position", "fixed").css("bottom", i.height()), i.css("position", "fixed").css("bottom", 0)),
                r.length ? r.css("margin-bottom", t.height() + i.height() - 1) : n.length ? n.css("margin-bottom", t.height() + i.height() - 1) : a.css("margin-bottom", t.height() + i.height() - 1));
        });
    })(jQuery, window, document),
    (function (P, R, I, e) {
        "use strict";
        var A = P(".pageloader");
        P("body").hasClass("active-pageloader") &&
            A.length &&
            P(R).on("load", function () {
                setTimeout(function () {
                    A.removeClass("is-active");
                }, 500);
            }),
            P(I).ready(function () {
                var t,
                    e = P(".current-year"),
                    i = P(".video-back-vidbacking"),
                    a = P(".video-back-vidbacking-muted"),
                    n = P(".show-pageloader"),
                    r = P(".notification"),
                    s = P(".message"),
                    o = P(".dropdown"),
                    l = P(".show-modal"),
                    d = P(".parallax-background"),
                    c = P(".docs-content"),
                    u = P("#back-to-top"),
                    h = P(".sidebar-fixed"),
                    p = P(".video-container"),
                    f = P(".ajax-contact-form"),
                    g = P(".overhang-message-content.success"),
                    m = P(".overhang-message-content.error"),
                    v = P("body"),
                    y = P("#viewport-food-smoke"),
                    w = P("#viewport-food-smoke-2"),
                    _ = new Date();
                if (
                    (e.length && e.text(_.getFullYear()),
                    h.length && h.stickySidebar({ topSpacing: 100, bottomSpacing: 100 }),
                    p.length && fitvids(".video-container"),
                    c.length &&
                        (P(".docs-fixed").stickySidebar({ topSpacing: 100, bottomSpacing: 100 }),
                        jQuery(function () {
                            var a = P(".docs-fixed-content"),
                                n = P(".docs-fixed ul li");
                            768 < jQuery(R).width()
                                ? P(R).on("scroll", function () {
                                      var i = P(this).scrollTop();
                                      a.each(function () {
                                          var e = P(this).offset().top - 92,
                                              t = e + P(this).outerHeight();
                                          e <= i && i <= t && (n.find("a").removeClass("is-active"), a.removeClass("is-active"), P(this).addClass("is-active"), n.find('a[href="#' + P(this).attr("id") + '"]').addClass("is-active"));
                                      });
                                  })
                                : n.find("a").removeClass("is-active");
                        }),
                        P(R).scroll(function () {
                            P(".docs-fixed"), P(R).scrollTop(), jQuery(R).width();
                        }),
                        P(I).ready(function () {
                            P(".vertical-navigation-content.docs-fixed a").click(function () {
                                return P("html, body").animate({ scrollTop: P(P(this).attr("href")).offset().top - 90 + "px" }, { duration: 800 }), !1;
                            });
                        })),
                    u.length)
                ) {
                    var b = function () {
                        100 < P(R).scrollTop() ? P("#back-to-top").addClass("show") : P("#back-to-top").removeClass("show");
                    };
                    b(),
                        P(R).on("scroll", function () {
                            b();
                        }),
                        P("#back-to-top").on("click", function (e) {
                            e.preventDefault(), P("html,body").animate({ scrollTop: 0 }, 700);
                        });
                }
                P(".floating_buttons").each(function () {
                    var e = P(this);
                    e.find(".float").on("click", function () {
                        e.toggleClass("is-active");
                    });
                }),
                    P(I).on("click", function (e) {
                        !P(e.target).closest(".floating_buttons").length && P(".floating_buttons").hasClass("is-active") && P(".floating_buttons").removeClass("is-active");
                    }),
                    P(I).on("click", function (e) {
                        P(e.target).closest(".quickview").length ||
                            P(e.target).closest(".show-quickview").length ||
                            !P(".quickview").hasClass("is-active") ||
                            P(e.target).closest(".floating_buttons").length ||
                            P(".quickview").removeClass("is-active");
                    }),
                    i.length && i.vidbacking({ "youtube-mute-video": !1 }),
                    a.length && a.vidbacking(),
                    d.length && d.parallax(),
                    r.length &&
                        r.each(function () {
                            P(this).find("> .delete").length &&
                                P(this)
                                    .find("> .delete")
                                    .on("click", function () {
                                        P(this).parent().fadeOut();
                                    });
                        }),
                    s.length &&
                        s.each(function () {
                            P(this).find(".message-header > .delete").length &&
                                P(this)
                                    .find(".message-header > .delete")
                                    .on("click", function () {
                                        P(this).parent().parent().fadeOut();
                                    });
                        }),
                    o.length &&
                        (o.each(function () {
                            P(this).on("click", function () {
                                P(this).toggleClass("is-active");
                            });
                        }),
                        P(I).on("click", function (e) {
                            P(e.target).closest(".dropdown").length ||
                                o.each(function () {
                                    P(this).removeClass("is-active");
                                });
                        })),
                    l.length &&
                        l.each(function () {
                            var t = P(this);
                            t.find(".modal").length &&
                                (t.find(".launch-modal").on("click", function () {
                                    t.find(".modal").addClass("is-active");
                                }),
                                t
                                    .find(".modal")
                                    .find(".modal-close")
                                    .on("click", function (e) {
                                        t.find(".modal").removeClass("is-active");
                                    }),
                                t
                                    .find(".modal")
                                    .find(".delete")
                                    .on("click", function (e) {
                                        t.find(".modal").removeClass("is-active");
                                    }),
                                t
                                    .find(".modal")
                                    .find(".modal-background")
                                    .on("click", function (e) {
                                        t.find(".modal").removeClass("is-active");
                                    }));
                        });
                var x = v.find(".site-header-bottom .slider"),
                    T = v.find(".site-header-bottom .flexslider"),
                    C = P(R);
                function k() {
                    768 < C.width() ? (x.length ? AOS.init({ duration: 800, offset: 850 }) : T.length ? AOS.init({ duration: 800, offset: -850 }) : AOS.init({ duration: 800, offset: 0 })) : AOS.init({ duration: 800, offset: 0 });
                }
                k(), P(R).resize(k);
                var S = { custom: !0, easing: "linear", speed: 400, html: !0, duration: 10, closeConfirm: !0 };
                function j(e) {
                    v.addClass("overhang-push"),
                        v.addClass("overhang-success"),
                        v.removeClass("overhang-danger"),
                        v.overhang(
                            P.extend(S, {
                                message: g.html(),
                                callback: function (e) {
                                    v.removeClass("overhang-push"), v.removeClass("overhang-success");
                                },
                            })
                        ),
                        f.find('input:not([type="submit"]), textarea').val("");
                }
                function L(e) {
                    v.addClass("overhang-push"),
                        v.addClass("overhang-danger"),
                        v.removeClass("overhang-success"),
                        v.overhang(
                            P.extend(S, {
                                message: m.html(),
                                callback: function (e) {
                                    v.removeClass("overhang-push"), v.removeClass("overhang-danger");
                                },
                            })
                        );
                }
                f.length &&
                    f.submit(function (e) {
                        e.preventDefault(),
                            (t = P(this).serialize()),
                            P.ajax({ type: "POST", url: f.attr("action"), data: t, dataType: "json" })
                                .done(j)
                                .fail(L);
                    });
                bulmaTagsinput.attach('[type="tags"]'), bulmaQuickview.attach(), bulmaSteps.attach();
                if (
                    (n.length &&
                        (A.removeClass("is-active"),
                        n.each(function () {
                            var e = P(this);
                            e.find(".button").on("click", function () {
                                e.find(".pageloader").addClass("is-active"),
                                    setTimeout(function () {
                                        A.removeClass("is-active");
                                    }, 3500);
                            });
                        })),
                    y.length)
                )
                    for (var O = 0; O < 15; O += 1)
                        setTimeout(function e() {
                            var t = 1e3 * Math.random() + 5e3,
                                i = P("<div />", { class: "smoke", css: { opacity: 0, left: 200 * Math.random() + 80 } });
                            P(i).appendTo("#viewport-food-smoke"),
                                P.when(
                                    P(i).animate(
                                        { opacity: 0.8 },
                                        {
                                            duration: t / 4,
                                            easing: "linear",
                                            queue: !1,
                                            complete: function () {
                                                P(i).animate({ opacity: 0 }, { duration: t / 3, easing: "linear", queue: !1 });
                                            },
                                        }
                                    ),
                                    P(i).animate({ bottom: P("#viewport-food-smoke").height() }, { duration: t, easing: "linear", queue: !1 })
                                ).then(function () {
                                    P(i).remove(), e();
                                });
                        }, 3e3 * Math.random());
                if (w.length)
                    for (O = 0; O < 15; O += 1)
                        setTimeout(function e() {
                            var t = 1e3 * Math.random() + 5e3,
                                i = P("<div />", { class: "smoke", css: { opacity: 0, left: 200 * Math.random() + 80 } });
                            P(i).appendTo("#viewport-food-smoke-2"),
                                P.when(
                                    P(i).animate(
                                        { opacity: 0.8 },
                                        {
                                            duration: t / 4,
                                            easing: "linear",
                                            queue: !1,
                                            complete: function () {
                                                P(i).animate({ opacity: 0 }, { duration: t / 3, easing: "linear", queue: !1 });
                                            },
                                        }
                                    ),
                                    P(i).animate({ bottom: P("#viewport-food-smoke-2").height() }, { duration: t, easing: "linear", queue: !1 })
                                ).then(function () {
                                    P(i).remove(), e();
                                });
                        }, 3e3 * Math.random());
            });
    })(jQuery, window, document),
    (function (D, e, t, i) {
        "use strict";
        D(t).ready(function () {
            var e = D("#instafeed"),
                t = D(".owl-carousel.instafeed"),
                i = D(".owl-carousel.scrollbar"),
                a = D("#instafeed-sidebar"),
                n = D("#instafeed-footer"),
                r = D("#instafeed-footer-2"),
                s = D("#instafeed-content"),
                o = D("#instafeed-content-1"),
                l = D("#instafeed-content-2"),
                d = D("#instafeed-content-3"),
                c = D("#instafeed-content-4"),
                u = D("#instafeed-content-5"),
                h = D("html").attr("dir"),
                p = !1;
            (D("body").hasClass("rtl") || D("html").hasClass("rtl") || "rtl" == h) && (p = !0);
            var f = "12659728099",
                g = "12659728099.0a298a0.6478c888209b455ab9740ada547c0a8f",
                m = "joo_restaurant",
                v = 0,
                y = 0,
                w = 0,
                _ = 0,
                b = 0,
                x = 0,
                T = 0,
                C = 0,
                k = 0,
                S = 0,
                j = new Instafeed({
                    get: "user",
                    userId: f,
                    accessToken: g,
                    resolution: "standard_resolution",
                    template:
                        '<figure class="instafeed-image"><a href="{{link}}" target="_blank"><img src="{{image}}" /><div class="instafeed-overlay"><div class="instafeed-info"><span><i class="icon-heart"></i> {{likes}}</span> <span><i class="icon-bubbles"></i> {{comments}}</span></div></div></a></figure>',
                    filter: function (e) {
                        return 0 <= e.tags.indexOf(m) && v < 20 && ((v += 1), !0);
                    },
                    success: function (e) {
                        v = 0;
                    },
                    after: function () {
                        t.length &&
                            t.each(function () {
                                D(this).owlCarousel({
                                    rtl: p,
                                    items: 5,
                                    loop: !0,
                                    smartSpeed: 1e3,
                                    autoplay: !0,
                                    autoplayTimeout: 8e3,
                                    autoplaySpeed: 1e3,
                                    autoplayHoverPause: !0,
                                    nav: !0,
                                    dots: !1,
                                    navText: !1,
                                    responsive: { 0: { items: 1 }, 769: { items: 3 }, 1088: { items: 4 }, 1280: { items: 5 } },
                                });
                            }),
                            i.show(),
                            i.length &&
                                i.each(function () {
                                    D(this).owlCarousel({
                                        rtl: p,
                                        stagePadding: 375,
                                        items: 1,
                                        loop: !0,
                                        margin: 30,
                                        nav: !0,
                                        dots: !1,
                                        navText: !1,
                                        smartSpeed: 1e3,
                                        autoplay: !0,
                                        autoplayTimeout: 8e3,
                                        autoplaySpeed: 1e3,
                                        autoplayHoverPause: !0,
                                        scrollbarType: "scroll",
                                        responsive: {
                                            0: { items: 1, margin: 0, stagePadding: 0 },
                                            769: { items: 1, margin: 0, stagePadding: 0 },
                                            1088: { items: 1, margin: 25, stagePadding: 160 },
                                            1280: { items: 1, margin: 30, stagePadding: 375 },
                                        },
                                    });
                                });
                    },
                });
            e.length
                ? j.run()
                : (i.show(),
                  i.length &&
                      i.each(function () {
                          D(this).owlCarousel({
                              rtl: p,
                              stagePadding: 375,
                              items: 1,
                              loop: !0,
                              margin: 30,
                              nav: !0,
                              dots: !1,
                              navText: !1,
                              smartSpeed: 1e3,
                              autoplay: !0,
                              autoplayTimeout: 8e3,
                              autoplaySpeed: 1e3,
                              autoplayHoverPause: !0,
                              scrollbarType: "scroll",
                              responsive: { 0: { items: 1, margin: 0, stagePadding: 0 }, 769: { items: 1, margin: 0, stagePadding: 0 }, 1088: { items: 1, margin: 25, stagePadding: 160 }, 1280: { items: 1, margin: 30, stagePadding: 375 } },
                          });
                      }));
            var L = new Instafeed({
                get: "user",
                userId: f,
                accessToken: g,
                target: "instafeed-sidebar",
                resolution: "thumbnail",
                template:
                    '<figure class="instafeed-image"><a href="{{link}}" target="_blank"><img src="{{image}}" /><div class="instafeed-overlay"><div class="instafeed-info"><span><i class="icon-heart"></i> {{likes}}</span> <span><i class="icon-bubbles"></i> {{comments}}</span></div></div></a></figure>',
                filter: function (e) {
                    return 0 <= e.tags.indexOf(m) && y < 6 && ((y += 1), !0);
                },
                success: function (e) {
                    y = 0;
                },
            });
            a.length && L.run();
            var O = new Instafeed({
                get: "user",
                userId: f,
                accessToken: g,
                target: "instafeed-footer",
                resolution: "thumbnail",
                template:
                    '<figure class="instafeed-image"><a href="{{link}}" target="_blank"><img src="{{image}}" /><div class="instafeed-overlay"><div class="instafeed-info"><span><i class="icon-heart"></i> {{likes}}</span> <span><i class="icon-bubbles"></i> {{comments}}</span></div></div></a></figure>',
                filter: function (e) {
                    return 0 <= e.tags.indexOf(m) && w < 6 && ((w += 1), !0);
                },
                success: function (e) {
                    w = 0;
                },
            });
            n.length && O.run();
            var P = new Instafeed({
                get: "user",
                userId: f,
                accessToken: g,
                target: "instafeed-footer-2",
                resolution: "thumbnail",
                template:
                    '<figure class="instafeed-image"><a href="{{link}}" target="_blank"><img src="{{image}}" /><div class="instafeed-overlay"><div class="instafeed-info"><span><i class="icon-heart"></i> {{likes}}</span> <span><i class="icon-bubbles"></i> {{comments}}</span></div></div></a></figure>',
                filter: function (e) {
                    return 0 <= e.tags.indexOf(m) && _ < 6 && ((_ += 1), !0);
                },
                success: function (e) {
                    _ = 0;
                },
            });
            r.length && P.run();
            var R = new Instafeed({
                get: "user",
                userId: f,
                accessToken: g,
                target: "instafeed-content",
                resolution: "standard_resolution",
                template:
                    '<div class="column"><figure class="instafeed-image"><a href="{{link}}" target="_blank"><img src="{{image}}" /><div class="instafeed-overlay"><div class="instafeed-info"><span><i class="icon-heart"></i> {{likes}}</span> <span><i class="icon-bubbles"></i> {{comments}}</span></div></div></a></figure></div>',
                filter: function (e) {
                    return 0 <= e.tags.indexOf(m) && b < 6 && ((b += 1), !0);
                },
                success: function (e) {
                    b = 0;
                },
            });
            s.length && R.run();
            var I = new Instafeed({
                get: "user",
                userId: f,
                accessToken: g,
                target: "instafeed-content-1",
                resolution: "standard_resolution",
                template:
                    '<div class="column"><figure class="instafeed-image"><a href="{{link}}" target="_blank"><img src="{{image}}" /><div class="instafeed-overlay"><div class="instafeed-info"><span><i class="icon-heart"></i> {{likes}}</span> <span><i class="icon-bubbles"></i> {{comments}}</span></div></div></a></figure></div>',
                filter: function (e) {
                    return 0 <= e.tags.indexOf(m) && x < 8 && ((x += 1), !0);
                },
                success: function (e) {
                    x = 0;
                },
            });
            o.length && I.run();
            var A = new Instafeed({
                get: "user",
                userId: f,
                accessToken: g,
                target: "instafeed-content-2",
                resolution: "standard_resolution",
                template:
                    '<div class="column"><figure class="instafeed-image"><a href="{{link}}" target="_blank"><img src="{{image}}" /><div class="instafeed-overlay"><div class="instafeed-info"><span><i class="icon-heart"></i> {{likes}}</span> <span><i class="icon-bubbles"></i> {{comments}}</span></div></div></a></figure></div>',
                filter: function (e) {
                    return 0 <= e.tags.indexOf(m) && T < 9 && ((T += 1), !0);
                },
                success: function (e) {
                    T = 0;
                },
            });
            l.length && A.run();
            var Q = new Instafeed({
                get: "user",
                userId: f,
                accessToken: g,
                target: "instafeed-content-3",
                resolution: "standard_resolution",
                template:
                    '<div class="column"><figure class="instafeed-image"><a href="{{link}}" target="_blank"><img src="{{image}}" /><div class="instafeed-overlay"><div class="instafeed-info"><span><i class="icon-heart"></i> {{likes}}</span> <span><i class="icon-bubbles"></i> {{comments}}</span></div></div></a></figure></div>',
                filter: function (e) {
                    return 0 <= e.tags.indexOf(m) && C < 20 && ((C += 1), !0);
                },
                success: function (e) {
                    C = 0;
                },
            });
            d.length && Q.run();
            var M = new Instafeed({
                get: "user",
                userId: f,
                accessToken: g,
                target: "instafeed-content-4",
                resolution: "standard_resolution",
                template:
                    '<div class="column"><figure class="instafeed-image"><a href="{{link}}" target="_blank"><img src="{{image}}" /><div class="instafeed-overlay"><div class="instafeed-info"><span><i class="icon-heart"></i> {{likes}}</span> <span><i class="icon-bubbles"></i> {{comments}}</span></div></div></a></figure></div>',
                filter: function (e) {
                    return 0 <= e.tags.indexOf(m) && k < 18 && ((k += 1), !0);
                },
                success: function (e) {
                    k = 0;
                },
            });
            c.length && M.run();
            var z = new Instafeed({
                get: "user",
                userId: f,
                accessToken: g,
                target: "instafeed-content-5",
                resolution: "standard_resolution",
                template:
                    '<div class="column"><figure class="instafeed-image"><a href="{{link}}" target="_blank"><img src="{{image}}" /><div class="instafeed-overlay"><div class="instafeed-info"><span><i class="icon-heart"></i> {{likes}}</span> <span><i class="icon-bubbles"></i> {{comments}}</span></div></div></a></figure></div>',
                filter: function (e) {
                    return 0 <= e.tags.indexOf(m) && S < 20 && ((S += 1), !0);
                },
                success: function (e) {
                    S = 0;
                },
            });
            u.length && z.run();
        });
    })(jQuery, window, document),
    (function (w, _, e, t) {
        "use strict";
        w(e).ready(function () {
            var t = w(".isotope"),
                e = w(".isotope .columns"),
                i = w(".isotope .isotope-filter"),
                n = 1,
                a = 1,
                r = "*",
                s = "data-filter",
                o = "data-page",
                l = "pagination is-centered isotope-pager pagination-list",
                d = ".column";
            if (t.length) {
                var c = { itemSelector: ".column", transitionDuration: "0.8s", percentPosition: !0 },
                    u = e.imagesLoaded(function () {
                        u.isotope(c);
                    });
                if (t.hasClass("infinite-scroll")) {
                    var h = u.data("isotope");
                    t.hasClass("infinite-load-more")
                        ? u.infiniteScroll({ path: "infinite-scroll-p{{#}}.html", append: ".isotope .columns .column", outlayer: h, status: ".page-load-status", button: ".view-more-button button", scrollThreshold: !1 })
                        : u.infiniteScroll({ path: "infinite-scroll-p{{#}}.html", append: ".isotope .columns .column", outlayer: h, status: ".page-load-status" }),
                        u.on("load.infiniteScroll", function (e, t, i) {
                            var a = w(t).find(".isotope .columns .column");
                            a.imagesLoaded(function () {
                                u.append(a), u.isotope("insert", a);
                            });
                        });
                }
                t.hasClass("isotope-pagination") && (u.isotope({ itemSelector: ".column", transitionDuration: "0.8s", percentPosition: !0, filter: d + "[" + o + '="' + a + '"]' }), f(), g(), m()),
                    i.on("click", "li", function () {
                        i.find("li").removeClass("active"), w(this).addClass("active");
                        var e = w(this).attr("data-filter");
                        u.isotope({ filter: e }), t.hasClass("hash-filter") && (location.hash = "filter=" + encodeURIComponent(e)), t.hasClass("isotope-pagination") && ((r = e), f(), p(1), g(), m()), AOS.init({ disable: !0 });
                    });
            }
            function p(e) {
                var t,
                    i = d;
                (i += "*" != r ? "[" + s + '="' + r + '"]' : ""), (t = i += "[" + o + '="' + (a = e) + '"]'), u.isotope({ filter: t });
            }
            function f() {
                var e, t, i, a;
                (e = u.children(d).length),
                    Math.ceil(e / 6),
                    (i = t = 1),
                    (a = d),
                    (a += "*" != r ? "[" + s + '="' + r + '"]' : ""),
                    u.children(a).each(function () {
                        6 < t && (i++, (t = 1)), w(this).attr(o, i), t++;
                    }),
                    (n = i),
                    (function () {
                        var e = 0 === w("." + l).length ? w('<div class="' + l + '"></div>') : w("." + l);
                        e.html("");
                        for (var t = 0; t < n; t++) {
                            var i = w('<a href="javascript:void(0);" class="pager pagination-link" ' + o + '="' + (t + 1) + '"></a>');
                            i.html(t + 1),
                                i.click(function () {
                                    var e = w(this).eq(0).attr(o);
                                    AOS.init({ disable: !0 }), p(e);
                                }),
                                i.appendTo(e);
                        }
                        u.after(e);
                    })();
            }
            function g() {
                1 == w(".pager").length ? w(".isotope-pager").css("display", "none") : w(".isotope-pager").css("display", "block");
            }
            function m() {
                w(".pager:first").addClass("is-current"),
                    w(".pager").click(function () {
                        var e = w(this).attr("data-page");
                        w(".isotope-pager").find(".is-current").removeClass("is-current"), a == e && w(this).addClass("is-current");
                    });
            }
            var v = !1;
            function y() {
                var e = (function () {
                    location.hash;
                    var e = location.hash.match(/filter=([^&]+)/i),
                        t = e && e[1];
                    return t && decodeURIComponent(t);
                })();
                (!e && v) || ((v = !0), u.isotope({ filter: e }), e && (i.find(".active").removeClass("active"), i.find('[data-filter="' + e + '"]').addClass("active")), AOS.init({ disable: !0 }));
            }
            t.hasClass("hash-filter") && (w(_).on("hashchange", y), y());
        });
    })(jQuery, window, document),
    (function (a, e, n, t) {
        "use strict";
        a(n).ready(function () {
            var e = a(".mfp-lightbox"),
                t = a(".mfp-lightbox-gallery"),
                i = {
                    closeOnContentClick: !0,
                    closeBtnInside: !1,
                    zoom: {
                        enabled: !0,
                        duration: 300,
                        easing: "ease-in-out",
                        opener: function (e) {
                            return e.is("img") ? e : e.closest("figure").find("img");
                        },
                    },
                };
            e.length &&
                e.each(function () {
                    a(this).hasClass("mfp-image")
                        ? a(this).magnificPopup(i)
                        : a(this).hasClass("popup-with-zoom-anim")
                        ? a(this).magnificPopup({ type: "inline", fixedContentPos: !1, fixedBgPos: !0, overflowY: "auto", closeBtnInside: !0, preloader: !1, midClick: !0, removalDelay: 300, mainClass: "mfp-zoom-in" })
                        : a(this).hasClass("popup-with-move-anim")
                        ? a(this).magnificPopup({ type: "inline", fixedContentPos: !1, fixedBgPos: !0, overflowY: "auto", closeBtnInside: !0, preloader: !1, midClick: !0, removalDelay: 300, mainClass: "mfp-slide-bottom" })
                        : a(this).hasClass("popup-modal")
                        ? (a(this).magnificPopup({ type: "inline", fixedContentPos: !1, fixedBgPos: !0, overflowY: "auto", closeBtnInside: !0, preloader: !1, midClick: !0, removalDelay: 300, mainClass: "mfp-zoom-in", modal: !0 }),
                          a(n).on("click", ".popup-modal-dismiss", function (e) {
                              e.preventDefault(), a.magnificPopup.close();
                          }))
                        : a(this).magnificPopup({ closeBtnInside: !1 });
                }),
                t.length &&
                    t.each(function () {
                        a(this)
                            .find(".mfp-lightbox")
                            .magnificPopup({
                                closeBtnInside: !1,
                                gallery: { enabled: !0, tPrev: "previous", tNext: "next", tCounter: "%curr% of %total%" },
                                zoom: {
                                    enabled: !0,
                                    duration: 300,
                                    easing: "ease-in-out",
                                    opener: function (e) {
                                        return e.is("img") ? e : e.closest("figure").find("img");
                                    },
                                },
                            });
                    });
        });
    })(jQuery, window, document),
    (function (s, t, e, i) {
        "use strict";
        s(e).ready(function () {
            var r = s("header"),
                i = s("body"),
                a = (s("body.rtl"), r.find('.main-navigation ul li a[href*="#"]:not([href="#"])')),
                e = i.find('a[href*="#"]:not([href="#"])');
            i.hasClass("header-one-page") &&
                (a.on("click", function () {
                    var e = r.height();
                    if ((i.hasClass("hide-on-scroll") && (e = 0), location.pathname.replace(/^\//, "") == this.pathname.replace(/^\//, "") && location.hostname == this.hostname)) {
                        var t = s(this.hash);
                        if ((t = t.length ? t : s("[name=" + this.hash.slice(1) + "]")).length)
                            return (
                                event.preventDefault(),
                                a.parent("li").removeClass("active"),
                                s(this).parent("li").addClass("active"),
                                s("html, body").animate(
                                    { scrollTop: t.offset().top - e },
                                    {
                                        duration: 1e3,
                                        progress: function () {
                                            0 < e - r.height() ? s(this).css("margin-top", e - r.height()) : s(this).css("margin-top", "");
                                        },
                                    }
                                ),
                                !1
                            );
                    }
                }),
                s(t).scroll(function () {
                    var n = s(t).scrollTop();
                    s("section").each(function (e) {
                        var t = s(this).offset().top - (r.height() + 1),
                            i = t + s(this).height();
                        if (t <= n && n <= i) {
                            var a = s(this).attr("id");
                            s('a[href="#' + a + '"]')
                                .parent()
                                .addClass("active")
                                .siblings()
                                .removeClass("active");
                        }
                    }),
                        0 === n && (a.parent("li").removeClass("active"), a.parent("li:first-child").addClass("active"));
                })),
                e.on("click", function () {
                    var e = r.height();
                    if ((i.hasClass("hide-on-scroll") && (e = 0), location.pathname.replace(/^\//, "") == this.pathname.replace(/^\//, "") && location.hostname == this.hostname)) {
                        var t = s(this.hash);
                        if ((t = t.length ? t : s("[name=" + this.hash.slice(1) + "]")).length)
                            return (
                                event.preventDefault(),
                                s("html, body").animate(
                                    { scrollTop: t.offset().top - e },
                                    {
                                        duration: 1e3,
                                        progress: function () {
                                            0 < e - r.height() ? s(this).css("margin-top", e - r.height()) : s(this).css("margin-top", "");
                                        },
                                    }
                                ),
                                !1
                            );
                    }
                });
        });
    })(jQuery, window, document),
    (function (d, c, e, t) {
        "use strict";
        d(e).ready(function () {
            var i = d("header"),
                a = d("body"),
                n = (d("body.rtl"), c.pageYOffset),
                r = parseInt(i.css("padding-top"), 10),
                s = d(".parallax-mirror"),
                o = i.height(),
                l = i.width();
            d(c).scroll(function () {
                var e = d(c).scrollTop();
                if (
                    a.hasClass("header-sticky") &&
                    !a.hasClass("header-side-navigation") &&
                    (a.hasClass("show-on-scroll") &&
                        (a.hasClass("boxed-layout") && i.css("width", l + "px"),
                        0 !== e
                            ? (e > i.height()
                                  ? (i.css("position", "fixed").css("top", 0), 59 < i.height() && i.addClass("show-on-scroll"))
                                  : a.hasClass("header-center-overlay")
                                  ? i.css("position", "").css("top", -(i.height() + r))
                                  : i.css("position", "").css("top", "-100%"),
                              s.css("top", -o))
                            : (i.removeClass("show-on-scroll"), (a.hasClass("header-center-overlay") || a.hasClass("header-transparent") || a.hasClass("header-transparent-overlay")) && i.css("top", 0), s.css("top", 0))),
                    a.hasClass("hide-on-scroll"))
                ) {
                    a.hasClass("boxed-layout") && i.css("width", l + "px");
                    var t = c.pageYOffset;
                    0 !== t
                        ? (t < n
                              ? (a.hasClass("header-topbar"),
                                i.css("position", "fixed").css("top", 0),
                                59 < i.height() && i.addClass("hide-on-scroll"),
                                (a.hasClass("header-menu-background-primary") || a.hasClass("header-menu-background-dark")) && i.addClass("hide-on-scroll"))
                              : a.hasClass("header-center-overlay")
                              ? i.css("position", "fixed").css("top", -(i.height() + r))
                              : i.css("position", "fixed").css("top", 0),
                          (n = t),
                          s.css("top", -o))
                        : (i.css("position", ""),
                          i.removeClass("hide-on-scroll"),
                          a.hasClass("header-topbar") && a.hasClass("header-transparent") && i.css("top", d("#header-top-wrap").height()),
                          a.hasClass("header-topbar") && a.hasClass("header-transparent-overlay") && i.css("top", d("#header-top-wrap").height()),
                          s.css("top", 0));
                }
            });
        });
    })(jQuery, window, document),
    (function (j, L, O, e) {
        "use strict";
        j(O).ready(function () {
            var i = j(".main-navigation"),
                n = j("body"),
                e = (j("body.rtl"), j(".nav-menu-dropdown")),
                a = j(".header-menu-icons"),
                r = j(".search-form-overlay"),
                t = j(".header-side-navigation"),
                s = j(".side-push-menu"),
                o = j(".hamburger-menu"),
                l = j(".header-hamburger-menu"),
                d = j(".header-hamburger-menu header .level:last-child"),
                c = n.hasClass("header-hamburger-menu"),
                u = n.hasClass("header-logo-top"),
                h = n.hasClass("header-menu-top"),
                p = n.hasClass("header-side-navigation"),
                f = n.hasClass("side-mini"),
                g = l.hasClass("slide-up"),
                m = l.hasClass("slide-down"),
                v = j("#header-wrap header"),
                y = j("#header-wrap header .site-header-inner"),
                w = y.hasClass("header-fullwidth"),
                _ = j(L),
                b = j("html").attr("dir"),
                x = !1;
            function T() {
                var e = _.width(),
                    t = j("#header-logo").html();
                if (
                    (c ||
                        u ||
                        h ||
                        p ||
                        y.find(".level.top").length ||
                        (n.hasClass("header-logo-right")
                            ? y.prepend(
                                  '<div class="level top" style="display: none;"><div class="level-left"><div class="hamburger-menu"><span class="hamburger-menu-icon"></span></div></div><div class="level-right"><div id="header-logo" class="site-logo">' +
                                      t +
                                      "</div></div></div>"
                              )
                            : y.prepend(
                                  '<div class="level top" style="display: none;"><div class="level-left"><div id="header-logo" class="site-logo">' +
                                      t +
                                      '</div></div><div class="level-right"><div class="hamburger-menu"><span class="hamburger-menu-icon"></span></div></div></div>'
                              )),
                    u &&
                        (y.find(".level.top .level-right").length
                            ? n.hasClass("header-logo-with-icons") &&
                              y.find(".level.top .level-right").length < 2 &&
                              y.find(".level.top").append('<div class="level-right" style="display: none;"><div class="hamburger-menu"><span class="hamburger-menu-icon"></span></div></div>')
                            : y.find(".level.top").append('<div class="level-right" style="display: none;"><div class="hamburger-menu"><span class="hamburger-menu-icon"></span></div></div>')),
                    h &&
                        (y.find(".level").last().find(".level-right.num-2").length ||
                            y.find(".level").last().append('<div class="level-right num-2" style="display: none;"><div class="hamburger-menu"><span class="hamburger-menu-icon"></span></div></div>'),
                        y.find(".level.top").find(".level-right").length ||
                            y.find(".level.top").append('<div class="level-right num-2" style="display: none;"><div class="hamburger-menu"><span class="hamburger-menu-icon"></span></div></div>')),
                    (g || m) &&
                        (y.find(".level.top").length ||
                            (n.hasClass("icon-left")
                                ? y.prepend(
                                      '<div class="level top" style="display: none;"><div class="level-left"><div class="hamburger-menu"><span class="hamburger-menu-icon"></span></div></div><div class="level-right"><div id="header-logo" class="site-logo">' +
                                          t +
                                          "</div></div></div>"
                                  )
                                : y.prepend(
                                      '<div class="level top" style="display: none;"><div class="level-left"><div id="header-logo" class="site-logo">' +
                                          t +
                                          '</div></div><div class="level-right"><div class="hamburger-menu"><span class="hamburger-menu-icon"></span></div></div></div>'
                                  ))),
                    p &&
                        !f &&
                        (y.find(".level.top").length ||
                            (n.hasClass("side-right")
                                ? y.prepend(
                                      '<div class="level top" style="display: none;"><div class="level-left"><div class="hamburger-menu"><span class="hamburger-menu-icon"></span></div></div><div class="level-right"><div id="header-logo" class="site-logo">' +
                                          t +
                                          "</div></div></div>"
                                  )
                                : y.prepend(
                                      '<div class="level top" style="display: none;"><div class="level-left"><div id="header-logo" class="site-logo">' +
                                          t +
                                          '</div></div><div class="level-right"><div class="hamburger-menu"><span class="hamburger-menu-icon"></span></div></div></div>'
                                  ))),
                    e < 1088)
                ) {
                    if (
                        (n.hasClass("footer-widgets") &&
                            n.find("#footer-wrap .site-footer-inner .columns .column").each(function () {
                                j(this).addClass("is-6-tablet"),
                                    j(this).hasClass("is-4") && (j(this).removeClass("is-4"), j(this).addClass("is-4-desktop")),
                                    j(this).hasClass("is-3") && (j(this).removeClass("is-3"), j(this).addClass("is-3-desktop"));
                            }),
                        n.addClass("responsive-layout"),
                        f || v.addClass("responsive-on-scroll"),
                        c || p)
                    )
                        y.find(".site-logo").css("visibility", "visible").show(),
                            y.find(".hamburger-menu").css("visibility", "visible").show(),
                            y.find(".main-navigation").css("visibility", "visible").show(),
                            y.find(".header-menu-icons").css("visibility", "visible").show(),
                            y.find(".button").css("visibility", "visible").css("display", "flex"),
                            y.find(".nav-menu-dropdown").css("visibility", "visible").show();
                    else {
                        if (
                            (n.hasClass("header-logo-right") ? n.addClass("header-hamburger-menu slide-left slide-overlay") : n.addClass("header-hamburger-menu slide-right slide-overlay"),
                            y.addClass("header-fullwidth"),
                            y.find(".level.top").length)
                        )
                            if (u) y.find(".level.top").css("display", "flex"), y.find(".level.top .level-right").show(), n.hasClass("header-logo-with-icons") && y.find(".level.top .level-left").first().hide();
                            else if (h) {
                                var i = y.children(".level");
                                y.find(".level").first().find(".level-left .site-logo ").length || y.append(i.get().reverse()),
                                    y.find(".level").first().addClass("top"),
                                    y.find(".level").last().removeClass("top").show(),
                                    y.find(".level").first().find(".level-left").css("display", "flex").css("margin", 0),
                                    2 === y.find(".level").first().find(".level-left").length && y.find(".level").first().find(".level-left").first().hide(),
                                    y.find(".level").first().find(".level-right.num-2").css("display", "flex"),
                                    y.find(".logo-text").hide();
                            } else y.find(".level.top").show();
                        (n.hasClass("header-logo-center") || u) && y.find(".logo-text").hide(),
                            y.find(".site-logo").css("visibility", "visible").show(),
                            y.find(".hamburger-menu").css("visibility", "visible").show(),
                            y.find(".main-navigation").css("visibility", "visible").show(),
                            y.find(".header-menu-icons").css("visibility", "visible").show(),
                            y.find(".button").css("visibility", "visible").css("display", "flex"),
                            y.find(".nav-menu-dropdown").css("visibility", "visible").show(),
                            (o = j(".hamburger-menu")),
                            (l = j(".header-hamburger-menu")),
                            (d = j(".header-hamburger-menu header .level:last-child")),
                            n.hasClass("header-logo-right")
                                ? d.find(".level-right").last().hide()
                                : n.hasClass("header-logo-center-menu-center")
                                ? d.find(".site-logo").hide()
                                : u
                                ? n.hasClass("header-logo-with-icons")
                                    ? d.find(".level-left").first().show()
                                    : 1 < d.find(".level-left").length
                                    ? d.find(".level-left").first().hide()
                                    : d.find(".level-left").first().show()
                                : h
                                ? y.find(".level").last().find(".level-left").show()
                                : d.find(".level-left").last().hide();
                    }
                    (g || m) &&
                        (n.removeClass("slide-up"),
                        n.removeClass("slide-down"),
                        n.hasClass("icon-left") ? n.addClass("slide-left slide-overlay slide-up-down-left") : n.addClass("slide-right slide-overlay slide-up-down"),
                        y.addClass("header-fullwidth"),
                        y.find(".level.top").length && y.find(".level.top").show(),
                        (o = j(".hamburger-menu")),
                        (l = j(".header-hamburger-menu")),
                        (d = j(".header-hamburger-menu header .level:last-child"))),
                        p &&
                            !f &&
                            (n.removeClass("header-side-navigation"),
                            n.hasClass("side-right") ? n.addClass("header-hamburger-menu slide-left slide-overlay") : n.addClass("header-hamburger-menu slide-right slide-overlay"),
                            y.addClass("header-fullwidth"),
                            y.find(".level.top").length && y.find(".level.top").show(),
                            (o = j(".hamburger-menu")),
                            (l = j(".header-hamburger-menu")),
                            (d = j(".header-hamburger-menu header .level:last-child")));
                } else {
                    if (
                        (n.hasClass("footer-widgets") &&
                            n.find("#footer-wrap .site-footer-inner .columns .column").each(function () {
                                j(this).removeClass("is-6-tablet"),
                                    j(this).hasClass("is-4-desktop") && (j(this).removeClass("is-4-desktop"), j(this).addClass("is-4")),
                                    j(this).hasClass("is-3-desktop") && (j(this).removeClass("is-3-desktop"), j(this).addClass("is-3"));
                            }),
                        n.removeClass("responsive-layout"),
                        f || v.removeClass("responsive-on-scroll"),
                        "0px" === d.css("margin-right") && "0px" === d.css("margin-left") && (l.hasClass("slide-right") || l.hasClass("slide-left")) && (d.toggleClass("opened"), o.toggleClass("expanded"), l.toggleClass("pushed")),
                        !c && !p)
                    ) {
                        if (
                            (n.hasClass("header-logo-right")
                                ? d.find(".level-right").last().show()
                                : n.hasClass("header-logo-center-menu-center")
                                ? d.find(".site-logo").show()
                                : u
                                ? d.find(".level-left").first().css("display", "flex")
                                : h
                                ? 2 === y.find(".level").first().find(".level-left").length && y.find(".level").first().find(".level-left").first().css("display", "flex")
                                : d.find(".level-left").last().show(),
                            n.hasClass("header-logo-right") ? n.removeClass("header-hamburger-menu slide-left slide-overlay") : n.removeClass("header-hamburger-menu slide-right slide-overlay"),
                            w || y.removeClass("header-fullwidth"),
                            y.find(".level.top").length &&
                                (u || y.find(".level.top").hide(),
                                u && (n.hasClass("header-logo-with-icons") ? (y.find(".level.top .level-right").last().hide(), y.find(".level.top .level-left").first().css("display", "flex")) : y.find(".level.top .level-right").hide()),
                                h))
                        ) {
                            var a = y.children(".level");
                            y.find(".level").last().find(".level-left .site-logo ").length || y.append(a.get().reverse()),
                                y.find(".level").first().addClass("top").css("display", "flex"),
                                y.find(".level").last().removeClass("top").show(),
                                y.find(".level").last().find(".level-left").last().css("display", "flex").css("margin", "0 auto"),
                                y.find(".level").first().find(".level-right.num-2").hide(),
                                y.find(".level").last().find(".level-right.num-2").hide(),
                                y.find(".logo-text").show();
                        }
                        (n.hasClass("header-logo-center") || u) && y.find(".logo-text").show(), (o = j(".hamburger-menu")), (l = j(".header-hamburger-menu")), (d = j(".header-hamburger-menu header .level:last-child"));
                    }
                    (g || m) &&
                        (g && n.addClass("slide-up"),
                        m && n.addClass("slide-down"),
                        n.hasClass("icon-left") ? n.removeClass("slide-left slide-overlay slide-up-down-left") : n.removeClass("slide-right slide-overlay slide-up-down"),
                        w || y.removeClass("header-fullwidth"),
                        y.find(".level.top").length && y.find(".level.top").hide(),
                        y.find(".main-navigation").css("visibility", "visible").hide(),
                        (o = j(".hamburger-menu")),
                        (l = j(".header-hamburger-menu")),
                        (d = j(".header-hamburger-menu header .level:last-child"))),
                        p &&
                            !f &&
                            (n.addClass("header-side-navigation"),
                            n.hasClass("side-right") ? n.removeClass("header-hamburger-menu slide-left slide-overlay") : n.removeClass("header-hamburger-menu slide-right slide-overlay"),
                            y.removeClass("header-fullwidth"),
                            y.find(".level.top").length && y.find(".level.top").hide(),
                            (o = j(".hamburger-menu")),
                            (l = j(".header-hamburger-menu")),
                            (d = j(".header-hamburger-menu header .level:last-child")));
                }
            }
            if (((j("body").hasClass("rtl") || j("html").hasClass("rtl") || "rtl" == b) && (x = !0), T(), j(L).resize(T), i.length)) {
                i.find("> ul > li:has( > ul)").addClass("menu-down-icon");
                var C = j(".container").offset().left;
                i.find("> ul > li").each(function () {
                    if (
                        !j(this).hasClass("mega-menu") ||
                        j("body").hasClass("overlay-full-width") ||
                        j("body").hasClass("slide-overlay") ||
                        j("body").hasClass("header-side-navigation") ||
                        j("body").hasClass("header-background-primary") ||
                        j("body").hasClass("header-background-dark") ||
                        j("body").hasClass("slide-push")
                    )
                        j(this).hasClass("mega-menu") && j(this).removeClass("mega-menu"), j(this).find("> ul li:has( > ul)").addClass("menu-right-icon");
                    else {
                        var e = j(this);
                        j("body").hasClass("header-side-navigation")
                            ? j(this).hasClass("niche-templates")
                                ? j(this).find("> ul").addClass("container columns is-3 is-variable is-multiline").css("margin-top", 0)
                                : j(this).find("> ul").addClass("container columns is-gapless").css("margin-top", 0)
                            : j(this).hasClass("niche-templates")
                            ? j(this)
                                  .find("> ul")
                                  .addClass("container columns is-3 is-variable is-multiline")
                                  .css("margin-left", -(j(this).offset().left - C))
                                  .css("margin-top", 0)
                            : j(this)
                                  .find("> ul")
                                  .addClass("container columns is-gapless")
                                  .css("margin-left", -(j(this).offset().left - C))
                                  .css("margin-top", 0),
                            j(this)
                                .find("> ul > li")
                                .each(function () {
                                    j(this).addClass("column"), e.hasClass("niche-templates") && j(this).addClass("is-3");
                                });
                    }
                }),
                    k();
            }
            function k() {
                var e = _.width();
                if (e < 1088)
                    i.find("ul li").off("mouseenter mouseleave"),
                        i.find("> ul > li > span").length || i.find("> ul > li:has( > ul)").prepend('<span class="main-parent"></span>'),
                        i.find("> ul > li").each(function () {
                            j(this).find("> ul > li > span").length || j(this).find("> ul li:has( > ul)").prepend("<span></span>");
                        }),
                        i
                            .find("ul li > span")
                            .unbind()
                            .click(function () {
                                j(this).hasClass("main-parent") && (i.find("ul li ul").fadeOut("fast"), i.find("ul li > span").removeClass("opened")),
                                    j(this).closest("li").children("ul").is(":visible")
                                        ? (j(this).removeClass("opened"), j(this).closest("li").children("ul").fadeOut("fast"))
                                        : (j(this).addClass("opened"), j(this).closest("li").children("ul").slideToggle(400));
                            }),
                        j(O).on("click", function (e) {
                            j(e.target).closest(".main-navigation").length || (i.find("ul li ul").is(":visible") && (i.find("ul li ul").fadeOut("fast"), i.find("ul li > span").removeClass("opened")));
                        });
                else {
                    if (e < 1280)
                        i.find("> ul > li").each(function () {
                            j(this).hasClass("mega-menu") &&
                                (j(this).addClass("old-mega-menu"),
                                j(this).removeClass("mega-menu"),
                                j(this).find("> ul").removeClass("container columns").css("margin-left", 0).css("margin-top", 0),
                                j(this).find("> ul li:has( > ul)").addClass("menu-right-icon"),
                                j(this).find("> ul li").removeClass("column"),
                                j(this)
                                    .find("> ul li")
                                    .hover(
                                        function () {
                                            if ((j(this).children("ul").hide(), j(this).children("ul").fadeIn(350), j(this).children("ul").length)) {
                                                var e = j(this).children("ul");
                                                e.offset().left + e.width() <= n.width() + n.offset().left || (j(this).children("ul").removeClass("open-left"), j(this).children("ul").addClass("open-left"));
                                            }
                                        },
                                        function () {
                                            j("ul", this).fadeOut("fast");
                                        }
                                    ));
                        });
                    else {
                        var t = j(".container").offset().left;
                        i.find("> ul > li").each(function () {
                            j(this).hasClass("old-mega-menu") &&
                                (j(this).addClass("mega-menu"),
                                j(this).removeClass("old-mega-menu"),
                                j(this)
                                    .find("> ul")
                                    .addClass("container columns")
                                    .css("margin-left", -(j(this).offset().left - t))
                                    .css("margin-top", 0),
                                j(this).find("> ul li:has( > ul)").removeClass("menu-right-icon"),
                                j(this).find("> ul > li").addClass("column"),
                                j(this).find("> ul li ul").removeAttr("style class"),
                                j(this).find("> ul > li > ul").show(),
                                j(this).find("> ul li").off("mouseenter mouseleave"));
                        });
                    }
                    i.find("ul li").hover(
                        function () {
                            if (j(this).hasClass("mega-menu")) j(this).find("> ul").fadeIn(350);
                            else if (j(this).hasClass("column")) j(this).find("> ul").show();
                            else if ((j(this).children("ul").hide(), j(this).children("ul").fadeIn(350), j(this).children("ul").length)) {
                                var e = j(this).children("ul");
                                e.offset().left + e.width() <= n.width() + n.offset().left || (j(this).children("ul").removeClass("open-left"), j(this).children("ul").addClass("open-left"));
                            }
                        },
                        function () {
                            j(this).hasClass("mega-menu") ? j(this).find("> ul").fadeOut("fast") : j(this).hasClass("column") ? j(this).find("> ul").show() : j("ul", this).fadeOut("fast");
                        }
                    );
                }
            }
            (n.hasClass("header-logo-center") ||
                n.hasClass("header-logo-left") ||
                n.hasClass("header-logo-right") ||
                n.hasClass("header-menu-with-buttons") ||
                n.hasClass("header-menu-with-icons") ||
                n.hasClass("slide-up") ||
                n.hasClass("slide-down")) &&
                y.hasClass("header-fullwidth") &&
                !n.hasClass("menu-center") &&
                i.find("> ul > li").each(function () {
                    j(this).hasClass("mega-menu") &&
                        (j(this).removeClass("mega-menu"),
                        j(this).find("> ul").removeClass("container columns").css("margin-left", 0).css("margin-top", 0),
                        j(this).find("> ul li:has( > ul)").addClass("menu-right-icon"),
                        j(this).find("> ul li").removeClass("column"));
                }),
                j(L).resize(k),
                e.length &&
                    (e.hasClass("on-click")
                        ? (j(O).on("click", function (e) {
                              j(e.target).closest(".nav-menu-dropdown").length || (j(".nav-menu-dropdown > li > ul").is(":visible") && j(".nav-menu-dropdown > li > ul").fadeOut("fast"));
                          }),
                          e.find("> li").on("click", function () {
                              if (j(this).children("ul").is(":visible")) j(this).children("ul").hide(), j(this).children("ul").fadeOut("fast");
                              else if ((j(this).children("ul").hide(), j(this).children("ul").fadeIn(350), j(this).children("ul").length)) {
                                  var e = j(this).children("ul");
                                  e.offset().left + e.width() <= n.width() + n.offset().left || (j(this).children("ul").removeClass("open-left"), j(this).children("ul").addClass("open-left"));
                              }
                          }))
                        : e.find("> li").hover(
                              function () {
                                  if ((j(this).children("ul").hide(), j(this).children("ul").fadeIn(350), j(this).children("ul").length)) {
                                      var e = j(this).children("ul");
                                      e.offset().left + e.width() <= n.width() + n.offset().left || (j(this).children("ul").removeClass("open-left"), j(this).children("ul").addClass("open-left"));
                                  }
                              },
                              function () {
                                  j("ul", this).fadeOut("fast");
                              }
                          )),
                a.length &&
                    a.find("ul").length &&
                    (j(O).on("click", function (e) {
                        j(e.target).closest(".header-menu-icons").length || (j(".header-menu-icons > li > ul").is(":visible") && j(".header-menu-icons > li > ul").fadeOut("fast")),
                            j(e.target).closest(".search-form-overlay input").length || j(".search-form-overlay input").is(":focus") || (r.hide(), r.removeClass("is-active"), r.fadeOut("fast"));
                    }),
                    a.find("> li").on("click", function (e) {
                        var t = j(e.target).parent().attr("class");
                        if (
                            (j(this).hasClass("search-style-2") && (a.find("ul").hide(), a.find("ul").fadeOut("fast"), r.fadeIn(350), r.addClass("is-active"), r.find("input").focus()),
                            r.find(".modal-close").on("click", function (e) {
                                r.hide(), r.removeClass("is-active"), r.fadeOut("fast");
                            }),
                            "product-remove" !== t && !j(".dropdown-search-form input").is(":focus") && !j(this).hasClass("search-style-2") && !j(this).find(".dropdown-user-account").is(":visible"))
                        )
                            if (j(this).children("ul").is(":visible")) a.find("ul").hide(), a.find("ul").fadeOut("fast");
                            else if ((a.find("ul").hide(), j(this).children("ul").fadeIn(350), j(this).children("ul").length)) {
                                var i = j(this).children("ul");
                                i.offset().left + i.width() <= n.width() + n.offset().left || (j(this).children("ul").removeClass("open-left"), j(this).children("ul").addClass("open-left"));
                            }
                    }));
            var S = j("header").width() + 1;
            j("body").hasClass("header-side-navigation") &&
                j("body").hasClass("side-left") &&
                (j(".site-header-top").css("margin-left", S),
                j(".site-header-bottom").css("margin-left", S),
                j(".site-content-header").css("margin-left", S),
                j("#content-main-wrap").css("margin-left", S),
                j(".site-content-footer").css("margin-left", S),
                j(".site-footer-top").css("margin-left", S),
                j(".site-footer").css("margin-left", S),
                j(".site-footer-bottom").css("margin-left", S),
                j(".rev_slider_wrapper").css("max-width", j("body").width() - S + "px"),
                j(".rev_slider_wrapper").css("margin-left", S)),
                j("body").hasClass("header-side-navigation") &&
                    j("body").hasClass("side-right") &&
                    (j(".site-header-top").css("margin-right", S),
                    j(".site-header-bottom").css("margin-right", S),
                    j(".site-content-header").css("margin-right", S),
                    j("#content-main-wrap").css("margin-right", S),
                    j(".site-content-footer").css("margin-right", S),
                    j(".site-footer-top").css("margin-right", S),
                    j(".site-footer").css("margin-right", S),
                    j(".site-footer-bottom").css("margin-right", S),
                    j(".rev_slider_wrapper").css("max-width", j("body").width() - S + "px"),
                    j(".rev_slider_wrapper").css("margin-right", S)),
                s.length &&
                    (j(O).on("click", function (e) {
                        t.find(".site-header .level").each(function () {
                            j(this).hasClass("top") || j(e.target).closest(".header-side-navigation .site-header .level").length || (j(this).is(":visible") && (s.find("i").attr("class", "ion-ios-menu"), j(this).fadeOut("fast")));
                        });
                    }),
                    s.on("click", function (e) {
                        j("body").hasClass("header-side-navigation") &&
                            j("body").hasClass("side-mini") &&
                            (s.find("i").attr("class", "ion-ios-close-outline"),
                            t.find(".site-header .level").each(function () {
                                j(this).hasClass("top") || (j(this).is(":visible") ? (s.find("i").attr("class", "ion-ios-menu"), j(this).hide(), j(this).fadeOut("fast")) : (j(this).hide(), j(this).fadeIn(350)));
                            }));
                    })),
                o.length &&
                    (j(O).on("click", function (e) {
                        j(e.target).closest("header .level:last-child").length ||
                            j(e.target).closest(".hamburger-menu").length ||
                            ("0px" === d.css("margin-right") && "0px" === d.css("margin-left") && (l.hasClass("slide-right") || l.hasClass("slide-left")) && (d.toggleClass("opened"), o.toggleClass("expanded"), l.toggleClass("pushed")));
                    }),
                    o.on("click", function (e) {
                        j(this).toggleClass("expanded"),
                            l.hasClass("slide-down") && i.css("top", "0"),
                            l.hasClass("slide-up") && i.css("bottom", "0"),
                            (l.hasClass("slide-down") || l.hasClass("slide-up")) &&
                                (l.hasClass("icon-left")
                                    ? y.hasClass("header-fullwidth")
                                        ? x
                                            ? i.css("right", j(this).width() + 45)
                                            : i.css("left", j(this).width() + 45)
                                        : x
                                        ? i.css("right", j(this).width() + 15)
                                        : i.css("left", j(this).width() + 15)
                                    : y.hasClass("header-fullwidth")
                                    ? x
                                        ? i.css("left", j(this).width() + 45)
                                        : i.css("right", j(this).width() + 45)
                                    : x
                                    ? i.css("left", j(this).width() + 15)
                                    : i.css("right", j(this).width() + 15),
                                i.slideToggle(),
                                (C = j(".container").offset().left),
                                i.find("> ul > li").each(function () {
                                    j(this).hasClass("mega-menu")
                                        ? (j(this)
                                              .find("> ul")
                                              .addClass("container columns is-gapless")
                                              .css("margin-left", -(j(this).offset().left - C))
                                              .css("margin-top", 0),
                                          j(this)
                                              .find("> ul > li")
                                              .each(function () {
                                                  j(this).addClass("column");
                                              }))
                                        : j(this).find("> ul li:has( > ul)").addClass("menu-right-icon");
                                })),
                            (l.hasClass("slide-right") || l.hasClass("slide-left")) &&
                                (l.hasClass("slide-overlay") && d.toggleClass("opened"),
                                l.hasClass("slide-push") && (d.toggleClass("opened"), l.toggleClass("pushed")),
                                l.hasClass("overlay-full-width") &&
                                    i.find("> ul > li").each(function () {
                                        j(this).hasClass("mega-menu") && j(this).removeClass("mega-menu");
                                    }));
                    }));
        });
    })(jQuery, window, document),
    (function (o, e, t, i) {
        "use strict";
        o(t).ready(function () {
            var t = o("body"),
                e = (o(".overhang"), o(".show-overhang"), o(".overhang-top")),
                i = o(".overhang-bottom"),
                a = o(".overhang-message-content"),
                n = o(".notify-alert-message"),
                r = o(".notify-alert"),
                s = { custom: !0, easing: "linear", speed: 400, html: !0, closeConfirm: !0, primary: "#e83c2e" };
            e.on("click", function () {
                t.removeClass("overhang-in-bottom"),
                    t.addClass("overhang-push"),
                    t.removeClass("overhang-info"),
                    t.removeClass("overhang-success"),
                    t.removeClass("overhang-warning"),
                    t.removeClass("overhang-danger"),
                    t.overhang(
                        o.extend(s, {
                            message: a.html(),
                            callback: function (e) {
                                t.removeClass("overhang-push"), t.removeClass("overhang-info"), t.removeClass("overhang-success"), t.removeClass("overhang-warning"), t.removeClass("overhang-danger");
                            },
                        })
                    );
            }),
                i.on("click", function () {
                    t.addClass("overhang-in-bottom"),
                        t.removeClass("overhang-push"),
                        t.removeClass("overhang-info"),
                        t.removeClass("overhang-success"),
                        t.removeClass("overhang-warning"),
                        t.removeClass("overhang-danger"),
                        t.overhang(
                            o.extend(s, {
                                message: a.html(),
                                callback: function (e) {
                                    t.removeClass("overhang-push"), t.removeClass("overhang-info"), t.removeClass("overhang-success"), t.removeClass("overhang-warning"), t.removeClass("overhang-danger");
                                },
                            })
                        );
                }),
                o(".button.overhang-info").on("click", function () {
                    t.removeClass("overhang-in-bottom"),
                        t.addClass("overhang-push"),
                        t.addClass("overhang-info"),
                        t.removeClass("overhang-success"),
                        t.removeClass("overhang-warning"),
                        t.removeClass("overhang-danger"),
                        t.overhang(
                            o.extend(s, {
                                message: a.html(),
                                callback: function (e) {
                                    t.removeClass("overhang-push"), t.removeClass("overhang-info");
                                },
                            })
                        );
                }),
                o(".button.overhang-success").on("click", function () {
                    t.removeClass("overhang-in-bottom"),
                        t.addClass("overhang-push"),
                        t.addClass("overhang-success"),
                        t.removeClass("overhang-info"),
                        t.removeClass("overhang-warning"),
                        t.removeClass("overhang-danger"),
                        t.overhang(
                            o.extend(s, {
                                message: a.html(),
                                callback: function (e) {
                                    t.removeClass("overhang-push"), t.removeClass("overhang-success");
                                },
                            })
                        );
                }),
                o(".button.overhang-warning").on("click", function () {
                    t.removeClass("overhang-in-bottom"),
                        t.addClass("overhang-push"),
                        t.addClass("overhang-warning"),
                        t.removeClass("overhang-info"),
                        t.removeClass("overhang-success"),
                        t.removeClass("overhang-danger"),
                        t.overhang(
                            o.extend(s, {
                                message: a.html(),
                                callback: function (e) {
                                    t.removeClass("overhang-push"), t.removeClass("overhang-warning");
                                },
                            })
                        );
                }),
                o(".button.overhang-danger").on("click", function () {
                    t.removeClass("overhang-in-bottom"),
                        t.addClass("overhang-push"),
                        t.addClass("overhang-danger"),
                        t.removeClass("overhang-info"),
                        t.removeClass("overhang-success"),
                        t.removeClass("overhang-warning"),
                        t.overhang(
                            o.extend(s, {
                                message: a.html(),
                                callback: function (e) {
                                    t.removeClass("overhang-push"), t.removeClass("overhang-danger");
                                },
                            })
                        );
                }),
                r.length &&
                    r.find(".button").each(function () {
                        o(this).on("click", function () {
                            o(this).is("[data-options]") && !o.isEmptyObject(o.parseJSON(o(this).attr("data-options")))
                                ? new Noty(o.extend({ text: n.html(), type: "success" }, o.parseJSON(o(this).attr("data-options")))).show()
                                : new Noty({ text: n.html(), type: "success" }).show();
                        });
                    });
        });
    })(jQuery, window, document),
    (function (r, s, e, t) {
        "use strict";
        r(e).ready(function () {
            var e = r(".progressbar"),
                t = {
                    strokeWidth: 1.8,
                    trailWidth: 1.8,
                    easing: "easeInOut",
                    duration: 1400,
                    color: "#e83c2e",
                    trailColor: "#EAEAEA",
                    svgStyle: { width: "100%", height: "100%" },
                    text: { style: {} },
                    step: function (e, t) {
                        t.setText(Math.round(100 * t.value()) + "%");
                    },
                };
            e.length &&
                e.each(function () {
                    var a,
                        e = t;
                    r(this).is("[data-options]") && !r.isEmptyObject(r.parseJSON(r(this).attr("data-options"))) && (e = r.extend(t, r.parseJSON(r(this).attr("data-options")))),
                        (a = r(this).hasClass("circle")
                            ? ((e = r.extend(e, {
                                  text: { autoStyleContainer: !1 },
                                  strokeWidth: 4,
                                  trailWidth: 4,
                                  step: function (e, t) {
                                      var i = Math.round(100 * t.value()) + "%";
                                      "0%" === i ? t.setText("") : t.setText(i);
                                  },
                              })),
                              new ProgressBar.Circle("." + r(this).attr("class").replace(/\s+/g, "."), e))
                            : ((e = r.extend(e, { strokeWidth: 1.8, trailWidth: 1.8, text: { style: {} } })), new ProgressBar.Line("." + r(this).attr("class").replace(/\s+/g, "."), e))).animate(r(this).attr("data-value"));
                    var n = r(this);
                    r(s).scroll(function (e) {
                        var t, i;
                        (t = n), (i = r(s).scrollTop() + r(s).height()), t.offset().top + 100 <= i ? a.animate(n.attr("data-value")) : a.set(0);
                    });
                });
        });
    })(jQuery, window, document),
    (function (i, e, t, a) {
        "use strict";
        i(t).ready(function () {
            i("#barrating-1to10").barrating("show", { theme: "bars-1to10" }),
                i("#barrating-movie").barrating("show", { theme: "bars-movie" }),
                i("#barrating-movie").barrating("set", "Mediocre"),
                i("#barrating-square").barrating("show", { theme: "bars-square", showValues: !0, showSelectedRating: !1 }),
                i("#barrating-pill").barrating("show", {
                    theme: "bars-pill",
                    initialRating: "A",
                    showValues: !0,
                    showSelectedRating: !1,
                    allowEmpty: !0,
                    emptyValue: "-- no rating selected --",
                    onSelect: function (e, t) {
                        alert("Selected rating: " + e);
                    },
                }),
                i("#barrating-reversed").barrating("show", { theme: "bars-reversed", showSelectedRating: !0, reverse: !0 }),
                i("#barrating-horizontal").barrating("show", { theme: "bars-horizontal", reverse: !0, hoverState: !1 }),
                i("#barrating-fontawesome").barrating({ theme: "fontawesome-stars", showSelectedRating: !1 }),
                i("#barrating-css").barrating({ theme: "css-stars", showSelectedRating: !1 });
            var e = i("#barrating-fontawesome-o").data("current-rating");
            i(".stars-fontawesome-o .current-rating").find("span").html(e),
                i(".stars-fontawesome-o .clear-rating").on("click", function (e) {
                    e.preventDefault(), i("#barrating-fontawesome-o").barrating("clear");
                }),
                i("#barrating-fontawesome-o").barrating({
                    theme: "fontawesome-stars-o",
                    showSelectedRating: !1,
                    initialRating: e,
                    onSelect: function (e, t) {
                        e ? (i(".stars-fontawesome-o .current-rating").addClass("hidden"), i(".stars-fontawesome-o .your-rating").removeClass("hidden").find("span").html(e)) : i("#barrating-fontawesome-o").barrating("clear");
                    },
                    onClear: function (e, t) {
                        i(".stars-fontawesome-o").find(".current-rating").removeClass("hidden").end().find(".your-rating").addClass("hidden");
                    },
                });
        });
    })(jQuery, window, document),
    (function (a, e, t, i) {
        "use strict";
        a(t).ready(function () {
            var e = a("body"),
                t = (a("body.rtl"), e.find("#rev_slider_1")),
                i = "fullscreen";
            e.hasClass("boxed-layout") && (i = "auto"),
                t.length &&
                    t
                        .show()
                        .revolution({
                            sliderLayout: i,
                            fullScreenOffsetContainer: "#header-wrap",
                            fullScreenAlignForce: "off",
                            autoHeight: "on",
                            minHeight: "500",
                            navigation: {
                                keyboardNavigation: "on",
                                keyboard_direction: "horizontal",
                                onHoverStop: "on",
                                arrows: { enable: !0, style: "uranus", hide_onleave: !1, left: { h_offset: 50, v_offset: 0 }, right: { h_offset: 50, v_offset: 0 } },
                                bullets: { enable: !0, style: "hermes", hide_onleave: !1, h_align: "center", v_align: "bottom", h_offset: 0, v_offset: 50, space: 17 },
                            },
                            spinner: "spinner2",
                            viewPort: { enable: !0, outof: "wait", visible_area: "80%", presize: !0 },
                            parallax: { type: "mouse+scroll", origo: "slidercenter", speed: 400, levels: [5, 10, 15, 20, 25, 30, 35, 40, 45, 46, 47, 48, 49, 50, 51, 55], disable_onmobile: "on" },
                        });
        });
    })(jQuery, window, document),
    (function (s, e, t, i) {
        "use strict";
        s(t).ready(function () {
            var a = s(".accordions"),
                n = s(".beefup"),
                e = s(".toggle-buttons"),
                t = { openSingle: !0, openSpeed: 300, closeSpeed: 300 };
            a.length &&
                a.each(function () {
                    n.length && s(this).find(n).beefup(t);
                }),
                e.length &&
                    e.each(function () {
                        var e = s(this),
                            i = e.find(n).beefup(t);
                        e.find(".toggle-open-all").on("click", function () {
                            i.open();
                        }),
                            e.find(".toggle-close-all").on("click", function () {
                                i.close();
                            }),
                            e
                                .find(".buttons-group")
                                .find(".button")
                                .each(function (t) {
                                    s(this).on("click", function () {
                                        s(this).hasClass("toggle-open-all") ||
                                            s(this).hasClass("toggle-close-all") ||
                                            e
                                                .find(a)
                                                .find(n)
                                                .each(function (e) {
                                                    t === e && i.click(s(this));
                                                });
                                    });
                                });
                    });
            var r = {
                s: { animLen: 300 },
                init: function () {
                    r.bindUIActions(), r.hideInactive();
                },
                bindUIActions: function () {
                    s(".tabs").on("click", "li", function () {
                        r.switchTab(s(this));
                    });
                },
                hideInactive: function () {
                    var n = s(".tabs-list");
                    n.each(function (e) {
                        var t = s(n[e]),
                            i = t.find(".tab-block"),
                            a = t.find("li.is-active");
                        i.hide(), s(i[a.index()]).show();
                    });
                },
                switchTab: function (e) {
                    var t = e.closest(".tabs-list");
                    e.hasClass("is-active") || (e.siblings().removeClass("is-active"), e.addClass("is-active"), r.showPane(e.index(), t));
                },
                showPane: function (e, t) {
                    var i = t.find(".tab-block");
                    i.slideUp(r.s.animLen), s(i[e]).slideDown(r.s.animLen);
                },
            };
            s(".tabs-list").length && r.init();
        });
    })(jQuery, window, document),
    (function (jQuery, undefined) {
        "use strict";
        var version = {
            core: "5.4.8",
            "revolution.extensions.actions.min.js": "2.1.0",
            "revolution.extensions.carousel.min.js": "1.2.1",
            "revolution.extensions.kenburn.min.js": "1.3.1",
            "revolution.extensions.layeranimation.min.js": "3.6.5",
            "revolution.extensions.navigation.min.js": "1.3.5",
            "revolution.extensions.parallax.min.js": "2.2.3",
            "revolution.extensions.slideanims.min.js": "1.8",
            "revolution.extensions.video.min.js": "2.2.2",
        };
        jQuery.fn.extend({
            revolution: function (t) {
                var e = {
                    delay: 9e3,
                    responsiveLevels: 4064,
                    visibilityLevels: [2048, 1024, 778, 480],
                    gridwidth: 960,
                    gridheight: 500,
                    minHeight: 0,
                    autoHeight: "off",
                    sliderType: "standard",
                    sliderLayout: "auto",
                    fullScreenAutoWidth: "off",
                    fullScreenAlignForce: "off",
                    fullScreenOffsetContainer: "",
                    fullScreenOffset: "0",
                    hideCaptionAtLimit: 0,
                    hideAllCaptionAtLimit: 0,
                    hideSliderAtLimit: 0,
                    disableProgressBar: "off",
                    stopAtSlide: -1,
                    stopAfterLoops: -1,
                    shadow: 0,
                    dottedOverlay: "none",
                    startDelay: 0,
                    lazyType: "smart",
                    spinner: "spinner0",
                    shuffle: "off",
                    viewPort: { enable: !1, outof: "wait", visible_area: "60%", presize: !1 },
                    fallbacks: {
                        isJoomla: !1,
                        panZoomDisableOnMobile: "off",
                        simplifyAll: "on",
                        nextSlideOnWindowFocus: "off",
                        disableFocusListener: !0,
                        ignoreHeightChanges: "off",
                        ignoreHeightChangesSize: 0,
                        allowHTML5AutoPlayOnAndroid: !0,
                    },
                    parallax: {
                        type: "off",
                        levels: [10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85],
                        origo: "enterpoint",
                        speed: 400,
                        bgparallax: "off",
                        opacity: "on",
                        disable_onmobile: "off",
                        ddd_shadow: "on",
                        ddd_bgfreeze: "off",
                        ddd_overflow: "visible",
                        ddd_layer_overflow: "visible",
                        ddd_z_correction: 65,
                        ddd_path: "mouse",
                    },
                    scrolleffect: {
                        fade: "off",
                        blur: "off",
                        scale: "off",
                        grayscale: "off",
                        maxblur: 10,
                        on_layers: "off",
                        on_slidebg: "off",
                        on_static_layers: "off",
                        on_parallax_layers: "off",
                        on_parallax_static_layers: "off",
                        direction: "both",
                        multiplicator: 1.35,
                        multiplicator_layers: 0.5,
                        tilt: 30,
                        disable_on_mobile: "on",
                    },
                    carousel: {
                        easing: punchgs.Power3.easeInOut,
                        speed: 800,
                        showLayersAllTime: "off",
                        horizontal_align: "center",
                        vertical_align: "center",
                        infinity: "on",
                        space: 0,
                        maxVisibleItems: 3,
                        stretch: "off",
                        fadeout: "on",
                        maxRotation: 0,
                        minScale: 0,
                        vary_fade: "off",
                        vary_rotation: "on",
                        vary_scale: "off",
                        border_radius: "0px",
                        padding_top: 0,
                        padding_bottom: 0,
                    },
                    navigation: {
                        keyboardNavigation: "off",
                        keyboard_direction: "horizontal",
                        mouseScrollNavigation: "off",
                        onHoverStop: "on",
                        touch: { touchenabled: "off", touchOnDesktop: "off", swipe_treshold: 75, swipe_min_touches: 1, drag_block_vertical: !1, swipe_direction: "horizontal" },
                        arrows: {
                            style: "",
                            enable: !1,
                            hide_onmobile: !1,
                            hide_onleave: !0,
                            hide_delay: 200,
                            hide_delay_mobile: 1200,
                            hide_under: 0,
                            hide_over: 9999,
                            tmp: "",
                            rtl: !1,
                            left: { h_align: "left", v_align: "center", h_offset: 20, v_offset: 0, container: "slider" },
                            right: { h_align: "right", v_align: "center", h_offset: 20, v_offset: 0, container: "slider" },
                        },
                        bullets: {
                            container: "slider",
                            rtl: !1,
                            style: "",
                            enable: !1,
                            hide_onmobile: !1,
                            hide_onleave: !0,
                            hide_delay: 200,
                            hide_delay_mobile: 1200,
                            hide_under: 0,
                            hide_over: 9999,
                            direction: "horizontal",
                            h_align: "left",
                            v_align: "center",
                            space: 0,
                            h_offset: 20,
                            v_offset: 0,
                            tmp: '<span class="tp-bullet-image"></span><span class="tp-bullet-title"></span>',
                        },
                        thumbnails: {
                            container: "slider",
                            rtl: !1,
                            style: "",
                            enable: !1,
                            width: 100,
                            height: 50,
                            min_width: 100,
                            wrapper_padding: 2,
                            wrapper_color: "#f5f5f5",
                            wrapper_opacity: 1,
                            tmp: '<span class="tp-thumb-image"></span><span class="tp-thumb-title"></span>',
                            visibleAmount: 5,
                            hide_onmobile: !1,
                            hide_onleave: !0,
                            hide_delay: 200,
                            hide_delay_mobile: 1200,
                            hide_under: 0,
                            hide_over: 9999,
                            direction: "horizontal",
                            span: !1,
                            position: "inner",
                            space: 2,
                            h_align: "left",
                            v_align: "center",
                            h_offset: 20,
                            v_offset: 0,
                        },
                        tabs: {
                            container: "slider",
                            rtl: !1,
                            style: "",
                            enable: !1,
                            width: 100,
                            min_width: 100,
                            height: 50,
                            wrapper_padding: 10,
                            wrapper_color: "#f5f5f5",
                            wrapper_opacity: 1,
                            tmp: '<span class="tp-tab-image"></span>',
                            visibleAmount: 5,
                            hide_onmobile: !1,
                            hide_onleave: !0,
                            hide_delay: 200,
                            hide_delay_mobile: 1200,
                            hide_under: 0,
                            hide_over: 9999,
                            direction: "horizontal",
                            span: !1,
                            space: 0,
                            position: "inner",
                            h_align: "left",
                            v_align: "center",
                            h_offset: 20,
                            v_offset: 0,
                        },
                    },
                    extensions: "extensions/",
                    extensions_suffix: ".min.js",
                    debugMode: !1,
                };
                return (
                    (t = jQuery.extend(!0, {}, e, t)),
                    this.each(function () {
                        var e = jQuery(this);
                        (t.minHeight = t.minHeight != undefined ? parseInt(t.minHeight, 0) : t.minHeight),
                            (t.scrolleffect.on = "on" === t.scrolleffect.fade || "on" === t.scrolleffect.scale || "on" === t.scrolleffect.blur || "on" === t.scrolleffect.grayscale),
                            "hero" == t.sliderType &&
                                e.find(">ul>li").each(function (e) {
                                    0 < e && jQuery(this).remove();
                                }),
                            (t.jsFileLocation = t.jsFileLocation || getScriptLocation("themepunch.revolution.min.js")),
                            (t.jsFileLocation = t.jsFileLocation + t.extensions),
                            (t.scriptsneeded = getNeededScripts(t, e)),
                            (t.curWinRange = 0),
                            (t.rtl = !0),
                            t.navigation != undefined && t.navigation.touch != undefined && (t.navigation.touch.swipe_min_touches = 5 < t.navigation.touch.swipe_min_touches ? 1 : t.navigation.touch.swipe_min_touches),
                            jQuery(this).on("scriptsloaded", function () {
                                if (t.modulesfailing)
                                    return (
                                        e
                                            .html(
                                                '<div style="margin:auto;line-height:40px;font-size:14px;color:#fff;padding:15px;background:#e74c3c;margin:20px 0px;">!! Error at loading Slider Revolution 5.0 Extrensions.' +
                                                    t.errorm +
                                                    "</div>"
                                            )
                                            .show(),
                                        !1
                                    );
                                _R.migration != undefined && (t = _R.migration(e, t)), (punchgs.force3D = !0), "on" !== t.simplifyAll && punchgs.TweenLite.lagSmoothing(1e3, 16), prepareOptions(e, t), initSlider(e, t);
                            }),
                            (e[0].opt = t),
                            waitForScripts(e, t);
                    })
                );
            },
            getRSVersion: function (e) {
                if (!0 === e) return jQuery("body").data("tp_rs_version");
                var t = jQuery("body").data("tp_rs_version"),
                    i = "";
                for (var a in ((i += "---------------------------------------------------------\n"), (i += "    Currently Loaded Slider Revolution & SR Modules :\n"), (i += "---------------------------------------------------------\n"), t))
                    i += t[a].alias + ": " + t[a].ver + "\n";
                return i + "---------------------------------------------------------\n";
            },
            revremoveslide: function (r) {
                return this.each(function () {
                    var e = jQuery(this),
                        t = e[0].opt;
                    if (!(r < 0 || r > t.slideamount) && e != undefined && 0 < e.length && 0 < jQuery("body").find("#" + e.attr("id")).length && t && 0 < t.li.length && (0 < r || r <= t.li.length)) {
                        var i = jQuery(t.li[r]),
                            a = i.data("index"),
                            n = !1;
                        (t.slideamount = t.slideamount - 1),
                            (t.realslideamount = t.realslideamount - 1),
                            removeNavWithLiref(".tp-bullet", a, t),
                            removeNavWithLiref(".tp-tab", a, t),
                            removeNavWithLiref(".tp-thumb", a, t),
                            i.hasClass("active-revslide") && (n = !0),
                            i.remove(),
                            (t.li = removeArray(t.li, r)),
                            t.carousel && t.carousel.slides && (t.carousel.slides = removeArray(t.carousel.slides, r)),
                            (t.thumbs = removeArray(t.thumbs, r)),
                            _R.updateNavIndexes && _R.updateNavIndexes(t),
                            n && e.revnext(),
                            punchgs.TweenLite.set(t.li, { minWidth: "99%" }),
                            punchgs.TweenLite.set(t.li, { minWidth: "100%" });
                    }
                });
            },
            revaddcallback: function (e) {
                return this.each(function () {
                    this.opt && (this.opt.callBackArray === undefined && (this.opt.callBackArray = new Array()), this.opt.callBackArray.push(e));
                });
            },
            revgetparallaxproc: function () {
                return jQuery(this)[0].opt.scrollproc;
            },
            revdebugmode: function () {
                return this.each(function () {
                    var e = jQuery(this);
                    (e[0].opt.debugMode = !0), containerResized(e, e[0].opt);
                });
            },
            revscroll: function (t) {
                return this.each(function () {
                    var e = jQuery(this);
                    jQuery("body,html").animate({ scrollTop: e.offset().top + e.height() - t + "px" }, { duration: 400 });
                });
            },
            revredraw: function (e) {
                return this.each(function () {
                    var e = jQuery(this);
                    containerResized(e, e[0].opt);
                });
            },
            revkill: function (e) {
                var t = jQuery(this);
                if ((punchgs.TweenLite.killDelayedCallsTo(_R.showHideNavElements), t != undefined && 0 < t.length && 0 < jQuery("body").find("#" + t.attr("id")).length)) {
                    t.data("conthover", 1), t.data("conthover-changed", 1), t.trigger("revolution.slide.onpause");
                    var i = t.parent().find(".tp-bannertimer"),
                        a = t[0].opt;
                    (a.tonpause = !0), t.trigger("stoptimer");
                    var n = "resize.revslider-" + t.attr("id");
                    jQuery(window).unbind(n),
                        punchgs.TweenLite.killTweensOf(t.find("*"), !1),
                        punchgs.TweenLite.killTweensOf(t, !1),
                        t.unbind("hover, mouseover, mouseenter,mouseleave, resize"),
                        (n = "resize.revslider-" + t.attr("id")),
                        jQuery(window).off(n),
                        t.find("*").each(function () {
                            var e = jQuery(this);
                            e.unbind("on, hover, mouseenter,mouseleave,mouseover, resize,restarttimer, stoptimer"),
                                e.off("on, hover, mouseenter,mouseleave,mouseover, resize"),
                                e.data("mySplitText", null),
                                e.data("ctl", null),
                                e.data("tween") != undefined && e.data("tween").kill(),
                                e.data("kenburn") != undefined && e.data("kenburn").kill(),
                                e.data("timeline_out") != undefined && e.data("timeline_out").kill(),
                                e.data("timeline") != undefined && e.data("timeline").kill(),
                                e.remove(),
                                e.empty(),
                                (e = null);
                        }),
                        punchgs.TweenLite.killTweensOf(t.find("*"), !1),
                        punchgs.TweenLite.killTweensOf(t, !1),
                        i.remove();
                    try {
                        t.closest(".forcefullwidth_wrapper_tp_banner").remove();
                    } catch (e) {}
                    try {
                        t.closest(".rev_slider_wrapper").remove();
                    } catch (e) {}
                    try {
                        t.remove();
                    } catch (e) {}
                    return t.empty(), t.html(), (a = t = null), delete this.c, delete this.opt, delete this.container, !0;
                }
                return !1;
            },
            revpause: function () {
                return this.each(function () {
                    var e = jQuery(this);
                    e != undefined &&
                        0 < e.length &&
                        0 < jQuery("body").find("#" + e.attr("id")).length &&
                        (e.data("conthover", 1), e.data("conthover-changed", 1), e.trigger("revolution.slide.onpause"), (e[0].opt.tonpause = !0), e.trigger("stoptimer"));
                });
            },
            revresume: function () {
                return this.each(function () {
                    var e = jQuery(this);
                    e != undefined &&
                        0 < e.length &&
                        0 < jQuery("body").find("#" + e.attr("id")).length &&
                        (e.data("conthover", 0), e.data("conthover-changed", 1), e.trigger("revolution.slide.onresume"), (e[0].opt.tonpause = !1), e.trigger("starttimer"));
                });
            },
            revstart: function () {
                var e = jQuery(this);
                if (e != undefined && 0 < e.length && 0 < jQuery("body").find("#" + e.attr("id")).length && e[0].opt !== undefined)
                    return e[0].opt.sliderisrunning ? (console.log("Slider Is Running Already"), !1) : (((e[0].opt.c = e)[0].opt.ul = e.find(">ul")), runSlider(e, e[0].opt), !0);
            },
            revnext: function () {
                return this.each(function () {
                    var e = jQuery(this);
                    e != undefined && 0 < e.length && 0 < jQuery("body").find("#" + e.attr("id")).length && _R.callingNewSlide(e, 1);
                });
            },
            revprev: function () {
                return this.each(function () {
                    var e = jQuery(this);
                    e != undefined && 0 < e.length && 0 < jQuery("body").find("#" + e.attr("id")).length && _R.callingNewSlide(e, -1);
                });
            },
            revmaxslide: function () {
                return jQuery(this).find(".tp-revslider-mainul >li").length;
            },
            revcurrentslide: function () {
                var e = jQuery(this);
                if (e != undefined && 0 < e.length && 0 < jQuery("body").find("#" + e.attr("id")).length) return parseInt(e[0].opt.act, 0) + 1;
            },
            revlastslide: function () {
                return jQuery(this).find(".tp-revslider-mainul >li").length;
            },
            revshowslide: function (t) {
                return this.each(function () {
                    var e = jQuery(this);
                    e != undefined && 0 < e.length && 0 < jQuery("body").find("#" + e.attr("id")).length && _R.callingNewSlide(e, "to" + (t - 1));
                });
            },
            revcallslidewithid: function (t) {
                return this.each(function () {
                    var e = jQuery(this);
                    e != undefined && 0 < e.length && 0 < jQuery("body").find("#" + e.attr("id")).length && _R.callingNewSlide(e, t);
                });
            },
        });
        var _R = jQuery.fn.revolution;
        jQuery.extend(!0, _R, {
            getversion: function () {
                return version;
            },
            compare_version: function (e) {
                var t = jQuery("body").data("tp_rs_version");
                return (
                    (t = t === undefined ? new Object() : t).Core === undefined &&
                        ((t.Core = new Object()), (t.Core.alias = "Slider Revolution Core"), (t.Core.name = "jquery.themepunch.revolution.min.js"), (t.Core.ver = _R.getversion().core)),
                    "stop" != e.check &&
                        (_R.getversion().core < e.min_core
                            ? (e.check === undefined &&
                                  (console.log("%cSlider Revolution Warning (Core:" + _R.getversion().core + ")", "color:#c0392b;font-weight:bold;"),
                                  console.log("%c     Core is older than expected (" + e.min_core + ") from " + e.alias, "color:#333"),
                                  console.log("%c     Please update Slider Revolution to the latest version.", "color:#333"),
                                  console.log("%c     It might be required to purge and clear Server/Client side Caches.", "color:#333")),
                              (e.check = "stop"))
                            : _R.getversion()[e.name] != undefined &&
                              e.version < _R.getversion()[e.name] &&
                              (e.check === undefined &&
                                  (console.log("%cSlider Revolution Warning (Core:" + _R.getversion().core + ")", "color:#c0392b;font-weight:bold;"),
                                  console.log("%c     " + e.alias + " (" + e.version + ") is older than requiered (" + _R.getversion()[e.name] + ")", "color:#333"),
                                  console.log("%c     Please update Slider Revolution to the latest version.", "color:#333"),
                                  console.log("%c     It might be required to purge and clear Server/Client side Caches.", "color:#333")),
                              (e.check = "stop"))),
                    t[e.alias] === undefined && ((t[e.alias] = new Object()), (t[e.alias].alias = e.alias), (t[e.alias].ver = e.version), (t[e.alias].name = e.name)),
                    jQuery("body").data("tp_rs_version", t),
                    e
                );
            },
            currentSlideIndex: function (e) {
                var t = e.c.find(".active-revslide").index();
                return -1 == t ? 0 : t;
            },
            simp: function (e, t, i) {
                var a = Math.abs(e) - Math.floor(Math.abs(e / t)) * t;
                return i ? a : e < 0 ? -1 * a : a;
            },
            iOSVersion: function () {
                var e = !1;
                return navigator.userAgent.match(/iPhone/i) || navigator.userAgent.match(/iPod/i) || navigator.userAgent.match(/iPad/i) ? navigator.userAgent.match(/OS 4_\d like Mac OS X/i) && (e = !0) : (e = !1), e;
            },
            isIE: function (e, t) {
                var i = jQuery('<div style="display:none;"/>').appendTo(jQuery("body"));
                i.html("\x3c!--[if " + (t || "") + " IE " + (e || "") + "]><a>&nbsp;</a><![endif]--\x3e");
                var a = i.find("a").length;
                return i.remove(), a;
            },
            is_mobile: function () {
                var e = ["android", "webos", "iphone", "ipad", "blackberry", "Android", "webos", , "iPod", "iPhone", "iPad", "Blackberry", "BlackBerry"],
                    t = !1;
                for (var i in e) 1 < navigator.userAgent.split(e[i]).length && (t = !0);
                return t;
            },
            is_android: function () {
                var e = ["android", "Android"],
                    t = !1;
                for (var i in e) 1 < navigator.userAgent.split(e[i]).length && (t = !0);
                return t;
            },
            callBackHandling: function (e, i, a) {
                try {
                    e.callBackArray &&
                        jQuery.each(e.callBackArray, function (e, t) {
                            t && t.inmodule && t.inmodule === i && t.atposition && t.atposition === a && t.callback && t.callback.call();
                        });
                } catch (e) {
                    console.log("Call Back Failed");
                }
            },
            get_browser: function () {
                var e,
                    t = navigator.appName,
                    i = navigator.userAgent,
                    a = i.match(/(opera|chrome|safari|firefox|msie)\/?\s*(\.?\d+(\.\d+)*)/i);
                return a && null != (e = i.match(/version\/([\.\d]+)/i)) && (a[2] = e[1]), (a = a ? [a[1], a[2]] : [t, navigator.appVersion, "-?"])[0];
            },
            get_browser_version: function () {
                var e,
                    t = navigator.appName,
                    i = navigator.userAgent,
                    a = i.match(/(opera|chrome|safari|firefox|msie)\/?\s*(\.?\d+(\.\d+)*)/i);
                return a && null != (e = i.match(/version\/([\.\d]+)/i)) && (a[2] = e[1]), (a = a ? [a[1], a[2]] : [t, navigator.appVersion, "-?"])[1];
            },
            isSafari11: function () {
                var e = jQuery.trim(_R.get_browser().toLowerCase());
                return -1 === jQuery.trim(navigator.userAgent.toLowerCase()).search("edge") && "msie" !== e && e.match(/safari|chrome/);
            },
            getHorizontalOffset: function (e, t) {
                var i = gWiderOut(e, ".outer-left"),
                    a = gWiderOut(e, ".outer-right");
                switch (t) {
                    case "left":
                        return i;
                    case "right":
                        return a;
                    case "both":
                        return i + a;
                }
            },
            callingNewSlide: function (e, t) {
                var i = 0 < e.find(".next-revslide").length ? e.find(".next-revslide").index() : 0 < e.find(".processing-revslide").length ? e.find(".processing-revslide").index() : e.find(".active-revslide").index(),
                    a = 0,
                    n = e[0].opt;
                e.find(".next-revslide").removeClass("next-revslide"),
                    e.find(".active-revslide").hasClass("tp-invisible-slide") && (i = n.last_shown_slide),
                    (t && jQuery.isNumeric(t)) || t.match(/to/g)
                        ? ((a =
                              1 === t || -1 === t ? ((a = i + t) < 0 ? n.slideamount - 1 : a >= n.slideamount ? 0 : a) : (t = jQuery.isNumeric(t) ? t : parseInt(t.split("to")[1], 0)) < 0 ? 0 : t > n.slideamount - 1 ? n.slideamount - 1 : t),
                          e.find(".tp-revslider-slidesli:eq(" + a + ")").addClass("next-revslide"))
                        : t &&
                          e.find(".tp-revslider-slidesli").each(function () {
                              var e = jQuery(this);
                              e.data("index") === t && e.addClass("next-revslide");
                          }),
                    (a = e.find(".next-revslide").index()),
                    e.trigger("revolution.nextslide.waiting"),
                    (i === a && i === n.last_shown_slide) || (a !== i && -1 != a) ? swapSlide(e) : e.find(".next-revslide").removeClass("next-revslide");
            },
            slotSize: function (e, t) {
                (t.slotw = Math.ceil(t.width / t.slots)),
                    "fullscreen" == t.sliderLayout ? (t.sloth = Math.ceil(jQuery(window).height() / t.slots)) : (t.sloth = Math.ceil(t.height / t.slots)),
                    "on" == t.autoHeight && e !== undefined && "" !== e && (t.sloth = Math.ceil(e.height() / t.slots));
            },
            setSize: function (e) {
                var t = (e.top_outer || 0) + (e.bottom_outer || 0),
                    i = parseInt(e.carousel.padding_top || 0, 0),
                    a = parseInt(e.carousel.padding_bottom || 0, 0),
                    n = e.gridheight[e.curWinRange],
                    r = 0,
                    s = -1 === e.nextSlide || e.nextSlide === undefined ? 0 : e.nextSlide;
                if (((e.paddings = e.paddings === undefined ? { top: parseInt(e.c.parent().css("paddingTop"), 0) || 0, bottom: parseInt(e.c.parent().css("paddingBottom"), 0) || 0 } : e.paddings), e.rowzones && 0 < e.rowzones.length))
                    for (var o = 0; o < e.rowzones[s].length; o++) r += e.rowzones[s][o][0].offsetHeight;
                if (
                    ((n = (n = n < e.minHeight ? e.minHeight : n) < r ? r : n),
                    "fullwidth" == e.sliderLayout && "off" == e.autoHeight && punchgs.TweenLite.set(e.c, { maxHeight: n + "px" }),
                    e.c.css({ marginTop: i, marginBottom: a }),
                    (e.width = e.ul.width()),
                    (e.height = e.ul.height()),
                    setScale(e),
                    (e.height = Math.round(e.gridheight[e.curWinRange] * (e.width / e.gridwidth[e.curWinRange]))),
                    e.height > e.gridheight[e.curWinRange] && "on" != e.autoHeight && (e.height = e.gridheight[e.curWinRange]),
                    "fullscreen" == e.sliderLayout || e.infullscreenmode)
                ) {
                    (e.height = e.bw * e.gridheight[e.curWinRange]), e.c.parent().width();
                    var l = jQuery(window).height();
                    if (e.fullScreenOffsetContainer != undefined) {
                        try {
                            var d = e.fullScreenOffsetContainer.split(",");
                            d &&
                                jQuery.each(d, function (e, t) {
                                    l = 0 < jQuery(t).length ? l - jQuery(t).outerHeight(!0) : l;
                                });
                        } catch (e) {}
                        try {
                            1 < e.fullScreenOffset.split("%").length && e.fullScreenOffset != undefined && 0 < e.fullScreenOffset.length
                                ? (l -= (jQuery(window).height() * parseInt(e.fullScreenOffset, 0)) / 100)
                                : e.fullScreenOffset != undefined && 0 < e.fullScreenOffset.length && (l -= parseInt(e.fullScreenOffset, 0));
                        } catch (e) {}
                    }
                    (l = l < e.minHeight ? e.minHeight : l),
                        (l -= t),
                        e.c.parent().height(l),
                        e.c.closest(".rev_slider_wrapper").height(l),
                        e.c.css({ height: "100%" }),
                        (e.height = l),
                        e.minHeight != undefined && e.height < e.minHeight && (e.height = e.minHeight),
                        (e.height = parseInt(r, 0) > parseInt(e.height, 0) ? r : e.height);
                } else e.minHeight != undefined && e.height < e.minHeight && (e.height = e.minHeight), (e.height = parseInt(r, 0) > parseInt(e.height, 0) ? r : e.height), e.c.height(e.height);
                var c = { height: i + a + t + e.height + e.paddings.top + e.paddings.bottom };
                e.c.closest(".forcefullwidth_wrapper_tp_banner").find(".tp-fullwidth-forcer").css(c), e.c.closest(".rev_slider_wrapper").css(c), setScale(e);
            },
            enterInViewPort: function (i) {
                i.waitForCountDown && (countDown(i.c, i), (i.waitForCountDown = !1)),
                    i.waitForFirstSlide &&
                        (swapSlide(i.c),
                        (i.waitForFirstSlide = !1),
                        setTimeout(function () {
                            i.c.removeClass("tp-waitforfirststart");
                        }, 500)),
                    ("playing" != i.sliderlaststatus && i.sliderlaststatus != undefined) || i.c.trigger("starttimer"),
                    i.lastplayedvideos != undefined &&
                        0 < i.lastplayedvideos.length &&
                        jQuery.each(i.lastplayedvideos, function (e, t) {
                            _R.playVideo(t, i);
                        });
            },
            leaveViewPort: function (i) {
                (i.sliderlaststatus = i.sliderstatus),
                    i.c.trigger("stoptimer"),
                    i.playingvideos != undefined &&
                        0 < i.playingvideos.length &&
                        ((i.lastplayedvideos = jQuery.extend(!0, [], i.playingvideos)),
                        i.playingvideos &&
                            jQuery.each(i.playingvideos, function (e, t) {
                                (i.leaveViewPortBasedStop = !0), _R.stopVideo && _R.stopVideo(t, i);
                            }));
            },
            unToggleState: function (e) {
                e != undefined &&
                    0 < e.length &&
                    jQuery.each(e, function (e, t) {
                        t.removeClass("rs-toggle-content-active");
                    });
            },
            toggleState: function (e) {
                e != undefined &&
                    0 < e.length &&
                    jQuery.each(e, function (e, t) {
                        t.addClass("rs-toggle-content-active");
                    });
            },
            swaptoggleState: function (e) {
                e != undefined &&
                    0 < e.length &&
                    jQuery.each(e, function (e, t) {
                        jQuery(t).hasClass("rs-toggle-content-active") ? jQuery(t).removeClass("rs-toggle-content-active") : jQuery(t).addClass("rs-toggle-content-active");
                    });
            },
            lastToggleState: function (e) {
                var i = 0;
                return (
                    e != undefined &&
                        0 < e.length &&
                        jQuery.each(e, function (e, t) {
                            i = t.hasClass("rs-toggle-content-active");
                        }),
                    i
                );
            },
        });
        var _ISM = _R.is_mobile(),
            _ANDROID = _R.is_android(),
            checkIDS = function (e, t) {
                if (((e.anyid = e.anyid === undefined ? [] : e.anyid), -1 != jQuery.inArray(t.attr("id"), e.anyid))) {
                    var i = t.attr("id") + "_" + Math.round(9999 * Math.random());
                    t.attr("id", i);
                }
                e.anyid.push(t.attr("id"));
            },
            removeArray = function (e, i) {
                var a = [];
                return (
                    jQuery.each(e, function (e, t) {
                        e != i && a.push(t);
                    }),
                    a
                );
            },
            removeNavWithLiref = function (e, t, i) {
                i.c.find(e).each(function () {
                    var e = jQuery(this);
                    e.data("liref") === t && e.remove();
                });
            },
            lAjax = function (t, i) {
                return (
                    !jQuery("body").data(t) &&
                    (i.filesystem
                        ? (i.errorm === undefined && (i.errorm = "<br>Local Filesystem Detected !<br>Put this to your header:"),
                          console.warn("Local Filesystem detected !"),
                          (i.errorm = i.errorm + '<br>&lt;script type="text/javascript" src="' + i.jsFileLocation + t + i.extensions_suffix + '"&gt;&lt;/script&gt;'),
                          console.warn(i.jsFileLocation + t + i.extensions_suffix + " could not be loaded !"),
                          console.warn("Please use a local Server or work online or make sure that you load all needed Libraries manually in your Document."),
                          console.log(" "),
                          !(i.modulesfailing = !0))
                        : (jQuery.ajax({
                              url: i.jsFileLocation + t + i.extensions_suffix + "?version=" + version.core,
                              dataType: "script",
                              cache: !0,
                              error: function (e) {
                                  console.warn("Slider Revolution 5.0 Error !"), console.error("Failure at Loading:" + t + i.extensions_suffix + " on Path:" + i.jsFileLocation), console.info(e);
                              },
                          }),
                          void jQuery("body").data(t, !0)))
                );
            },
            getNeededScripts = function (i, e) {
                var t = new Object(),
                    a = i.navigation;
                return (
                    (t.kenburns = !1),
                    (t.parallax = !1),
                    (t.carousel = !1),
                    (t.navigation = !1),
                    (t.videos = !1),
                    (t.actions = !1),
                    (t.layeranim = !1),
                    (t.migration = !1),
                    e.data("version") && e.data("version").toString().match(/5./gi)
                        ? (e.find("img").each(function () {
                              "on" == jQuery(this).data("kenburns") && (t.kenburns = !0);
                          }),
                          ("carousel" == i.sliderType || "on" == a.keyboardNavigation || "on" == a.mouseScrollNavigation || "on" == a.touch.touchenabled || a.arrows.enable || a.bullets.enable || a.thumbnails.enable || a.tabs.enable) &&
                              (t.navigation = !0),
                          e.find(".tp-caption, .tp-static-layer, .rs-background-video-layer").each(function () {
                              var e = jQuery(this);
                              (e.data("ytid") != undefined || (0 < e.find("iframe").length && 0 < e.find("iframe").attr("src").toLowerCase().indexOf("youtube"))) && (t.videos = !0),
                                  (e.data("vimeoid") != undefined || (0 < e.find("iframe").length && 0 < e.find("iframe").attr("src").toLowerCase().indexOf("vimeo"))) && (t.videos = !0),
                                  e.data("actions") !== undefined && (t.actions = !0),
                                  (t.layeranim = !0);
                          }),
                          e.find("li").each(function () {
                              jQuery(this).data("link") && jQuery(this).data("link") != undefined && ((t.layeranim = !0), (t.actions = !0));
                          }),
                          !t.videos &&
                              (0 < e.find(".rs-background-video-layer").length || 0 < e.find(".tp-videolayer").length || 0 < e.find(".tp-audiolayer").length || 0 < e.find("iframe").length || 0 < e.find("video").length) &&
                              (t.videos = !0),
                          "carousel" == i.sliderType && (t.carousel = !0),
                          ("off" !== i.parallax.type || i.viewPort.enable || "true" == i.viewPort.enable || "true" === i.scrolleffect.on || i.scrolleffect.on) && (t.parallax = !0))
                        : ((t.kenburns = !0), (t.parallax = !0), (t.carousel = !1), (t.navigation = !0), (t.videos = !0), (t.actions = !0), (t.layeranim = !0), (t.migration = !0)),
                    "hero" == i.sliderType && ((t.carousel = !1), (t.navigation = !1)),
                    window.location.href.match(/file:/gi) && ((t.filesystem = !0), (i.filesystem = !0)),
                    t.videos && void 0 === _R.isVideoPlaying && lAjax("revolution.extension.video", i),
                    t.carousel && void 0 === _R.prepareCarousel && lAjax("revolution.extension.carousel", i),
                    t.carousel || void 0 !== _R.animateSlide || lAjax("revolution.extension.slideanims", i),
                    t.actions && void 0 === _R.checkActions && lAjax("revolution.extension.actions", i),
                    t.layeranim && void 0 === _R.handleStaticLayers && lAjax("revolution.extension.layeranimation", i),
                    t.kenburns && void 0 === _R.stopKenBurn && lAjax("revolution.extension.kenburn", i),
                    t.navigation && void 0 === _R.createNavigation && lAjax("revolution.extension.navigation", i),
                    t.migration && void 0 === _R.migration && lAjax("revolution.extension.migration", i),
                    t.parallax && void 0 === _R.checkForParallax && lAjax("revolution.extension.parallax", i),
                    i.addons != undefined &&
                        0 < i.addons.length &&
                        jQuery.each(i.addons, function (e, t) {
                            "object" == typeof t && t.fileprefix != undefined && lAjax(t.fileprefix, i);
                        }),
                    t
                );
            },
            waitForScripts = function (e, t) {
                var i = !0,
                    a = t.scriptsneeded;
                t.addons != undefined &&
                    0 < t.addons.length &&
                    jQuery.each(t.addons, function (e, t) {
                        "object" == typeof t && t.init != undefined && _R[t.init] === undefined && (i = !1);
                    }),
                    a.filesystem ||
                    (void 0 !== punchgs &&
                        i &&
                        (!a.kenburns || (a.kenburns && void 0 !== _R.stopKenBurn)) &&
                        (!a.navigation || (a.navigation && void 0 !== _R.createNavigation)) &&
                        (!a.carousel || (a.carousel && void 0 !== _R.prepareCarousel)) &&
                        (!a.videos || (a.videos && void 0 !== _R.resetVideo)) &&
                        (!a.actions || (a.actions && void 0 !== _R.checkActions)) &&
                        (!a.layeranim || (a.layeranim && void 0 !== _R.handleStaticLayers)) &&
                        (!a.migration || (a.migration && void 0 !== _R.migration)) &&
                        (!a.parallax || (a.parallax && void 0 !== _R.checkForParallax)) &&
                        (a.carousel || (!a.carousel && void 0 !== _R.animateSlide)))
                        ? e.trigger("scriptsloaded")
                        : setTimeout(function () {
                              waitForScripts(e, t);
                          }, 50);
            },
            getScriptLocation = function (e) {
                var t = new RegExp("themepunch.revolution.min.js", "gi"),
                    i = "";
                return (
                    jQuery("script").each(function () {
                        var e = jQuery(this).attr("src");
                        e && e.match(t) && (i = e);
                    }),
                    (i = (i = (i = i.replace("jquery.themepunch.revolution.min.js", "")).replace("jquery.themepunch.revolution.js", "")).split("?")[0])
                );
            },
            setCurWinRange = function (e, t) {
                var i = 9999,
                    a = 0,
                    n = 0,
                    r = 0,
                    s = jQuery(window).width(),
                    o = t && 9999 == e.responsiveLevels ? e.visibilityLevels : e.responsiveLevels;
                o &&
                    o.length &&
                    jQuery.each(o, function (e, t) {
                        s < t && (0 == a || t < a) && ((r = e), (a = i = t)), t < s && a < t && ((a = t), (n = e));
                    }),
                    a < i && (r = n),
                    t ? (e.forcedWinRange = r) : (e.curWinRange = r);
            },
            prepareOptions = function (e, t) {
                (t.carousel.maxVisibleItems = t.carousel.maxVisibleItems < 1 ? 999 : t.carousel.maxVisibleItems),
                    (t.carousel.vertical_align = "top" === t.carousel.vertical_align ? "0%" : "bottom" === t.carousel.vertical_align ? "100%" : "50%");
            },
            gWiderOut = function (e, t) {
                var i = 0;
                return (
                    e.find(t).each(function () {
                        var e = jQuery(this);
                        !e.hasClass("tp-forcenotvisible") && i < e.outerWidth() && (i = e.outerWidth());
                    }),
                    i
                );
            },
            initSlider = function (container, opt) {
                if (container == undefined) return !1;
                container.data("aimg") != undefined &&
                    (("enabled" == container.data("aie8") && _R.isIE(8)) || ("enabled" == container.data("amobile") && _ISM)) &&
                    container.html('<img class="tp-slider-alternative-image" src="' + container.data("aimg") + '">'),
                    container.find(">ul").addClass("tp-revslider-mainul"),
                    (opt.c = container),
                    (opt.ul = container.find(".tp-revslider-mainul")),
                    opt.ul.find(">li").each(function (e) {
                        var t = jQuery(this);
                        "on" == t.data("hideslideonmobile") && _ISM && t.remove(), (t.data("invisible") || !0 === t.data("invisible")) && (t.addClass("tp-invisible-slide"), t.appendTo(opt.ul));
                    }),
                    opt.addons != undefined &&
                        0 < opt.addons.length &&
                        jQuery.each(opt.addons, function (i, obj) {
                            "object" == typeof obj && obj.init != undefined && _R[obj.init](eval(obj.params));
                        }),
                    (opt.cid = container.attr("id")),
                    opt.ul.css({ visibility: "visible" }),
                    (opt.slideamount = opt.ul.find(">li").not(".tp-invisible-slide").length),
                    (opt.realslideamount = opt.ul.find(">li").length),
                    (opt.slayers = container.find(".tp-static-layers")),
                    opt.slayers.data("index", "staticlayers"),
                    1 != opt.waitForInit && ((container[0].opt = opt), runSlider(container, opt));
            },
            onFullScreenChange = function () {
                jQuery("body").data("rs-fullScreenMode", !jQuery("body").data("rs-fullScreenMode")),
                    jQuery("body").data("rs-fullScreenMode") &&
                        setTimeout(function () {
                            jQuery(window).trigger("resize");
                        }, 200);
            },
            runSlider = function (i, x) {
                if (
                    ((x.sliderisrunning = !0),
                    x.ul.find(">li").each(function (e) {
                        jQuery(this).data("originalindex", e);
                    }),
                    (x.allli = x.ul.find(">li")),
                    jQuery.each(x.allli, function (e, t) {
                        (t = jQuery(t)).data("origindex", t.index());
                    }),
                    (x.li = x.ul.find(">li").not(".tp-invisible-slide")),
                    "on" == x.shuffle)
                ) {
                    var e = new Object(),
                        t = x.ul.find(">li:first-child");
                    (e.fstransition = t.data("fstransition")), (e.fsmasterspeed = t.data("fsmasterspeed")), (e.fsslotamount = t.data("fsslotamount"));
                    for (var a = 0; a < x.slideamount; a++) {
                        var n = Math.round(Math.random() * x.slideamount);
                        x.ul.find(">li:eq(" + n + ")").prependTo(x.ul);
                    }
                    var r = x.ul.find(">li:first-child");
                    r.data("fstransition", e.fstransition), r.data("fsmasterspeed", e.fsmasterspeed), r.data("fsslotamount", e.fsslotamount), (x.allli = x.ul.find(">li")), (x.li = x.ul.find(">li").not(".tp-invisible-slide"));
                }
                if (
                    ((x.inli = x.ul.find(">li.tp-invisible-slide")),
                    (x.thumbs = new Array()),
                    (x.slots = 4),
                    (x.act = -1),
                    (x.firststart = 1),
                    (x.loadqueue = new Array()),
                    (x.syncload = 0),
                    (x.conw = i.width()),
                    (x.conh = i.height()),
                    1 < x.responsiveLevels.length ? (x.responsiveLevels[0] = 9999) : (x.responsiveLevels = 9999),
                    jQuery.each(x.allli, function (e, t) {
                        var i = (t = jQuery(t)).find(".rev-slidebg") || t.find("img").first(),
                            a = 0;
                        t.addClass("tp-revslider-slidesli"), t.data("index") === undefined && t.data("index", "rs-" + Math.round(999999 * Math.random()));
                        var n = new Object();
                        for (
                            n.params = new Array(),
                                n.id = t.data("index"),
                                n.src = t.data("thumb") !== undefined ? t.data("thumb") : i.data("lazyload") !== undefined ? i.data("lazyload") : i.attr("src"),
                                t.data("title") !== undefined && n.params.push({ from: RegExp("\\{\\{title\\}\\}", "g"), to: t.data("title") }),
                                t.data("description") !== undefined && n.params.push({ from: RegExp("\\{\\{description\\}\\}", "g"), to: t.data("description") }),
                                a = 1;
                            a <= 10;
                            a++
                        )
                            t.data("param" + a) !== undefined && n.params.push({ from: RegExp("\\{\\{param" + a + "\\}\\}", "g"), to: t.data("param" + a) });
                        if ((x.thumbs.push(n), t.data("link") != undefined)) {
                            var r = t.data("link"),
                                s = t.data("target") || "_self",
                                o = "back" === t.data("slideindex") ? 0 : 60,
                                l = t.data("linktoslide"),
                                d = l;
                            l != undefined &&
                                "next" != l &&
                                "prev" != l &&
                                x.allli.each(function () {
                                    var e = jQuery(this);
                                    e.data("origindex") + 1 == d && (l = e.data("index"));
                                }),
                                "slide" != r && (l = "no");
                            var c = '<div class="tp-caption slidelink" style="cursor:pointer;width:100%;height:100%;z-index:' + o + ';" data-x="center" data-y="center" data-basealign="slide" ',
                                u = ' data-frames=\'[{"delay":0,"speed":100,"frame":"0","from":"opacity:0;","to":"o:1;","ease":"Power3.easeInOut"},{"delay":"wait","speed":300,"frame":"999","to":"opacity:0;","ease":"Power3.easeInOut"}]\'';
                            (c =
                                "no" == l
                                    ? c + u + " >"
                                    : c +
                                      "data-actions='" +
                                      ("scroll_under" === l
                                          ? '[{"event":"click","action":"scrollbelow","offset":"100px","delay":"0"}]'
                                          : "prev" === l
                                          ? '[{"event":"click","action":"jumptoslide","slide":"prev","delay":"0.2"}]'
                                          : "next" === l
                                          ? '[{"event":"click","action":"jumptoslide","slide":"next","delay":"0.2"}]'
                                          : '[{"event":"click","action":"jumptoslide","slide":"' + l + '","delay":"0.2"}]') +
                                      "'" +
                                      u +
                                      " >"),
                                (c += '<a style="width:100%;height:100%;display:block"'),
                                (c = "slide" != r ? c + ' target="' + s + '" href="' + r + '"' : c),
                                (c += '><span style="width:100%;height:100%;display:block"></span></a></div>'),
                                t.append(c);
                        }
                    }),
                    (x.rle = x.responsiveLevels.length || 1),
                    (x.gridwidth = cArray(x.gridwidth, x.rle)),
                    (x.gridheight = cArray(x.gridheight, x.rle)),
                    "on" == x.simplifyAll &&
                        (_R.isIE(8) || _R.iOSVersion()) &&
                        (i.find(".tp-caption").each(function () {
                            var e = jQuery(this);
                            e.removeClass("customin customout").addClass("fadein fadeout"), e.data("splitin", ""), e.data("speed", 400);
                        }),
                        x.allli.each(function () {
                            var e = jQuery(this);
                            e.data("transition", "fade"), e.data("masterspeed", 500), e.data("slotamount", 1), (e.find(".rev-slidebg") || e.find(">img").first()).data("kenburns", "off");
                        })),
                    (x.desktop = !navigator.userAgent.match(/(iPhone|iPod|iPad|Android|BlackBerry|BB10|mobi|tablet|opera mini|nexus 7)/i)),
                    (x.autoHeight = "fullscreen" == x.sliderLayout ? "on" : x.autoHeight),
                    "fullwidth" == x.sliderLayout && "off" == x.autoHeight && i.css({ maxHeight: x.gridheight[x.curWinRange] + "px" }),
                    "auto" != x.sliderLayout && 0 == i.closest(".forcefullwidth_wrapper_tp_banner").length && ("fullscreen" !== x.sliderLayout || "on" != x.fullScreenAutoWidth))
                ) {
                    var s = i.parent(),
                        o = s.css("marginBottom"),
                        l = s.css("marginTop"),
                        d = i.attr("id") + "_forcefullwidth";
                    (o = o === undefined ? 0 : o),
                        (l = l === undefined ? 0 : l),
                        s.wrap('<div class="forcefullwidth_wrapper_tp_banner" id="' + d + '" style="position:relative;width:100%;height:auto;margin-top:' + l + ";margin-bottom:" + o + '"></div>'),
                        i.closest(".forcefullwidth_wrapper_tp_banner").append('<div class="tp-fullwidth-forcer" style="width:100%;height:' + i.height() + 'px"></div>'),
                        i.parent().css({ marginTop: "0px", marginBottom: "0px" }),
                        i.parent().css({ position: "absolute" });
                }
                if (
                    (x.shadow !== undefined &&
                        0 < x.shadow &&
                        (i.parent().addClass("tp-shadow" + x.shadow),
                        i.parent().append('<div class="tp-shadowcover"></div>'),
                        i
                            .parent()
                            .find(".tp-shadowcover")
                            .css({ backgroundColor: i.parent().css("backgroundColor"), backgroundImage: i.parent().css("backgroundImage") })),
                    setCurWinRange(x),
                    setCurWinRange(x, !0),
                    !i.hasClass("revslider-initialised"))
                ) {
                    i.addClass("revslider-initialised"),
                        i.addClass("tp-simpleresponsive"),
                        i.attr("id") == undefined && i.attr("id", "revslider-" + Math.round(1e3 * Math.random() + 5)),
                        checkIDS(x, i),
                        (x.firefox13 = !1),
                        (x.ie = !jQuery.support.opacity),
                        (x.ie9 = 9 == document.documentMode),
                        (x.origcd = x.delay);
                    var c = jQuery.fn.jquery.split("."),
                        u = parseFloat(c[0]),
                        h = parseFloat(c[1]);
                    parseFloat(c[2] || "0"),
                        1 == u &&
                            h < 7 &&
                            i.html(
                                '<div style="text-align:center; padding:40px 0px; font-size:20px; color:#992222;"> The Current Version of jQuery:' +
                                    c +
                                    " <br>Please update your jQuery Version to min. 1.7 in Case you wish to use the Revolution Slider Plugin</div>"
                            ),
                        1 < u && (x.ie = !1);
                    var T = new Object();
                    (T.addedyt = 0),
                        (T.addedvim = 0),
                        (T.addedvid = 0),
                        x.scrolleffect.on && (x.scrolleffect.layers = new Array()),
                        i.find(".tp-caption, .rs-background-video-layer").each(function (e) {
                            var n = jQuery(this),
                                t = n.data(),
                                i = t.autoplayonlyfirsttime,
                                a = t.autoplay,
                                r = (t.videomp4 !== undefined || t.videowebm !== undefined || t.videoogv, n.hasClass("tp-audiolayer")),
                                s = t.videoloop,
                                o = !0,
                                l = !1;
                            (t.startclasses = n.attr("class")),
                                (t.isparallaxlayer = 0 <= t.startclasses.indexOf("rs-parallax")),
                                n.hasClass("tp-static-layer") &&
                                    _R.handleStaticLayers &&
                                    (_R.handleStaticLayers(n, x),
                                    x.scrolleffect.on && (("on" === x.scrolleffect.on_parallax_static_layers && t.isparallaxlayer) || ("on" === x.scrolleffect.on_static_layers && !t.isparallaxlayer)) && (l = !0),
                                    (o = !1));
                            var d = n.data("noposteronmobile") || n.data("noPosterOnMobile") || n.data("posteronmobile") || n.data("posterOnMobile") || n.data("posterOnMObile");
                            n.data("noposteronmobile", d);
                            var c = 0;
                            if (
                                (n.find("iframe").each(function () {
                                    punchgs.TweenLite.set(jQuery(this), { autoAlpha: 0 }), c++;
                                }),
                                0 < c && n.data("iframes", !0),
                                n.hasClass("tp-caption"))
                            ) {
                                var u = n.hasClass("slidelink") ? "width:100% !important;height:100% !important;" : "",
                                    h = n.data(),
                                    p = "",
                                    f = h.type,
                                    g = "row" === f || "column" === f ? "relative" : "absolute",
                                    m = "";
                                "row" === f
                                    ? (n.addClass("rev_row").removeClass("tp-resizeme"), (m = "rev_row_wrap"))
                                    : "column" === f
                                    ? ((p = h.verticalalign === undefined ? " vertical-align:bottom;" : " vertical-align:" + h.verticalalign + ";"),
                                      (m = "rev_column"),
                                      n.addClass("rev_column_inner").removeClass("tp-resizeme"),
                                      n.data("width", "auto"),
                                      punchgs.TweenLite.set(n, { width: "auto" }))
                                    : "group" === f && n.removeClass("tp-resizeme");
                                var v = "",
                                    y = "";
                                "row" !== f && "group" !== f && "column" !== f
                                    ? ((v = "display:" + n.css("display") + ";"),
                                      0 < n.closest(".rev_column").length ? (n.addClass("rev_layer_in_column"), (o = !1)) : 0 < n.closest(".rev_group").length && (n.addClass("rev_layer_in_group"), (o = !1)))
                                    : "column" === f && (o = !1),
                                    h.wrapper_class !== undefined && (m = m + " " + h.wrapper_class),
                                    h.wrapper_id !== undefined && (y = 'id="' + h.wrapper_id + '"');
                                var w = "";
                                n.hasClass("tp-no-events") && (w = ";pointer-events:none"),
                                    n.wrap(
                                        "<div " +
                                            y +
                                            ' class="tp-parallax-wrap ' +
                                            m +
                                            '" style="' +
                                            p +
                                            " " +
                                            u +
                                            "position:" +
                                            g +
                                            ";" +
                                            v +
                                            ";visibility:hidden" +
                                            w +
                                            '"><div class="tp-loop-wrap" style="' +
                                            u +
                                            "position:" +
                                            g +
                                            ";" +
                                            v +
                                            ';"><div class="tp-mask-wrap" style="' +
                                            u +
                                            "position:" +
                                            g +
                                            ";" +
                                            v +
                                            ';" ></div></div></div>'
                                    ),
                                    o && x.scrolleffect.on && (("on" === x.scrolleffect.on_parallax_layers && t.isparallaxlayer) || ("on" === x.scrolleffect.on_layers && !t.isparallaxlayer)) && x.scrolleffect.layers.push(n.parent()),
                                    l && x.scrolleffect.layers.push(n.parent()),
                                    "column" === f &&
                                        (n.append('<div class="rev_column_bg rev_column_bg_man_sized" style="visibility:hidden"></div>'), n.closest(".tp-parallax-wrap").append('<div class="rev_column_bg rev_column_bg_auto_sized"></div>'));
                                var _ = n.closest(".tp-loop-wrap");
                                jQuery.each(["pendulum", "rotate", "slideloop", "pulse", "wave"], function (e, t) {
                                    var i = n.find(".rs-" + t),
                                        a = i.data() || "";
                                    "" != a && (_.data(a), _.addClass("rs-" + t), i.children(0).unwrap(), n.data("loopanimation", "on"));
                                }),
                                    n.attr("id") === undefined && n.attr("id", "layer-" + Math.round(999999999 * Math.random())),
                                    checkIDS(x, n),
                                    punchgs.TweenLite.set(n, { visibility: "hidden" });
                            }
                            var b = n.data("actions");
                            b !== undefined && _R.checkActions(n, x, b),
                                checkHoverDependencies(n, x),
                                _R.checkVideoApis && (T = _R.checkVideoApis(n, x, T)),
                                r || (1 != i && "true" != i && "1sttime" != a) || "loopandnoslidestop" == s || n.closest("li.tp-revslider-slidesli").addClass("rs-pause-timer-once"),
                                r || (1 != a && "true" != a && "on" != a && "no1sttime" != a) || "loopandnoslidestop" == s || n.closest("li.tp-revslider-slidesli").addClass("rs-pause-timer-always");
                        }),
                        i[0].addEventListener(
                            "mouseenter",
                            function () {
                                i.trigger("tp-mouseenter"), (x.overcontainer = !0);
                            },
                            { passive: !0 }
                        ),
                        i[0].addEventListener(
                            "mouseover",
                            function () {
                                i.trigger("tp-mouseover"), (x.overcontainer = !0);
                            },
                            { passive: !0 }
                        ),
                        i[0].addEventListener(
                            "mouseleave",
                            function () {
                                i.trigger("tp-mouseleft"), (x.overcontainer = !1);
                            },
                            { passive: !0 }
                        ),
                        i.find(".tp-caption video").each(function (e) {
                            var t = jQuery(this);
                            t.removeClass("video-js vjs-default-skin"), t.attr("preload", ""), t.css({ display: "none" });
                        }),
                        "standard" !== x.sliderType && (x.lazyType = "all"),
                        loadImages(i.find(".tp-static-layers"), x, 0, !0),
                        waitForCurrentImages(i.find(".tp-static-layers"), x, function () {
                            i.find(".tp-static-layers img").each(function () {
                                var e = jQuery(this),
                                    t = e.data("lazyload") != undefined ? e.data("lazyload") : e.attr("src"),
                                    i = getLoadObj(x, t);
                                e.attr("src", i.src);
                            });
                        }),
                        (x.rowzones = []),
                        x.allli.each(function (e) {
                            var t = jQuery(this);
                            punchgs.TweenLite.set(this, { perspective: 6e3 }),
                                (x.rowzones[e] = []),
                                t.find(".rev_row_zone").each(function () {
                                    x.rowzones[e].push(jQuery(this));
                                }),
                                ("all" != x.lazyType && ("smart" != x.lazyType || (0 != e && 1 != e && e != x.slideamount && e != x.slideamount - 1))) || (loadImages(t, x, e), waitForCurrentImages(t, x, function () {}));
                        });
                    var p = getUrlVars("#")[0];
                    if (p.length < 9 && 1 < p.split("slide").length) {
                        var f = parseInt(p.split("slide")[1], 0);
                        f < 1 && (f = 1), f > x.slideamount && (f = x.slideamount), (x.startWithSlide = f - 1);
                    }
                    i.append('<div class="tp-loader ' + x.spinner + '"><div class="dot1"></div><div class="dot2"></div><div class="bounce1"></div><div class="bounce2"></div><div class="bounce3"></div></div>'),
                        (x.loader = i.find(".tp-loader")),
                        0 === i.find(".tp-bannertimer").length && i.append('<div class="tp-bannertimer" style="visibility:hidden"></div>'),
                        i.find(".tp-bannertimer").css({ width: "0%" }),
                        x.ul.css({ display: "block" }),
                        prepareSlides(i, x),
                        ("off" !== x.parallax.type || x.scrolleffect.on) && _R.checkForParallax && _R.checkForParallax(i, x),
                        _R.setSize(x),
                        "hero" !== x.sliderType && _R.createNavigation && _R.createNavigation(i, x),
                        _R.resizeThumbsTabs && _R.resizeThumbsTabs && _R.resizeThumbsTabs(x),
                        contWidthManager(x);
                    var g = x.viewPort;
                    (x.inviewport = !1),
                        g != undefined && g.enable && (jQuery.isNumeric(g.visible_area) || (-1 !== g.visible_area.indexOf("%") && (g.visible_area = parseInt(g.visible_area) / 100)), _R.scrollTicker && _R.scrollTicker(x, i)),
                        "carousel" === x.sliderType && _R.prepareCarousel && (punchgs.TweenLite.set(x.ul, { opacity: 0 }), _R.prepareCarousel(x, new punchgs.TimelineLite(), undefined, 0), (x.onlyPreparedSlide = !0)),
                        setTimeout(function () {
                            if (!g.enable || (g.enable && x.inviewport) || (g.enable && !x.inviewport && "wait" == !g.outof)) swapSlide(i);
                            else if ((x.c.addClass("tp-waitforfirststart"), (x.waitForFirstSlide = !0), g.presize)) {
                                var e = jQuery(x.li[0]);
                                loadImages(e, x, 0, !0),
                                    waitForCurrentImages(e.find(".tp-layers"), x, function () {
                                        _R.animateTheCaptions({ slide: e, opt: x, preset: !0 });
                                    });
                            }
                            _R.manageNavigation && _R.manageNavigation(x),
                                1 < x.slideamount && (!g.enable || (g.enable && x.inviewport) ? countDown(i, x) : (x.waitForCountDown = !0)),
                                setTimeout(function () {
                                    i.trigger("revolution.slide.onloaded");
                                }, 100);
                        }, x.startDelay),
                        (x.startDelay = 0),
                        jQuery("body").data("rs-fullScreenMode", !1),
                        window.addEventListener("fullscreenchange", onFullScreenChange, { passive: !0 }),
                        window.addEventListener("mozfullscreenchange", onFullScreenChange, { passive: !0 }),
                        window.addEventListener("webkitfullscreenchange", onFullScreenChange, { passive: !0 });
                    var m = "resize.revslider-" + i.attr("id");
                    jQuery(window).on(m, function () {
                        if (i == undefined) return !1;
                        0 != jQuery("body").find(i) && contWidthManager(x);
                        var e = !1;
                        if ("fullscreen" == x.sliderLayout) {
                            var t = jQuery(window).height();
                            e =
                                ("mobile" == x.fallbacks.ignoreHeightChanges && _ISM) || "always" == x.fallbacks.ignoreHeightChanges
                                    ? ((x.fallbacks.ignoreHeightChangesSize = x.fallbacks.ignoreHeightChangesSize == undefined ? 0 : x.fallbacks.ignoreHeightChangesSize),
                                      t != x.lastwindowheight && Math.abs(t - x.lastwindowheight) > x.fallbacks.ignoreHeightChangesSize)
                                    : t != x.lastwindowheight;
                        }
                        (i.outerWidth(!0) != x.width || i.is(":hidden") || e) && ((x.lastwindowheight = jQuery(window).height()), containerResized(i, x));
                    }),
                        hideSliderUnder(i, x),
                        contWidthManager(x),
                        x.fallbacks.disableFocusListener || "true" == x.fallbacks.disableFocusListener || !0 === x.fallbacks.disableFocusListener || (i.addClass("rev_redraw_on_blurfocus"), tabBlurringCheck());
                }
            },
            cArray = function (e, t) {
                if (!jQuery.isArray(e)) {
                    var i = e;
                    (e = new Array()).push(i);
                }
                if (e.length < t) {
                    i = e[e.length - 1];
                    for (var a = 0; a < t - e.length + 2; a++) e.push(i);
                }
                return e;
            },
            checkHoverDependencies = function (e, n) {
                var t = e.data();
                ("sliderenter" === t.start || (t.frames !== undefined && t.frames[0] != undefined && "sliderenter" === t.frames[0].delay)) &&
                    (n.layersonhover === undefined &&
                        (n.c.on("tp-mouseenter", function () {
                            n.layersonhover &&
                                jQuery.each(n.layersonhover, function (e, t) {
                                    var i = t.data("closestli") || t.closest(".tp-revslider-slidesli"),
                                        a = t.data("staticli") || t.closest(".tp-static-layers");
                                    t.data("closestli") === undefined && (t.data("closestli", i), t.data("staticli", a)),
                                        ((0 < i.length && i.hasClass("active-revslide")) || i.hasClass("processing-revslide") || 0 < a.length) &&
                                            (t.data("animdirection", "in"),
                                            _R.playAnimationFrame && _R.playAnimationFrame({ caption: t, opt: n, frame: "frame_0", triggerdirection: "in", triggerframein: "frame_0", triggerframeout: "frame_999" }),
                                            t.data("triggerstate", "on"));
                                });
                        }),
                        n.c.on("tp-mouseleft", function () {
                            n.layersonhover &&
                                jQuery.each(n.layersonhover, function (e, t) {
                                    t.data("animdirection", "out"),
                                        t.data("triggered", !0),
                                        t.data("triggerstate", "off"),
                                        _R.stopVideo && _R.stopVideo(t, n),
                                        _R.playAnimationFrame && _R.playAnimationFrame({ caption: t, opt: n, frame: "frame_999", triggerdirection: "out", triggerframein: "frame_0", triggerframeout: "frame_999" });
                                });
                        }),
                        (n.layersonhover = new Array())),
                    n.layersonhover.push(e));
            },
            contWidthManager = function (e) {
                var t = _R.getHorizontalOffset(e.c, "left");
                if ("auto" == e.sliderLayout || ("fullscreen" === e.sliderLayout && "on" == e.fullScreenAutoWidth))
                    "fullscreen" == e.sliderLayout && "on" == e.fullScreenAutoWidth
                        ? punchgs.TweenLite.set(e.ul, { left: 0, width: e.c.width() })
                        : punchgs.TweenLite.set(e.ul, { left: t, width: e.c.width() - _R.getHorizontalOffset(e.c, "both") });
                else {
                    var i = Math.ceil(e.c.closest(".forcefullwidth_wrapper_tp_banner").offset().left - t);
                    punchgs.TweenLite.set(e.c.parent(), { left: 0 - i + "px", width: jQuery(window).width() - _R.getHorizontalOffset(e.c, "both") });
                }
                e.slayers && "fullwidth" != e.sliderLayout && "fullscreen" != e.sliderLayout && punchgs.TweenLite.set(e.slayers, { left: t });
            },
            cv = function (e, t) {
                return e === undefined ? t : e;
            },
            hideSliderUnder = function (e, t, i) {
                var a = e.parent();
                jQuery(window).width() < t.hideSliderAtLimit
                    ? (e.trigger("stoptimer"), "none" != a.css("display") && a.data("olddisplay", a.css("display")), a.css({ display: "none" }))
                    : e.is(":hidden") &&
                      i &&
                      (a.data("olddisplay") != undefined && "undefined" != a.data("olddisplay") && "none" != a.data("olddisplay") ? a.css({ display: a.data("olddisplay") }) : a.css({ display: "block" }),
                      e.trigger("restarttimer"),
                      setTimeout(function () {
                          containerResized(e, t);
                      }, 150)),
                    _R.hideUnHideNav && _R.hideUnHideNav(t);
            },
            containerResized = function (e, t) {
                if ((e.trigger("revolution.slide.beforeredraw"), 1 == t.infullscreenmode && (t.minHeight = jQuery(window).height()), setCurWinRange(t), setCurWinRange(t, !0), !_R.resizeThumbsTabs || !0 === _R.resizeThumbsTabs(t))) {
                    if ((hideSliderUnder(e, t, !0), contWidthManager(t), "carousel" == t.sliderType && _R.prepareCarousel(t, !0), e === undefined)) return !1;
                    _R.setSize(t), (t.conw = t.c.width()), (t.conh = t.infullscreenmode ? t.minHeight : t.c.height());
                    var i = e.find(".active-revslide .slotholder"),
                        a = e.find(".processing-revslide .slotholder");
                    removeSlots(e, t, e, 2),
                        "standard" === t.sliderType && (punchgs.TweenLite.set(a.find(".defaultimg"), { opacity: 0 }), i.find(".defaultimg").css({ opacity: 1 })),
                        "carousel" === t.sliderType &&
                            t.lastconw != t.conw &&
                            (clearTimeout(t.pcartimer),
                            (t.pcartimer = setTimeout(function () {
                                _R.prepareCarousel(t, !0),
                                    "carousel" == t.sliderType &&
                                        "on" === t.carousel.showLayersAllTime &&
                                        jQuery.each(t.li, function (e) {
                                            _R.animateTheCaptions({ slide: jQuery(t.li[e]), opt: t, recall: !0 });
                                        });
                            }, 100)),
                            (t.lastconw = t.conw)),
                        _R.manageNavigation && _R.manageNavigation(t),
                        _R.animateTheCaptions && 0 < e.find(".active-revslide").length && _R.animateTheCaptions({ slide: e.find(".active-revslide"), opt: t, recall: !0 }),
                        "on" == a.data("kenburns") && _R.startKenBurn(a, t, a.data("kbtl") !== undefined ? a.data("kbtl").progress() : 0),
                        "on" == i.data("kenburns") && _R.startKenBurn(i, t, i.data("kbtl") !== undefined ? i.data("kbtl").progress() : 0),
                        _R.animateTheCaptions && 0 < e.find(".processing-revslide").length && _R.animateTheCaptions({ slide: e.find(".processing-revslide"), opt: t, recall: !0 }),
                        _R.manageNavigation && _R.manageNavigation(t);
                }
                e.trigger("revolution.slide.afterdraw");
            },
            setScale = function (e) {
                (e.bw = e.width / e.gridwidth[e.curWinRange]), (e.bh = e.height / e.gridheight[e.curWinRange]), e.bh > e.bw ? (e.bh = e.bw) : (e.bw = e.bh), (1 < e.bh || 1 < e.bw) && ((e.bw = 1), (e.bh = 1));
            },
            prepareSlides = function (e, u) {
                if (
                    (e.find(".tp-caption").each(function () {
                        var e = jQuery(this);
                        e.data("transition") !== undefined && e.addClass(e.data("transition"));
                    }),
                    u.ul.css({ overflow: "hidden", width: "100%", height: "100%", maxHeight: e.parent().css("maxHeight") }),
                    "on" == u.autoHeight && (u.ul.css({ overflow: "hidden", width: "100%", height: "100%", maxHeight: "none" }), e.css({ maxHeight: "none" }), e.parent().css({ maxHeight: "none" })),
                    u.allli.each(function (e) {
                        var t = jQuery(this),
                            i = t.data("originalindex");
                        ((u.startWithSlide != undefined && i == u.startWithSlide) || (u.startWithSlide === undefined && 0 == e)) && t.addClass("next-revslide"), t.css({ width: "100%", height: "100%", overflow: "hidden" });
                    }),
                    "carousel" === u.sliderType)
                ) {
                    u.ul.css({ overflow: "visible" }).wrap('<div class="tp-carousel-wrapper" style="width:100%;height:100%;position:absolute;top:0px;left:0px;overflow:hidden;"></div>');
                    var t = '<div style="clear:both;display:block;width:100%;height:1px;position:relative;margin-bottom:-1px"></div>';
                    u.c.parent().prepend(t), u.c.parent().append(t), _R.prepareCarousel(u);
                }
                e.parent().css({ overflow: "visible" }),
                    u.allli.find(">img").each(function (e) {
                        var t = jQuery(this),
                            i = t.closest("li"),
                            a = i.find(".rs-background-video-layer");
                        a.addClass("defaultvid").css({ zIndex: 30 }), t.addClass("defaultimg"), "on" == u.fallbacks.panZoomDisableOnMobile && _ISM && (t.data("kenburns", "off"), t.data("bgfit", "cover"));
                        var n = i.data("mediafilter");
                        (n = "none" === n || n === undefined ? "" : n), t.wrap('<div class="slotholder" style="position:absolute; top:0px; left:0px; z-index:0;width:100%;height:100%;"></div>'), a.appendTo(i.find(".slotholder"));
                        var r = t.data();
                        t.closest(".slotholder").data(r),
                            0 < a.length && r.bgparallax != undefined && (a.data("bgparallax", r.bgparallax), a.data("showcoveronpause", "on")),
                            "none" != u.dottedOverlay && u.dottedOverlay != undefined && t.closest(".slotholder").append('<div class="tp-dottedoverlay ' + u.dottedOverlay + '"></div>');
                        var s = t.attr("src");
                        (r.src = s), (r.bgfit = r.bgfit || "cover"), (r.bgrepeat = r.bgrepeat || "no-repeat"), (r.bgposition = r.bgposition || "center center"), t.closest(".slotholder");
                        var o,
                            l = t.data("bgcolor");
                        (o =
                            l !== undefined && 0 <= l.indexOf("gradient")
                                ? '"background:' + l + ';width:100%;height:100%;"'
                                : '"background-color:' + l + ";background-repeat:" + r.bgrepeat + ";background-image:url(" + s + ");background-size:" + r.bgfit + ";background-position:" + r.bgposition + ';width:100%;height:100%;"'),
                            t.data("mediafilter", n),
                            (n = "on" === t.data("kenburns") ? "" : n);
                        var d = jQuery('<div class="tp-bgimg defaultimg ' + n + '" data-bgcolor="' + l + '" style=' + o + "></div>");
                        t.parent().append(d);
                        var c = document.createComment("Runtime Modification - Img tag is Still Available for SEO Goals in Source - " + t.get(0).outerHTML);
                        t.replaceWith(c), d.data(r), d.attr("src", s), ("standard" !== u.sliderType && "undefined" !== u.sliderType) || d.css({ opacity: 0 });
                    }),
                    u.scrolleffect.on &&
                        "on" === u.scrolleffect.on_slidebg &&
                        ((u.allslotholder = new Array()),
                        u.allli.find(".slotholder").each(function () {
                            jQuery(this).wrap('<div style="display:block;position:absolute;top:0px;left:0px;width:100%;height:100%" class="slotholder_fadeoutwrap"></div>');
                        }),
                        (u.allslotholder = u.c.find(".slotholder_fadeoutwrap")));
            },
            removeSlots = function (e, t, i, a) {
                (t.removePrepare = t.removePrepare + a),
                    i.find(".slot, .slot-circle-wrapper").each(function () {
                        jQuery(this).remove();
                    }),
                    (t.transition = 0),
                    (t.removePrepare = 0);
            },
            cutParams = function (e) {
                var t = e;
                return e != undefined && 0 < e.length && (t = e.split("?")[0]), t;
            },
            relativeRedir = function (e) {
                return location.pathname.replace(/(.*)\/[^/]*/, "$1/" + e);
            },
            abstorel = function (e, t) {
                var i = e.split("/"),
                    a = t.split("/");
                i.pop();
                for (var n = 0; n < a.length; n++) "." != a[n] && (".." == a[n] ? i.pop() : i.push(a[n]));
                return i.join("/");
            },
            imgLoaded = function (l, e, d) {
                e.syncload--,
                    e.loadqueue &&
                        jQuery.each(e.loadqueue, function (e, t) {
                            var i = t.src.replace(/\.\.\/\.\.\//gi, ""),
                                a = self.location.href,
                                n = document.location.origin,
                                r = a.substring(0, a.length - 1) + "/" + i,
                                s = n + "/" + i,
                                o = abstorel(self.location.href, t.src);
                            (a = a.substring(0, a.length - 1) + i),
                                (cutParams((n += i)) === cutParams(decodeURIComponent(l.src)) ||
                                    cutParams(a) === cutParams(decodeURIComponent(l.src)) ||
                                    cutParams(o) === cutParams(decodeURIComponent(l.src)) ||
                                    cutParams(s) === cutParams(decodeURIComponent(l.src)) ||
                                    cutParams(r) === cutParams(decodeURIComponent(l.src)) ||
                                    cutParams(t.src) === cutParams(decodeURIComponent(l.src)) ||
                                    cutParams(t.src).replace(/^.*\/\/[^\/]+/, "") === cutParams(decodeURIComponent(l.src)).replace(/^.*\/\/[^\/]+/, "") ||
                                    ("file://" === window.location.origin && cutParams(l.src).match(new RegExp(i)))) &&
                                    ((t.progress = d), (t.width = l.width), (t.height = l.height));
                        }),
                    progressImageLoad(e);
            },
            progressImageLoad = function (a) {
                3 != a.syncload &&
                    a.loadqueue &&
                    jQuery.each(a.loadqueue, function (e, t) {
                        if (t.progress.match(/prepared/g) && a.syncload <= 3) {
                            if ((a.syncload++, "img" == t.type)) {
                                var i = new Image();
                                (i.onload = function () {
                                    imgLoaded(this, a, "loaded"), (t.error = !1);
                                }),
                                    (i.onerror = function () {
                                        imgLoaded(this, a, "failed"), (t.error = !0);
                                    }),
                                    (i.src = t.src);
                            } else
                                jQuery
                                    .get(t.src, function (e) {
                                        (t.innerHTML = new XMLSerializer().serializeToString(e.documentElement)), (t.progress = "loaded"), a.syncload--, progressImageLoad(a);
                                    })
                                    .fail(function () {
                                        (t.progress = "failed"), a.syncload--, progressImageLoad(a);
                                    });
                            t.progress = "inload";
                        }
                    });
            },
            addToLoadQueue = function (i, e, t, a, n) {
                var r = !1;
                if (
                    (e.loadqueue &&
                        jQuery.each(e.loadqueue, function (e, t) {
                            t.src === i && (r = !0);
                        }),
                    !r)
                ) {
                    var s = new Object();
                    (s.src = i), (s.starttoload = jQuery.now()), (s.type = a || "img"), (s.prio = t), (s.progress = "prepared"), (s.static = n), e.loadqueue.push(s);
                }
            },
            loadImages = function (e, a, n, r) {
                e.find("img,.defaultimg, .tp-svg-layer").each(function () {
                    var e = jQuery(this),
                        t = e.data("lazyload") !== undefined && "undefined" !== e.data("lazyload") ? e.data("lazyload") : e.data("svg_src") != undefined ? e.data("svg_src") : e.attr("src"),
                        i = e.data("svg_src") != undefined ? "svg" : "img";
                    e.data("start-to-load", jQuery.now()), addToLoadQueue(t, a, n, i, r);
                }),
                    progressImageLoad(a);
            },
            getLoadObj = function (e, i) {
                var a = new Object();
                return (
                    e.loadqueue &&
                        jQuery.each(e.loadqueue, function (e, t) {
                            t.src == i && (a = t);
                        }),
                    a
                );
            },
            waitForCurrentImages = function (s, o, e) {
                var l = !1;
                s.find("img,.defaultimg, .tp-svg-layer").each(function () {
                    var e = jQuery(this),
                        t = e.data("lazyload") != undefined ? e.data("lazyload") : e.data("svg_src") != undefined ? e.data("svg_src") : e.attr("src"),
                        i = getLoadObj(o, t);
                    if (e.data("loaded") === undefined && i !== undefined && i.progress && i.progress.match(/loaded/g)) {
                        if ((e.attr("src", i.src), "img" == i.type))
                            if (e.hasClass("defaultimg"))
                                _R.isIE(8)
                                    ? defimg.attr("src", i.src)
                                    : (-1 == i.src.indexOf("images/transparent.png") && -1 == i.src.indexOf("assets/transparent.png")) || e.data("bgcolor") === undefined
                                    ? e.css({ backgroundImage: 'url("' + i.src + '")' })
                                    : e.data("bgcolor") !== undefined && e.css({ background: e.data("bgcolor") }),
                                    s.data("owidth", i.width),
                                    s.data("oheight", i.height),
                                    s.find(".slotholder").data("owidth", i.width),
                                    s.find(".slotholder").data("oheight", i.height);
                            else {
                                var a = e.data("ww"),
                                    n = e.data("hh");
                                e.data("owidth", i.width),
                                    e.data("oheight", i.height),
                                    (a = a == undefined || "auto" == a || "" == a ? i.width : a),
                                    (n = n == undefined || "auto" == n || "" == n ? i.height : n),
                                    !jQuery.isNumeric(a) && 0 < a.indexOf("%") && (n = a),
                                    e.data("ww", a),
                                    e.data("hh", n);
                            }
                        else "svg" == i.type && "loaded" == i.progress && (e.append('<div class="tp-svg-innercontainer"></div>'), e.find(".tp-svg-innercontainer").append(i.innerHTML));
                        e.data("loaded", !0);
                    }
                    if (
                        (i &&
                            i.progress &&
                            i.progress.match(/inprogress|inload|prepared/g) &&
                            (!i.error && jQuery.now() - e.data("start-to-load") < 5e3 ? (l = !0) : ((i.progress = "failed"), i.reported_img || ((i.reported_img = !0), console.warn(t + "  Could not be loaded !")))),
                        1 == o.youtubeapineeded && (!window.YT || YT.Player == undefined) && ((l = !0), 5e3 < jQuery.now() - o.youtubestarttime && 1 != o.youtubewarning))
                    ) {
                        o.youtubewarning = !0;
                        var r = "YouTube Api Could not be loaded !";
                        "https:" === location.protocol && (r += " Please Check and Renew SSL Certificate !"),
                            console.error(r),
                            o.c.append('<div style="position:absolute;top:50%;width:100%;color:#e74c3c;  font-size:16px; text-align:center; padding:15px;background:#000; display:block;"><strong>' + r + "</strong></div>");
                    }
                    1 == o.vimeoapineeded &&
                        !window.Vimeo &&
                        ((l = !0), 5e3 < jQuery.now() - o.vimeostarttime && 1 != o.vimeowarning) &&
                        ((o.vimeowarning = !0),
                        (r = "Vimeo Api Could not be loaded !"),
                        "https:" === location.protocol && (r += " Please Check and Renew SSL Certificate !"),
                        console.error(r),
                        o.c.append('<div style="position:absolute;top:50%;width:100%;color:#e74c3c;  font-size:16px; text-align:center; padding:15px;background:#000; display:block;"><strong>' + r + "</strong></div>"));
                }),
                    !_ISM &&
                        o.audioqueue &&
                        0 < o.audioqueue.length &&
                        jQuery.each(o.audioqueue, function (e, t) {
                            t.status && "prepared" === t.status && jQuery.now() - t.start < t.waittime && (l = !0);
                        }),
                    jQuery.each(o.loadqueue, function (e, t) {
                        !0 !== t.static ||
                            ("loaded" == t.progress && "failed" !== t.progress) ||
                            ("failed" == t.progress
                                ? t.reported || ((t.reported = !0), console.warn("Static Image " + t.src + "  Could not be loaded in time. Error Exists:" + t.error))
                                : !t.error && jQuery.now() - t.starttoload < 5e3
                                ? (l = !0)
                                : t.reported || ((t.reported = !0), console.warn("Static Image " + t.src + "  Could not be loaded within 5s! Error Exists:" + t.error)));
                    }),
                    l ? punchgs.TweenLite.delayedCall(0.18, waitForCurrentImages, [s, o, e]) : punchgs.TweenLite.delayedCall(0.18, e);
            },
            swapSlide = function (e) {
                var t = e[0].opt;
                if ((clearTimeout(t.waitWithSwapSlide), 0 < e.find(".processing-revslide").length))
                    return (
                        (t.waitWithSwapSlide = setTimeout(function () {
                            swapSlide(e);
                        }, 150)),
                        !1
                    );
                var i = e.find(".active-revslide"),
                    a = e.find(".next-revslide"),
                    n = a.find(".defaultimg");
                if (("carousel" !== t.sliderType || t.carousel.fadein || (punchgs.TweenLite.to(t.ul, 1, { opacity: 1 }), (t.carousel.fadein = !0)), a.index() === i.index() && !0 !== t.onlyPreparedSlide))
                    return a.removeClass("next-revslide"), !1;
                !0 === t.onlyPreparedSlide && ((t.onlyPreparedSlide = !1), jQuery(t.li[0]).addClass("processing-revslide")),
                    a.removeClass("next-revslide").addClass("processing-revslide"),
                    -1 === a.index() && "carousel" === t.sliderType && (a = jQuery(t.li[0])),
                    a.data("slide_on_focus_amount", a.data("slide_on_focus_amount") + 1 || 1),
                    "on" == t.stopLoop && a.index() == t.lastslidetoshow - 1 && (e.find(".tp-bannertimer").css({ visibility: "hidden" }), e.trigger("revolution.slide.onstop"), (t.noloopanymore = 1)),
                    a.index() === t.slideamount - 1 && ((t.looptogo = t.looptogo - 1), t.looptogo <= 0 && (t.stopLoop = "on")),
                    (t.tonpause = !0),
                    e.trigger("stoptimer"),
                    (t.cd = 0),
                    "off" === t.spinner &&
                        (t.loader !== undefined
                            ? t.loader.css({ display: "none" })
                            : (t.loadertimer = setTimeout(function () {
                                  t.loader !== undefined && t.loader.css({ display: "block" });
                              }, 50))),
                    loadImages(a, t, 1),
                    _R.preLoadAudio && _R.preLoadAudio(a, t, 1),
                    waitForCurrentImages(a, t, function () {
                        a.find(".rs-background-video-layer").each(function () {
                            var e = jQuery(this);
                            e.hasClass("HasListener") || (e.data("bgvideo", 1), _R.manageVideoLayer && _R.manageVideoLayer(e, t)), 0 == e.find(".rs-fullvideo-cover").length && e.append('<div class="rs-fullvideo-cover"></div>');
                        }),
                            swapSlideProgress(n, e);
                    });
            },
            swapSlideProgress = function (e, t) {
                var i = t.find(".active-revslide"),
                    a = t.find(".processing-revslide"),
                    n = i.find(".slotholder"),
                    r = a.find(".slotholder"),
                    s = t[0].opt;
                (s.tonpause = !1), (s.cd = 0), clearTimeout(s.loadertimer), s.loader !== undefined && s.loader.css({ display: "none" }), _R.setSize(s), _R.slotSize(e, s), _R.manageNavigation && _R.manageNavigation(s);
                var o = {};
                (o.nextslide = a),
                    (o.currentslide = i),
                    t.trigger("revolution.slide.onbeforeswap", o),
                    (s.transition = 1),
                    (s.videoplaying = !1),
                    a.data("delay") != undefined ? ((s.cd = 0), (s.delay = a.data("delay"))) : (s.delay = s.origcd),
                    "true" == a.data("ssop") || !0 === a.data("ssop") ? (s.ssop = !0) : (s.ssop = !1),
                    t.trigger("nulltimer");
                var l,
                    d = i.index(),
                    c = a.index();
                if (
                    ((s.sdir = c < d ? 1 : 0),
                    "arrow" == s.sc_indicator && (0 == d && c == s.slideamount - 1 && (s.sdir = 1), d == s.slideamount - 1 && 0 == c && (s.sdir = 0)),
                    (s.lsdir = s.lsdir === undefined ? s.sdir : s.lsdir),
                    (s.dirc = s.lsdir != s.sdir),
                    (s.lsdir = s.sdir),
                    i.index() != a.index() && 1 != s.firststart && _R.removeTheCaptions && _R.removeTheCaptions(i, s),
                    a.hasClass("rs-pause-timer-once") || a.hasClass("rs-pause-timer-always") ? (s.videoplaying = !0) : t.trigger("restarttimer"),
                    a.removeClass("rs-pause-timer-once"),
                    (s.currentSlide = i.index()),
                    (s.nextSlide = a.index()),
                    "carousel" == s.sliderType)
                )
                    (l = new punchgs.TimelineLite()), _R.prepareCarousel(s, l), letItFree(t, r, n, a, i, l), (s.transition = 0), (s.firststart = 0);
                else {
                    (l = new punchgs.TimelineLite({
                        onComplete: function () {
                            letItFree(t, r, n, a, i, l);
                        },
                    })).add(punchgs.TweenLite.set(r.find(".defaultimg"), { opacity: 0 })),
                        l.pause(),
                        _R.animateTheCaptions && _R.animateTheCaptions({ slide: a, opt: s, preset: !0 }),
                        1 == s.firststart && (punchgs.TweenLite.set(i, { autoAlpha: 0 }), (s.firststart = 0)),
                        punchgs.TweenLite.set(i, { zIndex: 18 }),
                        punchgs.TweenLite.set(a, { autoAlpha: 0, zIndex: 20 }),
                        "prepared" == a.data("differentissplayed") &&
                            (a.data("differentissplayed", "done"), a.data("transition", a.data("savedtransition")), a.data("slotamount", a.data("savedslotamount")), a.data("masterspeed", a.data("savedmasterspeed"))),
                        a.data("fstransition") != undefined &&
                            "done" != a.data("differentissplayed") &&
                            (a.data("savedtransition", a.data("transition")),
                            a.data("savedslotamount", a.data("slotamount")),
                            a.data("savedmasterspeed", a.data("masterspeed")),
                            a.data("transition", a.data("fstransition")),
                            a.data("slotamount", a.data("fsslotamount")),
                            a.data("masterspeed", a.data("fsmasterspeed")),
                            a.data("differentissplayed", "prepared")),
                        a.data("transition") == undefined && a.data("transition", "random");
                    var u = a.data("transition") !== undefined ? a.data("transition").split(",") : "fade",
                        h = a.data("nexttransid") == undefined ? -1 : a.data("nexttransid");
                    "on" == a.data("randomtransition") ? (h = Math.round(Math.random() * u.length)) : (h += 1), h == u.length && (h = 0), a.data("nexttransid", h);
                    var p = u[h];
                    s.ie && ("boxfade" == p && (p = "boxslide"), "slotfade-vertical" == p && (p = "slotzoom-vertical"), "slotfade-horizontal" == p && (p = "slotzoom-horizontal")),
                        _R.isIE(8) && (p = 11),
                        (l = _R.animateSlide(0, p, t, a, i, r, n, l)),
                        "on" == r.data("kenburns") && (_R.startKenBurn(r, s), l.add(punchgs.TweenLite.set(r, { autoAlpha: 0 }))),
                        l.pause();
                }
                _R.scrollHandling &&
                    (_R.scrollHandling(s, !0, 0),
                    l.eventCallback("onUpdate", function () {
                        _R.scrollHandling(s, !0, 0);
                    })),
                    "off" != s.parallax.type &&
                        s.parallax.firstgo == undefined &&
                        _R.scrollHandling &&
                        ((s.parallax.firstgo = !0),
                        (s.lastscrolltop = -999),
                        _R.scrollHandling(s, !0, 0),
                        setTimeout(function () {
                            (s.lastscrolltop = -999), _R.scrollHandling(s, !0, 0);
                        }, 210),
                        setTimeout(function () {
                            (s.lastscrolltop = -999), _R.scrollHandling(s, !0, 0);
                        }, 420)),
                    _R.animateTheCaptions
                        ? "carousel" === s.sliderType && "on" === s.carousel.showLayersAllTime
                            ? (jQuery.each(s.li, function (e) {
                                  s.carousel.allLayersStarted
                                      ? _R.animateTheCaptions({ slide: jQuery(s.li[e]), opt: s, recall: !0 })
                                      : s.li[e] === a
                                      ? _R.animateTheCaptions({ slide: jQuery(s.li[e]), maintimeline: l, opt: s, startslideanimat: 0 })
                                      : _R.animateTheCaptions({ slide: jQuery(s.li[e]), opt: s, startslideanimat: 0 });
                              }),
                              (s.carousel.allLayersStarted = !0))
                            : _R.animateTheCaptions({ slide: a, opt: s, maintimeline: l, startslideanimat: 0 })
                        : l != undefined &&
                          setTimeout(function () {
                              l.resume();
                          }, 30),
                    punchgs.TweenLite.to(a, 0.001, { autoAlpha: 1 });
            },
            letItFree = function (e, t, i, a, n, r) {
                var s = e[0].opt;
                "carousel" === s.sliderType ||
                    ((s.removePrepare = 0),
                    punchgs.TweenLite.to(t.find(".defaultimg"), 0.001, {
                        zIndex: 20,
                        autoAlpha: 1,
                        onComplete: function () {
                            removeSlots(e, s, a, 1);
                        },
                    }),
                    a.index() != n.index() &&
                        punchgs.TweenLite.to(n, 0.2, {
                            zIndex: 18,
                            autoAlpha: 0,
                            onComplete: function () {
                                removeSlots(e, s, n, 1);
                            },
                        })),
                    e.find(".active-revslide").removeClass("active-revslide"),
                    e.find(".processing-revslide").removeClass("processing-revslide").addClass("active-revslide"),
                    (s.act = a.index()),
                    s.c.attr("data-slideactive", e.find(".active-revslide").data("index")),
                    ("scroll" != s.parallax.type && "scroll+mouse" != s.parallax.type && "mouse+scroll" != s.parallax.type) || ((s.lastscrolltop = -999), _R.scrollHandling(s)),
                    r.clear(),
                    i.data("kbtl") != undefined && (i.data("kbtl").reverse(), i.data("kbtl").timeScale(25)),
                    "on" == t.data("kenburns") && (t.data("kbtl") != undefined ? (t.data("kbtl").timeScale(1), t.data("kbtl").play()) : _R.startKenBurn(t, s)),
                    a.find(".rs-background-video-layer").each(function (e) {
                        if (_ISM && !s.fallbacks.allowHTML5AutoPlayOnAndroid) return !1;
                        var t = jQuery(this);
                        _R.resetVideo(t, s, !1, !0),
                            punchgs.TweenLite.fromTo(
                                t,
                                1,
                                { autoAlpha: 0 },
                                {
                                    autoAlpha: 1,
                                    ease: punchgs.Power3.easeInOut,
                                    delay: 0.2,
                                    onComplete: function () {
                                        _R.animcompleted && _R.animcompleted(t, s);
                                    },
                                }
                            );
                    }),
                    n.find(".rs-background-video-layer").each(function (e) {
                        if (_ISM) return !1;
                        var t = jQuery(this);
                        _R.stopVideo && (_R.resetVideo(t, s), _R.stopVideo(t, s)), punchgs.TweenLite.to(t, 1, { autoAlpha: 0, ease: punchgs.Power3.easeInOut, delay: 0.2 });
                    });
                var o = {};
                if (
                    ((o.slideIndex = a.index() + 1),
                    (o.slideLIIndex = a.index()),
                    (o.slide = a),
                    (o.currentslide = a),
                    (o.prevslide = n),
                    (s.last_shown_slide = n.index()),
                    e.trigger("revolution.slide.onchange", o),
                    e.trigger("revolution.slide.onafterswap", o),
                    s.startWithSlide !== undefined && "done" !== s.startWithSlide && "carousel" === s.sliderType)
                ) {
                    for (var l = s.startWithSlide, d = 0; d <= s.li.length - 1; d++) jQuery(s.li[d]).data("originalindex") === s.startWithSlide && (l = d);
                    0 !== l && _R.callingNewSlide(s.c, l), (s.startWithSlide = "done");
                }
                s.duringslidechange = !1;
                var c = n.data("slide_on_focus_amount"),
                    u = n.data("hideafterloop");
                0 != u && u <= c && s.c.revremoveslide(n.index());
                var h = -1 === s.nextSlide || s.nextSlide === undefined ? 0 : s.nextSlide;
                s.rowzones != undefined && (h = h > s.rowzones.length ? s.rowzones.length : h),
                    s.rowzones != undefined && 0 < s.rowzones.length && s.rowzones[h] != undefined && 0 <= h && h <= s.rowzones.length && 0 < s.rowzones[h].length && _R.setSize(s);
            },
            removeAllListeners = function (e, t) {
                e.children().each(function () {
                    try {
                        jQuery(this).die("click");
                    } catch (e) {}
                    try {
                        jQuery(this).die("mouseenter");
                    } catch (e) {}
                    try {
                        jQuery(this).die("mouseleave");
                    } catch (e) {}
                    try {
                        jQuery(this).unbind("hover");
                    } catch (e) {}
                });
                try {
                    e.die("click", "mouseenter", "mouseleave");
                } catch (e) {}
                clearInterval(t.cdint), (e = null);
            },
            countDown = function (e, t) {
                (t.cd = 0),
                    (t.loop = 0),
                    t.stopAfterLoops != undefined && -1 < t.stopAfterLoops ? (t.looptogo = t.stopAfterLoops) : (t.looptogo = 9999999),
                    t.stopAtSlide != undefined && -1 < t.stopAtSlide ? (t.lastslidetoshow = t.stopAtSlide) : (t.lastslidetoshow = 999),
                    (t.stopLoop = "off"),
                    0 == t.looptogo && (t.stopLoop = "on");
                var i = e.find(".tp-bannertimer");
                e.on("stoptimer", function () {
                    var e = jQuery(this).find(".tp-bannertimer");
                    e[0].tween.pause(), "on" == t.disableProgressBar && e.css({ visibility: "hidden" }), (t.sliderstatus = "paused"), _R.unToggleState(t.slidertoggledby);
                }),
                    e.on("starttimer", function () {
                        t.forcepause_viatoggle ||
                            (1 != t.conthover &&
                                1 != t.videoplaying &&
                                t.width > t.hideSliderAtLimit &&
                                1 != t.tonpause &&
                                1 != t.overnav &&
                                1 != t.ssop &&
                                (1 === t.noloopanymore || (t.viewPort.enable && !t.inviewport) || (i.css({ visibility: "visible" }), i[0].tween.resume(), (t.sliderstatus = "playing"))),
                            "on" == t.disableProgressBar && i.css({ visibility: "hidden" }),
                            _R.toggleState(t.slidertoggledby));
                    }),
                    e.on("restarttimer", function () {
                        if (!t.forcepause_viatoggle) {
                            var e = jQuery(this).find(".tp-bannertimer");
                            if (t.mouseoncontainer && "on" == t.navigation.onHoverStop && !_ISM) return !1;
                            1 === t.noloopanymore ||
                                (t.viewPort.enable && !t.inviewport) ||
                                1 == t.ssop ||
                                (e.css({ visibility: "visible" }),
                                e[0].tween.kill(),
                                (e[0].tween = punchgs.TweenLite.fromTo(e, t.delay / 1e3, { width: "0%" }, { force3D: "auto", width: "100%", ease: punchgs.Linear.easeNone, onComplete: a, delay: 1 })),
                                (t.sliderstatus = "playing")),
                                "on" == t.disableProgressBar && e.css({ visibility: "hidden" }),
                                _R.toggleState(t.slidertoggledby);
                        }
                    }),
                    e.on("nulltimer", function () {
                        i[0].tween.kill(),
                            (i[0].tween = punchgs.TweenLite.fromTo(i, t.delay / 1e3, { width: "0%" }, { force3D: "auto", width: "100%", ease: punchgs.Linear.easeNone, onComplete: a, delay: 1 })),
                            i[0].tween.pause(0),
                            "on" == t.disableProgressBar && i.css({ visibility: "hidden" }),
                            (t.sliderstatus = "paused");
                    });
                var a = function () {
                    0 == jQuery("body").find(e).length && (removeAllListeners(e, t), clearInterval(t.cdint)),
                        e.trigger("revolution.slide.slideatend"),
                        1 == e.data("conthover-changed") && ((t.conthover = e.data("conthover")), e.data("conthover-changed", 0)),
                        _R.callingNewSlide(e, 1);
                };
                (i[0].tween = punchgs.TweenLite.fromTo(i, t.delay / 1e3, { width: "0%" }, { force3D: "auto", width: "100%", ease: punchgs.Linear.easeNone, onComplete: a, delay: 1 })),
                    1 < t.slideamount && (0 != t.stopAfterLoops || 1 != t.stopAtSlide) ? e.trigger("starttimer") : ((t.noloopanymore = 1), e.trigger("nulltimer")),
                    e.on("tp-mouseenter", function () {
                        (t.mouseoncontainer = !0), "on" != t.navigation.onHoverStop || _ISM || (e.trigger("stoptimer"), e.trigger("revolution.slide.onpause"));
                    }),
                    e.on("tp-mouseleft", function () {
                        (t.mouseoncontainer = !1),
                            1 != e.data("conthover") && "on" == t.navigation.onHoverStop && ((1 == t.viewPort.enable && t.inviewport) || 0 == t.viewPort.enable) && (e.trigger("revolution.slide.onresume"), e.trigger("starttimer"));
                    });
            },
            vis = (function () {
                var t,
                    i,
                    e = { hidden: "visibilitychange", webkitHidden: "webkitvisibilitychange", mozHidden: "mozvisibilitychange", msHidden: "msvisibilitychange" };
                for (t in e)
                    if (t in document) {
                        i = e[t];
                        break;
                    }
                return function (e) {
                    return e && document.addEventListener(i, e, { pasive: !0 }), !document[t];
                };
            })(),
            restartOnFocus = function () {
                jQuery(".rev_redraw_on_blurfocus").each(function () {
                    var e = jQuery(this)[0].opt;
                    if (e == undefined || e.c == undefined || 0 === e.c.length) return !1;
                    1 != e.windowfocused &&
                        ((e.windowfocused = !0),
                        punchgs.TweenLite.delayedCall(0.3, function () {
                            "on" == e.fallbacks.nextSlideOnWindowFocus && e.c.revnext(), e.c.revredraw(), "playing" == e.lastsliderstatus && e.c.revresume();
                        }));
                });
            },
            lastStatBlur = function () {
                jQuery(".rev_redraw_on_blurfocus").each(function () {
                    var e = jQuery(this)[0].opt;
                    (e.windowfocused = !1), (e.lastsliderstatus = e.sliderstatus), e.c.revpause();
                    var t = e.c.find(".active-revslide .slotholder"),
                        i = e.c.find(".processing-revslide .slotholder");
                    "on" == i.data("kenburns") && _R.stopKenBurn(i, e), "on" == t.data("kenburns") && _R.stopKenBurn(t, e);
                });
            },
            tabBlurringCheck = function () {
                var e = document.documentMode === undefined,
                    t = window.chrome;
                1 !== jQuery("body").data("revslider_focus_blur_listener") &&
                    (jQuery("body").data("revslider_focus_blur_listener", 1),
                    e && !t
                        ? jQuery(window)
                              .on("focusin", function () {
                                  restartOnFocus();
                              })
                              .on("focusout", function () {
                                  lastStatBlur();
                              })
                        : window.addEventListener
                        ? (window.addEventListener(
                              "focus",
                              function (e) {
                                  restartOnFocus();
                              },
                              { capture: !1, passive: !0 }
                          ),
                          window.addEventListener(
                              "blur",
                              function (e) {
                                  lastStatBlur();
                              },
                              { capture: !1, passive: !0 }
                          ))
                        : (window.attachEvent("focus", function (e) {
                              restartOnFocus();
                          }),
                          window.attachEvent("blur", function (e) {
                              lastStatBlur();
                          })));
            },
            getUrlVars = function (e) {
                for (var t, i = [], a = window.location.href.slice(window.location.href.indexOf(e) + 1).split("_"), n = 0; n < a.length; n++) (a[n] = a[n].replace("%3D", "=")), (t = a[n].split("=")), i.push(t[0]), (i[t[0]] = t[1]);
                return i;
            };
    })(jQuery),
    (function (e) {
        "function" == typeof define && define.amd && define.amd.jQuery ? define(["jquery"], e) : e(jQuery);
    })(function (oe) {
        var le = "left",
            de = "right",
            ce = "up",
            ue = "down",
            he = "in",
            pe = "out",
            fe = "none",
            ge = "auto",
            me = "swipe",
            ve = "pinch",
            ye = "tap",
            we = "doubletap",
            _e = "longtap",
            be = "horizontal",
            xe = "vertical",
            Te = "all",
            Ce = 10,
            ke = "start",
            Se = "move",
            je = "end",
            Le = "cancel",
            Oe = "ontouchstart" in window,
            Pe = window.navigator.msPointerEnabled && !window.navigator.pointerEnabled,
            Re = window.navigator.pointerEnabled || window.navigator.msPointerEnabled,
            Ie = "TouchSwipe";
        function a(e, y) {
            var t = Oe || Re || !y.fallbackToMouseEvents,
                i = t ? (Re ? (Pe ? "MSPointerDown" : "pointerdown") : "touchstart") : "mousedown",
                a = t ? (Re ? (Pe ? "MSPointerMove" : "pointermove") : "touchmove") : "mousemove",
                n = t ? (Re ? (Pe ? "MSPointerUp" : "pointerup") : "touchend") : "mouseup",
                r = t ? null : "mouseleave",
                s = Re ? (Pe ? "MSPointerCancel" : "pointercancel") : "touchcancel",
                w = 0,
                _ = null,
                b = 0,
                x = 0,
                T = 0,
                C = 1,
                k = 0,
                S = 0,
                j = null,
                o = oe(e),
                L = "start",
                O = 0,
                P = null,
                l = 0,
                R = 0,
                d = 0,
                c = 0,
                u = 0,
                h = null,
                I = null;
            try {
                o.bind(i, p), o.bind(s, m);
            } catch (e) {
                oe.error("events not supported " + i + "," + s + " on jQuery.swipetp");
            }
            function p(e) {
                if (!0 !== o.data(Ie + "_intouch") && !(0 < oe(e.target).closest(y.excludedElements, o).length)) {
                    var t,
                        i,
                        a = e.originalEvent ? e.originalEvent : e,
                        n = a.touches,
                        r = n ? n[0] : a;
                    return (
                        (L = ke),
                        n ? (O = n.length) : e.preventDefault(),
                        (S = _ = null),
                        (C = 1),
                        (k = T = x = b = w = 0),
                        (P = (function () {
                            for (var e = [], t = 0; t <= 5; t++) e.push({ start: { x: 0, y: 0 }, end: { x: 0, y: 0 }, identifier: 0 });
                            return e;
                        })()),
                        ((i = {})[le] = ae(le)),
                        (i[de] = ae(de)),
                        (i[ce] = ae(ce)),
                        (i[ue] = ae(ue)),
                        (j = i),
                        J(),
                        !n || O === y.fingers || y.fingers === Te || H() ? (ee(0, r), (l = se()), 2 == O && (ee(1, n[1]), (x = T = re(P[0].start, P[1].start))), (y.swipeStatus || y.pinchStatus) && (t = M(a, L))) : (t = !1),
                        !1 === t
                            ? (M(a, (L = Le)), t)
                            : (y.hold &&
                                  (I = setTimeout(
                                      oe.proxy(function () {
                                          o.trigger("hold", [a.target]), y.hold && (t = y.hold.call(o, a, a.target));
                                      }, this),
                                      y.longTapThreshold
                                  )),
                              K(!0),
                              null)
                    );
                }
            }
            function f(e) {
                var t = e.originalEvent ? e.originalEvent : e;
                if (L !== je && L !== Le && !$()) {
                    var i,
                        a,
                        n,
                        r,
                        s,
                        o,
                        l,
                        d,
                        c,
                        u,
                        h,
                        p,
                        f = t.touches,
                        g = te(f ? f[0] : t);
                    if (
                        ((R = se()),
                        f && (O = f.length),
                        y.hold && clearTimeout(I),
                        (L = Se),
                        2 == O && (0 == x ? (ee(1, f[1]), (x = T = re(P[0].start, P[1].start))) : (te(f[1]), (T = re(P[0].end, P[1].end)), P[0].end, P[1].end, (S = C < 1 ? pe : he)), (C = ((T / x) * 1).toFixed(2)), (k = Math.abs(x - T))),
                        O === y.fingers || y.fingers === Te || !f || H())
                    ) {
                        if (
                            ((u = g.start),
                            (h = g.end),
                            (p = (function (e, t) {
                                var i = e.x - t.x,
                                    a = t.y - e.y,
                                    n = Math.atan2(a, i),
                                    r = Math.round((180 * n) / Math.PI);
                                r < 0 && (r = 360 - Math.abs(r));
                                return r;
                            })(u, h)),
                            (function (e, t) {
                                if (!1 === y.preventDefaultEvents) return;
                                if (y.allowPageScroll === fe) e.preventDefault();
                                else {
                                    var i = y.allowPageScroll === ge;
                                    switch (t) {
                                        case le:
                                            ((y.swipeLeft && i) || (!i && y.allowPageScroll != be)) && e.preventDefault();
                                            break;
                                        case de:
                                            ((y.swipeRight && i) || (!i && y.allowPageScroll != be)) && e.preventDefault();
                                            break;
                                        case ce:
                                            ((y.swipeUp && i) || (!i && y.allowPageScroll != xe)) && e.preventDefault();
                                            break;
                                        case ue:
                                            ((y.swipeDown && i) || (!i && y.allowPageScroll != xe)) && e.preventDefault();
                                    }
                                }
                            })(e, (_ = p <= 45 && 0 <= p ? le : p <= 360 && 315 <= p ? le : 135 <= p && p <= 225 ? de : 45 < p && p < 135 ? ue : ce)),
                            (d = g.start),
                            (c = g.end),
                            (w = Math.round(Math.sqrt(Math.pow(c.x - d.x, 2) + Math.pow(c.y - d.y, 2)))),
                            (b = ne()),
                            (o = _),
                            (l = w),
                            (l = Math.max(l, ie(o))),
                            (j[o].distance = l),
                            (y.swipeStatus || y.pinchStatus) && (i = M(t, L)),
                            !y.triggerOnTouchEnd || y.triggerOnTouchLeave)
                        ) {
                            var m = !0;
                            if (y.triggerOnTouchLeave) {
                                var v = { left: (s = (r = oe((r = this))).offset()).left, right: s.left + r.outerWidth(), top: s.top, bottom: s.top + r.outerHeight() };
                                (a = g.end), (n = v), (m = a.x > n.left && a.x < n.right && a.y > n.top && a.y < n.bottom);
                            }
                            !y.triggerOnTouchEnd && m ? (L = Q(Se)) : y.triggerOnTouchLeave && !m && (L = Q(je)), (L != Le && L != je) || M(t, L);
                        }
                    } else M(t, (L = Le));
                    !1 === i && M(t, (L = Le));
                }
            }
            function g(e) {
                var t = e.originalEvent ? e.originalEvent : e,
                    i = t.touches;
                return i && i.length
                    ? ((d = se()), (c = event.touches.length + 1), !0)
                    : ($() && (O = c),
                      (R = se()),
                      (b = ne()),
                      F() || !D() ? M(t, (L = Le)) : y.triggerOnTouchEnd || (0 == y.triggerOnTouchEnd && L === Se) ? (e.preventDefault(), M(t, (L = je))) : !y.triggerOnTouchEnd && U() ? z(t, (L = je), ye) : L === Se && M(t, (L = Le)),
                      K(!1),
                      null);
            }
            function m() {
                (T = x = l = R = O = 0), (C = 1), J(), K(!1);
            }
            function v(e) {
                var t = e.originalEvent ? e.originalEvent : e;
                y.triggerOnTouchLeave && M(t, (L = Q(je)));
            }
            function A() {
                o.unbind(i, p), o.unbind(s, m), o.unbind(a, f), o.unbind(n, g), r && o.unbind(r, v), K(!1);
            }
            function Q(e) {
                var t = e,
                    i = E(),
                    a = D(),
                    n = F();
                return !i || n ? (t = Le) : !a || e != Se || (y.triggerOnTouchEnd && !y.triggerOnTouchLeave) ? !a && e == je && y.triggerOnTouchLeave && (t = Le) : (t = je), t;
            }
            function M(e, t) {
                var i,
                    a = e.touches;
                return (
                    Y() || V() || W() || H()
                        ? ((Y() || V()) && (i = z(e, t, me)), (W() || H()) && !1 !== i && (i = z(e, t, ve)))
                        : Z() && G() && !1 !== i
                        ? (i = z(e, t, we))
                        : b > y.longTapThreshold && w < Ce && y.longTap && !1 !== i
                        ? (i = z(e, t, _e))
                        : (1 !== O && Oe) || !(isNaN(w) || w < y.threshold) || !U() || !1 === i || (i = z(e, t, ye)),
                    t === Le && m(),
                    t === je && ((a && a.length) || m()),
                    i
                );
            }
            function z(e, t, i) {
                var a;
                if (i == me) {
                    if ((o.trigger("swipeStatus", [t, _ || null, w || 0, b || 0, O, P]), y.swipeStatus && !1 === (a = y.swipeStatus.call(o, e, t, _ || null, w || 0, b || 0, O, P)))) return !1;
                    if (t == je && B()) {
                        if ((o.trigger("swipe", [_, w, b, O, P]), y.swipe && !1 === (a = y.swipe.call(o, e, _, w, b, O, P)))) return !1;
                        switch (_) {
                            case le:
                                o.trigger("swipeLeft", [_, w, b, O, P]), y.swipeLeft && (a = y.swipeLeft.call(o, e, _, w, b, O, P));
                                break;
                            case de:
                                o.trigger("swipeRight", [_, w, b, O, P]), y.swipeRight && (a = y.swipeRight.call(o, e, _, w, b, O, P));
                                break;
                            case ce:
                                o.trigger("swipeUp", [_, w, b, O, P]), y.swipeUp && (a = y.swipeUp.call(o, e, _, w, b, O, P));
                                break;
                            case ue:
                                o.trigger("swipeDown", [_, w, b, O, P]), y.swipeDown && (a = y.swipeDown.call(o, e, _, w, b, O, P));
                        }
                    }
                }
                if (i == ve) {
                    if ((o.trigger("pinchStatus", [t, S || null, k || 0, b || 0, O, C, P]), y.pinchStatus && !1 === (a = y.pinchStatus.call(o, e, t, S || null, k || 0, b || 0, O, C, P)))) return !1;
                    if (t == je && N())
                        switch (S) {
                            case he:
                                o.trigger("pinchIn", [S || null, k || 0, b || 0, O, C, P]), y.pinchIn && (a = y.pinchIn.call(o, e, S || null, k || 0, b || 0, O, C, P));
                                break;
                            case pe:
                                o.trigger("pinchOut", [S || null, k || 0, b || 0, O, C, P]), y.pinchOut && (a = y.pinchOut.call(o, e, S || null, k || 0, b || 0, O, C, P));
                        }
                }
                return (
                    i == ye
                        ? (t !== Le && t !== je) ||
                          (clearTimeout(h),
                          clearTimeout(I),
                          G() && !Z()
                              ? ((u = se()),
                                (h = setTimeout(
                                    oe.proxy(function () {
                                        (u = null), o.trigger("tap", [e.target]), y.tap && (a = y.tap.call(o, e, e.target));
                                    }, this),
                                    y.doubleTapThreshold
                                )))
                              : ((u = null), o.trigger("tap", [e.target]), y.tap && (a = y.tap.call(o, e, e.target))))
                        : i == we
                        ? (t !== Le && t !== je) || (clearTimeout(h), (u = null), o.trigger("doubletap", [e.target]), y.doubleTap && (a = y.doubleTap.call(o, e, e.target)))
                        : i == _e && ((t !== Le && t !== je) || (clearTimeout(h), (u = null), o.trigger("longtap", [e.target]), y.longTap && (a = y.longTap.call(o, e, e.target)))),
                    a
                );
            }
            function D() {
                var e = !0;
                return null !== y.threshold && (e = w >= y.threshold), e;
            }
            function F() {
                var e = !1;
                return null !== y.cancelThreshold && null !== _ && (e = ie(_) - w >= y.cancelThreshold), e;
            }
            function E() {
                return !y.maxTimeThreshold || !(b >= y.maxTimeThreshold);
            }
            function N() {
                var e = X(),
                    t = q(),
                    i = null === y.pinchThreshold || k >= y.pinchThreshold;
                return e && t && i;
            }
            function H() {
                return !!(y.pinchStatus || y.pinchIn || y.pinchOut);
            }
            function W() {
                return !(!N() || !H());
            }
            function B() {
                var e = E(),
                    t = D(),
                    i = X(),
                    a = q();
                return !F() && a && i && t && e;
            }
            function V() {
                return !!(y.swipe || y.swipeStatus || y.swipeLeft || y.swipeRight || y.swipeUp || y.swipeDown);
            }
            function Y() {
                return !(!B() || !V());
            }
            function X() {
                return O === y.fingers || y.fingers === Te || !Oe;
            }
            function q() {
                return 0 !== P[0].end.x;
            }
            function U() {
                return !!y.tap;
            }
            function G() {
                return !!y.doubleTap;
            }
            function Z() {
                if (null == u) return !1;
                var e = se();
                return G() && e - u <= y.doubleTapThreshold;
            }
            function J() {
                c = d = 0;
            }
            function $() {
                var e = !1;
                d && se() - d <= y.fingerReleaseThreshold && (e = !0);
                return e;
            }
            function K(e) {
                !0 === e ? (o.bind(a, f), o.bind(n, g), r && o.bind(r, v)) : (o.unbind(a, f, !1), o.unbind(n, g, !1), r && o.unbind(r, v, !1)), o.data(Ie + "_intouch", !0 === e);
            }
            function ee(e, t) {
                var i = void 0 !== t.identifier ? t.identifier : 0;
                return (P[e].identifier = i), (P[e].start.x = P[e].end.x = t.pageX || t.clientX), (P[e].start.y = P[e].end.y = t.pageY || t.clientY), P[e];
            }
            function te(e) {
                var t = (function (e) {
                    for (var t = 0; t < P.length; t++) if (P[t].identifier == e) return P[t];
                })(void 0 !== e.identifier ? e.identifier : 0);
                return (t.end.x = e.pageX || e.clientX), (t.end.y = e.pageY || e.clientY), t;
            }
            function ie(e) {
                if (j[e]) return j[e].distance;
            }
            function ae(e) {
                return { direction: e, distance: 0 };
            }
            function ne() {
                return R - l;
            }
            function re(e, t) {
                var i = Math.abs(e.x - t.x),
                    a = Math.abs(e.y - t.y);
                return Math.round(Math.sqrt(i * i + a * a));
            }
            function se() {
                return new Date().getTime();
            }
            (this.enable = function () {
                return o.bind(i, p), o.bind(s, m), o;
            }),
                (this.disable = function () {
                    return A(), o;
                }),
                (this.destroy = function () {
                    A(), o.data(Ie, null), (o = null);
                }),
                (this.option = function (e, t) {
                    if (void 0 !== y[e]) {
                        if (void 0 === t) return y[e];
                        y[e] = t;
                    } else oe.error("Option " + e + " does not exist on jQuery.swipetp.options");
                    return null;
                });
        }
        (oe.fn.swipetp = function (e) {
            var t = oe(this),
                i = t.data(Ie);
            if (i && "string" == typeof e) {
                if (i[e]) return i[e].apply(this, Array.prototype.slice.call(arguments, 1));
                oe.error("Method " + e + " does not exist on jQuery.swipetp");
            } else if (!(i || ("object" != typeof e && e)))
                return function (i) {
                    !i || void 0 !== i.allowPageScroll || (void 0 === i.swipe && void 0 === i.swipeStatus) || (i.allowPageScroll = fe);
                    void 0 !== i.click && void 0 === i.tap && (i.tap = i.click);
                    i || (i = {});
                    return (
                        (i = oe.extend({}, oe.fn.swipetp.defaults, i)),
                        this.each(function () {
                            var e = oe(this),
                                t = e.data(Ie);
                            t || ((t = new a(this, i)), e.data(Ie, t));
                        })
                    );
                }.apply(this, arguments);
            return t;
        }),
            (oe.fn.swipetp.version = "1.6.9"),
            (oe.fn.swipetp.defaults = {
                fingers: 1,
                threshold: 75,
                cancelThreshold: null,
                pinchThreshold: 20,
                maxTimeThreshold: null,
                fingerReleaseThreshold: 250,
                longTapThreshold: 500,
                doubleTapThreshold: 200,
                swipe: null,
                swipeLeft: null,
                swipeRight: null,
                swipeUp: null,
                swipeDown: null,
                swipeStatus: null,
                pinchIn: null,
                pinchOut: null,
                pinchStatus: null,
                click: null,
                tap: null,
                doubleTap: null,
                longTap: null,
                hold: null,
                triggerOnTouchEnd: !0,
                triggerOnTouchLeave: !1,
                allowPageScroll: "auto",
                fallbackToMouseEvents: !0,
                excludedElements: "label, button, input, select, textarea, a, .noSwipe",
                preventDefaultEvents: !0,
            }),
            (oe.fn.swipetp.phases = { PHASE_START: ke, PHASE_MOVE: Se, PHASE_END: je, PHASE_CANCEL: Le }),
            (oe.fn.swipetp.directions = { LEFT: le, RIGHT: de, UP: ce, DOWN: ue, IN: he, OUT: pe }),
            (oe.fn.swipetp.pageScroll = { NONE: fe, HORIZONTAL: be, VERTICAL: xe, AUTO: ge }),
            (oe.fn.swipetp.fingers = { ONE: 1, TWO: 2, THREE: 3, ALL: Te });
    }),
    void 0 === console)
) {
    var console = {};
    console.log = console.error = console.info = console.debug = console.warn = console.trace = console.dir = console.dirxml = console.group = console.groupEnd = console.time = console.timeEnd = console.assert = console.profile = console.groupCollapsed = function () {};
}
if (1 == window.tplogs)
    try {
        console.groupCollapsed("ThemePunch GreenSocks Logs");
    } catch (e) {}
var oldgs = window.GreenSockGlobals;
oldgs_queue = window._gsQueue;
var punchgs = (window.GreenSockGlobals = {});
if (1 == window.tplogs)
    try {
        console.info("Build GreenSock SandBox for ThemePunch Plugins"), console.info("GreenSock TweenLite Engine Initalised by ThemePunch Plugin");
    } catch (e) {}
!(function (p, f) {
    "use strict";
    var t,
        i,
        g = {},
        a = p.document,
        m = (p.GreenSockGlobals = p.GreenSockGlobals || p);
    if (!m.TweenLite) {
        var e,
            n,
            r,
            v,
            y,
            w = function (e) {
                var t,
                    i = e.split("."),
                    a = m;
                for (t = 0; t < i.length; t++) a[i[t]] = a = a[i[t]] || {};
                return a;
            },
            u = w("com.greensock"),
            _ = 1e-10,
            l = function (e) {
                var t,
                    i = [],
                    a = e.length;
                for (t = 0; t !== a; i.push(e[t++]));
                return i;
            },
            b = function () {},
            x =
                ((t = Object.prototype.toString),
                (i = t.call([])),
                function (e) {
                    return null != e && (e instanceof Array || ("object" == typeof e && !!e.push && t.call(e) === i));
                }),
            T = {},
            C = function (l, d, c, u) {
                (this.sc = T[l] ? T[l].sc : []), ((T[l] = this).gsClass = null), (this.func = c);
                var h = [];
                (this.check = function (e) {
                    for (var t, i, a, n, r, s = d.length, o = s; -1 < --s; ) (t = T[d[s]] || new C(d[s], [])).gsClass ? ((h[s] = t.gsClass), o--) : e && t.sc.push(this);
                    if (0 === o && c) {
                        if (((a = (i = ("com.greensock." + l).split(".")).pop()), (n = w(i.join("."))[a] = this.gsClass = c.apply(c, h)), u))
                            if (((m[a] = g[a] = n), !(r = "undefined" != typeof module && module.exports) && "function" == typeof define && define.amd))
                                define((p.GreenSockAMDPath ? p.GreenSockAMDPath + "/" : "") + l.split(".").pop(), [], function () {
                                    return n;
                                });
                            else if (r)
                                if (l === f) for (s in ((module.exports = g[f] = n), g)) n[s] = g[s];
                                else g[f] && (g[f][a] = n);
                        for (s = 0; s < this.sc.length; s++) this.sc[s].check();
                    }
                }),
                    this.check(!0);
            },
            s = (p._gsDefine = function (e, t, i, a) {
                return new C(e, t, i, a);
            }),
            h = (u._class = function (e, t, i) {
                return (
                    (t = t || function () {}),
                    s(
                        e,
                        [],
                        function () {
                            return t;
                        },
                        i
                    ),
                    t
                );
            });
        s.globals = m;
        var o = [0, 0, 1, 1],
            k = h(
                "easing.Ease",
                function (e, t, i, a) {
                    (this._func = e), (this._type = i || 0), (this._power = a || 0), (this._params = t ? o.concat(t) : o);
                },
                !0
            ),
            S = (k.map = {}),
            d = (k.register = function (e, t, i, a) {
                for (var n, r, s, o, l = t.split(","), d = l.length, c = (i || "easeIn,easeOut,easeInOut").split(","); -1 < --d; )
                    for (r = l[d], n = a ? h("easing." + r, null, !0) : u.easing[r] || {}, s = c.length; -1 < --s; ) (o = c[s]), (S[r + "." + o] = S[o + r] = n[o] = e.getRatio ? e : e[o] || new e());
            });
        for (
            (r = k.prototype)._calcEnd = !1,
                r.getRatio = function (e) {
                    if (this._func) return (this._params[0] = e), this._func.apply(null, this._params);
                    var t = this._type,
                        i = this._power,
                        a = 1 === t ? 1 - e : 2 === t ? e : e < 0.5 ? 2 * e : 2 * (1 - e);
                    return 1 === i ? (a *= a) : 2 === i ? (a *= a * a) : 3 === i ? (a *= a * a * a) : 4 === i && (a *= a * a * a * a), 1 === t ? 1 - a : 2 === t ? a : e < 0.5 ? a / 2 : 1 - a / 2;
                },
                n = (e = ["Linear", "Quad", "Cubic", "Quart", "Quint,Strong"]).length;
            -1 < --n;

        )
            (r = e[n] + ",Power" + n), d(new k(null, null, 1, n), r, "easeOut", !0), d(new k(null, null, 2, n), r, "easeIn" + (0 === n ? ",easeNone" : "")), d(new k(null, null, 3, n), r, "easeInOut");
        (S.linear = u.easing.Linear.easeIn), (S.swing = u.easing.Quad.easeInOut);
        var j = h("events.EventDispatcher", function (e) {
            (this._listeners = {}), (this._eventTarget = e || this);
        });
        ((r = j.prototype).addEventListener = function (e, t, i, a, n) {
            n = n || 0;
            var r,
                s,
                o = this._listeners[e],
                l = 0;
            for (this !== v || y || v.wake(), null == o && (this._listeners[e] = o = []), s = o.length; -1 < --s; ) (r = o[s]).c === t && r.s === i ? o.splice(s, 1) : 0 === l && r.pr < n && (l = s + 1);
            o.splice(l, 0, { c: t, s: i, up: a, pr: n });
        }),
            (r.removeEventListener = function (e, t) {
                var i,
                    a = this._listeners[e];
                if (a) for (i = a.length; -1 < --i; ) if (a[i].c === t) return void a.splice(i, 1);
            }),
            (r.dispatchEvent = function (e) {
                var t,
                    i,
                    a,
                    n = this._listeners[e];
                if (n) for (1 < (t = n.length) && (n = n.slice(0)), i = this._eventTarget; -1 < --t; ) (a = n[t]) && (a.up ? a.c.call(a.s || i, { type: e, target: i }) : a.c.call(a.s || i));
            });
        var L = p.requestAnimationFrame,
            O = p.cancelAnimationFrame,
            P =
                Date.now ||
                function () {
                    return new Date().getTime();
                },
            R = P();
        for (n = (e = ["ms", "moz", "webkit", "o"]).length; -1 < --n && !L; ) (L = p[e[n] + "RequestAnimationFrame"]), (O = p[e[n] + "CancelAnimationFrame"] || p[e[n] + "CancelRequestAnimationFrame"]);
        h("Ticker", function (e, t) {
            var n,
                r,
                s,
                o,
                l,
                d = this,
                c = P(),
                i = !(!1 === t || !L) && "auto",
                u = 500,
                h = 33,
                p = function (e) {
                    var t,
                        i,
                        a = P() - R;
                    u < a && (c += a - h), (R += a), (d.time = (R - c) / 1e3), (t = d.time - l), (!n || 0 < t || !0 === e) && (d.frame++, (l += t + (o <= t ? 0.004 : o - t)), (i = !0)), !0 !== e && (s = r(p)), i && d.dispatchEvent("tick");
                };
            j.call(d),
                (d.time = d.frame = 0),
                (d.tick = function () {
                    p(!0);
                }),
                (d.lagSmoothing = function (e, t) {
                    (u = e || 1e10), (h = Math.min(t, u, 0));
                }),
                (d.sleep = function () {
                    null != s && (i && O ? O(s) : clearTimeout(s), (r = b), (s = null), d === v && (y = !1));
                }),
                (d.wake = function (e) {
                    null !== s ? d.sleep() : e ? (c += -R + (R = P())) : 10 < d.frame && (R = P() - u + 5),
                        (r =
                            0 === n
                                ? b
                                : i && L
                                ? L
                                : function (e) {
                                      return setTimeout(e, (1e3 * (l - d.time) + 1) | 0);
                                  }),
                        d === v && (y = !0),
                        p(2);
                }),
                (d.fps = function (e) {
                    return arguments.length ? ((o = 1 / ((n = e) || 60)), (l = this.time + o), void d.wake()) : n;
                }),
                (d.useRAF = function (e) {
                    return arguments.length ? (d.sleep(), (i = e), void d.fps(n)) : i;
                }),
                d.fps(e),
                setTimeout(function () {
                    "auto" === i && d.frame < 5 && "hidden" !== a.visibilityState && d.useRAF(!1);
                }, 1500);
        }),
            ((r = u.Ticker.prototype = new u.events.EventDispatcher()).constructor = u.Ticker);
        var c = h("core.Animation", function (e, t) {
            if (
                ((this.vars = t = t || {}),
                (this._duration = this._totalDuration = e || 0),
                (this._delay = Number(t.delay) || 0),
                (this._timeScale = 1),
                (this._active = !0 === t.immediateRender),
                (this.data = t.data),
                (this._reversed = !0 === t.reversed),
                G)
            ) {
                y || v.wake();
                var i = this.vars.useFrames ? U : G;
                i.add(this, i._time), this.vars.paused && this.paused(!0);
            }
        });
        (v = c.ticker = new u.Ticker()),
            ((r = c.prototype)._dirty = r._gc = r._initted = r._paused = !1),
            (r._totalTime = r._time = 0),
            (r._rawPrevTime = -1),
            (r._next = r._last = r._onUpdate = r._timeline = r.timeline = null),
            (r._paused = !1);
        var I = function () {
            y && 2e3 < P() - R && v.wake(), setTimeout(I, 2e3);
        };
        I(),
            (r.play = function (e, t) {
                return null != e && this.seek(e, t), this.reversed(!1).paused(!1);
            }),
            (r.pause = function (e, t) {
                return null != e && this.seek(e, t), this.paused(!0);
            }),
            (r.resume = function (e, t) {
                return null != e && this.seek(e, t), this.paused(!1);
            }),
            (r.seek = function (e, t) {
                return this.totalTime(Number(e), !1 !== t);
            }),
            (r.restart = function (e, t) {
                return this.reversed(!1)
                    .paused(!1)
                    .totalTime(e ? -this._delay : 0, !1 !== t, !0);
            }),
            (r.reverse = function (e, t) {
                return null != e && this.seek(e || this.totalDuration(), t), this.reversed(!0).paused(!1);
            }),
            (r.render = function (e, t, i) {}),
            (r.invalidate = function () {
                return (this._time = this._totalTime = 0), (this._initted = this._gc = !1), (this._rawPrevTime = -1), (this._gc || !this.timeline) && this._enabled(!0), this;
            }),
            (r.isActive = function () {
                var e,
                    t = this._timeline,
                    i = this._startTime;
                return !t || (!this._gc && !this._paused && t.isActive() && (e = t.rawTime(!0)) >= i && e < i + this.totalDuration() / this._timeScale);
            }),
            (r._enabled = function (e, t) {
                return (
                    y || v.wake(), (this._gc = !e), (this._active = this.isActive()), !0 !== t && (e && !this.timeline ? this._timeline.add(this, this._startTime - this._delay) : !e && this.timeline && this._timeline._remove(this, !0)), !1
                );
            }),
            (r._kill = function (e, t) {
                return this._enabled(!1, !1);
            }),
            (r.kill = function (e, t) {
                return this._kill(e, t), this;
            }),
            (r._uncache = function (e) {
                for (var t = e ? this : this.timeline; t; ) (t._dirty = !0), (t = t.timeline);
                return this;
            }),
            (r._swapSelfInParams = function (e) {
                for (var t = e.length, i = e.concat(); -1 < --t; ) "{self}" === e[t] && (i[t] = this);
                return i;
            }),
            (r._callback = function (e) {
                var t = this.vars,
                    i = t[e],
                    a = t[e + "Params"],
                    n = t[e + "Scope"] || t.callbackScope || this;
                switch (a ? a.length : 0) {
                    case 0:
                        i.call(n);
                        break;
                    case 1:
                        i.call(n, a[0]);
                        break;
                    case 2:
                        i.call(n, a[0], a[1]);
                        break;
                    default:
                        i.apply(n, a);
                }
            }),
            (r.eventCallback = function (e, t, i, a) {
                if ("on" === (e || "").substr(0, 2)) {
                    var n = this.vars;
                    if (1 === arguments.length) return n[e];
                    null == t ? delete n[e] : ((n[e] = t), (n[e + "Params"] = x(i) && -1 !== i.join("").indexOf("{self}") ? this._swapSelfInParams(i) : i), (n[e + "Scope"] = a)), "onUpdate" === e && (this._onUpdate = t);
                }
                return this;
            }),
            (r.delay = function (e) {
                return arguments.length ? (this._timeline.smoothChildTiming && this.startTime(this._startTime + e - this._delay), (this._delay = e), this) : this._delay;
            }),
            (r.duration = function (e) {
                return arguments.length
                    ? ((this._duration = this._totalDuration = e),
                      this._uncache(!0),
                      this._timeline.smoothChildTiming && 0 < this._time && this._time < this._duration && 0 !== e && this.totalTime(this._totalTime * (e / this._duration), !0),
                      this)
                    : ((this._dirty = !1), this._duration);
            }),
            (r.totalDuration = function (e) {
                return (this._dirty = !1), arguments.length ? this.duration(e) : this._totalDuration;
            }),
            (r.time = function (e, t) {
                return arguments.length ? (this._dirty && this.totalDuration(), this.totalTime(e > this._duration ? this._duration : e, t)) : this._time;
            }),
            (r.totalTime = function (e, t, i) {
                if ((y || v.wake(), !arguments.length)) return this._totalTime;
                if (this._timeline) {
                    if ((e < 0 && !i && (e += this.totalDuration()), this._timeline.smoothChildTiming)) {
                        this._dirty && this.totalDuration();
                        var a = this._totalDuration,
                            n = this._timeline;
                        if ((a < e && !i && (e = a), (this._startTime = (this._paused ? this._pauseTime : n._time) - (this._reversed ? a - e : e) / this._timeScale), n._dirty || this._uncache(!1), n._timeline))
                            for (; n._timeline; ) n._timeline._time !== (n._startTime + n._totalTime) / n._timeScale && n.totalTime(n._totalTime, !0), (n = n._timeline);
                    }
                    this._gc && this._enabled(!0, !1), (this._totalTime !== e || 0 === this._duration) && (z.length && J(), this.render(e, t, !1), z.length && J());
                }
                return this;
            }),
            (r.progress = r.totalProgress = function (e, t) {
                var i = this.duration();
                return arguments.length ? this.totalTime(i * e, t) : i ? this._time / i : this.ratio;
            }),
            (r.startTime = function (e) {
                return arguments.length ? (e !== this._startTime && ((this._startTime = e), this.timeline && this.timeline._sortChildren && this.timeline.add(this, e - this._delay)), this) : this._startTime;
            }),
            (r.endTime = function (e) {
                return this._startTime + (0 != e ? this.totalDuration() : this.duration()) / this._timeScale;
            }),
            (r.timeScale = function (e) {
                if (!arguments.length) return this._timeScale;
                if (((e = e || _), this._timeline && this._timeline.smoothChildTiming)) {
                    var t = this._pauseTime,
                        i = t || 0 === t ? t : this._timeline.totalTime();
                    this._startTime = i - ((i - this._startTime) * this._timeScale) / e;
                }
                return (this._timeScale = e), this._uncache(!1);
            }),
            (r.reversed = function (e) {
                return arguments.length
                    ? (e != this._reversed && ((this._reversed = e), this.totalTime(this._timeline && !this._timeline.smoothChildTiming ? this.totalDuration() - this._totalTime : this._totalTime, !0)), this)
                    : this._reversed;
            }),
            (r.paused = function (e) {
                if (!arguments.length) return this._paused;
                var t,
                    i,
                    a = this._timeline;
                return (
                    e != this._paused &&
                        a &&
                        (y || e || v.wake(),
                        (i = (t = a.rawTime()) - this._pauseTime),
                        !e && a.smoothChildTiming && ((this._startTime += i), this._uncache(!1)),
                        (this._pauseTime = e ? t : null),
                        (this._paused = e),
                        (this._active = this.isActive()),
                        !e && 0 !== i && this._initted && this.duration() && ((t = a.smoothChildTiming ? this._totalTime : (t - this._startTime) / this._timeScale), this.render(t, t === this._totalTime, !0))),
                    this._gc && !e && this._enabled(!0, !1),
                    this
                );
            });
        var A = h("core.SimpleTimeline", function (e) {
            c.call(this, 0, e), (this.autoRemoveChildren = this.smoothChildTiming = !0);
        });
        ((r = A.prototype = new c()).constructor = A),
            (r.kill()._gc = !1),
            (r._first = r._last = r._recent = null),
            (r._sortChildren = !1),
            (r.add = r.insert = function (e, t, i, a) {
                var n, r;
                if (
                    ((e._startTime = Number(t || 0) + e._delay),
                    e._paused && this !== e._timeline && (e._pauseTime = e._startTime + (this.rawTime() - e._startTime) / e._timeScale),
                    e.timeline && e.timeline._remove(e, !0),
                    (e.timeline = e._timeline = this),
                    e._gc && e._enabled(!0, !0),
                    (n = this._last),
                    this._sortChildren)
                )
                    for (r = e._startTime; n && n._startTime > r; ) n = n._prev;
                return n ? ((e._next = n._next), (n._next = e)) : ((e._next = this._first), (this._first = e)), e._next ? (e._next._prev = e) : (this._last = e), (e._prev = n), (this._recent = e), this._timeline && this._uncache(!0), this;
            }),
            (r._remove = function (e, t) {
                return (
                    e.timeline === this &&
                        (t || e._enabled(!1, !0),
                        e._prev ? (e._prev._next = e._next) : this._first === e && (this._first = e._next),
                        e._next ? (e._next._prev = e._prev) : this._last === e && (this._last = e._prev),
                        (e._next = e._prev = e.timeline = null),
                        e === this._recent && (this._recent = this._last),
                        this._timeline && this._uncache(!0)),
                    this
                );
            }),
            (r.render = function (e, t, i) {
                var a,
                    n = this._first;
                for (this._totalTime = this._time = this._rawPrevTime = e; n; )
                    (a = n._next),
                        (n._active || (e >= n._startTime && !n._paused)) &&
                            (n._reversed ? n.render((n._dirty ? n.totalDuration() : n._totalDuration) - (e - n._startTime) * n._timeScale, t, i) : n.render((e - n._startTime) * n._timeScale, t, i)),
                        (n = a);
            }),
            (r.rawTime = function () {
                return y || v.wake(), this._totalTime;
            });
        var Q = h(
                "TweenLite",
                function (e, t, i) {
                    if ((c.call(this, t, i), (this.render = Q.prototype.render), null == e)) throw "Cannot tween a null target.";
                    this.target = e = "string" != typeof e ? e : Q.selector(e) || e;
                    var a,
                        n,
                        r,
                        s = e.jquery || (e.length && e !== p && e[0] && (e[0] === p || (e[0].nodeType && e[0].style && !e.nodeType))),
                        o = this.vars.overwrite;
                    if (((this._overwrite = o = null == o ? q[Q.defaultOverwrite] : "number" == typeof o ? o >> 0 : q[o]), (s || e instanceof Array || (e.push && x(e))) && "number" != typeof e[0]))
                        for (this._targets = r = l(e), this._propLookup = [], this._siblings = [], a = 0; a < r.length; a++)
                            (n = r[a])
                                ? "string" != typeof n
                                    ? n.length && n !== p && n[0] && (n[0] === p || (n[0].nodeType && n[0].style && !n.nodeType))
                                        ? (r.splice(a--, 1), (this._targets = r = r.concat(l(n))))
                                        : ((this._siblings[a] = $(n, this, !1)), 1 === o && 1 < this._siblings[a].length && ee(n, this, null, 1, this._siblings[a]))
                                    : "string" == typeof (n = r[a--] = Q.selector(n)) && r.splice(a + 1, 1)
                                : r.splice(a--, 1);
                    else (this._propLookup = {}), (this._siblings = $(e, this, !1)), 1 === o && 1 < this._siblings.length && ee(e, this, null, 1, this._siblings);
                    (this.vars.immediateRender || (0 === t && 0 === this._delay && !1 !== this.vars.immediateRender)) && ((this._time = -_), this.render(Math.min(0, -this._delay)));
                },
                !0
            ),
            M = function (e) {
                return e && e.length && e !== p && e[0] && (e[0] === p || (e[0].nodeType && e[0].style && !e.nodeType));
            };
        ((r = Q.prototype = new c()).constructor = Q),
            (r.kill()._gc = !1),
            (r.ratio = 0),
            (r._firstPT = r._targets = r._overwrittenProps = r._startAt = null),
            (r._notifyPluginsOfEnabled = r._lazy = !1),
            (Q.version = "1.19.1"),
            (Q.defaultEase = r._ease = new k(null, null, 1, 1)),
            (Q.defaultOverwrite = "auto"),
            (Q.ticker = v),
            (Q.autoSleep = 120),
            (Q.lagSmoothing = function (e, t) {
                v.lagSmoothing(e, t);
            }),
            (Q.selector =
                p.$ ||
                p.jQuery ||
                function (e) {
                    var t = p.$ || p.jQuery;
                    return t ? (Q.selector = t)(e) : void 0 === a ? e : a.querySelectorAll ? a.querySelectorAll(e) : a.getElementById("#" === e.charAt(0) ? e.substr(1) : e);
                });
        var z = [],
            D = {},
            F = /(?:(-|-=|\+=)?\d*\.?\d*(?:e[\-+]?\d+)?)[0-9]/gi,
            E = function (e) {
                for (var t, i = this._firstPT; i; )
                    (t = i.blob ? (1 === e ? this.end : e ? this.join("") : this.start) : i.c * e + i.s),
                        i.m ? (t = i.m(t, this._target || i.t)) : t < 1e-6 && -1e-6 < t && !i.blob && (t = 0),
                        i.f ? (i.fp ? i.t[i.p](i.fp, t) : i.t[i.p](t)) : (i.t[i.p] = t),
                        (i = i._next);
            },
            N = function (e, t, i, a) {
                var n,
                    r,
                    s,
                    o,
                    l,
                    d,
                    c,
                    u = [],
                    h = 0,
                    p = "",
                    f = 0;
                for (
                    u.start = e,
                        u.end = t,
                        e = u[0] = e + "",
                        t = u[1] = t + "",
                        i && (i(u), (e = u[0]), (t = u[1])),
                        u.length = 0,
                        n = e.match(F) || [],
                        r = t.match(F) || [],
                        a && ((a._next = null), (a.blob = 1), (u._firstPT = u._applyPT = a)),
                        l = r.length,
                        o = 0;
                    o < l;
                    o++
                )
                    (c = r[o]),
                        (p += (d = t.substr(h, t.indexOf(c, h) - h)) || !o ? d : ","),
                        (h += d.length),
                        f ? (f = (f + 1) % 5) : "rgba(" === d.substr(-5) && (f = 1),
                        c === n[o] || n.length <= o
                            ? (p += c)
                            : (p && (u.push(p), (p = "")),
                              (s = parseFloat(n[o])),
                              u.push(s),
                              (u._firstPT = {
                                  _next: u._firstPT,
                                  t: u,
                                  p: u.length - 1,
                                  s: s,
                                  c: ("=" === c.charAt(1) ? parseInt(c.charAt(0) + "1", 10) * parseFloat(c.substr(2)) : parseFloat(c) - s) || 0,
                                  f: 0,
                                  m: f && f < 4 ? Math.round : 0,
                              })),
                        (h += c.length);
                return (p += t.substr(h)) && u.push(p), (u.setRatio = E), u;
            },
            H = function (e, t, i, a, n, r, s, o, l) {
                "function" == typeof a && (a = a(l || 0, e));
                var d = typeof e[t],
                    c = "function" !== d ? "" : t.indexOf("set") || "function" != typeof e["get" + t.substr(3)] ? t : "get" + t.substr(3),
                    u = "get" !== i ? i : c ? (s ? e[c](s) : e[c]()) : e[t],
                    h = "string" == typeof a && "=" === a.charAt(1),
                    p = { t: e, p: t, s: u, f: "function" === d, pg: 0, n: n || t, m: r ? ("function" == typeof r ? r : Math.round) : 0, pr: 0, c: h ? parseInt(a.charAt(0) + "1", 10) * parseFloat(a.substr(2)) : parseFloat(a) - u || 0 };
                return (
                    ("number" != typeof u || ("number" != typeof a && !h)) &&
                        (s || isNaN(u) || (!h && isNaN(a)) || "boolean" == typeof u || "boolean" == typeof a
                            ? ((p.fp = s), (p = { t: N(u, h ? p.s + p.c : a, o || Q.defaultStringFilter, p), p: "setRatio", s: 0, c: 1, f: 2, pg: 0, n: n || t, pr: 0, m: 0 }))
                            : ((p.s = parseFloat(u)), h || (p.c = parseFloat(a) - p.s || 0))),
                    p.c ? ((p._next = this._firstPT) && (p._next._prev = p), (this._firstPT = p)) : void 0
                );
            },
            W = (Q._internals = { isArray: x, isSelector: M, lazyTweens: z, blobDif: N }),
            B = (Q._plugins = {}),
            V = (W.tweenLookup = {}),
            Y = 0,
            X = (W.reservedProps = {
                ease: 1,
                delay: 1,
                overwrite: 1,
                onComplete: 1,
                onCompleteParams: 1,
                onCompleteScope: 1,
                useFrames: 1,
                runBackwards: 1,
                startAt: 1,
                onUpdate: 1,
                onUpdateParams: 1,
                onUpdateScope: 1,
                onStart: 1,
                onStartParams: 1,
                onStartScope: 1,
                onReverseComplete: 1,
                onReverseCompleteParams: 1,
                onReverseCompleteScope: 1,
                onRepeat: 1,
                onRepeatParams: 1,
                onRepeatScope: 1,
                easeParams: 1,
                yoyo: 1,
                immediateRender: 1,
                repeat: 1,
                repeatDelay: 1,
                data: 1,
                paused: 1,
                reversed: 1,
                autoCSS: 1,
                lazy: 1,
                onOverwrite: 1,
                callbackScope: 1,
                stringFilter: 1,
                id: 1,
            }),
            q = { none: 0, all: 1, auto: 2, concurrent: 3, allOnStart: 4, preexisting: 5, true: 1, false: 0 },
            U = (c._rootFramesTimeline = new A()),
            G = (c._rootTimeline = new A()),
            Z = 30,
            J = (W.lazyRender = function () {
                var e,
                    t = z.length;
                for (D = {}; -1 < --t; ) (e = z[t]) && !1 !== e._lazy && (e.render(e._lazy[0], e._lazy[1], !0), (e._lazy = !1));
                z.length = 0;
            });
        (G._startTime = v.time),
            (U._startTime = v.frame),
            (G._active = U._active = !0),
            setTimeout(J, 1),
            (c._updateRoot = Q.render = function () {
                var e, t, i;
                if ((z.length && J(), G.render((v.time - G._startTime) * G._timeScale, !1, !1), U.render((v.frame - U._startTime) * U._timeScale, !1, !1), z.length && J(), v.frame >= Z)) {
                    for (i in ((Z = v.frame + (parseInt(Q.autoSleep, 10) || 120)), V)) {
                        for (e = (t = V[i].tweens).length; -1 < --e; ) t[e]._gc && t.splice(e, 1);
                        0 === t.length && delete V[i];
                    }
                    if ((!(i = G._first) || i._paused) && Q.autoSleep && !U._first && 1 === v._listeners.tick.length) {
                        for (; i && i._paused; ) i = i._next;
                        i || v.sleep();
                    }
                }
            }),
            v.addEventListener("tick", c._updateRoot);
        var $ = function (e, t, i) {
                var a,
                    n,
                    r = e._gsTweenID;
                if ((V[r || (e._gsTweenID = r = "t" + Y++)] || (V[r] = { target: e, tweens: [] }), t && (((a = V[r].tweens)[(n = a.length)] = t), i))) for (; -1 < --n; ) a[n] === t && a.splice(n, 1);
                return V[r].tweens;
            },
            K = function (e, t, i, a) {
                var n,
                    r,
                    s = e.vars.onOverwrite;
                return s && (n = s(e, t, i, a)), (s = Q.onOverwrite) && (r = s(e, t, i, a)), !1 !== n && !1 !== r;
            },
            ee = function (e, t, i, a, n) {
                var r, s, o, l;
                if (1 === a || 4 <= a) {
                    for (l = n.length, r = 0; r < l; r++)
                        if ((o = n[r]) !== t) o._gc || (o._kill(null, e, t) && (s = !0));
                        else if (5 === a) break;
                    return s;
                }
                var d,
                    c = t._startTime + _,
                    u = [],
                    h = 0,
                    p = 0 === t._duration;
                for (r = n.length; -1 < --r; )
                    (o = n[r]) === t ||
                        o._gc ||
                        o._paused ||
                        (o._timeline !== t._timeline
                            ? ((d = d || te(t, 0, p)), 0 === te(o, d, p) && (u[h++] = o))
                            : o._startTime <= c && o._startTime + o.totalDuration() / o._timeScale > c && (((p || !o._initted) && c - o._startTime <= 2e-10) || (u[h++] = o)));
                for (r = h; -1 < --r; )
                    if (((o = u[r]), 2 === a && o._kill(i, e, t) && (s = !0), 2 !== a || (!o._firstPT && o._initted))) {
                        if (2 !== a && !K(o, t)) continue;
                        o._enabled(!1, !1) && (s = !0);
                    }
                return s;
            },
            te = function (e, t, i) {
                for (var a = e._timeline, n = a._timeScale, r = e._startTime; a._timeline; ) {
                    if (((r += a._startTime), (n *= a._timeScale), a._paused)) return -100;
                    a = a._timeline;
                }
                return t < (r /= n) ? r - t : (i && r === t) || (!e._initted && r - t < 2 * _) ? _ : (r += e.totalDuration() / e._timeScale / n) > t + _ ? 0 : r - t - _;
            };
        (r._init = function () {
            var e,
                t,
                i,
                a,
                n,
                r,
                s = this.vars,
                o = this._overwrittenProps,
                l = this._duration,
                d = !!s.immediateRender,
                c = s.ease;
            if (s.startAt) {
                for (a in (this._startAt && (this._startAt.render(-1, !0), this._startAt.kill()), (n = {}), s.startAt)) n[a] = s.startAt[a];
                if (((n.overwrite = !1), (n.immediateRender = !0), (n.lazy = d && !1 !== s.lazy), (n.startAt = n.delay = null), (this._startAt = Q.to(this.target, 0, n)), d))
                    if (0 < this._time) this._startAt = null;
                    else if (0 !== l) return;
            } else if (s.runBackwards && 0 !== l)
                if (this._startAt) this._startAt.render(-1, !0), this._startAt.kill(), (this._startAt = null);
                else {
                    for (a in (0 !== this._time && (d = !1), (i = {}), s)) (X[a] && "autoCSS" !== a) || (i[a] = s[a]);
                    if (((i.overwrite = 0), (i.data = "isFromStart"), (i.lazy = d && !1 !== s.lazy), (i.immediateRender = d), (this._startAt = Q.to(this.target, 0, i)), d)) {
                        if (0 === this._time) return;
                    } else this._startAt._init(), this._startAt._enabled(!1), this.vars.immediateRender && (this._startAt = null);
                }
            if (
                ((this._ease = c = c ? (c instanceof k ? c : "function" == typeof c ? new k(c, s.easeParams) : S[c] || Q.defaultEase) : Q.defaultEase),
                s.easeParams instanceof Array && c.config && (this._ease = c.config.apply(c, s.easeParams)),
                (this._easeType = this._ease._type),
                (this._easePower = this._ease._power),
                (this._firstPT = null),
                this._targets)
            )
                for (r = this._targets.length, e = 0; e < r; e++) this._initProps(this._targets[e], (this._propLookup[e] = {}), this._siblings[e], o ? o[e] : null, e) && (t = !0);
            else t = this._initProps(this.target, this._propLookup, this._siblings, o, 0);
            if ((t && Q._onPluginEvent("_onInitAllProps", this), o && (this._firstPT || ("function" != typeof this.target && this._enabled(!1, !1))), s.runBackwards)) for (i = this._firstPT; i; ) (i.s += i.c), (i.c = -i.c), (i = i._next);
            (this._onUpdate = s.onUpdate), (this._initted = !0);
        }),
            (r._initProps = function (e, t, i, a, n) {
                var r, s, o, l, d, c;
                if (null == e) return !1;
                for (r in (D[e._gsTweenID] && J(),
                this.vars.css ||
                    (e.style &&
                        e !== p &&
                        e.nodeType &&
                        B.css &&
                        !1 !== this.vars.autoCSS &&
                        (function (e, t) {
                            var i,
                                a = {};
                            for (i in e)
                                X[i] ||
                                    (i in t && "transform" !== i && "x" !== i && "y" !== i && "width" !== i && "height" !== i && "className" !== i && "border" !== i) ||
                                    !(!B[i] || (B[i] && B[i]._autoCSS)) ||
                                    ((a[i] = e[i]), delete e[i]);
                            e.css = a;
                        })(this.vars, e)),
                this.vars))
                    if (((c = this.vars[r]), X[r])) c && (c instanceof Array || (c.push && x(c))) && -1 !== c.join("").indexOf("{self}") && (this.vars[r] = c = this._swapSelfInParams(c, this));
                    else if (B[r] && (l = new B[r]())._onInitTween(e, this.vars[r], this, n)) {
                        for (this._firstPT = d = { _next: this._firstPT, t: l, p: "setRatio", s: 0, c: 1, f: 1, n: r, pg: 1, pr: l._priority, m: 0 }, s = l._overwriteProps.length; -1 < --s; ) t[l._overwriteProps[s]] = this._firstPT;
                        (l._priority || l._onInitAllProps) && (o = !0), (l._onDisable || l._onEnable) && (this._notifyPluginsOfEnabled = !0), d._next && (d._next._prev = d);
                    } else t[r] = H.call(this, e, r, "get", c, r, 0, null, this.vars.stringFilter, n);
                return a && this._kill(a, e)
                    ? this._initProps(e, t, i, a, n)
                    : 1 < this._overwrite && this._firstPT && 1 < i.length && ee(e, this, t, this._overwrite, i)
                    ? (this._kill(t, e), this._initProps(e, t, i, a, n))
                    : (this._firstPT && ((!1 !== this.vars.lazy && this._duration) || (this.vars.lazy && !this._duration)) && (D[e._gsTweenID] = !0), o);
            }),
            (r.render = function (e, t, i) {
                var a,
                    n,
                    r,
                    s,
                    o = this._time,
                    l = this._duration,
                    d = this._rawPrevTime;
                if (l - 1e-7 <= e && 0 <= e)
                    (this._totalTime = this._time = l),
                        (this.ratio = this._ease._calcEnd ? this._ease.getRatio(1) : 1),
                        this._reversed || ((a = !0), (n = "onComplete"), (i = i || this._timeline.autoRemoveChildren)),
                        0 === l &&
                            (this._initted || !this.vars.lazy || i) &&
                            (this._startTime === this._timeline._duration && (e = 0),
                            (d < 0 || (e <= 0 && -1e-7 <= e) || (d === _ && "isPause" !== this.data)) && d !== e && ((i = !0), _ < d && (n = "onReverseComplete")),
                            (this._rawPrevTime = s = !t || e || d === e ? e : _));
                else if (e < 1e-7)
                    (this._totalTime = this._time = 0),
                        (this.ratio = this._ease._calcEnd ? this._ease.getRatio(0) : 0),
                        (0 !== o || (0 === l && 0 < d)) && ((n = "onReverseComplete"), (a = this._reversed)),
                        e < 0 && ((this._active = !1), 0 === l && (this._initted || !this.vars.lazy || i) && (0 <= d && (d !== _ || "isPause" !== this.data) && (i = !0), (this._rawPrevTime = s = !t || e || d === e ? e : _))),
                        this._initted || (i = !0);
                else if (((this._totalTime = this._time = e), this._easeType)) {
                    var c = e / l,
                        u = this._easeType,
                        h = this._easePower;
                    (1 === u || (3 === u && 0.5 <= c)) && (c = 1 - c),
                        3 === u && (c *= 2),
                        1 === h ? (c *= c) : 2 === h ? (c *= c * c) : 3 === h ? (c *= c * c * c) : 4 === h && (c *= c * c * c * c),
                        (this.ratio = 1 === u ? 1 - c : 2 === u ? c : e / l < 0.5 ? c / 2 : 1 - c / 2);
                } else this.ratio = this._ease.getRatio(e / l);
                if (this._time !== o || i) {
                    if (!this._initted) {
                        if ((this._init(), !this._initted || this._gc)) return;
                        if (!i && this._firstPT && ((!1 !== this.vars.lazy && this._duration) || (this.vars.lazy && !this._duration)))
                            return (this._time = this._totalTime = o), (this._rawPrevTime = d), z.push(this), void (this._lazy = [e, t]);
                        this._time && !a ? (this.ratio = this._ease.getRatio(this._time / l)) : a && this._ease._calcEnd && (this.ratio = this._ease.getRatio(0 === this._time ? 0 : 1));
                    }
                    for (
                        !1 !== this._lazy && (this._lazy = !1),
                            this._active || (!this._paused && this._time !== o && 0 <= e && (this._active = !0)),
                            0 === o && (this._startAt && (0 <= e ? this._startAt.render(e, t, i) : n || (n = "_dummyGS")), this.vars.onStart && (0 !== this._time || 0 === l) && (t || this._callback("onStart"))),
                            r = this._firstPT;
                        r;

                    )
                        r.f ? r.t[r.p](r.c * this.ratio + r.s) : (r.t[r.p] = r.c * this.ratio + r.s), (r = r._next);
                    this._onUpdate && (e < 0 && this._startAt && -1e-4 !== e && this._startAt.render(e, t, i), t || ((this._time !== o || a || i) && this._callback("onUpdate"))),
                        n &&
                            (!this._gc || i) &&
                            (e < 0 && this._startAt && !this._onUpdate && -1e-4 !== e && this._startAt.render(e, t, i),
                            a && (this._timeline.autoRemoveChildren && this._enabled(!1, !1), (this._active = !1)),
                            !t && this.vars[n] && this._callback(n),
                            0 === l && this._rawPrevTime === _ && s !== _ && (this._rawPrevTime = 0));
                }
            }),
            (r._kill = function (e, t, i) {
                if (("all" === e && (e = null), null == e && (null == t || t === this.target))) return (this._lazy = !1), this._enabled(!1, !1);
                t = "string" != typeof t ? t || this._targets || this.target : Q.selector(t) || t;
                var a,
                    n,
                    r,
                    s,
                    o,
                    l,
                    d,
                    c,
                    u,
                    h = i && this._time && i._startTime === this._startTime && this._timeline === i._timeline;
                if ((x(t) || M(t)) && "number" != typeof t[0]) for (a = t.length; -1 < --a; ) this._kill(e, t[a], i) && (l = !0);
                else {
                    if (this._targets) {
                        for (a = this._targets.length; -1 < --a; )
                            if (t === this._targets[a]) {
                                (o = this._propLookup[a] || {}), (this._overwrittenProps = this._overwrittenProps || []), (n = this._overwrittenProps[a] = e ? this._overwrittenProps[a] || {} : "all");
                                break;
                            }
                    } else {
                        if (t !== this.target) return !1;
                        (o = this._propLookup), (n = this._overwrittenProps = e ? this._overwrittenProps || {} : "all");
                    }
                    if (o) {
                        if (((d = e || o), (c = e !== n && "all" !== n && e !== o && ("object" != typeof e || !e._tempKill)), i && (Q.onOverwrite || this.vars.onOverwrite))) {
                            for (r in d) o[r] && (u || (u = []), u.push(r));
                            if ((u || !e) && !K(this, i, t, u)) return !1;
                        }
                        for (r in d)
                            (s = o[r]) &&
                                (h && (s.f ? s.t[s.p](s.s) : (s.t[s.p] = s.s), (l = !0)),
                                s.pg && s.t._kill(d) && (l = !0),
                                (s.pg && 0 !== s.t._overwriteProps.length) || (s._prev ? (s._prev._next = s._next) : s === this._firstPT && (this._firstPT = s._next), s._next && (s._next._prev = s._prev), (s._next = s._prev = null)),
                                delete o[r]),
                                c && (n[r] = 1);
                        !this._firstPT && this._initted && this._enabled(!1, !1);
                    }
                }
                return l;
            }),
            (r.invalidate = function () {
                return (
                    this._notifyPluginsOfEnabled && Q._onPluginEvent("_onDisable", this),
                    (this._firstPT = this._overwrittenProps = this._startAt = this._onUpdate = null),
                    (this._notifyPluginsOfEnabled = this._active = this._lazy = !1),
                    (this._propLookup = this._targets ? {} : []),
                    c.prototype.invalidate.call(this),
                    this.vars.immediateRender && ((this._time = -_), this.render(Math.min(0, -this._delay))),
                    this
                );
            }),
            (r._enabled = function (e, t) {
                if ((y || v.wake(), e && this._gc)) {
                    var i,
                        a = this._targets;
                    if (a) for (i = a.length; -1 < --i; ) this._siblings[i] = $(a[i], this, !0);
                    else this._siblings = $(this.target, this, !0);
                }
                return c.prototype._enabled.call(this, e, t), !(!this._notifyPluginsOfEnabled || !this._firstPT) && Q._onPluginEvent(e ? "_onEnable" : "_onDisable", this);
            }),
            (Q.to = function (e, t, i) {
                return new Q(e, t, i);
            }),
            (Q.from = function (e, t, i) {
                return (i.runBackwards = !0), (i.immediateRender = 0 != i.immediateRender), new Q(e, t, i);
            }),
            (Q.fromTo = function (e, t, i, a) {
                return (a.startAt = i), (a.immediateRender = 0 != a.immediateRender && 0 != i.immediateRender), new Q(e, t, a);
            }),
            (Q.delayedCall = function (e, t, i, a, n) {
                return new Q(t, 0, { delay: e, onComplete: t, onCompleteParams: i, callbackScope: a, onReverseComplete: t, onReverseCompleteParams: i, immediateRender: !1, lazy: !1, useFrames: n, overwrite: 0 });
            }),
            (Q.set = function (e, t) {
                return new Q(e, 0, t);
            }),
            (Q.getTweensOf = function (e, t) {
                if (null == e) return [];
                var i, a, n, r;
                if (((e = "string" != typeof e ? e : Q.selector(e) || e), (x(e) || M(e)) && "number" != typeof e[0])) {
                    for (i = e.length, a = []; -1 < --i; ) a = a.concat(Q.getTweensOf(e[i], t));
                    for (i = a.length; -1 < --i; ) for (r = a[i], n = i; -1 < --n; ) r === a[n] && a.splice(i, 1);
                } else for (i = (a = $(e).concat()).length; -1 < --i; ) (a[i]._gc || (t && !a[i].isActive())) && a.splice(i, 1);
                return a;
            }),
            (Q.killTweensOf = Q.killDelayedCallsTo = function (e, t, i) {
                "object" == typeof t && ((i = t), (t = !1));
                for (var a = Q.getTweensOf(e, t), n = a.length; -1 < --n; ) a[n]._kill(i, e);
            });
        var ie = h(
            "plugins.TweenPlugin",
            function (e, t) {
                (this._overwriteProps = (e || "").split(",")), (this._propName = this._overwriteProps[0]), (this._priority = t || 0), (this._super = ie.prototype);
            },
            !0
        );
        if (
            ((r = ie.prototype),
            (ie.version = "1.19.0"),
            (ie.API = 2),
            (r._firstPT = null),
            (r._addTween = H),
            (r.setRatio = E),
            (r._kill = function (e) {
                var t,
                    i = this._overwriteProps,
                    a = this._firstPT;
                if (null != e[this._propName]) this._overwriteProps = [];
                else for (t = i.length; -1 < --t; ) null != e[i[t]] && i.splice(t, 1);
                for (; a; ) null != e[a.n] && (a._next && (a._next._prev = a._prev), a._prev ? ((a._prev._next = a._next), (a._prev = null)) : this._firstPT === a && (this._firstPT = a._next)), (a = a._next);
                return !1;
            }),
            (r._mod = r._roundProps = function (e) {
                for (var t, i = this._firstPT; i; ) (t = e[this._propName] || (null != i.n && e[i.n.split(this._propName + "_").join("")])) && "function" == typeof t && (2 === i.f ? (i.t._applyPT.m = t) : (i.m = t)), (i = i._next);
            }),
            (Q._onPluginEvent = function (e, t) {
                var i,
                    a,
                    n,
                    r,
                    s,
                    o = t._firstPT;
                if ("_onInitAllProps" === e) {
                    for (; o; ) {
                        for (s = o._next, a = n; a && a.pr > o.pr; ) a = a._next;
                        (o._prev = a ? a._prev : r) ? (o._prev._next = o) : (n = o), (o._next = a) ? (a._prev = o) : (r = o), (o = s);
                    }
                    o = t._firstPT = n;
                }
                for (; o; ) o.pg && "function" == typeof o.t[e] && o.t[e]() && (i = !0), (o = o._next);
                return i;
            }),
            (ie.activate = function (e) {
                for (var t = e.length; -1 < --t; ) e[t].API === ie.API && (B[new e[t]()._propName] = e[t]);
                return !0;
            }),
            (s.plugin = function (e) {
                if (!(e && e.propName && e.init && e.API)) throw "illegal plugin definition.";
                var t,
                    i = e.propName,
                    a = e.priority || 0,
                    n = e.overwriteProps,
                    r = { init: "_onInitTween", set: "setRatio", kill: "_kill", round: "_mod", mod: "_mod", initAll: "_onInitAllProps" },
                    s = h(
                        "plugins." + i.charAt(0).toUpperCase() + i.substr(1) + "Plugin",
                        function () {
                            ie.call(this, i, a), (this._overwriteProps = n || []);
                        },
                        !0 === e.global
                    ),
                    o = (s.prototype = new ie(i));
                for (t in (((o.constructor = s).API = e.API), r)) "function" == typeof e[t] && (o[r[t]] = e[t]);
                return (s.version = e.version), ie.activate([s]), s;
            }),
            (e = p._gsQueue))
        ) {
            for (n = 0; n < e.length; n++) e[n]();
            for (r in T) T[r].func || p.console.log("GSAP encountered missing dependency: " + r);
        }
        y = !1;
    }
})("undefined" != typeof module && module.exports && "undefined" != typeof global ? global : this || window, "TweenLite");
var _gsScope = "undefined" != typeof module && module.exports && "undefined" != typeof global ? global : this || window;
(_gsScope._gsQueue || (_gsScope._gsQueue = [])).push(function () {
    "use strict";
    _gsScope._gsDefine(
        "TimelineLite",
        ["core.Animation", "core.SimpleTimeline", "TweenLite"],
        function (c, u, h) {
            var p = function (e) {
                    u.call(this, e),
                        (this._labels = {}),
                        (this.autoRemoveChildren = !0 === this.vars.autoRemoveChildren),
                        (this.smoothChildTiming = !0 === this.vars.smoothChildTiming),
                        (this._sortChildren = !0),
                        (this._onUpdate = this.vars.onUpdate);
                    var t,
                        i,
                        a = this.vars;
                    for (i in a) (t = a[i]), m(t) && -1 !== t.join("").indexOf("{self}") && (a[i] = this._swapSelfInParams(t));
                    m(a.tweens) && this.add(a.tweens, 0, a.align, a.stagger);
                },
                f = 1e-10,
                e = h._internals,
                t = (p._internals = {}),
                g = e.isSelector,
                m = e.isArray,
                v = e.lazyTweens,
                y = e.lazyRender,
                w = [],
                s = _gsScope._gsDefine.globals,
                _ = function (e) {
                    var t,
                        i = {};
                    for (t in e) i[t] = e[t];
                    return i;
                },
                r = (t.pauseCallback = function (e, t, i, a) {
                    var n,
                        r = e._timeline,
                        s = r._totalTime,
                        o = e._startTime,
                        l = e._rawPrevTime < 0 || (0 === e._rawPrevTime && r._reversed),
                        d = l ? 0 : f,
                        c = l ? f : 0;
                    if (t || !this._forcingPlayhead) {
                        for (r.pause(o), n = e._prev; n && n._startTime === o; ) (n._rawPrevTime = c), (n = n._prev);
                        for (n = e._next; n && n._startTime === o; ) (n._rawPrevTime = d), (n = n._next);
                        t && t.apply(a || r.vars.callbackScope || r, i || w), (this._forcingPlayhead || !r._paused) && r.seek(s);
                    }
                }),
                b = function (e) {
                    var t,
                        i = [],
                        a = e.length;
                    for (t = 0; t !== a; i.push(e[t++]));
                    return i;
                },
                i = (p.prototype = new u());
            return (
                (p.version = "1.17.0"),
                (i.constructor = p),
                (i.kill()._gc = i._forcingPlayhead = !1),
                (i.to = function (e, t, i, a) {
                    var n = (i.repeat && s.TweenMax) || h;
                    return t ? this.add(new n(e, t, i), a) : this.set(e, i, a);
                }),
                (i.from = function (e, t, i, a) {
                    return this.add(((i.repeat && s.TweenMax) || h).from(e, t, i), a);
                }),
                (i.fromTo = function (e, t, i, a, n) {
                    var r = (a.repeat && s.TweenMax) || h;
                    return t ? this.add(r.fromTo(e, t, i, a), n) : this.set(e, a, n);
                }),
                (i.staggerTo = function (e, t, i, a, n, r, s, o) {
                    var l,
                        d = new p({ onComplete: r, onCompleteParams: s, callbackScope: o, smoothChildTiming: this.smoothChildTiming });
                    for ("string" == typeof e && (e = h.selector(e) || e), g((e = e || [])) && (e = b(e)), (a = a || 0) < 0 && ((e = b(e)).reverse(), (a *= -1)), l = 0; e.length > l; l++)
                        i.startAt && (i.startAt = _(i.startAt)), d.to(e[l], t, _(i), l * a);
                    return this.add(d, n);
                }),
                (i.staggerFrom = function (e, t, i, a, n, r, s, o) {
                    return (i.immediateRender = 0 != i.immediateRender), (i.runBackwards = !0), this.staggerTo(e, t, i, a, n, r, s, o);
                }),
                (i.staggerFromTo = function (e, t, i, a, n, r, s, o, l) {
                    return (a.startAt = i), (a.immediateRender = 0 != a.immediateRender && 0 != i.immediateRender), this.staggerTo(e, t, a, n, r, s, o, l);
                }),
                (i.call = function (e, t, i, a) {
                    return this.add(h.delayedCall(0, e, t, i), a);
                }),
                (i.set = function (e, t, i) {
                    return (i = this._parseTimeOrLabel(i, 0, !0)), null == t.immediateRender && (t.immediateRender = i === this._time && !this._paused), this.add(new h(e, 0, t), i);
                }),
                (p.exportRoot = function (e, t) {
                    null == (e = e || {}).smoothChildTiming && (e.smoothChildTiming = !0);
                    var i,
                        a,
                        n = new p(e),
                        r = n._timeline;
                    for (null == t && (t = !0), r._remove(n, !0), n._startTime = 0, n._rawPrevTime = n._time = n._totalTime = r._time, i = r._first; i; )
                        (a = i._next), (t && i instanceof h && i.target === i.vars.onComplete) || n.add(i, i._startTime - i._delay), (i = a);
                    return r.add(n, 0), n;
                }),
                (i.add = function (e, t, i, a) {
                    var n, r, s, o, l, d;
                    if (("number" != typeof t && (t = this._parseTimeOrLabel(t, 0, !0, e)), !(e instanceof c))) {
                        if (e instanceof Array || (e && e.push && m(e))) {
                            for (i = i || "normal", a = a || 0, n = t, r = e.length, s = 0; s < r; s++)
                                m((o = e[s])) && (o = new p({ tweens: o })),
                                    this.add(o, n),
                                    "string" != typeof o && "function" != typeof o && ("sequence" === i ? (n = o._startTime + o.totalDuration() / o._timeScale) : "start" === i && (o._startTime -= o.delay())),
                                    (n += a);
                            return this._uncache(!0);
                        }
                        if ("string" == typeof e) return this.addLabel(e, t);
                        if ("function" != typeof e) throw "Cannot add " + e + " into the timeline; it is not a tween, timeline, function, or string.";
                        e = h.delayedCall(0, e);
                    }
                    if ((u.prototype.add.call(this, e, t), (this._gc || this._time === this._duration) && !this._paused && this._duration < this.duration()))
                        for (d = (l = this).rawTime() > e._startTime; l._timeline; ) d && l._timeline.smoothChildTiming ? l.totalTime(l._totalTime, !0) : l._gc && l._enabled(!0, !1), (l = l._timeline);
                    return this;
                }),
                (i.remove = function (e) {
                    if (e instanceof c) return this._remove(e, !1);
                    if (e instanceof Array || (e && e.push && m(e))) {
                        for (var t = e.length; -1 < --t; ) this.remove(e[t]);
                        return this;
                    }
                    return "string" == typeof e ? this.removeLabel(e) : this.kill(null, e);
                }),
                (i._remove = function (e, t) {
                    u.prototype._remove.call(this, e, t);
                    var i = this._last;
                    return (
                        i
                            ? this._time > i._startTime + i._totalDuration / i._timeScale && ((this._time = this.duration()), (this._totalTime = this._totalDuration))
                            : (this._time = this._totalTime = this._duration = this._totalDuration = 0),
                        this
                    );
                }),
                (i.append = function (e, t) {
                    return this.add(e, this._parseTimeOrLabel(null, t, !0, e));
                }),
                (i.insert = i.insertMultiple = function (e, t, i, a) {
                    return this.add(e, t || 0, i, a);
                }),
                (i.appendMultiple = function (e, t, i, a) {
                    return this.add(e, this._parseTimeOrLabel(null, t, !0, e), i, a);
                }),
                (i.addLabel = function (e, t) {
                    return (this._labels[e] = this._parseTimeOrLabel(t)), this;
                }),
                (i.addPause = function (e, t, i, a) {
                    var n = h.delayedCall(0, r, ["{self}", t, i, a], this);
                    return (n.data = "isPause"), this.add(n, e);
                }),
                (i.removeLabel = function (e) {
                    return delete this._labels[e], this;
                }),
                (i.getLabelTime = function (e) {
                    return null != this._labels[e] ? this._labels[e] : -1;
                }),
                (i._parseTimeOrLabel = function (e, t, i, a) {
                    var n;
                    if (a instanceof c && a.timeline === this) this.remove(a);
                    else if (a && (a instanceof Array || (a.push && m(a)))) for (n = a.length; -1 < --n; ) a[n] instanceof c && a[n].timeline === this && this.remove(a[n]);
                    if ("string" == typeof t) return this._parseTimeOrLabel(t, i && "number" == typeof e && null == this._labels[t] ? e - this.duration() : 0, i);
                    if (((t = t || 0), "string" != typeof e || (!isNaN(e) && null == this._labels[e]))) null == e && (e = this.duration());
                    else {
                        if (-1 === (n = e.indexOf("="))) return null == this._labels[e] ? (i ? (this._labels[e] = this.duration() + t) : t) : this._labels[e] + t;
                        (t = parseInt(e.charAt(n - 1) + "1", 10) * Number(e.substr(n + 1))), (e = 1 < n ? this._parseTimeOrLabel(e.substr(0, n - 1), 0, i) : this.duration());
                    }
                    return Number(e) + t;
                }),
                (i.seek = function (e, t) {
                    return this.totalTime("number" == typeof e ? e : this._parseTimeOrLabel(e), !1 !== t);
                }),
                (i.stop = function () {
                    return this.paused(!0);
                }),
                (i.gotoAndPlay = function (e, t) {
                    return this.play(e, t);
                }),
                (i.gotoAndStop = function (e, t) {
                    return this.pause(e, t);
                }),
                (i.render = function (e, t, i) {
                    this._gc && this._enabled(!0, !1);
                    var a,
                        n,
                        r,
                        s,
                        o,
                        l = this._dirty ? this.totalDuration() : this._totalDuration,
                        d = this._time,
                        c = this._startTime,
                        u = this._timeScale,
                        h = this._paused;
                    if (l <= e)
                        (this._totalTime = this._time = l),
                            this._reversed ||
                                this._hasPausedChild() ||
                                ((n = !0),
                                (s = "onComplete"),
                                (o = !!this._timeline.autoRemoveChildren),
                                0 === this._duration && (0 === e || this._rawPrevTime < 0 || this._rawPrevTime === f) && this._rawPrevTime !== e && this._first && ((o = !0), this._rawPrevTime > f && (s = "onReverseComplete"))),
                            (this._rawPrevTime = this._duration || !t || e || this._rawPrevTime === e ? e : f),
                            (e = l + 1e-4);
                    else if (e < 1e-7)
                        if (
                            ((this._totalTime = this._time = 0),
                            (0 !== d || (0 === this._duration && this._rawPrevTime !== f && (0 < this._rawPrevTime || (e < 0 && 0 <= this._rawPrevTime)))) && ((s = "onReverseComplete"), (n = this._reversed)),
                            e < 0)
                        )
                            (this._active = !1), this._timeline.autoRemoveChildren && this._reversed ? ((o = n = !0), (s = "onReverseComplete")) : 0 <= this._rawPrevTime && this._first && (o = !0), (this._rawPrevTime = e);
                        else {
                            if (((this._rawPrevTime = this._duration || !t || e || this._rawPrevTime === e ? e : f), 0 === e && n)) for (a = this._first; a && 0 === a._startTime; ) a._duration || (n = !1), (a = a._next);
                            (e = 0), this._initted || (o = !0);
                        }
                    else this._totalTime = this._time = this._rawPrevTime = e;
                    if ((this._time !== d && this._first) || i || o) {
                        if (
                            (this._initted || (this._initted = !0),
                            this._active || (!this._paused && this._time !== d && 0 < e && (this._active = !0)),
                            0 === d && this.vars.onStart && 0 !== this._time && (t || this._callback("onStart")),
                            this._time >= d)
                        )
                            for (a = this._first; a && ((r = a._next), !this._paused || h); )
                                (a._active || (a._startTime <= this._time && !a._paused && !a._gc)) &&
                                    (a._reversed ? a.render((a._dirty ? a.totalDuration() : a._totalDuration) - (e - a._startTime) * a._timeScale, t, i) : a.render((e - a._startTime) * a._timeScale, t, i)),
                                    (a = r);
                        else
                            for (a = this._last; a && ((r = a._prev), !this._paused || h); )
                                (a._active || (d >= a._startTime && !a._paused && !a._gc)) &&
                                    (a._reversed ? a.render((a._dirty ? a.totalDuration() : a._totalDuration) - (e - a._startTime) * a._timeScale, t, i) : a.render((e - a._startTime) * a._timeScale, t, i)),
                                    (a = r);
                        this._onUpdate && (t || (v.length && y(), this._callback("onUpdate"))),
                            s &&
                                (this._gc ||
                                    ((c === this._startTime || u !== this._timeScale) &&
                                        (0 === this._time || l >= this.totalDuration()) &&
                                        (n && (v.length && y(), this._timeline.autoRemoveChildren && this._enabled(!1, !1), (this._active = !1)), !t && this.vars[s] && this._callback(s))));
                    }
                }),
                (i._hasPausedChild = function () {
                    for (var e = this._first; e; ) {
                        if (e._paused || (e instanceof p && e._hasPausedChild())) return !0;
                        e = e._next;
                    }
                    return !1;
                }),
                (i.getChildren = function (e, t, i, a) {
                    a = a || -9999999999;
                    for (var n = [], r = this._first, s = 0; r; ) a > r._startTime || (r instanceof h ? !1 !== t && (n[s++] = r) : (!1 !== i && (n[s++] = r), !1 !== e && (s = (n = n.concat(r.getChildren(!0, t, i))).length))), (r = r._next);
                    return n;
                }),
                (i.getTweensOf = function (e, t) {
                    var i,
                        a,
                        n = this._gc,
                        r = [],
                        s = 0;
                    for (n && this._enabled(!0, !0), a = (i = h.getTweensOf(e)).length; -1 < --a; ) (i[a].timeline === this || (t && this._contains(i[a]))) && (r[s++] = i[a]);
                    return n && this._enabled(!1, !0), r;
                }),
                (i.recent = function () {
                    return this._recent;
                }),
                (i._contains = function (e) {
                    for (var t = e.timeline; t; ) {
                        if (t === this) return !0;
                        t = t.timeline;
                    }
                    return !1;
                }),
                (i.shiftChildren = function (e, t, i) {
                    i = i || 0;
                    for (var a, n = this._first, r = this._labels; n; ) n._startTime >= i && (n._startTime += e), (n = n._next);
                    if (t) for (a in r) r[a] >= i && (r[a] += e);
                    return this._uncache(!0);
                }),
                (i._kill = function (e, t) {
                    if (!e && !t) return this._enabled(!1, !1);
                    for (var i = t ? this.getTweensOf(t) : this.getChildren(!0, !0, !1), a = i.length, n = !1; -1 < --a; ) i[a]._kill(e, t) && (n = !0);
                    return n;
                }),
                (i.clear = function (e) {
                    var t = this.getChildren(!1, !0, !0),
                        i = t.length;
                    for (this._time = this._totalTime = 0; -1 < --i; ) t[i]._enabled(!1, !1);
                    return !1 !== e && (this._labels = {}), this._uncache(!0);
                }),
                (i.invalidate = function () {
                    for (var e = this._first; e; ) e.invalidate(), (e = e._next);
                    return c.prototype.invalidate.call(this);
                }),
                (i._enabled = function (e, t) {
                    if (e === this._gc) for (var i = this._first; i; ) i._enabled(e, !0), (i = i._next);
                    return u.prototype._enabled.call(this, e, t);
                }),
                (i.totalTime = function () {
                    this._forcingPlayhead = !0;
                    var e = c.prototype.totalTime.apply(this, arguments);
                    return (this._forcingPlayhead = !1), e;
                }),
                (i.duration = function (e) {
                    return arguments.length ? (0 !== this.duration() && 0 !== e && this.timeScale(this._duration / e), this) : (this._dirty && this.totalDuration(), this._duration);
                }),
                (i.totalDuration = function (e) {
                    if (arguments.length) return 0 !== this.totalDuration() && 0 !== e && this.timeScale(this._totalDuration / e), this;
                    if (this._dirty) {
                        for (var t, i, a = 0, n = this._last, r = 999999999999; n; )
                            (t = n._prev),
                                n._dirty && n.totalDuration(),
                                n._startTime > r && this._sortChildren && !n._paused ? this.add(n, n._startTime - n._delay) : (r = n._startTime),
                                n._startTime < 0 && !n._paused && ((a -= n._startTime), this._timeline.smoothChildTiming && (this._startTime += n._startTime / this._timeScale), this.shiftChildren(-n._startTime, !1, -9999999999), (r = 0)),
                                a < (i = n._startTime + n._totalDuration / n._timeScale) && (a = i),
                                (n = t);
                        (this._duration = this._totalDuration = a), (this._dirty = !1);
                    }
                    return this._totalDuration;
                }),
                (i.paused = function (e) {
                    if (!e) for (var t = this._first, i = this._time; t; ) t._startTime === i && "isPause" === t.data && (t._rawPrevTime = 0), (t = t._next);
                    return c.prototype.paused.apply(this, arguments);
                }),
                (i.usesFrames = function () {
                    for (var e = this._timeline; e._timeline; ) e = e._timeline;
                    return e === c._rootFramesTimeline;
                }),
                (i.rawTime = function () {
                    return this._paused ? this._totalTime : (this._timeline.rawTime() - this._startTime) * this._timeScale;
                }),
                p
            );
        },
        !0
    );
}),
    _gsScope._gsDefine && _gsScope._gsQueue.pop()(),
    (function (e) {
        "use strict";
        var t = function () {
            return (_gsScope.GreenSockGlobals || _gsScope).TimelineLite;
        };
        "function" == typeof define && define.amd ? define(["TweenLite"], t) : "undefined" != typeof module && module.exports && (require("./TweenLite.js"), (module.exports = t()));
    })();
var _gsScope = "undefined" != typeof module && module.exports && "undefined" != typeof global ? global : this || window;
(_gsScope._gsQueue || (_gsScope._gsQueue = [])).push(function () {
    "use strict";
    _gsScope._gsDefine(
        "easing.Back",
        ["easing.Ease"],
        function (m) {
            var t,
                i,
                e,
                a = _gsScope.GreenSockGlobals || _gsScope,
                n = a.com.greensock,
                r = 2 * Math.PI,
                s = Math.PI / 2,
                o = n._class,
                l = function (e, t) {
                    var i = o("easing." + e, function () {}, !0),
                        a = (i.prototype = new m());
                    return (a.constructor = i), (a.getRatio = t), i;
                },
                d = m.register || function () {},
                c = function (e, t, i, a, n) {
                    var r = o("easing." + e, { easeOut: new t(), easeIn: new i(), easeInOut: new a() }, !0);
                    return d(r, e), r;
                },
                v = function (e, t, i) {
                    (this.t = e), (this.v = t), i && ((((this.next = i).prev = this).c = i.v - t), (this.gap = i.t - e));
                },
                u = function (e, t) {
                    var i = o(
                            "easing." + e,
                            function (e) {
                                (this._p1 = e || 0 === e ? e : 1.70158), (this._p2 = 1.525 * this._p1);
                            },
                            !0
                        ),
                        a = (i.prototype = new m());
                    return (
                        (a.constructor = i),
                        (a.getRatio = t),
                        (a.config = function (e) {
                            return new i(e);
                        }),
                        i
                    );
                },
                h = c(
                    "Back",
                    u("BackOut", function (e) {
                        return (e -= 1) * e * ((this._p1 + 1) * e + this._p1) + 1;
                    }),
                    u("BackIn", function (e) {
                        return e * e * ((this._p1 + 1) * e - this._p1);
                    }),
                    u("BackInOut", function (e) {
                        return (e *= 2) < 1 ? 0.5 * e * e * ((this._p2 + 1) * e - this._p2) : 0.5 * ((e -= 2) * e * ((this._p2 + 1) * e + this._p2) + 2);
                    })
                ),
                p = o(
                    "easing.SlowMo",
                    function (e, t, i) {
                        (t = t || 0 === t ? t : 0.7), null == e ? (e = 0.7) : 1 < e && (e = 1), (this._p = 1 !== e ? t : 0), (this._p1 = (1 - e) / 2), (this._p2 = e), (this._p3 = this._p1 + this._p2), (this._calcEnd = !0 === i);
                    },
                    !0
                ),
                f = (p.prototype = new m());
            return (
                (f.constructor = p),
                (f.getRatio = function (e) {
                    var t = e + (0.5 - e) * this._p;
                    return e < this._p1
                        ? this._calcEnd
                            ? 1 - (e = 1 - e / this._p1) * e
                            : t - (e = 1 - e / this._p1) * e * e * e * t
                        : e > this._p3
                        ? this._calcEnd
                            ? 1 - (e = (e - this._p3) / this._p1) * e
                            : t + (e - t) * (e = (e - this._p3) / this._p1) * e * e * e
                        : this._calcEnd
                        ? 1
                        : t;
                }),
                (p.ease = new p(0.7, 0.7)),
                (f.config = p.config = function (e, t, i) {
                    return new p(e, t, i);
                }),
                ((f = (t = o(
                    "easing.SteppedEase",
                    function (e) {
                        (e = e || 1), (this._p1 = 1 / e), (this._p2 = e + 1);
                    },
                    !0
                )).prototype = new m()).constructor = t),
                (f.getRatio = function (e) {
                    return e < 0 ? (e = 0) : 1 <= e && (e = 0.999999999), ((this._p2 * e) >> 0) * this._p1;
                }),
                (f.config = t.config = function (e) {
                    return new t(e);
                }),
                ((f = (i = o(
                    "easing.RoughEase",
                    function (e) {
                        for (
                            var t,
                                i,
                                a,
                                n,
                                r,
                                s,
                                o = (e = e || {}).taper || "none",
                                l = [],
                                d = 0,
                                c = 0 | (e.points || 20),
                                u = c,
                                h = !1 !== e.randomize,
                                p = !0 === e.clamp,
                                f = e.template instanceof m ? e.template : null,
                                g = "number" == typeof e.strength ? 0.4 * e.strength : 0.4;
                            -1 < --u;

                        )
                            (t = h ? Math.random() : (1 / c) * u),
                                (i = f ? f.getRatio(t) : t),
                                (a = "none" === o ? g : "out" === o ? (n = 1 - t) * n * g : "in" === o ? t * t * g : (n = t < 0.5 ? 2 * t : 2 * (1 - t)) * n * 0.5 * g),
                                h ? (i += Math.random() * a - 0.5 * a) : u % 2 ? (i += 0.5 * a) : (i -= 0.5 * a),
                                p && (1 < i ? (i = 1) : i < 0 && (i = 0)),
                                (l[d++] = { x: t, y: i });
                        for (
                            l.sort(function (e, t) {
                                return e.x - t.x;
                            }),
                                s = new v(1, 1, null),
                                u = c;
                            -1 < --u;

                        )
                            (r = l[u]), (s = new v(r.x, r.y, s));
                        this._prev = new v(0, 0, 0 !== s.t ? s : s.next);
                    },
                    !0
                )).prototype = new m()).constructor = i),
                (f.getRatio = function (e) {
                    var t = this._prev;
                    if (e > t.t) {
                        for (; t.next && e >= t.t; ) t = t.next;
                        t = t.prev;
                    } else for (; t.prev && e <= t.t; ) t = t.prev;
                    return (this._prev = t).v + ((e - t.t) / t.gap) * t.c;
                }),
                (f.config = function (e) {
                    return new i(e);
                }),
                (i.ease = new i()),
                c(
                    "Bounce",
                    l("BounceOut", function (e) {
                        return e < 1 / 2.75 ? 7.5625 * e * e : e < 2 / 2.75 ? 7.5625 * (e -= 1.5 / 2.75) * e + 0.75 : e < 2.5 / 2.75 ? 7.5625 * (e -= 2.25 / 2.75) * e + 0.9375 : 7.5625 * (e -= 2.625 / 2.75) * e + 0.984375;
                    }),
                    l("BounceIn", function (e) {
                        return (e = 1 - e) < 1 / 2.75
                            ? 1 - 7.5625 * e * e
                            : e < 2 / 2.75
                            ? 1 - (7.5625 * (e -= 1.5 / 2.75) * e + 0.75)
                            : e < 2.5 / 2.75
                            ? 1 - (7.5625 * (e -= 2.25 / 2.75) * e + 0.9375)
                            : 1 - (7.5625 * (e -= 2.625 / 2.75) * e + 0.984375);
                    }),
                    l("BounceInOut", function (e) {
                        var t = e < 0.5;
                        return (
                            (e =
                                (e = t ? 1 - 2 * e : 2 * e - 1) < 1 / 2.75
                                    ? 7.5625 * e * e
                                    : e < 2 / 2.75
                                    ? 7.5625 * (e -= 1.5 / 2.75) * e + 0.75
                                    : e < 2.5 / 2.75
                                    ? 7.5625 * (e -= 2.25 / 2.75) * e + 0.9375
                                    : 7.5625 * (e -= 2.625 / 2.75) * e + 0.984375),
                            t ? 0.5 * (1 - e) : 0.5 * e + 0.5
                        );
                    })
                ),
                c(
                    "Circ",
                    l("CircOut", function (e) {
                        return Math.sqrt(1 - (e -= 1) * e);
                    }),
                    l("CircIn", function (e) {
                        return -(Math.sqrt(1 - e * e) - 1);
                    }),
                    l("CircInOut", function (e) {
                        return (e *= 2) < 1 ? -0.5 * (Math.sqrt(1 - e * e) - 1) : 0.5 * (Math.sqrt(1 - (e -= 2) * e) + 1);
                    })
                ),
                c(
                    "Elastic",
                    (e = function (e, t, i) {
                        var a = o(
                                "easing." + e,
                                function (e, t) {
                                    (this._p1 = 1 <= e ? e : 1), (this._p2 = (t || i) / (e < 1 ? e : 1)), (this._p3 = (this._p2 / r) * (Math.asin(1 / this._p1) || 0)), (this._p2 = r / this._p2);
                                },
                                !0
                            ),
                            n = (a.prototype = new m());
                        return (
                            (n.constructor = a),
                            (n.getRatio = t),
                            (n.config = function (e, t) {
                                return new a(e, t);
                            }),
                            a
                        );
                    })(
                        "ElasticOut",
                        function (e) {
                            return this._p1 * Math.pow(2, -10 * e) * Math.sin((e - this._p3) * this._p2) + 1;
                        },
                        0.3
                    ),
                    e(
                        "ElasticIn",
                        function (e) {
                            return -this._p1 * Math.pow(2, 10 * (e -= 1)) * Math.sin((e - this._p3) * this._p2);
                        },
                        0.3
                    ),
                    e(
                        "ElasticInOut",
                        function (e) {
                            return (e *= 2) < 1 ? this._p1 * Math.pow(2, 10 * (e -= 1)) * Math.sin((e - this._p3) * this._p2) * -0.5 : this._p1 * Math.pow(2, -10 * (e -= 1)) * Math.sin((e - this._p3) * this._p2) * 0.5 + 1;
                        },
                        0.45
                    )
                ),
                c(
                    "Expo",
                    l("ExpoOut", function (e) {
                        return 1 - Math.pow(2, -10 * e);
                    }),
                    l("ExpoIn", function (e) {
                        return Math.pow(2, 10 * (e - 1)) - 0.001;
                    }),
                    l("ExpoInOut", function (e) {
                        return (e *= 2) < 1 ? 0.5 * Math.pow(2, 10 * (e - 1)) : 0.5 * (2 - Math.pow(2, -10 * (e - 1)));
                    })
                ),
                c(
                    "Sine",
                    l("SineOut", function (e) {
                        return Math.sin(e * s);
                    }),
                    l("SineIn", function (e) {
                        return 1 - Math.cos(e * s);
                    }),
                    l("SineInOut", function (e) {
                        return -0.5 * (Math.cos(Math.PI * e) - 1);
                    })
                ),
                o(
                    "easing.EaseLookup",
                    {
                        find: function (e) {
                            return m.map[e];
                        },
                    },
                    !0
                ),
                d(a.SlowMo, "SlowMo", "ease,"),
                d(i, "RoughEase", "ease,"),
                d(t, "SteppedEase", "ease,"),
                h
            );
        },
        !0
    );
}),
    _gsScope._gsDefine && _gsScope._gsQueue.pop()(),
    (function () {
        "use strict";
        var e = function () {
            return _gsScope.GreenSockGlobals || _gsScope;
        };
        "function" == typeof define && define.amd ? define(["TweenLite"], e) : "undefined" != typeof module && module.exports && (require("../TweenLite.js"), (module.exports = e()));
    })();
var _gsScope = "undefined" != typeof module && module.exports && "undefined" != typeof global ? global : this || window;
(_gsScope._gsQueue || (_gsScope._gsQueue = [])).push(function () {
    "use strict";
    _gsScope._gsDefine(
        "plugins.CSSPlugin",
        ["plugins.TweenPlugin", "TweenLite"],
        function (r, N) {
            var f,
                C,
                S,
                g,
                H = function () {
                    r.call(this, "css"), (this._overwriteProps.length = 0), (this.setRatio = H.prototype.setRatio);
                },
                d = _gsScope._gsDefine.globals,
                m = {},
                e = (H.prototype = new r("css"));
            ((e.constructor = H).version = "1.19.1"),
                (H.API = 2),
                (H.defaultTransformPerspective = 0),
                (H.defaultSkewType = "compensated"),
                (H.defaultSmoothOrigin = !0),
                (e = "px"),
                (H.suffixMap = { top: e, right: e, bottom: e, left: e, width: e, height: e, fontSize: e, padding: e, margin: e, perspective: e, lineHeight: "" });
            var j,
                v,
                y,
                W,
                w,
                k,
                L,
                O,
                t,
                i,
                P = /(?:\-|\.|\b)(\d|\.|e\-)+/g,
                R = /(?:\d|\-\d|\.\d|\-\.\d|\+=\d|\-=\d|\+=.\d|\-=\.\d)+/g,
                _ = /(?:\+=|\-=|\-|\b)[\d\-\.]+[a-zA-Z0-9]*(?:%|\b)/gi,
                c = /(?![+-]?\d*\.?\d+|[+-]|e[+-]\d+)[^0-9]/g,
                I = /(?:\d|\-|\+|=|#|\.)*/g,
                A = /opacity *= *([^)]*)/i,
                b = /opacity:([^;]*)/i,
                s = /alpha\(opacity *=.+?\)/i,
                x = /^(rgb|hsl)/,
                o = /([A-Z])/g,
                l = /-([a-z])/gi,
                T = /(^(?:url\(\"|url\())|(?:(\"\))$|\)$)/gi,
                u = function (e, t) {
                    return t.toUpperCase();
                },
                p = /(?:Left|Right|Width)/i,
                h = /(M11|M12|M21|M22)=[\d\-\.e]+/gi,
                Q = /progid\:DXImageTransform\.Microsoft\.Matrix\(.+?\)/i,
                M = /,(?=[^\)]*(?:\(|$))/gi,
                z = /[\s,\(]/i,
                B = Math.PI / 180,
                V = 180 / Math.PI,
                D = {},
                a = { style: {} },
                F = _gsScope.document || {
                    createElement: function () {
                        return a;
                    },
                },
                E = function (e, t) {
                    return F.createElementNS ? F.createElementNS(t || "http://www.w3.org/1999/xhtml", e) : F.createElement(e);
                },
                Y = E("div"),
                X = E("img"),
                n = (H._internals = { _specialProps: m }),
                q = (_gsScope.navigator || {}).userAgent || "",
                U =
                    ((t = q.indexOf("Android")),
                    (i = E("a")),
                    (y = -1 !== q.indexOf("Safari") && -1 === q.indexOf("Chrome") && (-1 === t || 3 < parseFloat(q.substr(t + 8, 2)))),
                    (w = y && parseFloat(q.substr(q.indexOf("Version/") + 8, 2)) < 6),
                    (W = -1 !== q.indexOf("Firefox")),
                    (/MSIE ([0-9]{1,}[\.0-9]{0,})/.exec(q) || /Trident\/.*rv:([0-9]{1,}[\.0-9]{0,})/.exec(q)) && (k = parseFloat(RegExp.$1)),
                    !!i && ((i.style.cssText = "top:1px;opacity:.55;"), /^0.55/.test(i.style.opacity))),
                G = function (e) {
                    return A.test("string" == typeof e ? e : (e.currentStyle ? e.currentStyle.filter : e.style.filter) || "") ? parseFloat(RegExp.$1) / 100 : 1;
                },
                Z = function (e) {
                    _gsScope.console && console.log(e);
                },
                J = "",
                $ = "",
                K = function (e, t) {
                    var i,
                        a,
                        n = (t = t || Y).style;
                    if (void 0 !== n[e]) return e;
                    for (e = e.charAt(0).toUpperCase() + e.substr(1), i = ["O", "Moz", "ms", "Ms", "Webkit"], a = 5; -1 < --a && void 0 === n[i[a] + e]; );
                    return 0 <= a ? ((J = "-" + ($ = 3 === a ? "ms" : i[a]).toLowerCase() + "-"), $ + e) : null;
                },
                ee = F.defaultView ? F.defaultView.getComputedStyle : function () {},
                te = (H.getStyle = function (e, t, i, a, n) {
                    var r;
                    return U || "opacity" !== t
                        ? (!a && e.style[t] ? (r = e.style[t]) : (i = i || ee(e)) ? (r = i[t] || i.getPropertyValue(t) || i.getPropertyValue(t.replace(o, "-$1").toLowerCase())) : e.currentStyle && (r = e.currentStyle[t]),
                          null == n || (r && "none" !== r && "auto" !== r && "auto auto" !== r) ? r : n)
                        : G(e);
                }),
                ie = (n.convertToPixels = function (e, t, i, a, n) {
                    if ("px" === a || !a) return i;
                    if ("auto" === a || !i) return 0;
                    var r,
                        s,
                        o,
                        l = p.test(t),
                        d = e,
                        c = Y.style,
                        u = i < 0,
                        h = 1 === i;
                    if ((u && (i = -i), h && (i *= 100), "%" === a && -1 !== t.indexOf("border"))) r = (i / 100) * (l ? e.clientWidth : e.clientHeight);
                    else {
                        if (((c.cssText = "border:0 solid red;position:" + te(e, "position") + ";line-height:0;"), "%" !== a && d.appendChild && "v" !== a.charAt(0) && "rem" !== a)) c[l ? "borderLeftWidth" : "borderTopWidth"] = i + a;
                        else {
                            if (((s = (d = e.parentNode || F.body)._gsCache), (o = N.ticker.frame), s && l && s.time === o)) return (s.width * i) / 100;
                            c[l ? "width" : "height"] = i + a;
                        }
                        d.appendChild(Y),
                            (r = parseFloat(Y[l ? "offsetWidth" : "offsetHeight"])),
                            d.removeChild(Y),
                            l && "%" === a && !1 !== H.cacheWidths && (((s = d._gsCache = d._gsCache || {}).time = o), (s.width = (r / i) * 100)),
                            0 !== r || n || (r = ie(e, t, i, a, !0));
                    }
                    return h && (r /= 100), u ? -r : r;
                }),
                ae = (n.calculateOffset = function (e, t, i) {
                    if ("absolute" !== te(e, "position", i)) return 0;
                    var a = "left" === t ? "Left" : "Top",
                        n = te(e, "margin" + a, i);
                    return e["offset" + a] - (ie(e, t, parseFloat(n), n.replace(I, "")) || 0);
                }),
                ne = function (e, t) {
                    var i,
                        a,
                        n,
                        r = {};
                    if ((t = t || ee(e, null)))
                        if ((i = t.length)) for (; -1 < --i; ) (-1 === (n = t[i]).indexOf("-transform") || Me === n) && (r[n.replace(l, u)] = t.getPropertyValue(n));
                        else for (i in t) (-1 === i.indexOf("Transform") || Qe === i) && (r[i] = t[i]);
                    else if ((t = e.currentStyle || e.style)) for (i in t) "string" == typeof i && void 0 === r[i] && (r[i.replace(l, u)] = t[i]);
                    return (
                        U || (r.opacity = G(e)),
                        (a = Ue(e, t, !1)),
                        (r.rotation = a.rotation),
                        (r.skewX = a.skewX),
                        (r.scaleX = a.scaleX),
                        (r.scaleY = a.scaleY),
                        (r.x = a.x),
                        (r.y = a.y),
                        De && ((r.z = a.z), (r.rotationX = a.rotationX), (r.rotationY = a.rotationY), (r.scaleZ = a.scaleZ)),
                        r.filters && delete r.filters,
                        r
                    );
                },
                re = function (e, t, i, a, n) {
                    var r,
                        s,
                        o,
                        l = {},
                        d = e.style;
                    for (s in i)
                        "cssText" !== s &&
                            "length" !== s &&
                            isNaN(s) &&
                            (t[s] !== (r = i[s]) || (n && n[s])) &&
                            -1 === s.indexOf("Origin") &&
                            ("number" == typeof r || "string" == typeof r) &&
                            ((l[s] = "auto" !== r || ("left" !== s && "top" !== s) ? (("" !== r && "auto" !== r && "none" !== r) || "string" != typeof t[s] || "" === t[s].replace(c, "") ? r : 0) : ae(e, s)),
                            void 0 !== d[s] && (o = new _e(d, s, d[s], o)));
                    if (a) for (s in a) "className" !== s && (l[s] = a[s]);
                    return { difs: l, firstMPT: o };
                },
                se = { width: ["Left", "Right"], height: ["Top", "Bottom"] },
                oe = ["marginLeft", "marginRight", "marginTop", "marginBottom"],
                le = function (e, t, i) {
                    if ("svg" === (e.nodeName + "").toLowerCase()) return (i || ee(e))[t] || 0;
                    if (e.getCTM && Ye(e)) return e.getBBox()[t] || 0;
                    var a = parseFloat("width" === t ? e.offsetWidth : e.offsetHeight),
                        n = se[t],
                        r = n.length;
                    for (i = i || ee(e, null); -1 < --r; ) (a -= parseFloat(te(e, "padding" + n[r], i, !0)) || 0), (a -= parseFloat(te(e, "border" + n[r] + "Width", i, !0)) || 0);
                    return a;
                },
                de = function (e, t) {
                    if ("contain" === e || "auto" === e || "auto auto" === e) return e + " ";
                    (null == e || "" === e) && (e = "0 0");
                    var i,
                        a = e.split(" "),
                        n = -1 !== e.indexOf("left") ? "0%" : -1 !== e.indexOf("right") ? "100%" : a[0],
                        r = -1 !== e.indexOf("top") ? "0%" : -1 !== e.indexOf("bottom") ? "100%" : a[1];
                    if (3 < a.length && !t) {
                        for (a = e.split(", ").join(",").split(","), e = [], i = 0; i < a.length; i++) e.push(de(a[i]));
                        return e.join(",");
                    }
                    return (
                        null == r ? (r = "center" === n ? "50%" : "0") : "center" === r && (r = "50%"),
                        ("center" === n || (isNaN(parseFloat(n)) && -1 === (n + "").indexOf("="))) && (n = "50%"),
                        (e = n + " " + r + (2 < a.length ? " " + a[2] : "")),
                        t &&
                            ((t.oxp = -1 !== n.indexOf("%")),
                            (t.oyp = -1 !== r.indexOf("%")),
                            (t.oxr = "=" === n.charAt(1)),
                            (t.oyr = "=" === r.charAt(1)),
                            (t.ox = parseFloat(n.replace(c, ""))),
                            (t.oy = parseFloat(r.replace(c, ""))),
                            (t.v = e)),
                        t || e
                    );
                },
                ce = function (e, t) {
                    return "function" == typeof e && (e = e(O, L)), "string" == typeof e && "=" === e.charAt(1) ? parseInt(e.charAt(0) + "1", 10) * parseFloat(e.substr(2)) : parseFloat(e) - parseFloat(t) || 0;
                },
                ue = function (e, t) {
                    return "function" == typeof e && (e = e(O, L)), null == e ? t : "string" == typeof e && "=" === e.charAt(1) ? parseInt(e.charAt(0) + "1", 10) * parseFloat(e.substr(2)) + t : parseFloat(e) || 0;
                },
                he = function (e, t, i, a) {
                    var n, r, s, o, l;
                    return (
                        "function" == typeof e && (e = e(O, L)),
                        (o =
                            null == e
                                ? t
                                : "number" == typeof e
                                ? e
                                : ((n = 360),
                                  (r = e.split("_")),
                                  (s = ((l = "=" === e.charAt(1)) ? parseInt(e.charAt(0) + "1", 10) * parseFloat(r[0].substr(2)) : parseFloat(r[0])) * (-1 === e.indexOf("rad") ? 1 : V) - (l ? 0 : t)),
                                  r.length &&
                                      (a && (a[i] = t + s),
                                      -1 !== e.indexOf("short") && (s %= n) !== s % 180 && (s = s < 0 ? s + n : s - n),
                                      -1 !== e.indexOf("_cw") && s < 0 ? (s = ((s + 3599999999640) % n) - ((s / n) | 0) * n) : -1 !== e.indexOf("ccw") && 0 < s && (s = ((s - 3599999999640) % n) - ((s / n) | 0) * n)),
                                  t + s)) < 1e-6 &&
                            -1e-6 < o &&
                            (o = 0),
                        o
                    );
                },
                pe = {
                    aqua: [0, 255, 255],
                    lime: [0, 255, 0],
                    silver: [192, 192, 192],
                    black: [0, 0, 0],
                    maroon: [128, 0, 0],
                    teal: [0, 128, 128],
                    blue: [0, 0, 255],
                    navy: [0, 0, 128],
                    white: [255, 255, 255],
                    fuchsia: [255, 0, 255],
                    olive: [128, 128, 0],
                    yellow: [255, 255, 0],
                    orange: [255, 165, 0],
                    gray: [128, 128, 128],
                    purple: [128, 0, 128],
                    green: [0, 128, 0],
                    red: [255, 0, 0],
                    pink: [255, 192, 203],
                    cyan: [0, 255, 255],
                    transparent: [255, 255, 255, 0],
                },
                fe = function (e, t, i) {
                    return (255 * (6 * (e = e < 0 ? e + 1 : 1 < e ? e - 1 : e) < 1 ? t + (i - t) * e * 6 : e < 0.5 ? i : 3 * e < 2 ? t + (i - t) * (2 / 3 - e) * 6 : t) + 0.5) | 0;
                },
                ge = (H.parseColor = function (e, t) {
                    var i, a, n, r, s, o, l, d, c, u, h;
                    if (e)
                        if ("number" == typeof e) i = [e >> 16, (e >> 8) & 255, 255 & e];
                        else {
                            if (("," === e.charAt(e.length - 1) && (e = e.substr(0, e.length - 1)), pe[e])) i = pe[e];
                            else if ("#" === e.charAt(0)) 4 === e.length && (e = "#" + (a = e.charAt(1)) + a + (n = e.charAt(2)) + n + (r = e.charAt(3)) + r), (i = [(e = parseInt(e.substr(1), 16)) >> 16, (e >> 8) & 255, 255 & e]);
                            else if ("hsl" === e.substr(0, 3))
                                if (((i = h = e.match(P)), t)) {
                                    if (-1 !== e.indexOf("=")) return e.match(R);
                                } else
                                    (s = (Number(i[0]) % 360) / 360),
                                        (o = Number(i[1]) / 100),
                                        (a = 2 * (l = Number(i[2]) / 100) - (n = l <= 0.5 ? l * (o + 1) : l + o - l * o)),
                                        3 < i.length && (i[3] = Number(e[3])),
                                        (i[0] = fe(s + 1 / 3, a, n)),
                                        (i[1] = fe(s, a, n)),
                                        (i[2] = fe(s - 1 / 3, a, n));
                            else i = e.match(P) || pe.transparent;
                            (i[0] = Number(i[0])), (i[1] = Number(i[1])), (i[2] = Number(i[2])), 3 < i.length && (i[3] = Number(i[3]));
                        }
                    else i = pe.black;
                    return (
                        t &&
                            !h &&
                            ((a = i[0] / 255),
                            (n = i[1] / 255),
                            (r = i[2] / 255),
                            (l = ((d = Math.max(a, n, r)) + (c = Math.min(a, n, r))) / 2),
                            d === c ? (s = o = 0) : ((u = d - c), (o = 0.5 < l ? u / (2 - d - c) : u / (d + c)), (s = d === a ? (n - r) / u + (n < r ? 6 : 0) : d === n ? (r - a) / u + 2 : (a - n) / u + 4), (s *= 60)),
                            (i[0] = (s + 0.5) | 0),
                            (i[1] = (100 * o + 0.5) | 0),
                            (i[2] = (100 * l + 0.5) | 0)),
                        i
                    );
                }),
                me = function (e, t) {
                    var i,
                        a,
                        n,
                        r = e.match(ve) || [],
                        s = 0,
                        o = r.length ? "" : e;
                    for (i = 0; i < r.length; i++)
                        (a = r[i]),
                            (s += (n = e.substr(s, e.indexOf(a, s) - s)).length + a.length),
                            3 === (a = ge(a, t)).length && a.push(1),
                            (o += n + (t ? "hsla(" + a[0] + "," + a[1] + "%," + a[2] + "%," + a[3] : "rgba(" + a.join(",")) + ")");
                    return o + e.substr(s);
                },
                ve = "(?:\\b(?:(?:rgb|rgba|hsl|hsla)\\(.+?\\))|\\B#(?:[0-9a-f]{3}){1,2}\\b";
            for (e in pe) ve += "|" + e + "\\b";
            (ve = new RegExp(ve + ")", "gi")),
                (H.colorStringFilter = function (e) {
                    var t,
                        i = e[0] + e[1];
                    ve.test(i) && ((t = -1 !== i.indexOf("hsl(") || -1 !== i.indexOf("hsla(")), (e[0] = me(e[0], t)), (e[1] = me(e[1], t))), (ve.lastIndex = 0);
                }),
                N.defaultStringFilter || (N.defaultStringFilter = H.colorStringFilter);
            var ye = function (e, t, r, s) {
                    if (null == e)
                        return function (e) {
                            return e;
                        };
                    var o,
                        l = t ? (e.match(ve) || [""])[0] : "",
                        d = e.split(l).join("").match(_) || [],
                        c = e.substr(0, e.indexOf(d[0])),
                        u = ")" === e.charAt(e.length - 1) ? ")" : "",
                        h = -1 !== e.indexOf(" ") ? " " : ",",
                        p = d.length,
                        f = 0 < p ? d[0].replace(P, "") : "";
                    return p
                        ? (o = t
                              ? function (e) {
                                    var t, i, a, n;
                                    if ("number" == typeof e) e += f;
                                    else if (s && M.test(e)) {
                                        for (n = e.replace(M, "|").split("|"), a = 0; a < n.length; a++) n[a] = o(n[a]);
                                        return n.join(",");
                                    }
                                    if (((t = (e.match(ve) || [l])[0]), (a = (i = e.split(t).join("").match(_) || []).length), p > a--)) for (; ++a < p; ) i[a] = r ? i[((a - 1) / 2) | 0] : d[a];
                                    return c + i.join(h) + h + t + u + (-1 !== e.indexOf("inset") ? " inset" : "");
                                }
                              : function (e) {
                                    var t, i, a;
                                    if ("number" == typeof e) e += f;
                                    else if (s && M.test(e)) {
                                        for (i = e.replace(M, "|").split("|"), a = 0; a < i.length; a++) i[a] = o(i[a]);
                                        return i.join(",");
                                    }
                                    if (((a = (t = e.match(_) || []).length), p > a--)) for (; ++a < p; ) t[a] = r ? t[((a - 1) / 2) | 0] : d[a];
                                    return c + t.join(h) + u;
                                })
                        : function (e) {
                              return e;
                          };
                },
                we = function (d) {
                    return (
                        (d = d.split(",")),
                        function (e, t, i, a, n, r, s) {
                            var o,
                                l = (t + "").split(" ");
                            for (s = {}, o = 0; o < 4; o++) s[d[o]] = l[o] = l[o] || l[((o - 1) / 2) >> 0];
                            return a.parse(e, s, n, r);
                        }
                    );
                },
                _e =
                    ((n._setPluginRatio = function (e) {
                        this.plugin.setRatio(e);
                        for (var t, i, a, n, r, s = this.data, o = s.proxy, l = s.firstMPT; l; ) (t = o[l.v]), l.r ? (t = Math.round(t)) : t < 1e-6 && -1e-6 < t && (t = 0), (l.t[l.p] = t), (l = l._next);
                        if ((s.autoRotate && (s.autoRotate.rotation = s.mod ? s.mod(o.rotation, this.t) : o.rotation), 1 === e || 0 === e))
                            for (l = s.firstMPT, r = 1 === e ? "e" : "b"; l; ) {
                                if ((i = l.t).type) {
                                    if (1 === i.type) {
                                        for (n = i.xs0 + i.s + i.xs1, a = 1; a < i.l; a++) n += i["xn" + a] + i["xs" + (a + 1)];
                                        i[r] = n;
                                    }
                                } else i[r] = i.s + i.xs0;
                                l = l._next;
                            }
                    }),
                    function (e, t, i, a, n) {
                        (this.t = e), (this.p = t), (this.v = i), (this.r = n), a && ((a._prev = this)._next = a);
                    }),
                be =
                    ((n._parseToProxy = function (e, t, i, a, n, r) {
                        var s,
                            o,
                            l,
                            d,
                            c,
                            u = a,
                            h = {},
                            p = {},
                            f = i._transform,
                            g = D;
                        for (i._transform = null, D = t, a = c = i.parse(e, t, a, n), D = g, r && ((i._transform = f), u && ((u._prev = null), u._prev && (u._prev._next = null))); a && a !== u; ) {
                            if (a.type <= 1 && ((p[(o = a.p)] = a.s + a.c), (h[o] = a.s), r || ((d = new _e(a, "s", o, d, a.r)), (a.c = 0)), 1 === a.type))
                                for (s = a.l; 0 < --s; ) (l = "xn" + s), (p[(o = a.p + "_" + l)] = a.data[l]), (h[o] = a[l]), r || (d = new _e(a, l, o, d, a.rxp[l]));
                            a = a._next;
                        }
                        return { proxy: h, end: p, firstMPT: d, pt: c };
                    }),
                    (n.CSSPropTween = function (e, t, i, a, n, r, s, o, l, d, c) {
                        (this.t = e),
                            (this.p = t),
                            (this.s = i),
                            (this.c = a),
                            (this.n = s || t),
                            e instanceof be || g.push(this.n),
                            (this.r = o),
                            (this.type = r || 0),
                            l && ((this.pr = l), (f = !0)),
                            (this.b = void 0 === d ? i : d),
                            (this.e = void 0 === c ? i + a : c),
                            n && ((this._next = n)._prev = this);
                    })),
                xe = function (e, t, i, a, n, r) {
                    var s = new be(e, t, i, a - i, n, -1, r);
                    return (s.b = i), (s.e = s.xs0 = a), s;
                },
                Te = (H.parseComplex = function (e, t, i, a, n, r, s, o, l, d) {
                    (i = i || r || ""), "function" == typeof a && (a = a(O, L)), (s = new be(e, t, 0, 0, s, d ? 2 : 1, null, !1, o, i, a)), (a += ""), n && ve.test(a + i) && ((a = [i, a]), H.colorStringFilter(a), (i = a[0]), (a = a[1]));
                    var c,
                        u,
                        h,
                        p,
                        f,
                        g,
                        m,
                        v,
                        y,
                        w,
                        _,
                        b,
                        x,
                        T = i.split(", ").join(",").split(" "),
                        C = a.split(", ").join(",").split(" "),
                        k = T.length,
                        S = !1 !== j;
                    for (
                        (-1 !== a.indexOf(",") || -1 !== i.indexOf(",")) && ((T = T.join(" ").replace(M, ", ").split(" ")), (C = C.join(" ").replace(M, ", ").split(" ")), (k = T.length)),
                            k !== C.length && (k = (T = (r || "").split(" ")).length),
                            s.plugin = l,
                            s.setRatio = d,
                            c = ve.lastIndex = 0;
                        c < k;
                        c++
                    )
                        if (((p = T[c]), (f = C[c]), (v = parseFloat(p)) || 0 === v)) s.appendXtra("", v, ce(f, v), f.replace(R, ""), S && -1 !== f.indexOf("px"), !0);
                        else if (n && ve.test(p))
                            (b = ")" + ((b = f.indexOf(")") + 1) ? f.substr(b) : "")),
                                (x = -1 !== f.indexOf("hsl") && U),
                                (p = ge(p, x)),
                                (f = ge(f, x)),
                                (y = 6 < p.length + f.length) && !U && 0 === f[3]
                                    ? ((s["xs" + s.l] += s.l ? " transparent" : "transparent"), (s.e = s.e.split(C[c]).join("transparent")))
                                    : (U || (y = !1),
                                      x
                                          ? s
                                                .appendXtra(y ? "hsla(" : "hsl(", p[0], ce(f[0], p[0]), ",", !1, !0)
                                                .appendXtra("", p[1], ce(f[1], p[1]), "%,", !1)
                                                .appendXtra("", p[2], ce(f[2], p[2]), y ? "%," : "%" + b, !1)
                                          : s
                                                .appendXtra(y ? "rgba(" : "rgb(", p[0], f[0] - p[0], ",", !0, !0)
                                                .appendXtra("", p[1], f[1] - p[1], ",", !0)
                                                .appendXtra("", p[2], f[2] - p[2], y ? "," : b, !0),
                                      y && ((p = p.length < 4 ? 1 : p[3]), s.appendXtra("", p, (f.length < 4 ? 1 : f[3]) - p, b, !1))),
                                (ve.lastIndex = 0);
                        else if ((g = p.match(P))) {
                            if (!(m = f.match(R)) || m.length !== g.length) return s;
                            for (u = h = 0; u < g.length; u++) (_ = g[u]), (w = p.indexOf(_, h)), s.appendXtra(p.substr(h, w - h), Number(_), ce(m[u], _), "", S && "px" === p.substr(w + _.length, 2), 0 === u), (h = w + _.length);
                            s["xs" + s.l] += p.substr(h);
                        } else s["xs" + s.l] += s.l || s["xs" + s.l] ? " " + f : f;
                    if (-1 !== a.indexOf("=") && s.data) {
                        for (b = s.xs0 + s.data.s, c = 1; c < s.l; c++) b += s["xs" + c] + s.data["xn" + c];
                        s.e = b + s["xs" + c];
                    }
                    return s.l || ((s.type = -1), (s.xs0 = s.e)), s.xfirst || s;
                }),
                Ce = 9;
            for ((e = be.prototype).l = e.pr = 0; 0 < --Ce; ) (e["xn" + Ce] = 0), (e["xs" + Ce] = "");
            (e.xs0 = ""),
                (e._next = e._prev = e.xfirst = e.data = e.plugin = e.setRatio = e.rxp = null),
                (e.appendXtra = function (e, t, i, a, n, r) {
                    var s = this,
                        o = s.l;
                    return (
                        (s["xs" + o] += r && (o || s["xs" + o]) ? " " + e : e || ""),
                        i || 0 === o || s.plugin
                            ? (s.l++,
                              (s.type = s.setRatio ? 2 : 1),
                              (s["xs" + s.l] = a || ""),
                              0 < o
                                  ? ((s.data["xn" + o] = t + i), (s.rxp["xn" + o] = n), (s["xn" + o] = t), s.plugin || ((s.xfirst = new be(s, "xn" + o, t, i, s.xfirst || s, 0, s.n, n, s.pr)), (s.xfirst.xs0 = 0)))
                                  : ((s.data = { s: t + i }), (s.rxp = {}), (s.s = t), (s.c = i), (s.r = n)))
                            : (s["xs" + o] += t + (a || "")),
                        s
                    );
                });
            var ke = function (e, t) {
                    (t = t || {}),
                        (this.p = (t.prefix && K(e)) || e),
                        (m[e] = m[this.p] = this),
                        (this.format = t.formatter || ye(t.defaultValue, t.color, t.collapsible, t.multi)),
                        t.parser && (this.parse = t.parser),
                        (this.clrs = t.color),
                        (this.multi = t.multi),
                        (this.keyword = t.keyword),
                        (this.dflt = t.defaultValue),
                        (this.pr = t.priority || 0);
                },
                Se = (n._registerComplexSpecialProp = function (e, t, i) {
                    "object" != typeof t && (t = { parser: i });
                    var a,
                        n = e.split(","),
                        r = t.defaultValue;
                    for (i = i || [r], a = 0; a < n.length; a++) (t.prefix = 0 === a && t.prefix), (t.defaultValue = i[a] || r), new ke(n[a], t);
                }),
                je = (n._registerPluginProp = function (e) {
                    if (!m[e]) {
                        var l = e.charAt(0).toUpperCase() + e.substr(1) + "Plugin";
                        Se(e, {
                            parser: function (e, t, i, a, n, r, s) {
                                var o = d.com.greensock.plugins[l];
                                return o ? (o._cssRegister(), m[i].parse(e, t, i, a, n, r, s)) : (Z("Error: " + l + " js file not loaded."), n);
                            },
                        });
                    }
                });
            ((e = ke.prototype).parseComplex = function (e, t, i, a, n, r) {
                var s,
                    o,
                    l,
                    d,
                    c,
                    u,
                    h = this.keyword;
                if ((this.multi && (M.test(i) || M.test(t) ? ((o = t.replace(M, "|").split("|")), (l = i.replace(M, "|").split("|"))) : h && ((o = [t]), (l = [i]))), l)) {
                    for (d = l.length > o.length ? l.length : o.length, s = 0; s < d; s++)
                        (t = o[s] = o[s] || this.dflt), (i = l[s] = l[s] || this.dflt), h && (c = t.indexOf(h)) !== (u = i.indexOf(h)) && (-1 === u ? (o[s] = o[s].split(h).join("")) : -1 === c && (o[s] += " " + h));
                    (t = o.join(", ")), (i = l.join(", "));
                }
                return Te(e, this.p, t, i, this.clrs, this.dflt, a, this.pr, n, r);
            }),
                (e.parse = function (e, t, i, a, n, r, s) {
                    return this.parseComplex(e.style, this.format(te(e, this.p, S, !1, this.dflt)), this.format(t), n, r);
                }),
                (H.registerSpecialProp = function (e, l, d) {
                    Se(e, {
                        parser: function (e, t, i, a, n, r, s) {
                            var o = new be(e, i, 0, 0, n, 2, i, !1, d);
                            return (o.plugin = r), (o.setRatio = l(e, t, a._tween, i)), o;
                        },
                        priority: d,
                    });
                }),
                (H.useSVGTransformAttr = !0);
            var Le,
                Oe,
                Pe,
                Re,
                Ie,
                Ae = "scaleX,scaleY,scaleZ,x,y,z,skewX,skewY,rotation,rotationX,rotationY,perspective,xPercent,yPercent".split(","),
                Qe = K("transform"),
                Me = J + "transform",
                ze = K("transformOrigin"),
                De = null !== K("perspective"),
                Fe = (n.Transform = function () {
                    (this.perspective = parseFloat(H.defaultTransformPerspective) || 0), (this.force3D = !(!1 === H.defaultForce3D || !De) && (H.defaultForce3D || "auto"));
                }),
                Ee = _gsScope.SVGElement,
                Ne = function (e, t, i) {
                    var a,
                        n = F.createElementNS("http://www.w3.org/2000/svg", e),
                        r = /([a-z])([A-Z])/g;
                    for (a in i) n.setAttributeNS(null, a.replace(r, "$1-$2").toLowerCase(), i[a]);
                    return t.appendChild(n), n;
                },
                He = F.documentElement || {},
                We =
                    ((Ie = k || (/Android/i.test(q) && !_gsScope.chrome)),
                    F.createElementNS &&
                        !Ie &&
                        ((Oe = Ne("svg", He)),
                        (Re = (Pe = Ne("rect", Oe, { width: 100, height: 50, x: 100 })).getBoundingClientRect().width),
                        (Pe.style[ze] = "50% 50%"),
                        (Pe.style[Qe] = "scaleX(0.5)"),
                        (Ie = Re === Pe.getBoundingClientRect().width && !(W && De)),
                        He.removeChild(Oe)),
                    Ie),
                Be = function (e, t, i, a, n, r) {
                    var s,
                        o,
                        l,
                        d,
                        c,
                        u,
                        h,
                        p,
                        f,
                        g,
                        m,
                        v,
                        y,
                        w,
                        _ = e._gsTransform,
                        b = qe(e, !0);
                    _ && ((y = _.xOrigin), (w = _.yOrigin)),
                        (!a || (s = a.split(" ")).length < 2) &&
                            (0 === (h = e.getBBox()).x &&
                                0 === h.y &&
                                h.width + h.height === 0 &&
                                (h = {
                                    x: parseFloat(e.hasAttribute("x") ? e.getAttribute("x") : e.hasAttribute("cx") ? e.getAttribute("cx") : 0) || 0,
                                    y: parseFloat(e.hasAttribute("y") ? e.getAttribute("y") : e.hasAttribute("cy") ? e.getAttribute("cy") : 0) || 0,
                                    width: 0,
                                    height: 0,
                                }),
                            (s = [(-1 !== (t = de(t).split(" "))[0].indexOf("%") ? (parseFloat(t[0]) / 100) * h.width : parseFloat(t[0])) + h.x, (-1 !== t[1].indexOf("%") ? (parseFloat(t[1]) / 100) * h.height : parseFloat(t[1])) + h.y])),
                        (i.xOrigin = d = parseFloat(s[0])),
                        (i.yOrigin = c = parseFloat(s[1])),
                        a &&
                            b !== Xe &&
                            ((u = b[0]),
                            (h = b[1]),
                            (p = b[2]),
                            (f = b[3]),
                            (g = b[4]),
                            (m = b[5]),
                            (v = u * f - h * p) && ((o = d * (f / v) + c * (-p / v) + (p * m - f * g) / v), (l = d * (-h / v) + c * (u / v) - (u * m - h * g) / v), (d = i.xOrigin = s[0] = o), (c = i.yOrigin = s[1] = l))),
                        _ &&
                            (r && ((i.xOffset = _.xOffset), (i.yOffset = _.yOffset), (_ = i)),
                            n || (!1 !== n && !1 !== H.defaultSmoothOrigin) ? ((o = d - y), (l = c - w), (_.xOffset += o * b[0] + l * b[2] - o), (_.yOffset += o * b[1] + l * b[3] - l)) : (_.xOffset = _.yOffset = 0)),
                        r || e.setAttribute("data-svg-origin", s.join(" "));
                },
                Ve = function (e) {
                    var t,
                        i = E("svg", this.ownerSVGElement.getAttribute("xmlns") || "http://www.w3.org/2000/svg"),
                        a = this.parentNode,
                        n = this.nextSibling,
                        r = this.style.cssText;
                    if ((He.appendChild(i), i.appendChild(this), (this.style.display = "block"), e))
                        try {
                            (t = this.getBBox()), (this._originalGetBBox = this.getBBox), (this.getBBox = Ve);
                        } catch (e) {}
                    else this._originalGetBBox && (t = this._originalGetBBox());
                    return n ? a.insertBefore(this, n) : a.appendChild(this), He.removeChild(i), (this.style.cssText = r), t;
                },
                Ye = function (e) {
                    return !(
                        !(
                            Ee &&
                            e.getCTM &&
                            (function (t) {
                                try {
                                    return t.getBBox();
                                } catch (e) {
                                    return Ve.call(t, !0);
                                }
                            })(e)
                        ) ||
                        (e.parentNode && !e.ownerSVGElement)
                    );
                },
                Xe = [1, 0, 0, 1, 0, 0],
                qe = function (e, t) {
                    var i,
                        a,
                        n,
                        r,
                        s,
                        o,
                        l = e._gsTransform || new Fe(),
                        d = e.style;
                    if (
                        (Qe
                            ? (a = te(e, Me, null, !0))
                            : e.currentStyle && (a = (a = e.currentStyle.filter.match(h)) && 4 === a.length ? [a[0].substr(4), Number(a[2].substr(4)), Number(a[1].substr(4)), a[3].substr(4), l.x || 0, l.y || 0].join(",") : ""),
                        (i = !a || "none" === a || "matrix(1, 0, 0, 1, 0, 0)" === a) &&
                            Qe &&
                            ((o = "none" === ee(e).display) || !e.parentNode) &&
                            (o && ((r = d.display), (d.display = "block")),
                            e.parentNode || ((s = 1), He.appendChild(e)),
                            (i = !(a = te(e, Me, null, !0)) || "none" === a || "matrix(1, 0, 0, 1, 0, 0)" === a),
                            r ? (d.display = r) : o && $e(d, "display"),
                            s && He.removeChild(e)),
                        (l.svg || (e.getCTM && Ye(e))) &&
                            (i && -1 !== (d[Qe] + "").indexOf("matrix") && ((a = d[Qe]), (i = 0)),
                            (n = e.getAttribute("transform")),
                            i && n && (-1 !== n.indexOf("matrix") ? ((a = n), (i = 0)) : -1 !== n.indexOf("translate") && ((a = "matrix(1,0,0,1," + n.match(/(?:\-|\b)[\d\-\.e]+\b/gi).join(",") + ")"), (i = 0)))),
                        i)
                    )
                        return Xe;
                    for (n = (a || "").match(P) || [], Ce = n.length; -1 < --Ce; ) (r = Number(n[Ce])), (n[Ce] = (s = r - (r |= 0)) ? ((1e5 * s + (s < 0 ? -0.5 : 0.5)) | 0) / 1e5 + r : r);
                    return t && 6 < n.length ? [n[0], n[1], n[4], n[5], n[12], n[13]] : n;
                },
                Ue = (n.getTransform = function (e, t, i, a) {
                    if (e._gsTransform && i && !a) return e._gsTransform;
                    var n,
                        r,
                        s,
                        o,
                        l,
                        d,
                        c = (i && e._gsTransform) || new Fe(),
                        u = c.scaleX < 0,
                        h = (De && (parseFloat(te(e, ze, t, !1, "0 0 0").split(" ")[2]) || c.zOrigin)) || 0,
                        p = parseFloat(H.defaultTransformPerspective) || 0;
                    if (((c.svg = !(!e.getCTM || !Ye(e))), c.svg && (Be(e, te(e, ze, t, !1, "50% 50%") + "", c, e.getAttribute("data-svg-origin")), (Le = H.useSVGTransformAttr || We)), (n = qe(e)) !== Xe)) {
                        if (16 === n.length) {
                            var f,
                                g,
                                m,
                                v,
                                y,
                                w = n[0],
                                _ = n[1],
                                b = n[2],
                                x = n[3],
                                T = n[4],
                                C = n[5],
                                k = n[6],
                                S = n[7],
                                j = n[8],
                                L = n[9],
                                O = n[10],
                                P = n[12],
                                R = n[13],
                                I = n[14],
                                A = n[11],
                                Q = Math.atan2(k, O);
                            c.zOrigin && ((P = j * (I = -c.zOrigin) - n[12]), (R = L * I - n[13]), (I = O * I + c.zOrigin - n[14])),
                                (c.rotationX = Q * V),
                                Q &&
                                    ((f = T * (v = Math.cos(-Q)) + j * (y = Math.sin(-Q))),
                                    (g = C * v + L * y),
                                    (m = k * v + O * y),
                                    (j = T * -y + j * v),
                                    (L = C * -y + L * v),
                                    (O = k * -y + O * v),
                                    (A = S * -y + A * v),
                                    (T = f),
                                    (C = g),
                                    (k = m)),
                                (Q = Math.atan2(-b, O)),
                                (c.rotationY = Q * V),
                                Q && ((g = _ * (v = Math.cos(-Q)) - L * (y = Math.sin(-Q))), (m = b * v - O * y), (L = _ * y + L * v), (O = b * y + O * v), (A = x * y + A * v), (w = f = w * v - j * y), (_ = g), (b = m)),
                                (Q = Math.atan2(_, w)),
                                (c.rotation = Q * V),
                                Q && ((w = w * (v = Math.cos(-Q)) + T * (y = Math.sin(-Q))), (g = _ * v + C * y), (C = _ * -y + C * v), (k = b * -y + k * v), (_ = g)),
                                c.rotationX && 359.9 < Math.abs(c.rotationX) + Math.abs(c.rotation) && ((c.rotationX = c.rotation = 0), (c.rotationY = 180 - c.rotationY)),
                                (c.scaleX = ((1e5 * Math.sqrt(w * w + _ * _) + 0.5) | 0) / 1e5),
                                (c.scaleY = ((1e5 * Math.sqrt(C * C + L * L) + 0.5) | 0) / 1e5),
                                (c.scaleZ = ((1e5 * Math.sqrt(k * k + O * O) + 0.5) | 0) / 1e5),
                                c.rotationX || c.rotationY
                                    ? (c.skewX = 0)
                                    : ((c.skewX = T || C ? Math.atan2(T, C) * V + c.rotation : c.skewX || 0),
                                      90 < Math.abs(c.skewX) &&
                                          Math.abs(c.skewX) < 270 &&
                                          (u ? ((c.scaleX *= -1), (c.skewX += c.rotation <= 0 ? 180 : -180), (c.rotation += c.rotation <= 0 ? 180 : -180)) : ((c.scaleY *= -1), (c.skewX += c.skewX <= 0 ? 180 : -180)))),
                                (c.perspective = A ? 1 / (A < 0 ? -A : A) : 0),
                                (c.x = P),
                                (c.y = R),
                                (c.z = I),
                                c.svg && ((c.x -= c.xOrigin - (c.xOrigin * w - c.yOrigin * T)), (c.y -= c.yOrigin - (c.yOrigin * _ - c.xOrigin * C)));
                        } else if (!De || a || !n.length || c.x !== n[4] || c.y !== n[5] || (!c.rotationX && !c.rotationY)) {
                            var M = 6 <= n.length,
                                z = M ? n[0] : 1,
                                D = n[1] || 0,
                                F = n[2] || 0,
                                E = M ? n[3] : 1;
                            (c.x = n[4] || 0),
                                (c.y = n[5] || 0),
                                (s = Math.sqrt(z * z + D * D)),
                                (o = Math.sqrt(E * E + F * F)),
                                (l = z || D ? Math.atan2(D, z) * V : c.rotation || 0),
                                (d = F || E ? Math.atan2(F, E) * V + l : c.skewX || 0),
                                90 < Math.abs(d) && Math.abs(d) < 270 && (u ? ((s *= -1), (d += l <= 0 ? 180 : -180), (l += l <= 0 ? 180 : -180)) : ((o *= -1), (d += d <= 0 ? 180 : -180))),
                                (c.scaleX = s),
                                (c.scaleY = o),
                                (c.rotation = l),
                                (c.skewX = d),
                                De && ((c.rotationX = c.rotationY = c.z = 0), (c.perspective = p), (c.scaleZ = 1)),
                                c.svg && ((c.x -= c.xOrigin - (c.xOrigin * z + c.yOrigin * F)), (c.y -= c.yOrigin - (c.xOrigin * D + c.yOrigin * E)));
                        }
                        for (r in ((c.zOrigin = h), c)) c[r] < 2e-5 && -2e-5 < c[r] && (c[r] = 0);
                    }
                    return (
                        i &&
                            (e._gsTransform = c).svg &&
                            (Le && e.style[Qe]
                                ? N.delayedCall(0.001, function () {
                                      $e(e.style, Qe);
                                  })
                                : !Le &&
                                  e.getAttribute("transform") &&
                                  N.delayedCall(0.001, function () {
                                      e.removeAttribute("transform");
                                  })),
                        c
                    );
                }),
                Ge = function (e) {
                    var t,
                        i,
                        a = this.data,
                        n = -a.rotation * B,
                        r = n + a.skewX * B,
                        s = 1e5,
                        o = ((Math.cos(n) * a.scaleX * s) | 0) / s,
                        l = ((Math.sin(n) * a.scaleX * s) | 0) / s,
                        d = ((Math.sin(r) * -a.scaleY * s) | 0) / s,
                        c = ((Math.cos(r) * a.scaleY * s) | 0) / s,
                        u = this.t.style,
                        h = this.t.currentStyle;
                    if (h) {
                        (i = l), (l = -d), (d = -i), (t = h.filter), (u.filter = "");
                        var p,
                            f,
                            g = this.t.offsetWidth,
                            m = this.t.offsetHeight,
                            v = "absolute" !== h.position,
                            y = "progid:DXImageTransform.Microsoft.Matrix(M11=" + o + ", M12=" + l + ", M21=" + d + ", M22=" + c,
                            w = a.x + (g * a.xPercent) / 100,
                            _ = a.y + (m * a.yPercent) / 100;
                        if (
                            (null != a.ox && ((w += (p = (a.oxp ? g * a.ox * 0.01 : a.ox) - g / 2) - (p * o + (f = (a.oyp ? m * a.oy * 0.01 : a.oy) - m / 2) * l)), (_ += f - (p * d + f * c))),
                            v ? (y += ", Dx=" + ((p = g / 2) - (p * o + (f = m / 2) * l) + w) + ", Dy=" + (f - (p * d + f * c) + _) + ")") : (y += ", sizingMethod='auto expand')"),
                            -1 !== t.indexOf("DXImageTransform.Microsoft.Matrix(") ? (u.filter = t.replace(Q, y)) : (u.filter = y + " " + t),
                            (0 === e || 1 === e) &&
                                1 === o &&
                                0 === l &&
                                0 === d &&
                                1 === c &&
                                ((v && -1 === y.indexOf("Dx=0, Dy=0")) || (A.test(t) && 100 !== parseFloat(RegExp.$1)) || (-1 === t.indexOf(t.indexOf("Alpha")) && u.removeAttribute("filter"))),
                            !v)
                        ) {
                            var b,
                                x,
                                T,
                                C = k < 8 ? 1 : -1;
                            for (
                                p = a.ieOffsetX || 0,
                                    f = a.ieOffsetY || 0,
                                    a.ieOffsetX = Math.round((g - ((o < 0 ? -o : o) * g + (l < 0 ? -l : l) * m)) / 2 + w),
                                    a.ieOffsetY = Math.round((m - ((c < 0 ? -c : c) * m + (d < 0 ? -d : d) * g)) / 2 + _),
                                    Ce = 0;
                                Ce < 4;
                                Ce++
                            )
                                (T =
                                    (i = -1 !== (b = h[(x = oe[Ce])]).indexOf("px") ? parseFloat(b) : ie(this.t, x, parseFloat(b), b.replace(I, "")) || 0) !== a[x]
                                        ? Ce < 2
                                            ? -a.ieOffsetX
                                            : -a.ieOffsetY
                                        : Ce < 2
                                        ? p - a.ieOffsetX
                                        : f - a.ieOffsetY),
                                    (u[x] = (a[x] = Math.round(i - T * (0 === Ce || 2 === Ce ? 1 : C))) + "px");
                        }
                    }
                },
                Ze = (n.set3DTransformRatio = n.setTransformRatio = function (e) {
                    var t,
                        i,
                        a,
                        n,
                        r,
                        s,
                        o,
                        l,
                        d,
                        c,
                        u,
                        h,
                        p,
                        f,
                        g,
                        m,
                        v,
                        y,
                        w,
                        _,
                        b,
                        x,
                        T,
                        C = this.data,
                        k = this.t.style,
                        S = C.rotation,
                        j = C.rotationX,
                        L = C.rotationY,
                        O = C.scaleX,
                        P = C.scaleY,
                        R = C.scaleZ,
                        I = C.x,
                        A = C.y,
                        Q = C.z,
                        M = C.svg,
                        z = C.perspective,
                        D = C.force3D,
                        F = C.skewY,
                        E = C.skewX;
                    if ((F && ((E += F), (S += F)), !((((1 !== e && 0 !== e) || "auto" !== D || (this.tween._totalTime !== this.tween._totalDuration && this.tween._totalTime)) && D) || Q || z || L || j || 1 !== R) || (Le && M) || !De))
                        S || E || M
                            ? ((S *= B),
                              (x = E * B),
                              (T = 1e5),
                              (i = Math.cos(S) * O),
                              (r = Math.sin(S) * O),
                              (a = Math.sin(S - x) * -P),
                              (s = Math.cos(S - x) * P),
                              x && "simple" === C.skewType && ((t = Math.tan(x - F * B)), (a *= t = Math.sqrt(1 + t * t)), (s *= t), F && ((t = Math.tan(F * B)), (i *= t = Math.sqrt(1 + t * t)), (r *= t))),
                              M &&
                                  ((I += C.xOrigin - (C.xOrigin * i + C.yOrigin * a) + C.xOffset),
                                  (A += C.yOrigin - (C.xOrigin * r + C.yOrigin * s) + C.yOffset),
                                  Le && (C.xPercent || C.yPercent) && ((g = this.t.getBBox()), (I += 0.01 * C.xPercent * g.width), (A += 0.01 * C.yPercent * g.height)),
                                  I < (g = 1e-6) && -g < I && (I = 0),
                                  A < g && -g < A && (A = 0)),
                              (w = ((i * T) | 0) / T + "," + ((r * T) | 0) / T + "," + ((a * T) | 0) / T + "," + ((s * T) | 0) / T + "," + I + "," + A + ")"),
                              M && Le ? this.t.setAttribute("transform", "matrix(" + w) : (k[Qe] = (C.xPercent || C.yPercent ? "translate(" + C.xPercent + "%," + C.yPercent + "%) matrix(" : "matrix(") + w))
                            : (k[Qe] = (C.xPercent || C.yPercent ? "translate(" + C.xPercent + "%," + C.yPercent + "%) matrix(" : "matrix(") + O + ",0,0," + P + "," + I + "," + A + ")");
                    else {
                        if ((W && (O < (g = 1e-4) && -g < O && (O = R = 2e-5), P < g && -g < P && (P = R = 2e-5), !z || C.z || C.rotationX || C.rotationY || (z = 0)), S || E))
                            (S *= B),
                                (m = i = Math.cos(S)),
                                (v = r = Math.sin(S)),
                                E &&
                                    ((S -= E * B),
                                    (m = Math.cos(S)),
                                    (v = Math.sin(S)),
                                    "simple" === C.skewType && ((t = Math.tan((E - F) * B)), (m *= t = Math.sqrt(1 + t * t)), (v *= t), C.skewY && ((t = Math.tan(F * B)), (i *= t = Math.sqrt(1 + t * t)), (r *= t)))),
                                (a = -v),
                                (s = m);
                        else {
                            if (!(L || j || 1 !== R || z || M))
                                return void (k[Qe] =
                                    (C.xPercent || C.yPercent ? "translate(" + C.xPercent + "%," + C.yPercent + "%) translate3d(" : "translate3d(") +
                                    I +
                                    "px," +
                                    A +
                                    "px," +
                                    Q +
                                    "px)" +
                                    (1 !== O || 1 !== P ? " scale(" + O + "," + P + ")" : ""));
                            (i = s = 1), (a = r = 0);
                        }
                        (c = 1),
                            (n = o = l = d = u = h = 0),
                            (p = z ? -1 / z : 0),
                            (f = C.zOrigin),
                            (g = 1e-6),
                            (_ = ","),
                            (b = "0"),
                            (S = L * B) && ((m = Math.cos(S)), (u = p * (l = -(v = Math.sin(S)))), (n = i * v), (o = r * v), (p *= c = m), (i *= m), (r *= m)),
                            (S = j * B) && ((t = a * (m = Math.cos(S)) + n * (v = Math.sin(S))), (y = s * m + o * v), (d = c * v), (h = p * v), (n = a * -v + n * m), (o = s * -v + o * m), (c *= m), (p *= m), (a = t), (s = y)),
                            1 !== R && ((n *= R), (o *= R), (c *= R), (p *= R)),
                            1 !== P && ((a *= P), (s *= P), (d *= P), (h *= P)),
                            1 !== O && ((i *= O), (r *= O), (l *= O), (u *= O)),
                            (f || M) &&
                                (f && ((I += n * -f), (A += o * -f), (Q += c * -f + f)),
                                M && ((I += C.xOrigin - (C.xOrigin * i + C.yOrigin * a) + C.xOffset), (A += C.yOrigin - (C.xOrigin * r + C.yOrigin * s) + C.yOffset)),
                                I < g && -g < I && (I = b),
                                A < g && -g < A && (A = b),
                                Q < g && -g < Q && (Q = 0)),
                            (w = C.xPercent || C.yPercent ? "translate(" + C.xPercent + "%," + C.yPercent + "%) matrix3d(" : "matrix3d("),
                            (w += (i < g && -g < i ? b : i) + _ + (r < g && -g < r ? b : r) + _ + (l < g && -g < l ? b : l)),
                            (w += _ + (u < g && -g < u ? b : u) + _ + (a < g && -g < a ? b : a) + _ + (s < g && -g < s ? b : s)),
                            j || L || 1 !== R
                                ? ((w += _ + (d < g && -g < d ? b : d) + _ + (h < g && -g < h ? b : h) + _ + (n < g && -g < n ? b : n)),
                                  (w += _ + (o < g && -g < o ? b : o) + _ + (c < g && -g < c ? b : c) + _ + (p < g && -g < p ? b : p) + _))
                                : (w += ",0,0,0,0,1,0,"),
                            (w += I + _ + A + _ + Q + _ + (z ? 1 + -Q / z : 1) + ")"),
                            (k[Qe] = w);
                    }
                });
            ((e = Fe.prototype).x = e.y = e.z = e.skewX = e.skewY = e.rotation = e.rotationX = e.rotationY = e.zOrigin = e.xPercent = e.yPercent = e.xOffset = e.yOffset = 0),
                (e.scaleX = e.scaleY = e.scaleZ = 1),
                Se(
                    "transform,scale,scaleX,scaleY,scaleZ,x,y,z,rotation,rotationX,rotationY,rotationZ,skewX,skewY,shortRotation,shortRotationX,shortRotationY,shortRotationZ,transformOrigin,svgOrigin,transformPerspective,directionalRotation,parseTransform,force3D,skewType,xPercent,yPercent,smoothOrigin",
                    {
                        parser: function (e, t, i, a, n, r, s) {
                            if (a._lastParsedTransform === s) return n;
                            var o,
                                l = (a._lastParsedTransform = s).scale && "function" == typeof s.scale ? s.scale : 0;
                            "function" == typeof s[i] && ((o = s[i]), (s[i] = t)), l && (s.scale = l(O, e));
                            var d,
                                c,
                                u,
                                h,
                                p,
                                f,
                                g,
                                m,
                                v,
                                y = e._gsTransform,
                                w = e.style,
                                _ = Ae.length,
                                b = s,
                                x = {},
                                T = "transformOrigin",
                                C = Ue(e, S, !0, b.parseTransform),
                                k = b.transform && ("function" == typeof b.transform ? b.transform(O, L) : b.transform);
                            if (((a._transform = C), k && "string" == typeof k && Qe))
                                ((c = Y.style)[Qe] = k),
                                    (c.display = "block"),
                                    (c.position = "absolute"),
                                    F.body.appendChild(Y),
                                    (d = Ue(Y, null, !1)),
                                    C.svg &&
                                        ((f = C.xOrigin),
                                        (g = C.yOrigin),
                                        (d.x -= C.xOffset),
                                        (d.y -= C.yOffset),
                                        (b.transformOrigin || b.svgOrigin) &&
                                            ((k = {}), Be(e, de(b.transformOrigin), k, b.svgOrigin, b.smoothOrigin, !0), (f = k.xOrigin), (g = k.yOrigin), (d.x -= k.xOffset - C.xOffset), (d.y -= k.yOffset - C.yOffset)),
                                        (f || g) && ((m = qe(Y, !0)), (d.x -= f - (f * m[0] + g * m[2])), (d.y -= g - (f * m[1] + g * m[3])))),
                                    F.body.removeChild(Y),
                                    d.perspective || (d.perspective = C.perspective),
                                    null != b.xPercent && (d.xPercent = ue(b.xPercent, C.xPercent)),
                                    null != b.yPercent && (d.yPercent = ue(b.yPercent, C.yPercent));
                            else if ("object" == typeof b) {
                                if (
                                    ((d = {
                                        scaleX: ue(null != b.scaleX ? b.scaleX : b.scale, C.scaleX),
                                        scaleY: ue(null != b.scaleY ? b.scaleY : b.scale, C.scaleY),
                                        scaleZ: ue(b.scaleZ, C.scaleZ),
                                        x: ue(b.x, C.x),
                                        y: ue(b.y, C.y),
                                        z: ue(b.z, C.z),
                                        xPercent: ue(b.xPercent, C.xPercent),
                                        yPercent: ue(b.yPercent, C.yPercent),
                                        perspective: ue(b.transformPerspective, C.perspective),
                                    }),
                                    null != (p = b.directionalRotation))
                                )
                                    if ("object" == typeof p) for (c in p) b[c] = p[c];
                                    else b.rotation = p;
                                "string" == typeof b.x && -1 !== b.x.indexOf("%") && ((d.x = 0), (d.xPercent = ue(b.x, C.xPercent))),
                                    "string" == typeof b.y && -1 !== b.y.indexOf("%") && ((d.y = 0), (d.yPercent = ue(b.y, C.yPercent))),
                                    (d.rotation = he("rotation" in b ? b.rotation : "shortRotation" in b ? b.shortRotation + "_short" : "rotationZ" in b ? b.rotationZ : C.rotation, C.rotation, "rotation", x)),
                                    De &&
                                        ((d.rotationX = he("rotationX" in b ? b.rotationX : "shortRotationX" in b ? b.shortRotationX + "_short" : C.rotationX || 0, C.rotationX, "rotationX", x)),
                                        (d.rotationY = he("rotationY" in b ? b.rotationY : "shortRotationY" in b ? b.shortRotationY + "_short" : C.rotationY || 0, C.rotationY, "rotationY", x))),
                                    (d.skewX = he(b.skewX, C.skewX)),
                                    (d.skewY = he(b.skewY, C.skewY));
                            }
                            for (
                                De && null != b.force3D && ((C.force3D = b.force3D), (h = !0)),
                                    C.skewType = b.skewType || C.skewType || H.defaultSkewType,
                                    (u = C.force3D || C.z || C.rotationX || C.rotationY || d.z || d.rotationX || d.rotationY || d.perspective) || null == b.scale || (d.scaleZ = 1);
                                -1 < --_;

                            )
                                (1e-6 < (k = d[(v = Ae[_])] - C[v]) || k < -1e-6 || null != b[v] || null != D[v]) &&
                                    ((h = !0), (n = new be(C, v, C[v], k, n)), v in x && (n.e = x[v]), (n.xs0 = 0), (n.plugin = r), a._overwriteProps.push(n.n));
                            return (
                                (k = b.transformOrigin),
                                C.svg &&
                                    (k || b.svgOrigin) &&
                                    ((f = C.xOffset),
                                    (g = C.yOffset),
                                    Be(e, de(k), d, b.svgOrigin, b.smoothOrigin),
                                    (n = xe(C, "xOrigin", (y ? C : d).xOrigin, d.xOrigin, n, T)),
                                    (n = xe(C, "yOrigin", (y ? C : d).yOrigin, d.yOrigin, n, T)),
                                    (f !== C.xOffset || g !== C.yOffset) && ((n = xe(C, "xOffset", y ? f : C.xOffset, C.xOffset, n, T)), (n = xe(C, "yOffset", y ? g : C.yOffset, C.yOffset, n, T))),
                                    (k = "0px 0px")),
                                (k || (De && u && C.zOrigin)) &&
                                    (Qe
                                        ? ((h = !0),
                                          (v = ze),
                                          (k = (k || te(e, v, S, !1, "50% 50%")) + ""),
                                          ((n = new be(w, v, 0, 0, n, -1, T)).b = w[v]),
                                          (n.plugin = r),
                                          (n.xs0 = n.e = De
                                              ? ((c = C.zOrigin),
                                                (k = k.split(" ")),
                                                (C.zOrigin = (2 < k.length && (0 === c || "0px" !== k[2]) ? parseFloat(k[2]) : c) || 0),
                                                (n.xs0 = n.e = k[0] + " " + (k[1] || "50%") + " 0px"),
                                                ((n = new be(C, "zOrigin", 0, 0, n, -1, n.n)).b = c),
                                                C.zOrigin)
                                              : k))
                                        : de(k + "", C)),
                                h && (a._transformType = (C.svg && Le) || (!u && 3 !== this._transformType) ? 2 : 3),
                                o && (s[i] = o),
                                l && (s.scale = l),
                                n
                            );
                        },
                        prefix: !0,
                    }
                ),
                Se("boxShadow", { defaultValue: "0px 0px 0px 0px #999", prefix: !0, color: !0, multi: !0, keyword: "inset" }),
                Se("borderRadius", {
                    defaultValue: "0px",
                    parser: function (e, t, i, a, n, r) {
                        t = this.format(t);
                        var s,
                            o,
                            l,
                            d,
                            c,
                            u,
                            h,
                            p,
                            f,
                            g,
                            m,
                            v,
                            y,
                            w,
                            _,
                            b,
                            x = ["borderTopLeftRadius", "borderTopRightRadius", "borderBottomRightRadius", "borderBottomLeftRadius"],
                            T = e.style;
                        for (f = parseFloat(e.offsetWidth), g = parseFloat(e.offsetHeight), s = t.split(" "), o = 0; o < x.length; o++)
                            this.p.indexOf("border") && (x[o] = K(x[o])),
                                -1 !== (c = d = te(e, x[o], S, !1, "0px")).indexOf(" ") && ((c = (d = c.split(" "))[0]), (d = d[1])),
                                (u = l = s[o]),
                                (h = parseFloat(c)),
                                (v = c.substr((h + "").length)),
                                "" ===
                                    (m = (y = "=" === u.charAt(1))
                                        ? ((p = parseInt(u.charAt(0) + "1", 10)), (u = u.substr(2)), (p *= parseFloat(u)), u.substr((p + "").length - (p < 0 ? 1 : 0)) || "")
                                        : ((p = parseFloat(u)), u.substr((p + "").length))) && (m = C[i] || v),
                                m !== v &&
                                    ((w = ie(e, "borderLeft", h, v)),
                                    (_ = ie(e, "borderTop", h, v)),
                                    (d = "%" === m ? ((c = (w / f) * 100 + "%"), (_ / g) * 100 + "%") : "em" === m ? ((c = w / (b = ie(e, "borderLeft", 1, "em")) + "em"), _ / b + "em") : ((c = w + "px"), _ + "px")),
                                    y && ((u = parseFloat(c) + p + m), (l = parseFloat(d) + p + m))),
                                (n = Te(T, x[o], c + " " + d, u + " " + l, !1, "0px", n));
                        return n;
                    },
                    prefix: !0,
                    formatter: ye("0px 0px 0px 0px", !1, !0),
                }),
                Se("borderBottomLeftRadius,borderBottomRightRadius,borderTopLeftRadius,borderTopRightRadius", {
                    defaultValue: "0px",
                    parser: function (e, t, i, a, n, r) {
                        return Te(e.style, i, this.format(te(e, i, S, !1, "0px 0px")), this.format(t), !1, "0px", n);
                    },
                    prefix: !0,
                    formatter: ye("0px 0px", !1, !0),
                }),
                Se("backgroundPosition", {
                    defaultValue: "0 0",
                    parser: function (e, t, i, a, n, r) {
                        var s,
                            o,
                            l,
                            d,
                            c,
                            u,
                            h = "background-position",
                            p = S || ee(e, null),
                            f = this.format((p ? (k ? p.getPropertyValue(h + "-x") + " " + p.getPropertyValue(h + "-y") : p.getPropertyValue(h)) : e.currentStyle.backgroundPositionX + " " + e.currentStyle.backgroundPositionY) || "0 0"),
                            g = this.format(t);
                        if ((-1 !== f.indexOf("%")) != (-1 !== g.indexOf("%")) && g.split(",").length < 2 && (u = te(e, "backgroundImage").replace(T, "")) && "none" !== u) {
                            for (s = f.split(" "), o = g.split(" "), X.setAttribute("src", u), l = 2; -1 < --l; )
                                (d = -1 !== (f = s[l]).indexOf("%")) !== (-1 !== o[l].indexOf("%")) &&
                                    ((c = 0 === l ? e.offsetWidth - X.width : e.offsetHeight - X.height), (s[l] = d ? (parseFloat(f) / 100) * c + "px" : (parseFloat(f) / c) * 100 + "%"));
                            f = s.join(" ");
                        }
                        return this.parseComplex(e.style, f, g, n, r);
                    },
                    formatter: de,
                }),
                Se("backgroundSize", {
                    defaultValue: "0 0",
                    formatter: function (e) {
                        return de(-1 === (e += "").indexOf(" ") ? e + " " + e : e);
                    },
                }),
                Se("perspective", { defaultValue: "0px", prefix: !0 }),
                Se("perspectiveOrigin", { defaultValue: "50% 50%", prefix: !0 }),
                Se("transformStyle", { prefix: !0 }),
                Se("backfaceVisibility", { prefix: !0 }),
                Se("userSelect", { prefix: !0 }),
                Se("margin", { parser: we("marginTop,marginRight,marginBottom,marginLeft") }),
                Se("padding", { parser: we("paddingTop,paddingRight,paddingBottom,paddingLeft") }),
                Se("clip", {
                    defaultValue: "rect(0px,0px,0px,0px)",
                    parser: function (e, t, i, a, n, r) {
                        var s, o, l;
                        return (
                            (t =
                                k < 9
                                    ? ((o = e.currentStyle), (l = k < 8 ? " " : ","), (s = "rect(" + o.clipTop + l + o.clipRight + l + o.clipBottom + l + o.clipLeft + ")"), this.format(t).split(",").join(l))
                                    : ((s = this.format(te(e, this.p, S, !1, this.dflt))), this.format(t))),
                            this.parseComplex(e.style, s, t, n, r)
                        );
                    },
                }),
                Se("textShadow", { defaultValue: "0px 0px 0px #999", color: !0, multi: !0 }),
                Se("autoRound,strictUnits", {
                    parser: function (e, t, i, a, n) {
                        return n;
                    },
                }),
                Se("border", {
                    defaultValue: "0px solid #000",
                    parser: function (e, t, i, a, n, r) {
                        var s = te(e, "borderTopWidth", S, !1, "0px"),
                            o = this.format(t).split(" "),
                            l = o[0].replace(I, "");
                        return (
                            "px" !== l && (s = parseFloat(s) / ie(e, "borderTopWidth", 1, l) + l),
                            this.parseComplex(e.style, this.format(s + " " + te(e, "borderTopStyle", S, !1, "solid") + " " + te(e, "borderTopColor", S, !1, "#000")), o.join(" "), n, r)
                        );
                    },
                    color: !0,
                    formatter: function (e) {
                        var t = e.split(" ");
                        return t[0] + " " + (t[1] || "solid") + " " + (e.match(ve) || ["#000"])[0];
                    },
                }),
                Se("borderWidth", { parser: we("borderTopWidth,borderRightWidth,borderBottomWidth,borderLeftWidth") }),
                Se("float,cssFloat,styleFloat", {
                    parser: function (e, t, i, a, n, r) {
                        var s = e.style,
                            o = "cssFloat" in s ? "cssFloat" : "styleFloat";
                        return new be(s, o, 0, 0, n, -1, i, !1, 0, s[o], t);
                    },
                });
            var Je = function (e) {
                var t,
                    i = this.t,
                    a = i.filter || te(this.data, "filter") || "",
                    n = (this.s + this.c * e) | 0;
                100 === n && (t = -1 === a.indexOf("atrix(") && -1 === a.indexOf("radient(") && -1 === a.indexOf("oader(") ? (i.removeAttribute("filter"), !te(this.data, "filter")) : ((i.filter = a.replace(s, "")), !0)),
                    t || (this.xn1 && (i.filter = a = a || "alpha(opacity=" + n + ")"), -1 === a.indexOf("pacity") ? (0 === n && this.xn1) || (i.filter = a + " alpha(opacity=" + n + ")") : (i.filter = a.replace(A, "opacity=" + n)));
            };
            Se("opacity,alpha,autoAlpha", {
                defaultValue: "1",
                parser: function (e, t, i, a, n, r) {
                    var s = parseFloat(te(e, "opacity", S, !1, "1")),
                        o = e.style,
                        l = "autoAlpha" === i;
                    return (
                        "string" == typeof t && "=" === t.charAt(1) && (t = ("-" === t.charAt(0) ? -1 : 1) * parseFloat(t.substr(2)) + s),
                        l && 1 === s && "hidden" === te(e, "visibility", S) && 0 !== t && (s = 0),
                        U
                            ? (n = new be(o, "opacity", s, t - s, n))
                            : (((n = new be(o, "opacity", 100 * s, 100 * (t - s), n)).xn1 = l ? 1 : 0),
                              (o.zoom = 1),
                              (n.type = 2),
                              (n.b = "alpha(opacity=" + n.s + ")"),
                              (n.e = "alpha(opacity=" + (n.s + n.c) + ")"),
                              (n.data = e),
                              (n.plugin = r),
                              (n.setRatio = Je)),
                        l && (((n = new be(o, "visibility", 0, 0, n, -1, null, !1, 0, 0 !== s ? "inherit" : "hidden", 0 === t ? "hidden" : "inherit")).xs0 = "inherit"), a._overwriteProps.push(n.n), a._overwriteProps.push(i)),
                        n
                    );
                },
            });
            var $e = function (e, t) {
                    t && (e.removeProperty ? (("ms" === t.substr(0, 2) || "webkit" === t.substr(0, 6)) && (t = "-" + t), e.removeProperty(t.replace(o, "-$1").toLowerCase())) : e.removeAttribute(t));
                },
                Ke = function (e) {
                    if (((this.t._gsClassPT = this), 1 === e || 0 === e)) {
                        this.t.setAttribute("class", 0 === e ? this.b : this.e);
                        for (var t = this.data, i = this.t.style; t; ) t.v ? (i[t.p] = t.v) : $e(i, t.p), (t = t._next);
                        1 === e && this.t._gsClassPT === this && (this.t._gsClassPT = null);
                    } else this.t.getAttribute("class") !== this.e && this.t.setAttribute("class", this.e);
                };
            Se("className", {
                parser: function (e, t, i, a, n, r, s) {
                    var o,
                        l,
                        d,
                        c,
                        u,
                        h = e.getAttribute("class") || "",
                        p = e.style.cssText;
                    if ((((n = a._classNamePT = new be(e, i, 0, 0, n, 2)).setRatio = Ke), (n.pr = -11), (f = !0), (n.b = h), (l = ne(e, S)), (d = e._gsClassPT))) {
                        for (c = {}, u = d.data; u; ) (c[u.p] = 1), (u = u._next);
                        d.setRatio(1);
                    }
                    return (
                        ((e._gsClassPT = n).e = "=" !== t.charAt(1) ? t : h.replace(new RegExp("(?:\\s|^)" + t.substr(2) + "(?![\\w-])"), "") + ("+" === t.charAt(0) ? " " + t.substr(2) : "")),
                        e.setAttribute("class", n.e),
                        (o = re(e, l, ne(e), s, c)),
                        e.setAttribute("class", h),
                        (n.data = o.firstMPT),
                        (e.style.cssText = p),
                        (n.xfirst = a.parse(e, o.difs, n, r))
                    );
                },
            });
            var et = function (e) {
                if ((1 === e || 0 === e) && this.data._totalTime === this.data._totalDuration && "isFromStart" !== this.data.data) {
                    var t,
                        i,
                        a,
                        n,
                        r,
                        s = this.t.style,
                        o = m.transform.parse;
                    if ("all" === this.e) n = !(s.cssText = "");
                    else for (a = (t = this.e.split(" ").join("").split(",")).length; -1 < --a; ) (i = t[a]), m[i] && (m[i].parse === o ? (n = !0) : (i = "transformOrigin" === i ? ze : m[i].p)), $e(s, i);
                    n && ($e(s, Qe), (r = this.t._gsTransform) && (r.svg && (this.t.removeAttribute("data-svg-origin"), this.t.removeAttribute("transform")), delete this.t._gsTransform));
                }
            };
            for (
                Se("clearProps", {
                    parser: function (e, t, i, a, n) {
                        return ((n = new be(e, i, 0, 0, n, 2)).setRatio = et), (n.e = t), (n.pr = -10), (n.data = a._tween), (f = !0), n;
                    },
                }),
                    e = "bezier,throwProps,physicsProps,physics2D".split(","),
                    Ce = e.length;
                Ce--;

            )
                je(e[Ce]);
            ((e = H.prototype)._firstPT = e._lastParsedTransform = e._transform = null),
                (e._onInitTween = function (e, t, i, a) {
                    if (!e.nodeType) return !1;
                    (this._target = L = e), (this._tween = i), (this._vars = t), (O = a), (j = t.autoRound), (f = !1), (C = t.suffixMap || H.suffixMap), (S = ee(e, "")), (g = this._overwriteProps);
                    var n,
                        r,
                        s,
                        o,
                        l,
                        d,
                        c,
                        u,
                        h,
                        p = e.style;
                    if (
                        (v && "" === p.zIndex && ("auto" === (n = te(e, "zIndex", S)) || "" === n) && this._addLazySet(p, "zIndex", 0),
                        "string" == typeof t && ((o = p.cssText), (n = ne(e, S)), (p.cssText = o + ";" + t), (n = re(e, n, ne(e)).difs), !U && b.test(t) && (n.opacity = parseFloat(RegExp.$1)), (t = n), (p.cssText = o)),
                        t.className ? (this._firstPT = r = m.className.parse(e, t.className, "className", this, null, null, t)) : (this._firstPT = r = this.parse(e, t, null)),
                        this._transformType)
                    ) {
                        for (
                            h = 3 === this._transformType,
                                Qe
                                    ? y &&
                                      ((v = !0),
                                      "" === p.zIndex && ("auto" === (c = te(e, "zIndex", S)) || "" === c) && this._addLazySet(p, "zIndex", 0),
                                      w && this._addLazySet(p, "WebkitBackfaceVisibility", this._vars.WebkitBackfaceVisibility || (h ? "visible" : "hidden")))
                                    : (p.zoom = 1),
                                s = r;
                            s && s._next;

                        )
                            s = s._next;
                        (u = new be(e, "transform", 0, 0, null, 2)), this._linkCSSP(u, null, s), (u.setRatio = Qe ? Ze : Ge), (u.data = this._transform || Ue(e, S, !0)), (u.tween = i), (u.pr = -1), g.pop();
                    }
                    if (f) {
                        for (; r; ) {
                            for (d = r._next, s = o; s && s.pr > r.pr; ) s = s._next;
                            (r._prev = s ? s._prev : l) ? (r._prev._next = r) : (o = r), (r._next = s) ? (s._prev = r) : (l = r), (r = d);
                        }
                        this._firstPT = o;
                    }
                    return !0;
                }),
                (e.parse = function (e, t, i, a) {
                    var n,
                        r,
                        s,
                        o,
                        l,
                        d,
                        c,
                        u,
                        h,
                        p,
                        f = e.style;
                    for (n in t)
                        "function" == typeof (d = t[n]) && (d = d(O, L)),
                            (r = m[n])
                                ? (i = r.parse(e, d, n, this, i, a, t))
                                : ((l = te(e, n, S) + ""),
                                  (h = "string" == typeof d),
                                  "color" === n || "fill" === n || "stroke" === n || -1 !== n.indexOf("Color") || (h && x.test(d))
                                      ? (h || (d = (3 < (d = ge(d)).length ? "rgba(" : "rgb(") + d.join(",") + ")"), (i = Te(f, n, l, d, !0, "transparent", i, 0, a)))
                                      : h && z.test(d)
                                      ? (i = Te(f, n, l, d, !0, null, i, 0, a))
                                      : ((c = (s = parseFloat(l)) || 0 === s ? l.substr((s + "").length) : ""),
                                        ("" === l || "auto" === l) && (c = "width" === n || "height" === n ? ((s = le(e, n, S)), "px") : "left" === n || "top" === n ? ((s = ae(e, n, S)), "px") : ((s = "opacity" !== n ? 0 : 1), "")),
                                        "" === (u = (p = h && "=" === d.charAt(1)) ? ((o = parseInt(d.charAt(0) + "1", 10)), (d = d.substr(2)), (o *= parseFloat(d)), d.replace(I, "")) : ((o = parseFloat(d)), h ? d.replace(I, "") : "")) &&
                                            (u = n in C ? C[n] : c),
                                        (d = o || 0 === o ? (p ? o + s : o) + u : t[n]),
                                        c !== u &&
                                            "" !== u &&
                                            (o || 0 === o) &&
                                            s &&
                                            ((s = ie(e, n, s, c)),
                                            "%" === u
                                                ? ((s /= ie(e, n, 100, "%") / 100), !0 !== t.strictUnits && (l = s + "%"))
                                                : "em" === u || "rem" === u || "vw" === u || "vh" === u
                                                ? (s /= ie(e, n, 1, u))
                                                : "px" !== u && ((o = ie(e, n, o, u)), (u = "px")),
                                            p && (o || 0 === o) && (d = o + s + u)),
                                        p && (o += s),
                                        (!s && 0 !== s) || (!o && 0 !== o)
                                            ? void 0 !== f[n] && (d || (d + "" != "NaN" && null != d))
                                                ? ((i = new be(f, n, o || s || 0, 0, i, -1, n, !1, 0, l, d)).xs0 = "none" !== d || ("display" !== n && -1 === n.indexOf("Style")) ? d : l)
                                                : Z("invalid " + n + " tween value: " + t[n])
                                            : ((i = new be(f, n, s, o - s, i, 0, n, !1 !== j && ("px" === u || "zIndex" === n), 0, l, d)).xs0 = u))),
                            a && i && !i.plugin && (i.plugin = a);
                    return i;
                }),
                (e.setRatio = function (e) {
                    var t,
                        i,
                        a,
                        n = this._firstPT;
                    if (1 !== e || (this._tween._time !== this._tween._duration && 0 !== this._tween._time))
                        if (e || (this._tween._time !== this._tween._duration && 0 !== this._tween._time) || -1e-6 === this._tween._rawPrevTime)
                            for (; n; ) {
                                if (((t = n.c * e + n.s), n.r ? (t = Math.round(t)) : t < 1e-6 && -1e-6 < t && (t = 0), n.type))
                                    if (1 === n.type)
                                        if (2 === (a = n.l)) n.t[n.p] = n.xs0 + t + n.xs1 + n.xn1 + n.xs2;
                                        else if (3 === a) n.t[n.p] = n.xs0 + t + n.xs1 + n.xn1 + n.xs2 + n.xn2 + n.xs3;
                                        else if (4 === a) n.t[n.p] = n.xs0 + t + n.xs1 + n.xn1 + n.xs2 + n.xn2 + n.xs3 + n.xn3 + n.xs4;
                                        else if (5 === a) n.t[n.p] = n.xs0 + t + n.xs1 + n.xn1 + n.xs2 + n.xn2 + n.xs3 + n.xn3 + n.xs4 + n.xn4 + n.xs5;
                                        else {
                                            for (i = n.xs0 + t + n.xs1, a = 1; a < n.l; a++) i += n["xn" + a] + n["xs" + (a + 1)];
                                            n.t[n.p] = i;
                                        }
                                    else -1 === n.type ? (n.t[n.p] = n.xs0) : n.setRatio && n.setRatio(e);
                                else n.t[n.p] = t + n.xs0;
                                n = n._next;
                            }
                        else for (; n; ) 2 !== n.type ? (n.t[n.p] = n.b) : n.setRatio(e), (n = n._next);
                    else
                        for (; n; ) {
                            if (2 !== n.type)
                                if (n.r && -1 !== n.type)
                                    if (((t = Math.round(n.s + n.c)), n.type)) {
                                        if (1 === n.type) {
                                            for (a = n.l, i = n.xs0 + t + n.xs1, a = 1; a < n.l; a++) i += n["xn" + a] + n["xs" + (a + 1)];
                                            n.t[n.p] = i;
                                        }
                                    } else n.t[n.p] = t + n.xs0;
                                else n.t[n.p] = n.e;
                            else n.setRatio(e);
                            n = n._next;
                        }
                }),
                (e._enableTransforms = function (e) {
                    (this._transform = this._transform || Ue(this._target, S, !0)), (this._transformType = (this._transform.svg && Le) || (!e && 3 !== this._transformType) ? 2 : 3);
                });
            var tt = function (e) {
                (this.t[this.p] = this.e), this.data._linkCSSP(this, this._next, null, !0);
            };
            (e._addLazySet = function (e, t, i) {
                var a = (this._firstPT = new be(e, t, 0, 0, this._firstPT, 2));
                (a.e = i), (a.setRatio = tt), (a.data = this);
            }),
                (e._linkCSSP = function (e, t, i, a) {
                    return (
                        e &&
                            (t && (t._prev = e),
                            e._next && (e._next._prev = e._prev),
                            e._prev ? (e._prev._next = e._next) : this._firstPT === e && ((this._firstPT = e._next), (a = !0)),
                            i ? (i._next = e) : a || null !== this._firstPT || (this._firstPT = e),
                            (e._next = t),
                            (e._prev = i)),
                        e
                    );
                }),
                (e._mod = function (e) {
                    for (var t = this._firstPT; t; ) "function" == typeof e[t.p] && e[t.p] === Math.round && (t.r = 1), (t = t._next);
                }),
                (e._kill = function (e) {
                    var t,
                        i,
                        a,
                        n = e;
                    if (e.autoAlpha || e.alpha) {
                        for (i in ((n = {}), e)) n[i] = e[i];
                        (n.opacity = 1), n.autoAlpha && (n.visibility = 1);
                    }
                    for (
                        e.className &&
                            (t = this._classNamePT) &&
                            ((a = t.xfirst) && a._prev ? this._linkCSSP(a._prev, t._next, a._prev._prev) : a === this._firstPT && (this._firstPT = t._next),
                            t._next && this._linkCSSP(t._next, t._next._next, a._prev),
                            (this._classNamePT = null)),
                            t = this._firstPT;
                        t;

                    )
                        t.plugin && t.plugin !== i && t.plugin._kill && (t.plugin._kill(e), (i = t.plugin)), (t = t._next);
                    return r.prototype._kill.call(this, n);
                });
            var it = function (e, t, i) {
                var a, n, r, s;
                if (e.slice) for (n = e.length; -1 < --n; ) it(e[n], t, i);
                else for (n = (a = e.childNodes).length; -1 < --n; ) (s = (r = a[n]).type), r.style && (t.push(ne(r)), i && i.push(r)), (1 !== s && 9 !== s && 11 !== s) || !r.childNodes.length || it(r, t, i);
            };
            return (
                (H.cascadeTo = function (e, t, i) {
                    var a,
                        n,
                        r,
                        s,
                        o = N.to(e, t, i),
                        l = [o],
                        d = [],
                        c = [],
                        u = [],
                        h = N._internals.reservedProps;
                    for (e = o._targets || o.target, it(e, d, u), o.render(t, !0, !0), it(e, c), o.render(0, !0, !0), o._enabled(!0), a = u.length; -1 < --a; )
                        if ((n = re(u[a], d[a], c[a])).firstMPT) {
                            for (r in ((n = n.difs), i)) h[r] && (n[r] = i[r]);
                            for (r in ((s = {}), n)) s[r] = d[a][r];
                            l.push(N.fromTo(u[a], t, s, n));
                        }
                    return l;
                }),
                r.activate([H]),
                H
            );
        },
        !0
    );
}),
    _gsScope._gsDefine && _gsScope._gsQueue.pop()(),
    (function (e) {
        "use strict";
        var t = function () {
            return (_gsScope.GreenSockGlobals || _gsScope).CSSPlugin;
        };
        "function" == typeof define && define.amd ? define(["TweenLite"], t) : "undefined" != typeof module && module.exports && (require("../TweenLite.js"), (module.exports = t()));
    })();
var _gsScope = "undefined" != typeof module && module.exports && "undefined" != typeof global ? global : this || window;
!(function (i) {
    "use strict";
    var n = i.GreenSockGlobals || i,
        e = (function (e) {
            var t,
                i = e.split("."),
                a = n;
            for (t = 0; t < i.length; t++) a[i[t]] = a = a[i[t]] || {};
            return a;
        })("com.greensock.utils"),
        T = function (e) {
            var t = e.nodeType,
                i = "";
            if (1 === t || 9 === t || 11 === t) {
                if ("string" == typeof e.textContent) return e.textContent;
                for (e = e.firstChild; e; e = e.nextSibling) i += T(e);
            } else if (3 === t || 4 === t) return e.nodeValue;
            return i;
        },
        H = document,
        W = H.defaultView ? H.defaultView.getComputedStyle : function () {},
        r = /([A-Z])/g,
        B = function (e, t, i, a) {
            var n;
            return (i = i || W(e, null)) ? (n = (e = i.getPropertyValue(t.replace(r, "-$1").toLowerCase())) || i.length ? e : i[t]) : e.currentStyle && (n = (i = e.currentStyle)[t]), a ? n : parseInt(n, 10) || 0;
        },
        s = function (e) {
            return !!(e.length && e[0] && ((e[0].nodeType && e[0].style && !e.nodeType) || (e[0].length && e[0][0])));
        },
        C = /(?:\r|\n|\t\t)/g,
        k = /(?:\s\s+)/g,
        S = function (e) {
            return ((e.charCodeAt(0) - 55296) << 10) + (e.charCodeAt(1) - 56320) + 65536;
        },
        o = " style='position:relative;display:inline-block;" + (H.all && !H.addEventListener ? "*display:inline;*zoom:1;'" : "'"),
        l = function (e, t) {
            var i = -1 !== (e = e || "").indexOf("++"),
                a = 1;
            return (
                i && (e = e.split("++").join("")),
                function () {
                    return "<" + t + o + (e ? " class='" + e + (i ? a++ : "") + "'>" : ">");
                }
            );
        },
        a = (e.SplitText = n.SplitText = function (e, t) {
            if (("string" == typeof e && (e = a.selector(e)), !e)) throw "cannot split a null element.";
            (this.elements = s(e)
                ? (function (e) {
                      var t,
                          i,
                          a,
                          n = [],
                          r = e.length;
                      for (t = 0; t < r; t++)
                          if (((i = e[t]), s(i))) for (a = i.length, a = 0; a < i.length; a++) n.push(i[a]);
                          else n.push(i);
                      return n;
                  })(e)
                : [e]),
                (this.chars = []),
                (this.words = []),
                (this.lines = []),
                (this._originals = []),
                (this.vars = t || {}),
                this.split(t);
        }),
        V = function (e, t, i) {
            var a = e.nodeType;
            if (1 === a || 9 === a || 11 === a) for (e = e.firstChild; e; e = e.nextSibling) V(e, t, i);
            else (3 === a || 4 === a) && (e.nodeValue = e.nodeValue.split(t).join(i));
        },
        Y = function (e, t) {
            for (var i = t.length; -1 < --i; ) e.push(t[i]);
        },
        d = function (e) {
            var t,
                i = [],
                a = e.length;
            for (t = 0; t !== a; i.push(e[t++]));
            return i;
        },
        X = function (e, t, i) {
            for (var a; e && e !== t; ) {
                if ((a = e._next || e.nextSibling)) return a.textContent.charAt(0) === i;
                e = e.parentNode || e._parent;
            }
            return !1;
        },
        q = function (e) {
            var t,
                i,
                a = d(e.childNodes),
                n = a.length;
            for (t = 0; t < n; t++)
                (i = a[t])._isSplit
                    ? q(i)
                    : (t && 3 === i.previousSibling.nodeType ? (i.previousSibling.nodeValue += 3 === i.nodeType ? i.nodeValue : i.firstChild.nodeValue) : 3 !== i.nodeType && e.insertBefore(i.firstChild, i), e.removeChild(i));
        },
        c = function (e, t, i, a, n, r, s) {
            var o,
                l,
                d,
                c,
                u,
                h,
                p,
                f,
                g,
                m,
                v,
                y,
                w = W(e),
                _ = B(e, "paddingLeft", w),
                b = -999,
                x = B(e, "borderBottomWidth", w) + B(e, "borderTopWidth", w),
                T = B(e, "borderLeftWidth", w) + B(e, "borderRightWidth", w),
                C = B(e, "paddingTop", w) + B(e, "paddingBottom", w),
                k = B(e, "paddingLeft", w) + B(e, "paddingRight", w),
                S = 0.2 * B(e, "fontSize"),
                j = B(e, "textAlign", w, !0),
                L = [],
                O = [],
                P = [],
                R = t.wordDelimiter || " ",
                I = t.span ? "span" : "div",
                A = t.type || t.split || "chars,words,lines",
                Q = n && -1 !== A.indexOf("lines") ? [] : null,
                M = -1 !== A.indexOf("words"),
                z = -1 !== A.indexOf("chars"),
                D = "absolute" === t.position || !0 === t.absolute,
                F = t.linesClass,
                E = -1 !== (F || "").indexOf("++"),
                N = [];
            for (Q && 1 === e.children.length && e.children[0]._isSplit && (e = e.children[0]), E && (F = F.split("++").join("")), d = (l = e.getElementsByTagName("*")).length, u = [], o = 0; o < d; o++) u[o] = l[o];
            if (Q || D)
                for (o = 0; o < d; o++)
                    ((h = (c = u[o]).parentNode === e) || D || (z && !M)) &&
                        ((y = c.offsetTop),
                        Q && h && Math.abs(y - b) > S && "BR" !== c.nodeName && ((p = []), Q.push(p), (b = y)),
                        D && ((c._x = c.offsetLeft), (c._y = y), (c._w = c.offsetWidth), (c._h = c.offsetHeight)),
                        Q &&
                            (((c._isSplit && h) || (!z && h) || (M && h) || (!M && c.parentNode.parentNode === e && !c.parentNode._isSplit)) && (p.push(c), (c._x -= _), X(c, e, R) && (c._wordEnd = !0)),
                            "BR" === c.nodeName && c.nextSibling && "BR" === c.nextSibling.nodeName && Q.push([])));
            for (o = 0; o < d; o++)
                (h = (c = u[o]).parentNode === e),
                    "BR" !== c.nodeName
                        ? (D &&
                              ((g = c.style),
                              M || h || ((c._x += c.parentNode._x), (c._y += c.parentNode._y)),
                              (g.left = c._x + "px"),
                              (g.top = c._y + "px"),
                              (g.position = "absolute"),
                              (g.display = "block"),
                              (g.width = c._w + 1 + "px"),
                              (g.height = c._h + "px")),
                          !M && z
                              ? c._isSplit
                                  ? ((c._next = c.nextSibling), c.parentNode.appendChild(c))
                                  : c.parentNode._isSplit
                                  ? ((c._parent = c.parentNode),
                                    !c.previousSibling && c.firstChild && (c.firstChild._isFirst = !0),
                                    c.nextSibling && " " === c.nextSibling.textContent && !c.nextSibling.nextSibling && N.push(c.nextSibling),
                                    (c._next = c.nextSibling && c.nextSibling._isFirst ? null : c.nextSibling),
                                    c.parentNode.removeChild(c),
                                    u.splice(o--, 1),
                                    d--)
                                  : h ||
                                    ((y = !c.nextSibling && X(c.parentNode, e, R)),
                                    c.parentNode._parent && c.parentNode._parent.appendChild(c),
                                    y && c.parentNode.appendChild(H.createTextNode(" ")),
                                    t.span && (c.style.display = "inline"),
                                    L.push(c))
                              : c.parentNode._isSplit && !c._isSplit && "" !== c.innerHTML
                              ? O.push(c)
                              : z && !c._isSplit && (t.span && (c.style.display = "inline"), L.push(c)))
                        : Q || D
                        ? (c.parentNode && c.parentNode.removeChild(c), u.splice(o--, 1), d--)
                        : M || e.appendChild(c);
            for (o = N.length; -1 < --o; ) N[o].parentNode.removeChild(N[o]);
            if (Q) {
                for (D && ((m = H.createElement(I)), e.appendChild(m), (v = m.offsetWidth + "px"), (y = m.offsetParent === e ? 0 : e.offsetLeft), e.removeChild(m)), g = e.style.cssText, e.style.cssText = "display:none;"; e.firstChild; )
                    e.removeChild(e.firstChild);
                for (f = " " === R && (!D || (!M && !z)), o = 0; o < Q.length; o++) {
                    for (
                        p = Q[o], (m = H.createElement(I)).style.cssText = "display:block;text-align:" + j + ";position:" + (D ? "absolute;" : "relative;"), F && (m.className = F + (E ? o + 1 : "")), P.push(m), d = p.length, l = 0;
                        l < d;
                        l++
                    )
                        "BR" !== p[l].nodeName &&
                            ((c = p[l]),
                            m.appendChild(c),
                            f && c._wordEnd && m.appendChild(H.createTextNode(" ")),
                            D && (0 === l && ((m.style.top = c._y + "px"), (m.style.left = _ + y + "px")), (c.style.top = "0px"), y && (c.style.left = c._x - y + "px")));
                    0 === d ? (m.innerHTML = "&nbsp;") : M || z || (q(m), V(m, String.fromCharCode(160), " ")), D && ((m.style.width = v), (m.style.height = c._h + "px")), e.appendChild(m);
                }
                e.style.cssText = g;
            }
            D && (s > e.clientHeight && ((e.style.height = s - C + "px"), e.clientHeight < s && (e.style.height = s + x + "px")), r > e.clientWidth && ((e.style.width = r - k + "px"), e.clientWidth < r && (e.style.width = r + T + "px"))),
                Y(i, L),
                Y(a, O),
                Y(n, P);
        },
        u = function (e, t, i, a) {
            var n,
                r,
                s = d(e.childNodes),
                o = s.length,
                l = "absolute" === t.position || !0 === t.absolute;
            if (3 !== e.nodeType || 1 < o) {
                for (t.absolute = !1, n = 0; n < o; n++)
                    (3 !== (r = s[n]).nodeType || /\S+/.test(r.nodeValue)) &&
                        (l && 3 !== r.nodeType && "inline" === B(r, "display", null, !0) && ((r.style.display = "inline-block"), (r.style.position = "relative")), (r._isSplit = !0), u(r, t, i, a));
                return (t.absolute = l), void (e._isSplit = !0);
            }
            !(function (e, t, i, a) {
                var n,
                    r,
                    s,
                    o,
                    l,
                    d,
                    c,
                    u,
                    h,
                    p = t.span ? "span" : "div",
                    f = t.type || t.split || "chars,words,lines",
                    g = (f.indexOf("words"), -1 !== f.indexOf("chars")),
                    m = "absolute" === t.position || !0 === t.absolute,
                    v = t.wordDelimiter || " ",
                    y = " " !== v ? "" : m ? "&#173; " : " ",
                    w = t.span ? "</span>" : "</div>",
                    _ = !0,
                    b = H.createElement("div"),
                    x = e.parentNode;
                for (
                    x.insertBefore(b, e),
                        b.textContent = e.nodeValue,
                        x.removeChild(e),
                        c = -1 !== (n = T((e = b))).indexOf("<"),
                        !1 !== t.reduceWhiteSpace && (n = n.replace(k, " ").replace(C, "")),
                        c && (n = n.split("<").join("{{LT}}")),
                        l = n.length,
                        r = (" " === n.charAt(0) ? y : "") + i(),
                        s = 0;
                    s < l;
                    s++
                )
                    if ((d = n.charAt(s)) === v && n.charAt(s - 1) !== v && s) {
                        for (r += _ ? w : "", _ = !1; n.charAt(s + 1) === v; ) (r += y), s++;
                        s === l - 1 ? (r += y) : ")" !== n.charAt(s + 1) && ((r += y + i()), (_ = !0));
                    } else
                        "{" === d && "{{LT}}" === n.substr(s, 6)
                            ? ((r += g ? a() + "{{LT}}</" + p + ">" : "{{LT}}"), (s += 5))
                            : (55296 <= d.charCodeAt(0) && d.charCodeAt(0) <= 56319) || (65024 <= n.charCodeAt(s + 1) && n.charCodeAt(s + 1) <= 65039)
                            ? ((u = S(n.substr(s, 2))),
                              (h = S(n.substr(s + 2, 2))),
                              (o = (127462 <= u && u <= 127487 && 127462 <= h && h <= 127487) || (127995 <= h && h <= 127999) ? 4 : 2),
                              (r += g && " " !== d ? a() + n.substr(s, o) + "</" + p + ">" : n.substr(s, o)),
                              (s += o - 1))
                            : (r += g && " " !== d ? a() + d + "</" + p + ">" : d);
                (e.outerHTML = r + (_ ? w : "")), c && V(x, "{{LT}}", "<");
            })(e, t, i, a);
        },
        t = a.prototype;
    (t.split = function (e) {
        this.isSplit && this.revert(), (this.vars = e = e || this.vars), (this._originals.length = this.chars.length = this.words.length = this.lines.length = 0);
        for (var t, i, a, n = this.elements.length, r = e.span ? "span" : "div", s = ("absolute" === e.position || e.absolute, l(e.wordsClass, r)), o = l(e.charsClass, r); -1 < --n; )
            (a = this.elements[n]), (this._originals[n] = a.innerHTML), (t = a.clientHeight), (i = a.clientWidth), u(a, e, s, o), c(a, e, this.chars, this.words, this.lines, i, t);
        return this.chars.reverse(), this.words.reverse(), this.lines.reverse(), (this.isSplit = !0), this;
    }),
        (t.revert = function () {
            if (!this._originals) throw "revert() call wasn't scoped properly.";
            for (var e = this._originals.length; -1 < --e; ) this.elements[e].innerHTML = this._originals[e];
            return (this.chars = []), (this.words = []), (this.lines = []), (this.isSplit = !1), this;
        }),
        (a.selector =
            i.$ ||
            i.jQuery ||
            function (e) {
                var t = i.$ || i.jQuery;
                return t ? (a.selector = t)(e) : "undefined" == typeof document ? e : document.querySelectorAll ? document.querySelectorAll(e) : document.getElementById("#" === e.charAt(0) ? e.substr(1) : e);
            }),
        (a.version = "0.5.6");
})(_gsScope),
    (function (e) {
        "use strict";
        var t = function () {
            return (_gsScope.GreenSockGlobals || _gsScope).SplitText;
        };
        "function" == typeof define && define.amd ? define([], t) : "undefined" != typeof module && module.exports && (module.exports = t());
    })();
try {
    (window.GreenSockGlobals = null), (window._gsQueue = null), (window._gsDefine = null), delete window.GreenSockGlobals, delete window._gsQueue, delete window._gsDefine;
} catch (e) {}
try {
    (window.GreenSockGlobals = oldgs), (window._gsQueue = oldgs_queue);
} catch (e) {}
if (1 == window.tplogs)
    try {
        console.groupEnd();
    } catch (e) {}
!(function (c, e) {
    (c.waitForImages = { hasImageProperties: ["backgroundImage", "listStyleImage", "borderImage", "borderCornerImage"] }),
        (c.expr[":"].uncached = function (e) {
            var t = document.createElement("img");
            return (t.src = e.src), c(e).is('img[src!=""]') && !t.complete;
        }),
        (c.fn.waitForImages = function (l, d, t) {
            if ((c.isPlainObject(l) && ((d = l.each), (t = l.waitForAll), (l = l.finished)), (l = l || c.noop), (d = d || c.noop), (t = !!t), !c.isFunction(l) || !c.isFunction(d))) throw new TypeError("An invalid callback was supplied.");
            return this.each(function () {
                var a = c(this),
                    r = [];
                if (t) {
                    var e = c.waitForImages.hasImageProperties || [],
                        s = /url\((['"]?)(.*?)\1\)/g;
                    a.find("*").each(function () {
                        var n = c(this);
                        n.is("img:uncached") && r.push({ src: n.attr("src"), element: n[0] }),
                            c.each(e, function (e, t) {
                                var i,
                                    a = n.css(t);
                                if (!a) return !0;
                                for (; (i = s.exec(a)); ) r.push({ src: i[2], element: n[0] });
                            });
                    });
                } else
                    a.find("img:uncached").each(function () {
                        r.push({ src: this.src, element: this });
                    });
                var n = r.length,
                    o = 0;
                0 == n && l.call(a[0]),
                    c.each(r, function (e, t) {
                        var i = new Image();
                        c(i).bind("load error", function (e) {
                            if ((o++, d.call(t.element, o, n, "load" == e.type), o == n)) return l.call(a[0]), !1;
                        }),
                            (i.src = t.src);
                    });
            });
        });
})(jQuery),
    (function ($) {
        "use strict";
        function getScrollRoot() {
            var e,
                t = document.documentElement,
                i = document.body,
                a = (void 0 !== window.pageYOffset ? window.pageYOffset : null) || i.scrollTop || t.scrollTop;
            return (t.scrollTop = i.scrollTop = a + (0 < a) ? -1 : 1), ((e = t.scrollTop !== a ? t : i).scrollTop = a), e;
        }
        var _R = jQuery.fn.revolution,
            _ISM = _R.is_mobile(),
            extension = { alias: "Actions Min JS", name: "revolution.extensions.actions.min.js", min_core: "5.4.5", version: "2.1.0" };
        jQuery.extend(!0, _R, {
            checkActions: function (e, t, i) {
                if ("stop" === _R.compare_version(extension).check) return !1;
                checkActions_intern(e, t, i);
            },
        });
        var checkActions_intern = function (n, r, e) {
                e &&
                    jQuery.each(e, function (e, a) {
                        (a.delay = parseInt(a.delay, 0) / 1e3),
                            n.addClass("tp-withaction"),
                            r.fullscreen_esclistener ||
                                ("exitfullscreen" != a.action && "togglefullscreen" != a.action) ||
                                (jQuery(document).keyup(function (e) {
                                    27 == e.keyCode && 0 < jQuery("#rs-go-fullscreen").length && n.trigger(a.event);
                                }),
                                (r.fullscreen_esclistener = !0));
                        var t = "backgroundvideo" == a.layer ? jQuery(".rs-background-video-layer") : "firstvideo" == a.layer ? jQuery(".tp-revslider-slidesli").find(".tp-videolayer") : jQuery("#" + a.layer);
                        switch ((-1 != jQuery.inArray(a.action, ["toggleslider", "toggle_mute_video", "toggle_global_mute_video", "togglefullscreen"]) && n.data("togglelisteners", !0), a.action)) {
                            case "togglevideo":
                                jQuery.each(t, function (e, t) {
                                    var i = (t = jQuery(t)).data("videotoggledby");
                                    null == i && (i = new Array()), i.push(n), t.data("videotoggledby", i);
                                });
                                break;
                            case "togglelayer":
                                jQuery.each(t, function (e, t) {
                                    var i = (t = jQuery(t)).data("layertoggledby");
                                    null == i && (i = new Array()), i.push(n), t.data("layertoggledby", i), t.data("triggered_startstatus", a.layerstatus);
                                });
                                break;
                            case "toggle_mute_video":
                            case "toggle_global_mute_video":
                                jQuery.each(t, function (e, t) {
                                    var i = (t = jQuery(t)).data("videomutetoggledby");
                                    null == i && (i = new Array()), i.push(n), t.data("videomutetoggledby", i);
                                });
                                break;
                            case "toggleslider":
                                null == r.slidertoggledby && (r.slidertoggledby = new Array()), r.slidertoggledby.push(n);
                                break;
                            case "togglefullscreen":
                                null == r.fullscreentoggledby && (r.fullscreentoggledby = new Array()), r.fullscreentoggledby.push(n);
                        }
                        switch (
                            (n.on(a.event, function () {
                                if ("click" === a.event && n.hasClass("tp-temporarydisabled")) return !1;
                                var e = "backgroundvideo" == a.layer ? jQuery(".active-revslide .slotholder .rs-background-video-layer") : "firstvideo" == a.layer ? jQuery(".active-revslide .tp-videolayer").first() : jQuery("#" + a.layer);
                                if ("stoplayer" == a.action || "togglelayer" == a.action || "startlayer" == a.action) {
                                    if (0 < e.length) {
                                        var t = e.data();
                                        void 0 !== t.clicked_time_stamp && 150 < new Date().getTime() - t.clicked_time_stamp && (clearTimeout(t.triggerdelayIn), clearTimeout(t.triggerdelayOut)),
                                            (t.clicked_time_stamp = new Date().getTime()),
                                            "startlayer" == a.action || ("togglelayer" == a.action && "in" != e.data("animdirection"))
                                                ? ((t.animdirection = "in"),
                                                  (t.triggerstate = "on"),
                                                  _R.toggleState(t.layertoggledby),
                                                  _R.playAnimationFrame &&
                                                      (clearTimeout(t.triggerdelayIn),
                                                      (t.triggerdelayIn = setTimeout(function () {
                                                          _R.playAnimationFrame({ caption: e, opt: r, frame: "frame_0", triggerdirection: "in", triggerframein: "frame_0", triggerframeout: "frame_999" });
                                                      }, 1e3 * a.delay))))
                                                : ("stoplayer" == a.action || ("togglelayer" == a.action && "out" != e.data("animdirection"))) &&
                                                  ((t.animdirection = "out"),
                                                  (t.triggered = !0),
                                                  (t.triggerstate = "off"),
                                                  _R.stopVideo && _R.stopVideo(e, r),
                                                  _R.unToggleState(t.layertoggledby),
                                                  _R.endMoveCaption &&
                                                      (clearTimeout(t.triggerdelayOut),
                                                      (t.triggerdelayOut = setTimeout(function () {
                                                          _R.playAnimationFrame({ caption: e, opt: r, frame: "frame_999", triggerdirection: "out", triggerframein: "frame_0", triggerframeout: "frame_999" });
                                                      }, 1e3 * a.delay))));
                                    }
                                } else
                                    !_ISM ||
                                    ("playvideo" != a.action &&
                                        "stopvideo" != a.action &&
                                        "togglevideo" != a.action &&
                                        "mutevideo" != a.action &&
                                        "unmutevideo" != a.action &&
                                        "toggle_mute_video" != a.action &&
                                        "toggle_global_mute_video" != a.action)
                                        ? ((a.delay = "NaN" === a.delay || NaN === a.delay ? 0 : a.delay),
                                          _R.isSafari11()
                                              ? actionSwitches(e, r, a, n)
                                              : punchgs.TweenLite.delayedCall(
                                                    a.delay,
                                                    function () {
                                                        actionSwitches(e, r, a, n);
                                                    },
                                                    [e, r, a, n]
                                                ))
                                        : actionSwitches(e, r, a, n);
                            }),
                            a.action)
                        ) {
                            case "togglelayer":
                            case "startlayer":
                            case "playlayer":
                            case "stoplayer":
                                var i = (t = jQuery("#" + a.layer)).data();
                                0 < t.length && void 0 !== i && ((void 0 !== i.frames && "bytrigger" != i.frames[0].delay) || (void 0 === i.frames && "bytrigger" !== i.start)) && (i.triggerstate = "on");
                        }
                    });
            },
            actionSwitches = function (tnc, opt, a, _nc) {
                switch (a.action) {
                    case "scrollbelow":
                        (a.speed = void 0 !== a.speed ? a.speed : 400),
                            (a.ease = void 0 !== a.ease ? a.ease : punchgs.Power2.easeOut),
                            _nc.addClass("tp-scrollbelowslider"),
                            _nc.data("scrolloffset", a.offset),
                            _nc.data("scrolldelay", a.delay),
                            _nc.data("scrollspeed", a.speed),
                            _nc.data("scrollease", a.ease);
                        var off = getOffContH(opt.fullScreenOffsetContainer) || 0,
                            aof = parseInt(a.offset, 0) || 0;
                        (off = off - aof || 0), (opt.scrollRoot = jQuery(document));
                        var sobj = { _y: opt.scrollRoot.scrollTop() };
                        punchgs.TweenLite.to(sobj, a.speed / 1e3, {
                            _y: opt.c.offset().top + jQuery(opt.li[0]).height() - off,
                            ease: a.ease,
                            onUpdate: function () {
                                opt.scrollRoot.scrollTop(sobj._y);
                            },
                        });
                        break;
                    case "callback":
                        eval(a.callback);
                        break;
                    case "jumptoslide":
                        switch (a.slide.toLowerCase()) {
                            case "+1":
                            case "next":
                                (opt.sc_indicator = "arrow"), _R.callingNewSlide(opt.c, 1);
                                break;
                            case "previous":
                            case "prev":
                            case "-1":
                                (opt.sc_indicator = "arrow"), _R.callingNewSlide(opt.c, -1);
                                break;
                            default:
                                var ts = jQuery.isNumeric(a.slide) ? parseInt(a.slide, 0) : a.slide;
                                _R.callingNewSlide(opt.c, ts);
                        }
                        break;
                    case "simplelink":
                        window.open(a.url, a.target);
                        break;
                    case "toggleslider":
                        (opt.noloopanymore = 0),
                            "playing" == opt.sliderstatus
                                ? (opt.c.revpause(), (opt.forcepause_viatoggle = !0), _R.unToggleState(opt.slidertoggledby))
                                : ((opt.forcepause_viatoggle = !1), opt.c.revresume(), _R.toggleState(opt.slidertoggledby));
                        break;
                    case "pauseslider":
                        opt.c.revpause(), _R.unToggleState(opt.slidertoggledby);
                        break;
                    case "playslider":
                        (opt.noloopanymore = 0), opt.c.revresume(), _R.toggleState(opt.slidertoggledby);
                        break;
                    case "playvideo":
                        0 < tnc.length && _R.playVideo(tnc, opt);
                        break;
                    case "stopvideo":
                        0 < tnc.length && _R.stopVideo && _R.stopVideo(tnc, opt);
                        break;
                    case "togglevideo":
                        0 < tnc.length && (_R.isVideoPlaying(tnc, opt) ? _R.stopVideo && _R.stopVideo(tnc, opt) : _R.playVideo(tnc, opt));
                        break;
                    case "mutevideo":
                        0 < tnc.length && _R.muteVideo(tnc, opt);
                        break;
                    case "unmutevideo":
                        0 < tnc.length && _R.unMuteVideo && _R.unMuteVideo(tnc, opt);
                        break;
                    case "toggle_mute_video":
                        0 < tnc.length && (_R.isVideoMuted(tnc, opt) ? _R.unMuteVideo(tnc, opt) : _R.muteVideo && _R.muteVideo(tnc, opt)), _nc.toggleClass("rs-toggle-content-active");
                        break;
                    case "toggle_global_mute_video":
                        !0 === opt.globalmute
                            ? ((opt.globalmute = !1),
                              null != opt.playingvideos &&
                                  0 < opt.playingvideos.length &&
                                  jQuery.each(opt.playingvideos, function (e, t) {
                                      _R.unMuteVideo && _R.unMuteVideo(t, opt);
                                  }))
                            : ((opt.globalmute = !0),
                              null != opt.playingvideos &&
                                  0 < opt.playingvideos.length &&
                                  jQuery.each(opt.playingvideos, function (e, t) {
                                      _R.muteVideo && _R.muteVideo(t, opt);
                                  })),
                            _nc.toggleClass("rs-toggle-content-active");
                        break;
                    case "simulateclick":
                        0 < tnc.length && tnc.click();
                        break;
                    case "toggleclass":
                        0 < tnc.length && (tnc.hasClass(a.classname) ? tnc.removeClass(a.classname) : tnc.addClass(a.classname));
                        break;
                    case "gofullscreen":
                    case "exitfullscreen":
                    case "togglefullscreen":
                        if (0 < jQuery(".rs-go-fullscreen").length && ("togglefullscreen" == a.action || "exitfullscreen" == a.action)) {
                            jQuery(".rs-go-fullscreen").removeClass("rs-go-fullscreen");
                            var gf = 0 < opt.c.closest(".forcefullwidth_wrapper_tp_banner").length ? opt.c.closest(".forcefullwidth_wrapper_tp_banner") : opt.c.closest(".rev_slider_wrapper");
                            (opt.minHeight = opt.oldminheight), (opt.infullscreenmode = !1), opt.c.revredraw(), jQuery(window).trigger("resize"), _R.unToggleState(opt.fullscreentoggledby);
                        } else if (0 == jQuery(".rs-go-fullscreen").length && ("togglefullscreen" == a.action || "gofullscreen" == a.action)) {
                            var gf = 0 < opt.c.closest(".forcefullwidth_wrapper_tp_banner").length ? opt.c.closest(".forcefullwidth_wrapper_tp_banner") : opt.c.closest(".rev_slider_wrapper");
                            gf.addClass("rs-go-fullscreen"),
                                (opt.oldminheight = opt.minHeight),
                                (opt.minHeight = jQuery(window).height()),
                                (opt.infullscreenmode = !0),
                                opt.c.revredraw(),
                                jQuery(window).trigger("resize"),
                                _R.toggleState(opt.fullscreentoggledby);
                        }
                        break;
                    default:
                        var obj = {};
                        (obj.event = a), (obj.layer = _nc), opt.c.trigger("layeraction", [obj]);
                }
            },
            getOffContH = function (e) {
                if (null == e) return 0;
                if (1 < e.split(",").length) {
                    var t = e.split(","),
                        i = 0;
                    return (
                        t &&
                            jQuery.each(t, function (e, t) {
                                0 < jQuery(t).length && (i += jQuery(t).outerHeight(!0));
                            }),
                        i
                    );
                }
                return jQuery(e).height();
            };
    })(jQuery),
    (function (e) {
        "use strict";
        var c = jQuery.fn.revolution,
            n = { alias: "Carousel Min JS", name: "revolution.extensions.carousel.min.js", min_core: "5.3.0", version: "1.2.1" };
        jQuery.extend(!0, c, {
            prepareCarousel: function (e, t, i, a) {
                return (
                    "stop" !== c.compare_version(n).check &&
                    ((i = e.carousel.lastdirection = d(i, e.carousel.lastdirection)), r(e), (e.carousel.slide_offset_target = s(e)), void (void 0 !== a ? u(e, i, !1, 0) : null == t ? c.carouselToEvalPosition(e, i) : u(e, i, !1)))
                );
            },
            carouselToEvalPosition: function (e, t) {
                var i = e.carousel;
                t = i.lastdirection = d(t, i.lastdirection);
                var a = "center" === i.horizontal_align ? (i.wrapwidth / 2 - i.slide_width / 2 - i.slide_globaloffset) / i.slide_width : (0 - i.slide_globaloffset) / i.slide_width,
                    n = c.simp(a, e.slideamount, !1),
                    r = n - Math.floor(n),
                    s = 0,
                    o = -1 * (Math.ceil(n) - n),
                    l = -1 * (Math.floor(n) - n);
                (s = (0.3 <= r && "left" === t) || (0.7 <= r && "right" === t) ? o : (r < 0.3 && "left" === t) || (r < 0.7 && "right" === t) ? l : s),
                    (s = "off" === i.infinity ? (n < 0 ? n : a > e.slideamount - 1 ? a - (e.slideamount - 1) : s) : s),
                    (i.slide_offset_target = s * i.slide_width),
                    0 !== Math.abs(i.slide_offset_target) ? u(e, t, !0) : c.organiseCarousel(e, t);
            },
            organiseCarousel: function (s, o, l, e) {
                o = void 0 === o || "down" == o || "up" == o || null === o || jQuery.isEmptyObject(o) ? "left" : o;
                for (var d = s.carousel, c = new Array(), u = d.slides.length, t = ("right" === d.horizontal_align && s.width, 0); t < u; t++) {
                    var i = t * d.slide_width + d.slide_offset;
                    "on" === d.infinity && (i = (i = i > d.wrapwidth - d.inneroffset && "right" == o ? d.slide_offset - (d.slides.length - t) * d.slide_width : i) < 0 - d.inneroffset - d.slide_width && "left" == o ? i + d.maxwidth : i),
                        (c[t] = i);
                }
                var h = 999;
                d.slides &&
                    jQuery.each(d.slides, function (e, t) {
                        var i = c[e];
                        "on" === d.infinity &&
                            (i =
                                (i = i > d.wrapwidth - d.inneroffset && "left" === o ? c[0] - (u - e) * d.slide_width : i) < 0 - d.inneroffset - d.slide_width
                                    ? "left" == o
                                        ? i + d.maxwidth
                                        : "right" === o
                                        ? c[u - 1] + (e + 1) * d.slide_width
                                        : i
                                    : i);
                        var a = new Object();
                        a.left = i + d.inneroffset;
                        var n = "center" === d.horizontal_align ? (Math.abs(d.wrapwidth / 2) - (a.left + d.slide_width / 2)) / d.slide_width : (d.inneroffset - a.left) / d.slide_width,
                            r = "center" === d.horizontal_align ? 2 : 1;
                        if (
                            (((l && Math.abs(n) < h) || 0 === n) && ((h = Math.abs(n)), (d.focused = e)),
                            (a.width = d.slide_width),
                            (a.x = 0),
                            (a.transformPerspective = 1200),
                            (a.transformOrigin = "50% " + d.vertical_align),
                            "on" === d.fadeout)
                        )
                            if ("on" === d.vary_fade) a.autoAlpha = 1 - Math.abs((1 / Math.ceil(d.maxVisibleItems / r)) * n);
                            else
                                switch (d.horizontal_align) {
                                    case "center":
                                        a.autoAlpha = Math.abs(n) < Math.ceil(d.maxVisibleItems / r - 1) ? 1 : 1 - (Math.abs(n) - Math.floor(Math.abs(n)));
                                        break;
                                    case "left":
                                        a.autoAlpha = n < 1 && 0 < n ? 1 - n : Math.abs(n) > d.maxVisibleItems - 1 ? 1 - (Math.abs(n) - (d.maxVisibleItems - 1)) : 1;
                                        break;
                                    case "right":
                                        a.autoAlpha = -1 < n && n < 0 ? 1 - Math.abs(n) : n > d.maxVisibleItems - 1 ? 1 - (Math.abs(n) - (d.maxVisibleItems - 1)) : 1;
                                }
                        else a.autoAlpha = Math.abs(n) < Math.ceil(d.maxVisibleItems / r) ? 1 : 0;
                        if (void 0 !== d.minScale && 0 < d.minScale)
                            if ("on" === d.vary_scale) {
                                a.scale = 1 - Math.abs((d.minScale / 100 / Math.ceil(d.maxVisibleItems / r)) * n);
                                d.slide_width, d.slide_width, a.scale, Math.abs(n);
                            } else {
                                a.scale = 1 <= n || n <= -1 ? 1 - d.minScale / 100 : (100 - d.minScale * Math.abs(n)) / 100;
                                d.slide_width, d.slide_width, d.minScale, Math.abs(n);
                            }
                        void 0 !== d.maxRotation &&
                            0 != Math.abs(d.maxRotation) &&
                            ("on" === d.vary_rotation
                                ? ((a.rotationY = Math.abs(d.maxRotation) - Math.abs((1 - Math.abs((1 / Math.ceil(d.maxVisibleItems / r)) * n)) * d.maxRotation)), (a.autoAlpha = 90 < Math.abs(a.rotationY) ? 0 : a.autoAlpha))
                                : (a.rotationY = 1 <= n || n <= -1 ? d.maxRotation : Math.abs(n) * d.maxRotation),
                            (a.rotationY = n < 0 ? -1 * a.rotationY : a.rotationY)),
                            (a.x = -1 * d.space * n),
                            (a.left = Math.floor(a.left)),
                            (a.x = Math.floor(a.x)),
                            a.scale,
                            a.x,
                            (a.zIndex = Math.round(100 - Math.abs(5 * n))),
                            (a.transformStyle = "3D" != s.parallax.type && "3d" != s.parallax.type ? "flat" : "preserve-3d"),
                            punchgs.TweenLite.set(t, a);
                    }),
                    e && (s.c.find(".next-revslide").removeClass("next-revslide"), jQuery(d.slides[d.focused]).addClass("next-revslide"), s.c.trigger("revolution.nextslide.waiting")),
                    d.wrapwidth,
                    d.slide_offset,
                    d.maxwidth,
                    d.slide_offset,
                    d.wrapwidth;
            },
        });
        var r = function (e) {
                void 0 === e.bw && c.setSize(e);
                var t,
                    i,
                    a = e.carousel,
                    n = c.getHorizontalOffset(e.c, "left"),
                    r = c.getHorizontalOffset(e.c, "right");
                void 0 === a.wrap &&
                    (((i = (t = e).carousel).infbackup = i.infinity),
                    (i.maxVisiblebackup = i.maxVisibleItems),
                    (i.slide_globaloffset = "none"),
                    (i.slide_offset = 0),
                    (i.wrap = t.c.find(".tp-carousel-wrapper")),
                    (i.slides = t.c.find(".tp-revslider-slidesli")),
                    0 !== i.maxRotation &&
                        ("3D" != t.parallax.type && "3d" != t.parallax.type
                            ? punchgs.TweenLite.set(i.wrap, { perspective: 1200, transformStyle: "flat" })
                            : punchgs.TweenLite.set(i.wrap, { perspective: 1600, transformStyle: "preserve-3d" })),
                    void 0 !== i.border_radius && 0 < parseInt(i.border_radius, 0) && punchgs.TweenLite.set(t.c.find(".tp-revslider-slidesli"), { borderRadius: i.border_radius })),
                    (a.slide_width = "on" !== a.stretch ? e.gridwidth[e.curWinRange] * e.bw : e.c.width()),
                    (a.maxwidth = e.slideamount * a.slide_width),
                    a.maxVisiblebackup > a.slides.length + 1 && (a.maxVisibleItems = a.slides.length + 2),
                    (a.wrapwidth = a.maxVisibleItems * a.slide_width + (a.maxVisibleItems - 1) * a.space),
                    (a.wrapwidth =
                        "auto" != e.sliderLayout ? (a.wrapwidth > e.c.closest(".tp-simpleresponsive").width() ? e.c.closest(".tp-simpleresponsive").width() : a.wrapwidth) : a.wrapwidth > e.ul.width() ? e.ul.width() : a.wrapwidth),
                    (a.infinity = a.wrapwidth >= a.maxwidth ? "off" : a.infbackup),
                    (a.wrapoffset = "center" === a.horizontal_align ? (e.c.width() - r - n - a.wrapwidth) / 2 : 0),
                    (a.wrapoffset = "auto" != e.sliderLayout && e.outernav ? 0 : a.wrapoffset < n ? n : a.wrapoffset);
                var s = "hidden";
                ("3D" != e.parallax.type && "3d" != e.parallax.type) || (s = "visible"),
                    "right" === a.horizontal_align
                        ? punchgs.TweenLite.set(a.wrap, { left: "auto", right: a.wrapoffset + "px", width: a.wrapwidth, overflow: s })
                        : punchgs.TweenLite.set(a.wrap, { right: "auto", left: a.wrapoffset + "px", width: a.wrapwidth, overflow: s }),
                    (a.inneroffset = "right" === a.horizontal_align ? a.wrapwidth - a.slide_width : 0),
                    (a.realoffset = Math.abs(a.wrap.position().left)),
                    (a.windhalf = jQuery(window).width() / 2);
            },
            d = function (e, t) {
                return null === e || jQuery.isEmptyObject(e) ? t : void 0 === e ? "right" : e;
            },
            u = function (t, i, a, e) {
                var n = t.carousel;
                i = n.lastdirection = d(i, n.lastdirection);
                var r = new Object(),
                    s = a ? punchgs.Power2.easeOut : n.easing;
                (r.from = 0),
                    (r.to = n.slide_offset_target),
                    (e = void 0 === e ? n.speed / 1e3 : e),
                    (e = a ? 0.4 : e),
                    void 0 !== n.positionanim && n.positionanim.pause(),
                    (n.positionanim = punchgs.TweenLite.to(r, e, {
                        from: r.to,
                        onUpdate: function () {
                            (n.slide_offset = n.slide_globaloffset + r.from), (n.slide_offset = c.simp(n.slide_offset, n.maxwidth)), c.organiseCarousel(t, i, !1, !1);
                        },
                        onComplete: function () {
                            (n.slide_globaloffset = "off" === n.infinity ? n.slide_globaloffset + n.slide_offset_target : c.simp(n.slide_globaloffset + n.slide_offset_target, n.maxwidth)),
                                (n.slide_offset = c.simp(n.slide_offset, n.maxwidth)),
                                c.organiseCarousel(t, i, !1, !0);
                            var e = jQuery(t.li[n.focused]);
                            t.c.find(".next-revslide").removeClass("next-revslide"), a && c.callingNewSlide(t.c, e.data("index"));
                        },
                        ease: s,
                    }));
            },
            h = function (e, t) {
                return Math.abs(e) > Math.abs(t) ? (0 < e ? e - Math.abs(Math.floor(e / t) * t) : e + Math.abs(Math.floor(e / t) * t)) : e;
            },
            s = function (e) {
                var t,
                    i,
                    a,
                    n,
                    r,
                    s = 0,
                    o = e.carousel;
                if ((void 0 !== o.positionanim && o.positionanim.kill(), "none" == o.slide_globaloffset)) o.slide_globaloffset = s = "center" === o.horizontal_align ? o.wrapwidth / 2 - o.slide_width / 2 : 0;
                else {
                    (o.slide_globaloffset = o.slide_offset), (o.slide_offset = 0);
                    var l = e.c.find(".processing-revslide").index(),
                        d = "center" === o.horizontal_align ? (o.wrapwidth / 2 - o.slide_width / 2 - o.slide_globaloffset) / o.slide_width : (0 - o.slide_globaloffset) / o.slide_width;
                    (d = c.simp(d, e.slideamount, !1)),
                        (l = 0 <= (l = 0 <= l ? l : e.c.find(".active-revslide").index()) ? l : 0),
                        (s = "off" === o.infinity ? d - l : ((t = d), (i = l), (a = e.slideamount), (r = i - a - t), (n = h((n = i - t), a)), (r = h(r, a)), -(Math.abs(n) > Math.abs(r) ? r : n))),
                        (s *= o.slide_width);
                }
                return s;
            };
    })(jQuery),
    (function (e) {
        "use strict";
        var v = jQuery.fn.revolution,
            y = { alias: "KenBurns Min JS", name: "revolution.extensions.kenburn.min.js", min_core: "5.4", version: "1.3.1" };
        jQuery.extend(!0, v, {
            stopKenBurn: function (e) {
                if ("stop" === v.compare_version(y).check) return !1;
                null != e.data("kbtl") && e.data("kbtl").pause();
            },
            startKenBurn: function (e, t, i) {
                if ("stop" === v.compare_version(y).check) return !1;
                var a = e.data(),
                    n = e.find(".defaultimg"),
                    r = n.data("lazyload") || n.data("src"),
                    s = (a.owidth, a.oheight, "carousel" === t.sliderType ? t.carousel.slide_width : t.ul.width()),
                    o = t.ul.height();
                if ((e.data("kbtl") && e.data("kbtl").kill(), (i = i || 0), 0 == e.find(".tp-kbimg").length)) {
                    var l = n.data("mediafilter");
                    (l = void 0 === l ? "" : l),
                        e.append(
                            '<div class="tp-kbimg-wrap ' +
                                l +
                                '" style="z-index:2;width:100%;height:100%;top:0px;left:0px;position:absolute;"><img class="tp-kbimg" src="' +
                                r +
                                '" style="position:absolute;" width="' +
                                a.owidth +
                                '" height="' +
                                a.oheight +
                                '"></div>'
                        ),
                        e.data("kenburn", e.find(".tp-kbimg"));
                }
                var f = function (e, t, i, a, n, r, s) {
                    var o = e * i,
                        l = t * i,
                        d = Math.abs(a - o),
                        c = Math.abs(n - l),
                        u = new Object();
                    return (u.l = (0 - r) * d), (u.r = u.l + o), (u.t = (0 - s) * c), (u.b = u.t + l), (u.h = r), (u.v = s), u;
                };
                null != e.data("kbtl") && (e.data("kbtl").kill(), e.removeData("kbtl"));
                var d = e.data("kenburn"),
                    c = d.parent(),
                    u = (function (e, t, i) {
                        var a = i.scalestart / 100,
                            n = i.scaleend / 100,
                            r = (null != i.offsetstart && i.offsetstart.split(" ")) || [0, 0],
                            s = (null != i.offsetend && i.offsetend.split(" ")) || [0, 0];
                        i.bgposition = "center center" == i.bgposition ? "50% 50%" : i.bgposition;
                        var o = new Object();
                        i.owidth, i.oheight;
                        if (
                            (i.owidth,
                            i.oheight,
                            (o.start = new Object()),
                            (o.starto = new Object()),
                            (o.end = new Object()),
                            (o.endo = new Object()),
                            (o.start.width = e),
                            (o.start.height = (o.start.width / i.owidth) * i.oheight),
                            o.start.height < t)
                        ) {
                            var l = t / o.start.height;
                            (o.start.height = t), (o.start.width = o.start.width * l);
                        }
                        (o.start.transformOrigin = i.bgposition),
                            (o.start.scale = a),
                            (o.end.scale = n),
                            (i.rotatestart = 0 === i.rotatestart ? 0.01 : i.rotatestart),
                            (o.start.rotation = i.rotatestart + "deg"),
                            (o.end.rotation = i.rotateend + "deg");
                        var d = (function (e, t, i, a, n) {
                            var r = e.bgposition.split(" ") || "center center",
                                s = "center" == r[0] ? "50%" : "left" == r[0] || "left" == r[1] ? "0%" : "right" == r[0] || "right" == r[1] ? "100%" : r[0],
                                o = "center" == r[1] ? "50%" : "top" == r[0] || "top" == r[1] ? "0%" : "bottom" == r[0] || "bottom" == r[1] ? "100%" : r[1];
                            (s = parseInt(s, 0) / 100 || 0), (o = parseInt(o, 0) / 100 || 0);
                            var l = new Object();
                            return (l.start = f(n.start.width, n.start.height, n.start.scale, t, i, s, o)), (l.end = f(n.start.width, n.start.height, n.end.scale, t, i, s, o)), l;
                        })(i, e, t, 0, o);
                        (r[0] = parseFloat(r[0]) + d.start.l), (s[0] = parseFloat(s[0]) + d.end.l), (r[1] = parseFloat(r[1]) + d.start.t), (s[1] = parseFloat(s[1]) + d.end.t);
                        var c = d.start.r - d.start.l,
                            u = d.start.b - d.start.t,
                            h = d.end.r - d.end.l,
                            p = d.end.b - d.end.t;
                        return (
                            (r[0] = 0 < r[0] ? 0 : c + r[0] < e ? e - c : r[0]),
                            (s[0] = 0 < s[0] ? 0 : h + s[0] < e ? e - h : s[0]),
                            (r[1] = 0 < r[1] ? 0 : u + r[1] < t ? t - u : r[1]),
                            (s[1] = 0 < s[1] ? 0 : p + s[1] < t ? t - p : s[1]),
                            (o.starto.x = r[0] + "px"),
                            (o.starto.y = r[1] + "px"),
                            (o.endo.x = s[0] + "px"),
                            (o.endo.y = s[1] + "px"),
                            (o.end.ease = o.endo.ease = i.ease),
                            (o.end.force3D = o.endo.force3D = !0),
                            o
                        );
                    })(s, o, a),
                    h = new punchgs.TimelineLite();
                if (
                    (h.pause(),
                    (u.start.transformOrigin = "0% 0%"),
                    (u.starto.transformOrigin = "0% 0%"),
                    h.add(punchgs.TweenLite.fromTo(d, a.duration / 1e3, u.start, u.end), 0),
                    h.add(punchgs.TweenLite.fromTo(c, a.duration / 1e3, u.starto, u.endo), 0),
                    void 0 !== a.blurstart && void 0 !== a.blurend && (0 !== a.blurstart || 0 !== a.blurend))
                ) {
                    var p = { a: a.blurstart },
                        g = { a: a.blurend, ease: u.endo.ease },
                        m = new punchgs.TweenLite(p, a.duration / 1e3, g);
                    m.eventCallback(
                        "onUpdate",
                        function (e) {
                            punchgs.TweenLite.set(e, { filter: "blur(" + p.a + "px)", webkitFilter: "blur(" + p.a + "px)" });
                        },
                        [c]
                    ),
                        h.add(m, 0);
                }
                h.progress(i), h.play(), e.data("kbtl", h);
            },
        });
    })(jQuery),
    (function (e) {
        "use strict";
        var D = jQuery.fn.revolution,
            d = (D.is_mobile(), D.is_android(), { alias: "LayerAnimation Min JS", name: "revolution.extensions.layeranimation.min.js", min_core: "5.4.6.4", version: "3.6.5" });
        jQuery.extend(!0, D, {
            updateMarkup: function (e, t) {
                var i = jQuery(e).data();
                if (void 0 !== i.start && !i.frames_added && void 0 === i.frames) {
                    var a = new Array(),
                        n = H(F(), i.transform_in, void 0, !1),
                        r = H(F(), i.transform_out, void 0, !1),
                        s = H(F(), i.transform_hover, void 0, !1);
                    jQuery.isNumeric(i.end) && jQuery.isNumeric(i.start) && jQuery.isNumeric(n.speed) && (i.end = parseInt(i.end, 0) - (parseInt(i.start, 0) + parseFloat(n.speed, 0))),
                        a.push({ frame: "0", delay: i.start, from: i.transform_in, to: i.transform_idle, split: i.splitin, speed: n.speed, ease: n.anim.ease, mask: i.mask_in, splitdelay: i.elementdelay }),
                        a.push({ frame: "5", delay: i.end, to: i.transform_out, split: i.splitout, speed: r.speed, ease: r.anim.ease, mask: i.mask_out, splitdelay: i.elementdelay }),
                        i.transform_hover && a.push({ frame: "hover", to: i.transform_hover, style: i.style_hover, speed: s.speed, ease: s.anim.ease, splitdelay: i.elementdelay }),
                        (i.frames = a);
                }
                if (!i.frames_added) {
                    if (((i.inframeindex = 0), (i.outframeindex = -1), (i.hoverframeindex = -1), void 0 !== i.frames))
                        for (var o = 0; o < i.frames.length; o++)
                            void 0 !== i.frames[o].sfx_effect && 0 <= i.frames[o].sfx_effect.indexOf("block") && ((i.frames[o].to = 0 === o ? ((i.frames[o].from = "o:0"), "o:1") : "o:0"), (i._sfx = "block")),
                                void 0 === i.frames[0].from && (i.frames[0].from = "o:inherit"),
                                0 === i.frames[0].delay && (i.frames[0].delay = 20),
                                "hover" === i.frames[o].frame
                                    ? (i.hoverframeindex = o)
                                    : ("frame_999" !== i.frames[o].frame && "frame_out" !== i.frames[o].frame && "last" !== i.frames[o].frame && "end" !== i.frames[o].frame) || (i.outframeindex = o),
                                void 0 !== i.frames[o].split && i.frames[o].split.match(/chars|words|lines/g) && (i.splittext = !0);
                    (i.outframeindex = -1 === i.outframeindex ? (-1 === i.hoverframeindex ? i.frames.length - 1 : i.frames.length - 2) : i.outframeindex), (i.frames_added = !0);
                }
            },
            animcompleted: function (e, t) {
                var i = e.data(),
                    a = i.videotype,
                    n = i.autoplay,
                    r = i.autoplayonlyfirsttime;
                null != a &&
                    "none" != a &&
                    (1 == n || "true" == n || "on" == n || "1sttime" == n || r
                        ? (("carousel" !== t.sliderType ||
                              ("carousel" === t.sliderType && "on" === t.carousel.showLayersAllTime && e.closest("li").hasClass("active-revslide")) ||
                              ("carousel" === t.sliderType && "on" !== t.carousel.showLayersAllTime && e.closest("li").hasClass("active-revslide"))) &&
                              D.playVideo(e, t),
                          D.toggleState(e.data("videotoggledby")),
                          (r || "1sttime" == n) && ((i.autoplayonlyfirsttime = !1), (i.autoplay = "off")))
                        : ("no1sttime" == n && (i.datasetautoplay = "on"), D.unToggleState(e.data("videotoggledby"))));
            },
            handleStaticLayers: function (e, t) {
                var i = parseInt(e.data("startslide"), 0),
                    a = parseInt(e.data("endslide"), 0);
                i < 0 && (i = 0), a < 0 && (a = t.realslideamount), 0 === i && a === t.realslideamount - 1 && (a = t.realslideamount + 1), e.data("startslide", i), e.data("endslide", a);
            },
            animateTheCaptions: function (e) {
                if ("stop" === D.compare_version(d).check) return !1;
                var h = e.opt,
                    t = e.slide,
                    n = e.recall,
                    i = e.maintimeline,
                    r = e.preset,
                    s = e.startslideanimat,
                    o = "carousel" === h.sliderType ? 0 : h.width / 2 - (h.gridwidth[h.curWinRange] * h.bw) / 2,
                    a = t.data("index");
                if (
                    ((h.layers = h.layers || new Object()),
                    (h.layers[a] = h.layers[a] || t.find(".tp-caption")),
                    (h.layers.static = h.layers.static || h.c.find(".tp-static-layers").find(".tp-caption")),
                    void 0 === h.timelines && D.createTimelineStructure(h),
                    (h.conh = h.c.height()),
                    (h.conw = h.c.width()),
                    (h.ulw = h.ul.width()),
                    (h.ulh = h.ul.height()),
                    h.debugMode)
                ) {
                    t.addClass("indebugmode"),
                        t.find(".helpgrid").remove(),
                        h.c.find(".hglayerinfo").remove(),
                        t.append('<div class="helpgrid" style="width:' + h.gridwidth[h.curWinRange] * h.bw + "px;height:" + h.gridheight[h.curWinRange] * h.bw + 'px;"></div>');
                    var l = t.find(".helpgrid");
                    l.append(
                        '<div class="hginfo">Zoom:' +
                            Math.round(100 * h.bw) +
                            "% &nbsp;&nbsp;&nbsp; Device Level:" +
                            h.curWinRange +
                            "&nbsp;&nbsp;&nbsp; Grid Preset:" +
                            h.gridwidth[h.curWinRange] +
                            "x" +
                            h.gridheight[h.curWinRange] +
                            "</div>"
                    ),
                        h.c.append('<div class="hglayerinfo"></div>'),
                        l.append('<div class="tlhg"></div>');
                }
                void 0 !== a &&
                    h.layers[a] &&
                    jQuery.each(h.layers[a], function (e, t) {
                        var i = jQuery(this);
                        D.updateMarkup(this, h),
                            D.prepareSingleCaption({ caption: i, opt: h, offsetx: o, offsety: 0, index: e, recall: n, preset: r }),
                            (r && 0 !== s) || D.buildFullTimeLine({ caption: i, opt: h, offsetx: o, offsety: 0, index: e, recall: n, preset: r, regenerate: 0 === s }),
                            n && "carousel" === h.sliderType && "on" === h.carousel.showLayersAllTime && D.animcompleted(i, h);
                    }),
                    h.layers.static &&
                        jQuery.each(h.layers.static, function (e, t) {
                            var i = jQuery(this),
                                a = i.data();
                            !0 !== a.hoveredstatus && !0 !== a.inhoveroutanimation
                                ? (D.updateMarkup(this, h),
                                  D.prepareSingleCaption({ caption: i, opt: h, offsetx: o, offsety: 0, index: e, recall: n, preset: r }),
                                  (r && 0 !== s) || !0 === a.veryfirstststic || (D.buildFullTimeLine({ caption: i, opt: h, offsetx: o, offsety: 0, index: e, recall: n, preset: r, regenerate: 0 === s }), (a.veryfirstststic = !0)),
                                  n && "carousel" === h.sliderType && "on" === h.carousel.showLayersAllTime && D.animcompleted(i, h))
                                : D.prepareSingleCaption({ caption: i, opt: h, offsetx: o, offsety: 0, index: e, recall: n, preset: r });
                        });
                var p = -1 === h.nextSlide || void 0 === h.nextSlide ? 0 : h.nextSlide;
                void 0 !== h.rowzones && (p = p > h.rowzones.length ? h.rowzones.length : p),
                    null != h.rowzones && 0 < h.rowzones.length && null != h.rowzones[p] && 0 <= p && p <= h.rowzones.length && 0 < h.rowzones[p].length && D.setSize(h),
                    r ||
                        (void 0 !== s &&
                            (void 0 !== a &&
                                jQuery.each(h.timelines[a].layers, function (e, t) {
                                    var i = t.layer.data();
                                    ("none" !== t.wrapper && void 0 !== t.wrapper) ||
                                        ("keep" == t.triggerstate && "on" === i.triggerstate
                                            ? D.playAnimationFrame({ caption: t.layer, opt: h, frame: "frame_0", triggerdirection: "in", triggerframein: "frame_0", triggerframeout: "frame_999" })
                                            : t.timeline.restart());
                                }),
                            h.timelines.staticlayers &&
                                jQuery.each(h.timelines.staticlayers.layers, function (e, t) {
                                    var i = t.layer.data(),
                                        a = p >= t.firstslide && p <= t.lastslide,
                                        n = p < t.firstslide || p > t.lastslide,
                                        r = t.timeline.getLabelTime("slide_" + t.firstslide),
                                        s = t.timeline.getLabelTime("slide_" + t.lastslide),
                                        o = i.static_layer_timeline_time,
                                        l = "in" === i.animdirection || ("out" !== i.animdirection && void 0),
                                        d = "bytrigger" === i.frames[0].delay,
                                        c = (i.frames[i.frames.length - 1].delay, i.triggered_startstatus),
                                        u = i.lasttriggerstate;
                                    !0 !== i.hoveredstatus &&
                                        1 != i.inhoveroutanimation &&
                                        (void 0 !== o &&
                                            l &&
                                            ("keep" == u
                                                ? (D.playAnimationFrame({ caption: t.layer, opt: h, frame: "frame_0", triggerdirection: "in", triggerframein: "frame_0", triggerframeout: "frame_999" }), i.triggeredtimeline.time(o))
                                                : !0 !== i.hoveredstatus && t.timeline.time(o)),
                                        "reset" === u && "hidden" === c && (t.timeline.time(0), (i.animdirection = "out")),
                                        a
                                            ? l
                                                ? p === t.lastslide && (t.timeline.play(s), (i.animdirection = "in"))
                                                : (d || "in" === i.animdirection || t.timeline.play(r),
                                                  (("visible" == c && "keep" !== u) || ("keep" === u && !0 === l) || ("visible" == c && void 0 === l)) && (t.timeline.play(r + 0.01), (i.animdirection = "in")))
                                            : n && l && t.timeline.play("frame_999"));
                                }))),
                    null != i &&
                        setTimeout(function () {
                            i.resume();
                        }, 30);
            },
            prepareSingleCaption: function (e) {
                var t = e.caption,
                    i = t.data(),
                    a = e.opt,
                    n = e.recall,
                    r = e.recall,
                    s = (e.preset, jQuery("body").hasClass("rtl"));
                if (
                    ((i._pw = void 0 === i._pw ? t.closest(".tp-parallax-wrap") : i._pw),
                    (i._lw = void 0 === i._lw ? t.closest(".tp-loop-wrap") : i._lw),
                    (i._mw = void 0 === i._mw ? t.closest(".tp-mask-wrap") : i._mw),
                    (i._responsive = i.responsive || "on"),
                    (i._respoffset = i.responsive_offset || "on"),
                    (i._ba = i.basealign || "grid"),
                    (i._gw = "grid" === i._ba ? a.width : a.ulw),
                    (i._gh = "grid" === i._ba ? a.height : a.ulh),
                    (i._lig =
                        void 0 === i._lig
                            ? t.hasClass("rev_layer_in_group")
                                ? t.closest(".rev_group")
                                : t.hasClass("rev_layer_in_column")
                                ? t.closest(".rev_column_inner")
                                : t.hasClass("rev_column_inner")
                                ? t.closest(".rev_row")
                                : "none"
                            : i._lig),
                    (i._column = void 0 === i._column ? (t.hasClass("rev_column_inner") ? t.closest(".rev_column") : "none") : i._column),
                    (i._row = void 0 === i._row ? (t.hasClass("rev_column_inner") ? t.closest(".rev_row") : "none") : i._row),
                    (i._ingroup = void 0 === i._ingroup ? !(t.hasClass("rev_group") || !t.closest(".rev_group")) : i._ingroup),
                    (i._isgroup = void 0 === i._isgroup ? !!t.hasClass("rev_group") : i._isgroup),
                    (i._nctype = i.type || "none"),
                    (i._cbgc_auto = void 0 === i._cbgc_auto ? "column" === i._nctype && i._pw.find(".rev_column_bg_auto_sized") : i._cbgc_auto),
                    (i._cbgc_man = void 0 === i._cbgc_man ? "column" === i._nctype && i._pw.find(".rev_column_bg_man_sized") : i._cbgc_man),
                    (i._slideid = i._slideid || t.closest(".tp-revslider-slidesli").data("index")),
                    (i._id = void 0 === i._id ? t.data("id") || t.attr("id") : i._id),
                    (i._slidelink = void 0 === i._slidelink ? void 0 !== t.hasClass("slidelink") && t.hasClass("slidelink") : i._slidelink),
                    void 0 === i._li && (t.hasClass("tp-static-layer") ? ((i._isstatic = !0), (i._li = t.closest(".tp-static-layers")), (i._slideid = "staticlayers")) : (i._li = t.closest(".tp-revslider-slidesli"))),
                    (i._row = void 0 === i._row ? "column" === i._nctype && i._pw.closest(".rev_row") : i._row),
                    void 0 === i._togglelisteners && t.find(".rs-toggled-content")
                        ? ((i._togglelisteners = !0),
                          void 0 === i.actions &&
                              t.click(function () {
                                  D.swaptoggleState(t);
                              }))
                        : (i._togglelisteners = !1),
                    "fullscreen" == a.sliderLayout && (e.offsety = i._gh / 2 - (a.gridheight[a.curWinRange] * a.bh) / 2),
                    ("on" == a.autoHeight || (null != a.minHeight && 0 < a.minHeight)) && (e.offsety = a.conh / 2 - (a.gridheight[a.curWinRange] * a.bh) / 2),
                    e.offsety < 0 && (e.offsety = 0),
                    a.debugMode)
                ) {
                    t.closest("li")
                        .find(".helpgrid")
                        .css({ top: e.offsety + "px", left: e.offsetx + "px" });
                    var o = a.c.find(".hglayerinfo");
                    t.on("hover, mouseenter", function () {
                        var i = "";
                        t.data() &&
                            jQuery.each(t.data(), function (e, t) {
                                "object" != typeof t && (i = i + '<span style="white-space:nowrap"><span style="color:#27ae60">' + e + ":</span>" + t + "</span>&nbsp; &nbsp; ");
                            }),
                            o.html(i);
                    });
                }
                if (
                    ("off" === (void 0 === i.visibility ? "oon" : B(i.visibility, a)[a.forcedWinRange] || B(i.visibility, a) || "ooon") || (i._gw < a.hideCaptionAtLimit && "on" == i.captionhidden) || i._gw < a.hideAllCaptionAtLimit
                        ? i._pw.addClass("tp-hidden-caption")
                        : i._pw.removeClass("tp-hidden-caption"),
                    (i.layertype = "html"),
                    e.offsetx < 0 && (e.offsetx = 0),
                    null != i.thumbimage && null == i.videoposter && (i.videoposter = i.thumbimage),
                    0 < t.find("img").length)
                ) {
                    var l = t.find("img");
                    (i.layertype = "image"),
                        0 == l.width() && l.css({ width: "auto" }),
                        0 == l.height() && l.css({ height: "auto" }),
                        null == l.data("ww") && 0 < l.width() && l.data("ww", l.width()),
                        null == l.data("hh") && 0 < l.height() && l.data("hh", l.height());
                    var d = l.data("ww"),
                        c = l.data("hh"),
                        u = "slide" == i._ba ? a.ulw : a.gridwidth[a.curWinRange],
                        h = "slide" == i._ba ? a.ulh : a.gridheight[a.curWinRange],
                        p = "full" === (d = B(l.data("ww"), a)[a.curWinRange] || B(l.data("ww"), a) || "auto") || "full-proportional" === d,
                        f = "full" === (c = B(l.data("hh"), a)[a.curWinRange] || B(l.data("hh"), a) || "auto") || "full-proportional" === c;
                    if ("full-proportional" === d) {
                        var g = l.data("owidth"),
                            m = l.data("oheight");
                        g / u < m / h ? (c = m * ((d = u) / g)) : (d = g * ((c = h) / m));
                    } else (d = p ? u : !jQuery.isNumeric(d) && 0 < d.indexOf("%") ? d : parseFloat(d)), (c = f ? h : !jQuery.isNumeric(c) && 0 < c.indexOf("%") ? c : parseFloat(c));
                    (d = void 0 === d ? 0 : d),
                        (c = void 0 === c ? 0 : c),
                        "off" !== i._responsive
                            ? ("grid" != i._ba && p ? (jQuery.isNumeric(d) ? l.css({ width: d + "px" }) : l.css({ width: d })) : jQuery.isNumeric(d) ? l.css({ width: d * a.bw + "px" }) : l.css({ width: d }),
                              "grid" != i._ba && f ? (jQuery.isNumeric(c) ? l.css({ height: c + "px" }) : l.css({ height: c })) : jQuery.isNumeric(c) ? l.css({ height: c * a.bh + "px" }) : l.css({ height: c }))
                            : l.css({ width: d, height: c }),
                        i._ingroup &&
                            "row" !== i._nctype &&
                            (void 0 !== d && !jQuery.isNumeric(d) && "string" === jQuery.type(d) && 0 < d.indexOf("%") && punchgs.TweenLite.set([i._lw, i._pw, i._mw], { minWidth: d }),
                            void 0 !== c && !jQuery.isNumeric(c) && "string" === jQuery.type(c) && 0 < c.indexOf("%") && punchgs.TweenLite.set([i._lw, i._pw, i._mw], { minHeight: c }));
                }
                if ("slide" === i._ba) (e.offsetx = 0), (e.offsety = 0);
                else if (i._isstatic && void 0 !== a.carousel && void 0 !== a.carousel.horizontal_align && "carousel" === a.sliderType) {
                    switch (a.carousel.horizontal_align) {
                        case "center":
                            e.offsetx = 0 + (a.ulw - a.gridwidth[a.curWinRange] * a.bw) / 2;
                            break;
                        case "left":
                            break;
                        case "right":
                            e.offsetx = a.ulw - a.gridwidth[a.curWinRange] * a.bw;
                    }
                    e.offsetx = e.offsetx < 0 ? 0 : e.offsetx;
                }
                var v = "html5" == i.audio ? "audio" : "video";
                if (t.hasClass("tp-videolayer") || t.hasClass("tp-audiolayer") || 0 < t.find("iframe").length || 0 < t.find(v).length) {
                    (i.layertype = "video"), D.manageVideoLayer && D.manageVideoLayer(t, a, n, r), n || r || (i.videotype, D.resetVideo && D.resetVideo(t, a, e.preset));
                    var y = i.aspectratio;
                    null != y && 1 < y.split(":").length && D.prepareCoveredVideo(a, t), (l = t.find("iframe") ? t.find("iframe") : (l = t.find(v)));
                    var w = !t.find("iframe"),
                        _ = t.hasClass("coverscreenvideo");
                    l.css({ display: "block" }),
                        null == t.data("videowidth") && (t.data("videowidth", l.width()), t.data("videoheight", l.height())),
                        (d = B(t.data("videowidth"), a)[a.curWinRange] || B(t.data("videowidth"), a) || "auto"),
                        (c = B(t.data("videoheight"), a)[a.curWinRange] || B(t.data("videoheight"), a) || "auto"),
                        (d = "auto" === d || (!jQuery.isNumeric(d) && 0 < d.indexOf("%")) ? ("auto" === d ? "auto" : "grid" === i._ba ? a.gridwidth[a.curWinRange] * a.bw : i._gw) : parseFloat(d) * a.bw + "px"),
                        (c = "auto" === c || (!jQuery.isNumeric(c) && 0 < c.indexOf("%")) ? ("auto" === c ? "auto" : "grid" === i._ba ? a.gridheight[a.curWinRange] * a.bw : i._gh) : parseFloat(c) * a.bh + "px"),
                        (i.cssobj = void 0 === i.cssobj ? Y(t, 0) : i.cssobj);
                    var b = X(i.cssobj, a);
                    if (("auto" == b.lineHeight && (b.lineHeight = b.fontSize + 4), t.hasClass("fullscreenvideo") || _)) {
                        (e.offsetx = 0), (e.offsety = 0), t.data("x", 0), t.data("y", 0);
                        var x = i._gh;
                        "on" == a.autoHeight && (x = a.conh), t.css({ width: i._gw, height: x });
                    } else
                        punchgs.TweenLite.set(t, {
                            paddingTop: Math.round(b.paddingTop * a.bh) + "px",
                            paddingBottom: Math.round(b.paddingBottom * a.bh) + "px",
                            paddingLeft: Math.round(b.paddingLeft * a.bw) + "px",
                            paddingRight: Math.round(b.paddingRight * a.bw) + "px",
                            marginTop: b.marginTop * a.bh + "px",
                            marginBottom: b.marginBottom * a.bh + "px",
                            marginLeft: b.marginLeft * a.bw + "px",
                            marginRight: b.marginRight * a.bw + "px",
                            borderTopWidth: Math.round(b.borderTopWidth * a.bh) + "px",
                            borderBottomWidth: Math.round(b.borderBottomWidth * a.bh) + "px",
                            borderLeftWidth: Math.round(b.borderLeftWidth * a.bw) + "px",
                            borderRightWidth: Math.round(b.borderRightWidth * a.bw) + "px",
                            width: d,
                            height: c,
                        });
                    ((0 == w && !_) || (1 != i.forcecover && !t.hasClass("fullscreenvideo") && !_)) && (l.width(d), l.height(c)),
                        i._ingroup && null !== i.videowidth && void 0 !== i.videowidth && !jQuery.isNumeric(i.videowidth) && 0 < i.videowidth.indexOf("%") && punchgs.TweenLite.set([i._lw, i._pw, i._mw], { minWidth: i.videowidth });
                }
                q(t, a, 0, i._responsive),
                    t.hasClass("tp-resizeme") &&
                        t.find("*").each(function () {
                            q(jQuery(this), a, "rekursive", i._responsive);
                        });
                var T = t.outerHeight(),
                    C = t.css("backgroundColor");
                V(t, ".frontcorner", "left", "borderRight", "borderTopColor", T, C),
                    V(t, ".frontcornertop", "left", "borderRight", "borderBottomColor", T, C),
                    V(t, ".backcorner", "right", "borderLeft", "borderBottomColor", T, C),
                    V(t, ".backcornertop", "right", "borderLeft", "borderTopColor", T, C),
                    "on" == a.fullScreenAlignForce && ((e.offsetx = 0), (e.offsety = 0)),
                    "block" === i._sfx && void 0 === i._bmask && ((i._bmask = jQuery('<div class="tp-blockmask"></div>')), i._mw.append(i._bmask)),
                    (i.arrobj = new Object()),
                    (i.arrobj.voa = B(i.voffset, a)[a.curWinRange] || B(i.voffset, a)[0]),
                    (i.arrobj.hoa = B(i.hoffset, a)[a.curWinRange] || B(i.hoffset, a)[0]),
                    (i.arrobj.elx = B(i.x, a)[a.curWinRange] || B(i.x, a)[0]),
                    (i.arrobj.ely = B(i.y, a)[a.curWinRange] || B(i.y, a)[0]);
                var k = 0 == i.arrobj.voa.length ? 0 : i.arrobj.voa,
                    S = 0 == i.arrobj.hoa.length ? 0 : i.arrobj.hoa,
                    j = 0 == i.arrobj.elx.length ? 0 : i.arrobj.elx,
                    L = 0 == i.arrobj.ely.length ? 0 : i.arrobj.ely;
                (i.eow = t.outerWidth(!0)), (i.eoh = t.outerHeight(!0)), 0 == i.eow && 0 == i.eoh && ((i.eow = a.ulw), (i.eoh = a.ulh));
                var O = "off" !== i._respoffset ? parseInt(k, 0) * a.bw : parseInt(k, 0),
                    P = "off" !== i._respoffset ? parseInt(S, 0) * a.bw : parseInt(S, 0),
                    R = "grid" === i._ba ? a.gridwidth[a.curWinRange] * a.bw : i._gw,
                    I = "grid" === i._ba ? a.gridheight[a.curWinRange] * a.bw : i._gh;
                "on" == a.fullScreenAlignForce && ((R = a.ulw), (I = a.ulh)),
                    "none" !== i._lig && null != i._lig && ((R = i._lig.width()), (I = i._lig.height()), (e.offsetx = 0), (e.offsety = 0)),
                    (j = "center" === j || "middle" === j ? R / 2 - i.eow / 2 + P : "left" === j ? P : "right" === j ? R - i.eow - P : "off" !== i._respoffset ? j * a.bw : j),
                    (L = "center" == L || "middle" == L ? I / 2 - i.eoh / 2 + O : "top" == L ? O : "bottom" == L ? I - i.eoh - O : "off" !== i._respoffset ? L * a.bw : L),
                    s && !i._slidelink && (j += i.eow),
                    i._slidelink && (j = 0),
                    (i.calcx = parseInt(j, 0) + e.offsetx),
                    (i.calcy = parseInt(L, 0) + e.offsety);
                var A = t.css("z-Index");
                if ("row" !== i._nctype && "column" !== i._nctype) punchgs.TweenLite.set(i._pw, { zIndex: A, top: i.calcy, left: i.calcx, overwrite: "auto" });
                else if ("row" !== i._nctype) punchgs.TweenLite.set(i._pw, { zIndex: A, width: i.columnwidth, top: 0, left: 0, overwrite: "auto" });
                else if ("row" === i._nctype) {
                    var Q = "grid" === i._ba ? R + "px" : "100%";
                    punchgs.TweenLite.set(i._pw, { zIndex: A, width: Q, top: 0, left: e.offsetx, overwrite: "auto" });
                }
                if (
                    (void 0 !== i.blendmode && punchgs.TweenLite.set(i._pw, { mixBlendMode: i.blendmode }),
                    "row" === i._nctype && (i.columnbreak <= a.curWinRange ? t.addClass("rev_break_columns") : t.removeClass("rev_break_columns")),
                    "on" == i.loopanimation && punchgs.TweenLite.set(i._lw, { minWidth: i.eow, minHeight: i.eoh }),
                    "column" === i._nctype)
                ) {
                    var M = void 0 !== t[0]._gsTransform ? t[0]._gsTransform.y : 0,
                        z = parseInt(i._column[0].style.paddingTop, 0);
                    punchgs.TweenLite.set(t, { y: 0 }), punchgs.TweenLite.set(i._cbgc_man, { y: parseInt(z + i._column.offset().top - t.offset().top, 0) }), punchgs.TweenLite.set(t, { y: M });
                }
                i._ingroup &&
                    "row" !== i._nctype &&
                    (void 0 !== i._groupw && !jQuery.isNumeric(i._groupw) && 0 < i._groupw.indexOf("%") && punchgs.TweenLite.set([i._lw, i._pw, i._mw], { minWidth: i._groupw }),
                    void 0 !== i._grouph && !jQuery.isNumeric(i._grouph) && 0 < i._grouph.indexOf("%") && punchgs.TweenLite.set([i._lw, i._pw, i._mw], { minHeight: i._grouph }));
            },
            createTimelineStructure: function (o) {
                (o.timelines = o.timelines || new Object()),
                    o.c.find(".tp-revslider-slidesli, .tp-static-layers").each(function () {
                        var e = jQuery(this),
                            s = e.data("index");
                        (o.timelines[s] = o.timelines[s] || {}),
                            (o.timelines[s].layers = o.timelines[s].layers || new Object()),
                            e.find(".tp-caption").each(function (e) {
                                var t, i, a, n, r;
                                (t = jQuery(this)),
                                    (i = o.timelines[s].layers),
                                    (a = s),
                                    (r = new punchgs.TimelineLite({ paused: !0 })),
                                    ((i = i || new Object())[t.attr("id")] = i[t.attr("id")] || new Object()),
                                    "staticlayers" === a && ((i[t.attr("id")].firstslide = t.data("startslide")), (i[t.attr("id")].lastslide = t.data("endslide"))),
                                    t.data("slideid", a),
                                    (i[t.attr("id")].defclasses = n = t[0].className),
                                    (i[t.attr("id")].wrapper =
                                        0 <= n.indexOf("rev_layer_in_column")
                                            ? t.closest(".rev_column_inner")
                                            : 0 <= n.indexOf("rev_column_inner")
                                            ? t.closest(".rev_row")
                                            : 0 <= n.indexOf("rev_layer_in_group")
                                            ? t.closest(".rev_group")
                                            : "none"),
                                    (i[t.attr("id")].timeline = r),
                                    (i[t.attr("id")].layer = t),
                                    (i[t.attr("id")].triggerstate = t.data("lasttriggerstate")),
                                    (i[t.attr("id")].dchildren =
                                        0 <= n.indexOf("rev_row")
                                            ? t[0].getElementsByClassName("rev_column_inner")
                                            : 0 <= n.indexOf("rev_column_inner")
                                            ? t[0].getElementsByClassName("tp-caption")
                                            : 0 <= n.indexOf("rev_group")
                                            ? t[0].getElementsByClassName("rev_layer_in_group")
                                            : "none"),
                                    t.data("timeline", r);
                            });
                    });
            },
            buildFullTimeLine: function (e) {
                var t,
                    i,
                    a = e.caption,
                    n = a.data(),
                    r = e.opt,
                    s = {},
                    o = m();
                if (!(t = r.timelines[n._slideid].layers[n._id]).generated || !0 === e.regenerate) {
                    if (
                        ((i = t.timeline),
                        (t.generated = !0),
                        void 0 !== n.current_timeline && !0 !== e.regenerate
                            ? ((n.current_timeline_pause = n.current_timeline.paused()),
                              (n.current_timeline_time = n.current_timeline.time()),
                              (n.current_is_nc_timeline = i === n.current_timeline),
                              (n.static_layer_timeline_time = n.current_timeline_time))
                            : ((n.static_layer_timeline_time = n.current_timeline_time), (n.current_timeline_time = 0), n.current_timeline && n.current_timeline.clear()),
                        i.clear(),
                        (s.svg = null != n.svg_src && a.find("svg")),
                        s.svg && ((n.idlesvg = g(n.svg_idle, f())), punchgs.TweenLite.set(s.svg, n.idlesvg.anim)),
                        -1 !== n.hoverframeindex && void 0 !== n.hoverframeindex && !a.hasClass("rs-hover-ready"))
                    ) {
                        if ((a.addClass("rs-hover-ready"), (n.hovertimelines = {}), (n.hoveranim = H(o, n.frames[n.hoverframeindex].to)), (n.hoveranim = v(n.hoveranim, n.frames[n.hoverframeindex].style)), s.svg)) {
                            var l = g(n.svg_hover, f());
                            null != n.hoveranim.anim.color && ((l.anim.fill = n.hoveranim.anim.color), (n.idlesvg.anim.css.fill = s.svg.css("fill"))), (n.hoversvg = l);
                        }
                        a.hover(
                            function (e) {
                                var t = { caption: jQuery(e.currentTarget), opt: r, firstframe: "frame_0", lastframe: "frame_999" },
                                    i = (p(t), t.caption),
                                    a = i.data(),
                                    n = a.frames[a.hoverframeindex];
                                (a.forcehover = n.force),
                                    (a.hovertimelines.item = punchgs.TweenLite.to(i, n.speed / 1e3, a.hoveranim.anim)),
                                    (a.hoverzIndex || (a.hoveranim.anim && a.hoveranim.anim.zIndex)) &&
                                        ((a.basiczindex = void 0 === a.basiczindex ? a.cssobj.zIndex : a.basiczindex),
                                        (a.hoverzIndex = void 0 === a.hoverzIndex ? a.hoveranim.anim.zIndex : a.hoverzIndex),
                                        (a.inhoverinanimation = !0),
                                        0 === n.speed && (a.inhoverinanimation = !1),
                                        (a.hovertimelines.pwhoveranim = punchgs.TweenLite.to(a._pw, n.speed / 1e3, { overwrite: "auto", zIndex: a.hoverzIndex })),
                                        a.hovertimelines.pwhoveranim.eventCallback(
                                            "onComplete",
                                            function (e) {
                                                e.inhoverinanimation = !1;
                                            },
                                            [a]
                                        )),
                                    s.svg && (a.hovertimelines.svghoveranim = punchgs.TweenLite.to([s.svg, s.svg.find("path")], n.speed / 1e3, a.hoversvg.anim)),
                                    (a.hoveredstatus = !0);
                            },
                            function (e) {
                                var t = { caption: jQuery(e.currentTarget), opt: r, firstframe: "frame_0", lastframe: "frame_999" },
                                    i = (p(t), t.caption),
                                    a = i.data(),
                                    n = a.frames[a.hoverframeindex];
                                (a.hoveredstatus = !1),
                                    (a.inhoveroutanimation = !0),
                                    a.hovertimelines.item.pause(),
                                    (a.hovertimelines.item = punchgs.TweenLite.to(i, n.speed / 1e3, jQuery.extend(!0, {}, a._gsTransformTo))),
                                    0 == n.speed && (a.inhoveroutanimation = !1),
                                    a.hovertimelines.item.eventCallback(
                                        "onComplete",
                                        function (e) {
                                            e.inhoveroutanimation = !1;
                                        },
                                        [a]
                                    ),
                                    void 0 !== a.hovertimelines.pwhoveranim && (a.hovertimelines.pwhoveranim = punchgs.TweenLite.to(a._pw, n.speed / 1e3, { overwrite: "auto", zIndex: a.basiczindex })),
                                    s.svg && punchgs.TweenLite.to([s.svg, s.svg.find("path")], n.speed / 1e3, a.idlesvg.anim);
                            }
                        );
                    }
                    for (var d = 0; d < n.frames.length; d++)
                        if (d !== n.hoverframeindex) {
                            var c = d === n.inframeindex ? "frame_0" : d === n.outframeindex || "frame_999" === n.frames[d].frame ? "frame_999" : "frame_" + d;
                            (t[(n.frames[d].framename = c)] = {}), (t[c].timeline = new punchgs.TimelineLite({ align: "normal" }));
                            var u = n.frames[d].delay,
                                h = (n.triggered_startstatus, void 0 !== u ? (0 <= jQuery.inArray(u, ["slideenter", "bytrigger", "wait"]) ? u : parseInt(u, 0) / 1e3) : "wait");
                            void 0 !== t.firstslide && "frame_0" === c && (i.addLabel("slide_" + t.firstslide + "_pause", 0), i.addPause("slide_" + t.firstslide + "_pause"), i.addLabel("slide_" + t.firstslide, "+=0.005")),
                                void 0 !== t.lastslide && "frame_999" === c && (i.addLabel("slide_" + t.lastslide + "_pause", "+=0.01"), i.addPause("slide_" + t.lastslide + "_pause"), i.addLabel("slide_" + t.lastslide, "+=0.005")),
                                jQuery.isNumeric(h) ? i.addLabel(c, "+=" + h) : (i.addLabel("pause_" + d, "+=0.01"), i.addPause("pause_" + d), i.addLabel(c, "+=0.01")),
                                (i = D.createFrameOnTimeline({ caption: e.caption, timeline: i, label: c, frameindex: d, opt: r }));
                        }
                    e.regenerate || (n.current_is_nc_timeline && (n.current_timeline = i), n.current_timeline_pause ? i.pause(n.current_timeline_time) : i.time(n.current_timeline_time));
                }
            },
            createFrameOnTimeline: function (e) {
                var t = e.caption,
                    i = t.data(),
                    a = e.label,
                    n = e.timeline,
                    r = e.frameindex,
                    s = e.opt,
                    o = t,
                    l = {},
                    d = s.timelines[i._slideid].layers[i._id],
                    c = i.frames.length - 1,
                    u = i.frames[r].split,
                    h = i.frames[r].split_direction,
                    p = i.frames[r].sfx_effect,
                    f = !1;
                if (
                    ((h = void 0 === h ? "forward" : h),
                    -1 !== i.hoverframeindex && i.hoverframeindex == c && (c -= 1),
                    (l.content = new punchgs.TimelineLite({ align: "normal" })),
                    (l.mask = new punchgs.TimelineLite({ align: "normal" })),
                    void 0 === n.vars.id && (n.vars.id = Math.round(1e5 * Math.random())),
                    "column" === i._nctype && (n.add(punchgs.TweenLite.set(i._cbgc_man, { visibility: "visible" }), a), n.add(punchgs.TweenLite.set(i._cbgc_auto, { visibility: "hidden" }), a)),
                    i.splittext && 0 === r)
                ) {
                    void 0 !== i.mySplitText && i.mySplitText.revert();
                    var g = 0 < t.find("a").length ? t.find("a") : t;
                    (i.mySplitText = new punchgs.SplitText(g, { type: "chars,words,lines", charsClass: "tp-splitted tp-charsplit", wordsClass: "tp-splitted tp-wordsplit", linesClass: "tp-splitted tp-linesplit" })), t.addClass("splitted");
                }
                void 0 !== i.mySplitText && u && u.match(/chars|words|lines/g) && ((o = i.mySplitText[u]), (f = !0));
                var m,
                    v,
                    y =
                        r !== i.outframeindex
                            ? H(F(), i.frames[r].to, void 0, f, o.length - 1)
                            : void 0 !== i.frames[r].to && null === i.frames[r].to.match(/auto:auto/g)
                            ? H(E(), i.frames[r].to, 1 == s.sdir, f, o.length - 1)
                            : H(E(), i.frames[i.inframeindex].from, 0 == s.sdir, f, o.length - 1),
                    w = void 0 !== i.frames[r].from ? H(y, i.frames[i.inframeindex].from, 1 == s.sdir, f, o.length - 1) : void 0,
                    _ = i.frames[r].splitdelay;
                if (
                    (0 !== r || e.fromcurrentstate ? (v = W(i.frames[r].mask)) : (m = W(i.frames[r].mask)),
                    (y.anim.ease = void 0 === i.frames[r].ease ? punchgs.Power1.easeInOut : i.frames[r].ease),
                    void 0 !== w &&
                        ((w.anim.ease = void 0 === i.frames[r].ease ? punchgs.Power1.easeInOut : i.frames[r].ease),
                        (w.speed = void 0 === i.frames[r].speed ? w.speed : i.frames[r].speed),
                        (w.anim.x = w.anim.x * s.bw || N(w.anim.x, s, i.eow, i.eoh, i.calcy, i.calcx, "horizontal")),
                        (w.anim.y = w.anim.y * s.bw || N(w.anim.y, s, i.eow, i.eoh, i.calcy, i.calcx, "vertical"))),
                    void 0 !== y &&
                        ((y.anim.ease = void 0 === i.frames[r].ease ? punchgs.Power1.easeInOut : i.frames[r].ease),
                        (y.speed = void 0 === i.frames[r].speed ? y.speed : i.frames[r].speed),
                        (y.anim.x = y.anim.x * s.bw || N(y.anim.x, s, i.eow, i.eoh, i.calcy, i.calcx, "horizontal")),
                        (y.anim.y = y.anim.y * s.bw || N(y.anim.y, s, i.eow, i.eoh, i.calcy, i.calcx, "vertical"))),
                    t.data("iframes") && n.add(punchgs.TweenLite.set(t.find("iframe"), { autoAlpha: 1 }), a + "+=0.001"),
                    r === i.outframeindex &&
                        (i.frames[r].to && i.frames[r].to.match(/auto:auto/g),
                        (y.speed = void 0 === i.frames[r].speed || "inherit" === i.frames[r].speed ? i.frames[i.inframeindex].speed : i.frames[r].speed),
                        (y.anim.ease = void 0 === i.frames[r].ease || "inherit" === i.frames[r].ease ? i.frames[i.inframeindex].ease : i.frames[r].ease),
                        (y.anim.overwrite = "auto")),
                    0 !== r || e.fromcurrentstate)
                )
                    0 === r && e.fromcurrentstate && (y.speed = w.speed);
                else {
                    if (o != t) {
                        var b = jQuery.extend({}, y.anim, !0);
                        n.add(punchgs.TweenLite.set(t, y.anim), a), ((y = F()).ease = b.ease), void 0 !== b.filter && (y.anim.filter = b.filter), void 0 !== b["-webkit-filter"] && (y.anim["-webkit-filter"] = b["-webkit-filter"]);
                    }
                    (w.anim.visibility = "hidden"), (w.anim.immediateRender = !0), (y.anim.visibility = "visible");
                }
                e.fromcurrentstate && (y.anim.immediateRender = !0);
                var x = -1;
                if ((0 === r && !e.fromcurrentstate && void 0 !== i._bmask && void 0 !== p && 0 <= p.indexOf("block")) || (r === i.outframeindex && !e.fromcurrentstate && void 0 !== i._bmask && void 0 !== p && 0 <= p.indexOf("block"))) {
                    var T = 0 === r ? w.speed / 1e3 / 2 : y.speed / 1e3 / 2,
                        C = [
                            { scaleY: 1, scaleX: 0, transformOrigin: "0% 50%" },
                            { scaleY: 1, scaleX: 1, ease: y.anim.ease },
                        ],
                        k = { scaleY: 1, scaleX: 0, transformOrigin: "100% 50%", ease: y.anim.ease };
                    switch (((x = void 0 === _ ? T : _ + T), p)) {
                        case "blocktoleft":
                        case "blockfromright":
                            (C[0].transformOrigin = "100% 50%"), (k.transformOrigin = "0% 50%");
                            break;
                        case "blockfromtop":
                        case "blocktobottom":
                            (C = [
                                { scaleX: 1, scaleY: 0, transformOrigin: "50% 0%" },
                                { scaleX: 1, scaleY: 1, ease: y.anim.ease },
                            ]),
                                (k = { scaleX: 1, scaleY: 0, transformOrigin: "50% 100%", ease: y.anim.ease });
                            break;
                        case "blocktotop":
                        case "blockfrombottom":
                            (C = [
                                { scaleX: 1, scaleY: 0, transformOrigin: "50% 100%" },
                                { scaleX: 1, scaleY: 1, ease: y.anim.ease },
                            ]),
                                (k = { scaleX: 1, scaleY: 0, transformOrigin: "50% 0%", ease: y.anim.ease });
                    }
                    (C[0].background = i.frames[r].sfxcolor), n.add(l.mask.fromTo(i._bmask, T, C[0], C[1], _), a), n.add(l.mask.to(i._bmask, T, k, x), a);
                }
                if (f) var S = M(o.length - 1, h);
                if (0 !== r || e.fromcurrentstate)
                    if ("block" === i._sfx_out && r === i.outframeindex) n.add(l.content.staggerTo(o, 0.001, { autoAlpha: 0, delay: x }), a), n.add(l.content.staggerTo(o, y.speed / 1e3 / 2 - 0.001, { x: 0, delay: x }), a + "+=0.001");
                    else if (f && void 0 !== S)
                        for (var j in ((O = { to: z(y.anim) }), o)) {
                            for (var L in ((R = jQuery.extend({}, y.anim)), O.to)) (R[L] = parseInt(O.to[L].values[O.to[L].index], 0)), (O.to[L].index = O.to[L].index < O.to[L].len ? O.to[L].index + 1 : 0);
                            void 0 !== i.frames[r].color && (R.color = i.frames[r].color), void 0 !== i.frames[r].bgcolor && (R.backgroundColor = i.frames[r].bgcolor), n.add(l.content.to(o[S[j]], y.speed / 1e3, R, _ * j), a);
                        }
                    else void 0 !== i.frames[r].color && (y.anim.color = i.frames[r].color), void 0 !== i.frames[r].bgcolor && (y.anim.backgroundColor = i.frames[r].bgcolor), n.add(l.content.staggerTo(o, y.speed / 1e3, y.anim, _), a);
                else if ("block" === i._sfx_in) n.add(l.content.staggerFromTo(o, 0.05, { x: 0, y: 0, autoAlpha: 0 }, { x: 0, y: 0, autoAlpha: 1, delay: x }), a);
                else if (f && void 0 !== S) {
                    var O = { from: z(w.anim), to: z(y.anim) };
                    for (var j in o) {
                        var P = jQuery.extend({}, w.anim),
                            R = jQuery.extend({}, y.anim);
                        for (var L in O.from) (P[L] = parseInt(O.from[L].values[O.from[L].index], 0)), (O.from[L].index = O.from[L].index < O.from[L].len ? O.from[L].index + 1 : 0);
                        (R.ease = P.ease),
                            void 0 !== i.frames[r].color && ((P.color = i.frames[r].color), (R.color = i.cssobj.styleProps.color)),
                            void 0 !== i.frames[r].bgcolor && ((P.backgroundColor = i.frames[r].bgcolor), (R.backgroundColor = i.cssobj.styleProps["background-color"])),
                            n.add(l.content.fromTo(o[S[j]], w.speed / 1e3, P, R, _ * j), a);
                    }
                } else
                    void 0 !== i.frames[r].color && ((w.anim.color = i.frames[r].color), (y.anim.color = i.cssobj.styleProps.color)),
                        void 0 !== i.frames[r].bgcolor && ((w.anim.backgroundColor = i.frames[r].bgcolor), (y.anim.backgroundColor = i.cssobj.styleProps["background-color"])),
                        n.add(l.content.staggerFromTo(o, w.speed / 1e3, w.anim, y.anim, _), a);
                return (
                    void 0 === v ||
                        !1 === v ||
                        (0 === r && e.ignorefirstframe) ||
                        ((v.anim.ease = void 0 === v.anim.ease || "inherit" === v.anim.ease ? i.frames[0].ease : v.anim.ease),
                        (v.anim.overflow = "hidden"),
                        (v.anim.x = v.anim.x * s.bw || N(v.anim.x, s, i.eow, i.eoh, i.calcy, i.calcx, "horizontal")),
                        (v.anim.y = v.anim.y * s.bw || N(v.anim.y, s, i.eow, i.eoh, i.calcy, i.calcx, "vertical"))),
                    (0 === r && m && !1 !== m && !e.fromcurrentstate) || (0 === r && e.ignorefirstframe)
                        ? (((v = new Object()).anim = new Object()),
                          (v.anim.overwrite = "auto"),
                          (v.anim.ease = y.anim.ease),
                          (v.anim.x = v.anim.y = 0),
                          m &&
                              !1 !== m &&
                              ((m.anim.x = m.anim.x * s.bw || N(m.anim.x, s, i.eow, i.eoh, i.calcy, i.calcx, "horizontal")),
                              (m.anim.y = m.anim.y * s.bw || N(m.anim.y, s, i.eow, i.eoh, i.calcy, i.calcx, "vertical")),
                              (m.anim.overflow = "hidden")))
                        : 0 === r && n.add(l.mask.set(i._mw, { overflow: "visible" }), a),
                    void 0 !== m && void 0 !== v && !1 !== m && !1 !== v ? n.add(l.mask.fromTo(i._mw, w.speed / 1e3, m.anim, v.anim, _), a) : void 0 !== v && !1 !== v && n.add(l.mask.to(i._mw, y.speed / 1e3, v.anim, _), a),
                    n.addLabel(a + "_end"),
                    i._gsTransformTo && r === c && i.hoveredstatus && (i.hovertimelines.item = punchgs.TweenLite.to(t, 0, i._gsTransformTo)),
                    (i._gsTransformTo = !1),
                    l.content.eventCallback("onStart", I, [r, d, i._pw, i, n, y.anim, t, e.updateStaticTimeline, s]),
                    l.content.eventCallback("onUpdate", A, [a, i._id, i._pw, i, n, r, jQuery.extend(!0, {}, y.anim), e.updateStaticTimeline, t, s]),
                    l.content.eventCallback("onComplete", Q, [r, i.frames.length, c, i._pw, i, n, e.updateStaticTimeline, t, s]),
                    n
                );
            },
            endMoveCaption: function (e) {
                (e.firstframe = "frame_0"), (e.lastframe = "frame_999");
                var t = p(e),
                    i = e.caption.data();
                if (
                    (void 0 !== e.frame
                        ? t.timeline.play(e.frame)
                        : (!t.static || e.currentslide >= t.removeonslide || e.currentslide < t.showonslide) &&
                          ((t.outnow = new punchgs.TimelineLite()),
                          t.timeline.pause(),
                          !0 === i.visibleelement && D.createFrameOnTimeline({ caption: e.caption, timeline: t.outnow, label: "outnow", frameindex: e.caption.data("outframeindex"), opt: e.opt, fromcurrentstate: !0 }).play()),
                    e.checkchildrens && t.timeline_obj && t.timeline_obj.dchildren && "none" !== t.timeline_obj.dchildren && 0 < t.timeline_obj.dchildren.length)
                )
                    for (var a = 0; a < t.timeline_obj.dchildren.length; a++) D.endMoveCaption({ caption: jQuery(t.timeline_obj.dchildren[a]), opt: e.opt });
            },
            playAnimationFrame: function (e) {
                (e.firstframe = e.triggerframein), (e.lastframe = e.triggerframeout);
                var t,
                    i = p(e),
                    a = e.caption.data(),
                    n = 0;
                for (var r in a.frames) a.frames[r].framename === e.frame && (t = n), n++;
                void 0 !== a.triggeredtimeline && a.triggeredtimeline.pause(), (a.triggeredtimeline = new punchgs.TimelineLite()), i.timeline.pause();
                var s = !0 === a.visibleelement;
                a.triggeredtimeline = D.createFrameOnTimeline({ caption: e.caption, timeline: a.triggeredtimeline, label: "triggered", frameindex: t, updateStaticTimeline: !0, opt: e.opt, ignorefirstframe: !0, fromcurrentstate: s }).play();
            },
            removeTheCaptions: function (e, i) {
                if ("stop" === D.compare_version(d).check) return !1;
                var t = e.data("index"),
                    a = new Array();
                i.layers[t] &&
                    jQuery.each(i.layers[t], function (e, t) {
                        a.push(t);
                    });
                var n = D.currentSlideIndex(i);
                a &&
                    jQuery.each(a, function (e) {
                        var t = jQuery(this);
                        "carousel" === i.sliderType && "on" === i.carousel.showLayersAllTime
                            ? (clearTimeout(t.data("videoplaywait")), D.stopVideo && D.stopVideo(t, i))
                            : (r(t), clearTimeout(t.data("videoplaywait")), D.endMoveCaption({ caption: t, opt: i, currentslide: n })),
                            D.removeMediaFromList && D.removeMediaFromList(t, i),
                            (i.lastplayedvideos = []);
                    });
            },
        });
        var I = function (e, t, i, a, n, r, s, o, l) {
                var d = {};
                if (
                    ((d.layer = s),
                    (d.eventtype = 0 === e ? "enterstage" : e === a.outframeindex ? "leavestage" : "framestarted"),
                    (d.layertype = s.data("layertype")),
                    (a.active = !0),
                    (d.frame_index = e),
                    (d.layersettings = s.data()),
                    l.c.trigger("revolution.layeraction", [d]),
                    "on" == a.loopanimation && u(a._lw, l.bw),
                    "enterstage" === d.eventtype && ((a.animdirection = "in"), (a.visibleelement = !0), D.toggleState(a.layertoggledby)),
                    "none" !== t.dchildren && void 0 !== t.dchildren && 0 < t.dchildren.length)
                )
                    if (0 === e) for (var c = 0; c < t.dchildren.length; c++) jQuery(t.dchildren[c]).data("timeline").play(0);
                    else if (e === a.outframeindex) for (c = 0; c < t.dchildren.length; c++) D.endMoveCaption({ caption: jQuery(t.dchildren[c]), opt: l, checkchildrens: !0 });
                punchgs.TweenLite.set(i, { visibility: "visible" }),
                    (a.current_frame = e),
                    (a.current_timeline = n),
                    (a.current_timeline_time = n.time()),
                    o && (a.static_layer_timeline_time = a.current_timeline_time),
                    (a.last_frame_started = e);
            },
            A = function (e, t, i, a, n, r, s, o, l, d) {
                "column" === a._nctype && w(l, d),
                    punchgs.TweenLite.set(i, { visibility: "visible" }),
                    (a.current_frame = r),
                    (a.current_timeline = n),
                    (a.current_timeline_time = n.time()),
                    o && (a.static_layer_timeline_time = a.current_timeline_time),
                    void 0 !== a.hoveranim &&
                        !1 === a._gsTransformTo &&
                        ((a._gsTransformTo = s),
                        a._gsTransformTo && a._gsTransformTo.startAt && delete a._gsTransformTo.startAt,
                        void 0 === a.cssobj.styleProps.css ? (a._gsTransformTo = jQuery.extend(!0, {}, a.cssobj.styleProps, a._gsTransformTo)) : (a._gsTransformTo = jQuery.extend(!0, {}, a.cssobj.styleProps.css, a._gsTransformTo))),
                    (a.visibleelement = !0);
            },
            Q = function (e, t, i, a, n, r, s, o, l) {
                var d = {};
                (d.layer = o),
                    (d.eventtype = 0 === e ? "enteredstage" : e === t - 1 || e === i ? "leftstage" : "frameended"),
                    (d.layertype = o.data("layertype")),
                    (d.layersettings = o.data()),
                    l.c.trigger("revolution.layeraction", [d]),
                    "leftstage" !== d.eventtype && D.animcompleted(o, l),
                    "leftstage" === d.eventtype && D.stopVideo && D.stopVideo(o, l),
                    "column" === n._nctype && (punchgs.TweenLite.to(n._cbgc_man, 0.01, { visibility: "hidden" }), punchgs.TweenLite.to(n._cbgc_auto, 0.01, { visibility: "visible" })),
                    "leftstage" === d.eventtype &&
                        ((n.active = !1),
                        punchgs.TweenLite.set(a, { visibility: "hidden", overwrite: "auto" }),
                        (n.animdirection = "out"),
                        (n.visibleelement = !1),
                        D.unToggleState(n.layertoggledby),
                        "video" === n._nctype &&
                            D.resetVideo &&
                            setTimeout(function () {
                                D.resetVideo(o, l);
                            }, 100)),
                    (n.current_frame = e),
                    (n.current_timeline = r),
                    (n.current_timeline_time = r.time()),
                    s && (n.static_layer_timeline_time = n.current_timeline_time);
            },
            p = function (e) {
                var t = {};
                return (
                    (e.firstframe = void 0 === e.firstframe ? "frame_0" : e.firstframe),
                    (e.lastframe = void 0 === e.lastframe ? "frame_999" : e.lastframe),
                    (t.id = e.caption.data("id") || e.caption.attr("id")),
                    (t.slideid = e.caption.data("slideid") || e.caption.closest(".tp-revslider-slidesli").data("index")),
                    (t.timeline_obj = e.opt.timelines[t.slideid].layers[t.id]),
                    (t.timeline = t.timeline_obj.timeline),
                    (t.ffs = t.timeline.getLabelTime(e.firstframe)),
                    (t.ffe = t.timeline.getLabelTime(e.firstframe + "_end")),
                    (t.lfs = t.timeline.getLabelTime(e.lastframe)),
                    (t.lfe = t.timeline.getLabelTime(e.lastframe + "_end")),
                    (t.ct = t.timeline.time()),
                    (t.static = null != t.timeline_obj.firstslide || null != t.timeline_obj.lastslide),
                    t.static && ((t.showonslide = t.timeline_obj.firstslide), (t.removeonslide = t.timeline_obj.lastslide)),
                    t
                );
            },
            M = function (e, t) {
                var i = new Array();
                switch (t) {
                    case "forward":
                    case "random":
                        for (var a = 0; a <= e; a++) i.push(a);
                        "random" === t &&
                            (i = (function (e) {
                                for (var t, i, a = e.length; 0 !== a; ) (i = Math.floor(Math.random() * a)), (t = e[(a -= 1)]), (e[a] = e[i]), (e[i] = t);
                                return e;
                            })(i));
                        break;
                    case "backward":
                        for (a = 0; a <= e; a++) i.push(e - a);
                        break;
                    case "middletoedge":
                        var n = Math.ceil(e / 2),
                            r = n - 1,
                            s = n + 1;
                        for (i.push(n), a = 0; a < n; a++) 0 <= r && i.push(r), s <= e && i.push(s), r--, s++;
                        break;
                    case "edgetomiddle":
                        for (r = e, a = s = 0; a <= Math.floor(e / 2); a++) i.push(r), s < r && i.push(s), r--, s++;
                }
                return i;
            },
            z = function (e) {
                var t = {};
                for (var i in e) "string" == typeof e[i] && 0 <= e[i].indexOf("|") && (void 0 === t[i] && (t[i] = { index: 0 }), (t[i].values = e[i].replace("[", "").replace("]", "").split("|")), (t[i].len = t[i].values.length - 1));
                return t;
            },
            F = function (e) {
                return (
                    ((e = void 0 === e ? new Object() : e).anim = void 0 === e.anim ? new Object() : e.anim),
                    (e.anim.x = void 0 === e.anim.x ? 0 : e.anim.x),
                    (e.anim.y = void 0 === e.anim.y ? 0 : e.anim.y),
                    (e.anim.z = void 0 === e.anim.z ? 0 : e.anim.z),
                    (e.anim.rotationX = void 0 === e.anim.rotationX ? 0 : e.anim.rotationX),
                    (e.anim.rotationY = void 0 === e.anim.rotationY ? 0 : e.anim.rotationY),
                    (e.anim.rotationZ = void 0 === e.anim.rotationZ ? 0 : e.anim.rotationZ),
                    (e.anim.scaleX = void 0 === e.anim.scaleX ? 1 : e.anim.scaleX),
                    (e.anim.scaleY = void 0 === e.anim.scaleY ? 1 : e.anim.scaleY),
                    (e.anim.skewX = void 0 === e.anim.skewX ? 0 : e.anim.skewX),
                    (e.anim.skewY = void 0 === e.anim.skewY ? 0 : e.anim.skewY),
                    (e.anim.opacity = void 0 === e.anim.opacity ? 1 : e.anim.opacity),
                    (e.anim.transformOrigin = void 0 === e.anim.transformOrigin ? "50% 50%" : e.anim.transformOrigin),
                    (e.anim.transformPerspective = void 0 === e.anim.transformPerspective ? 600 : e.anim.transformPerspective),
                    (e.anim.rotation = void 0 === e.anim.rotation ? 0 : e.anim.rotation),
                    (e.anim.force3D = void 0 === e.anim.force3D ? "auto" : e.anim.force3D),
                    (e.anim.autoAlpha = void 0 === e.anim.autoAlpha ? 1 : e.anim.autoAlpha),
                    (e.anim.visibility = void 0 === e.anim.visibility ? "visible" : e.anim.visibility),
                    (e.anim.overwrite = void 0 === e.anim.overwrite ? "auto" : e.anim.overwrite),
                    (e.speed = void 0 === e.speed ? 0.3 : e.speed),
                    (e.filter = void 0 === e.filter ? "blur(0px) grayscale(0%) brightness(100%)" : e.filter),
                    (e["-webkit-filter"] = void 0 === e["-webkit-filter"] ? "blur(0px) grayscale(0%) brightness(100%)" : e["-webkit-filter"]),
                    e
                );
            },
            f = function () {
                var e = new Object();
                return (e.anim = new Object()), (e.anim.stroke = "none"), (e.anim.strokeWidth = 0), (e.anim.strokeDasharray = "none"), (e.anim.strokeDashoffset = "0"), e;
            },
            g = function (e, r) {
                var t = e.split(";");
                return (
                    t &&
                        jQuery.each(t, function (e, t) {
                            var i = t.split(":"),
                                a = i[0],
                                n = i[1];
                            "sc" == a && (r.anim.stroke = n), "sw" == a && (r.anim.strokeWidth = n), "sda" == a && (r.anim.strokeDasharray = n), "sdo" == a && (r.anim.strokeDashoffset = n);
                        }),
                    r
                );
            },
            E = function () {
                var e = new Object();
                return (e.anim = new Object()), (e.anim.x = 0), (e.anim.y = 0), (e.anim.z = 0), e;
            },
            m = function () {
                var e = new Object();
                return (e.anim = new Object()), (e.speed = 0.2), e;
            },
            c = function (e, t, i, a, n) {
                if (((n = void 0 === n ? "" : n), jQuery.isNumeric(parseFloat(e)))) return parseFloat(e) + n;
                if (void 0 === e || "inherit" === e) return t + "ext";
                if (1 < e.split("{").length) {
                    var r = e.split(","),
                        s = parseFloat(r[1].split("}")[0]);
                    if (((r = parseFloat(r[0].split("{")[1])), void 0 !== i && void 0 !== a)) {
                        parseInt(Math.random() * (s - r), 0), parseInt(r, 0);
                        for (var o = 0; o < a; o++) e = e + "|" + (parseInt(Math.random() * (s - r), 0) + parseInt(r, 0)) + n;
                        e += "]";
                    } else e = Math.random() * (s - r) + r;
                }
                return e;
            },
            N = function (e, t, i, a, n, r, s) {
                return (
                    !jQuery.isNumeric(e) && e.match(/%]/g)
                        ? ((e = e.split("[")[1].split("]")[0]), "horizontal" == s ? (e = ((i + 2) * parseInt(e, 0)) / 100) : "vertical" == s && (e = ((a + 2) * parseInt(e, 0)) / 100))
                        : (e =
                              "top" ===
                                  (e =
                                      "left" === (e = "layer_top" === (e = "layer_left" === e ? 0 - i : "layer_right" === e ? i : e) ? 0 - a : "layer_bottom" === e ? a : e) || "stage_left" === e
                                          ? 0 - i - r
                                          : "right" === e || "stage_right" === e
                                          ? t.conw - r
                                          : "center" === e || "stage_center" === e
                                          ? t.conw / 2 - i / 2 - r
                                          : e) || "stage_top" === e
                                  ? 0 - a - n
                                  : "bottom" === e || "stage_bottom" === e
                                  ? t.conh - n
                                  : "middle" === e || "stage_middle" === e
                                  ? t.conh / 2 - a / 2 - n
                                  : e),
                    e
                );
            },
            H = function (e, t, r, s, o) {
                var l = new Object();
                if (((l = jQuery.extend(!0, {}, l, e)), void 0 === t)) return l;
                var i = t.split(";"),
                    d = "";
                return (
                    i &&
                        jQuery.each(i, function (e, t) {
                            var i = t.split(":"),
                                a = i[0],
                                n = i[1];
                            r &&
                                "none" !== r &&
                                null != n &&
                                0 < n.length &&
                                n.match(/\(R\)/) &&
                                ("[" === (n = "right" === (n = n.replace("(R)", "")) ? "left" : "left" === n ? "right" : "top" === n ? "bottom" : "bottom" === n ? "top" : n)[0] && "-" === n[1]
                                    ? (n = n.replace("[-", "["))
                                    : "[" === n[0] && "-" !== n[1]
                                    ? (n = n.replace("[", "[-"))
                                    : "-" === n[0]
                                    ? (n = n.replace("-", ""))
                                    : n[0].match(/[1-9]/) && (n = "-" + n)),
                                null != n &&
                                    ((n = n.replace(/\(R\)/, "")),
                                    ("rotationX" != a && "rX" != a) || (l.anim.rotationX = c(n, l.anim.rotationX, s, o, "deg")),
                                    ("rotationY" != a && "rY" != a) || (l.anim.rotationY = c(n, l.anim.rotationY, s, o, "deg")),
                                    ("rotationZ" != a && "rZ" != a) || (l.anim.rotation = c(n, l.anim.rotationZ, s, o, "deg")),
                                    ("scaleX" != a && "sX" != a) || (l.anim.scaleX = c(n, l.anim.scaleX, s, o)),
                                    ("scaleY" != a && "sY" != a) || (l.anim.scaleY = c(n, l.anim.scaleY, s, o)),
                                    ("opacity" != a && "o" != a) || (l.anim.opacity = c(n, l.anim.opacity, s, o)),
                                    "fb" == a && (d = "" === d ? "blur(" + parseInt(n, 0) + "px)" : d + " blur(" + parseInt(n, 0) + "px)"),
                                    "fg" == a && (d = "" === d ? "grayscale(" + parseInt(n, 0) + "%)" : d + " grayscale(" + parseInt(n, 0) + "%)"),
                                    "fbr" == a && (d = "" === d ? "brightness(" + parseInt(n, 0) + "%)" : d + " brightness(" + parseInt(n, 0) + "%)"),
                                    0 === l.anim.opacity && (l.anim.autoAlpha = 0),
                                    (l.anim.opacity = 0 == l.anim.opacity ? 1e-4 : l.anim.opacity),
                                    ("skewX" != a && "skX" != a) || (l.anim.skewX = c(n, l.anim.skewX, s, o)),
                                    ("skewY" != a && "skY" != a) || (l.anim.skewY = c(n, l.anim.skewY, s, o)),
                                    "x" == a && (l.anim.x = c(n, l.anim.x, s, o)),
                                    "y" == a && (l.anim.y = c(n, l.anim.y, s, o)),
                                    "z" == a && (l.anim.z = c(n, l.anim.z, s, o)),
                                    ("transformOrigin" != a && "tO" != a) || (l.anim.transformOrigin = n.toString()),
                                    ("transformPerspective" != a && "tP" != a) || (l.anim.transformPerspective = parseInt(n, 0)),
                                    ("speed" != a && "s" != a) || (l.speed = parseFloat(n)));
                        }),
                    "" !== d && ((l.anim["-webkit-filter"] = d), (l.anim.filter = d)),
                    l
                );
            },
            W = function (e) {
                if (void 0 === e) return !1;
                var n = new Object();
                n.anim = new Object();
                var t = e.split(";");
                return (
                    t &&
                        jQuery.each(t, function (e, t) {
                            var i = (t = t.split(":"))[0],
                                a = t[1];
                            "x" == i && (n.anim.x = a), "y" == i && (n.anim.y = a), "s" == i && (n.speed = parseFloat(a)), ("e" != i && "ease" != i) || (n.anim.ease = a);
                        }),
                    n
                );
            },
            B = function (i, e, t) {
                if ((null == i && (i = 0), !jQuery.isArray(i) && "string" === jQuery.type(i) && (1 < i.split(",").length || 1 < i.split("[").length))) {
                    var a = (i = (i = i.replace("[", "")).replace("]", "")).match(/'/g) ? i.split("',") : i.split(",");
                    (i = new Array()),
                        a &&
                            jQuery.each(a, function (e, t) {
                                (t = (t = t.replace("'", "")).replace("'", "")), i.push(t);
                            });
                } else {
                    var n = i;
                    jQuery.isArray(i) || (i = new Array()).push(n);
                }
                if (((n = i[i.length - 1]), i.length < e.rle)) for (var r = 1; r <= e.curWinRange; r++) i.push(n);
                return i;
            };
        function V(e, t, i, a, n, r, s) {
            var o = e.find(t);
            o.css("borderWidth", r + "px"), o.css(i, 0 - r + "px"), o.css(a, "0px solid transparent"), o.css(n, s);
        }
        var v = function (a, e) {
                if (void 0 === e) return a;
                var t = (e = (e = (e = (e = (e = (e = (e = (e = e.replace("c:", "color:")).replace("bg:", "background-color:")).replace("bw:", "border-width:")).replace("bc:", "border-color:")).replace("br:", "borderRadius:")).replace(
                    "bs:",
                    "border-style:"
                )).replace("td:", "text-decoration:")).replace("zi:", "zIndex:")).split(";");
                return (
                    t &&
                        jQuery.each(t, function (e, t) {
                            var i = t.split(":");
                            0 < i[0].length && ("background-color" === i[0] && 0 <= i[1].indexOf("gradient") && (i[0] = "background"), (a.anim[i[0]] = i[1]));
                        }),
                    a
                );
            },
            Y = function (e, t) {
                var i,
                    a = new Object(),
                    n = !1;
                if (
                    ("rekursive" == t && (i = e.closest(".tp-caption")) && e.css("fontSize") === i.css("fontSize") && e.css("fontWeight") === i.css("fontWeight") && e.css("lineHeight") === i.css("lineHeight") && (n = !0),
                    (a.basealign = e.data("basealign") || "grid"),
                    (a.fontSize = n ? (void 0 === i.data("fontsize") ? parseInt(i.css("fontSize"), 0) || 0 : i.data("fontsize")) : void 0 === e.data("fontsize") ? parseInt(e.css("fontSize"), 0) || 0 : e.data("fontsize")),
                    (a.fontWeight = n ? (void 0 === i.data("fontweight") ? parseInt(i.css("fontWeight"), 0) || 0 : i.data("fontweight")) : void 0 === e.data("fontweight") ? parseInt(e.css("fontWeight"), 0) || 0 : e.data("fontweight")),
                    (a.whiteSpace = n ? (void 0 === i.data("whitespace") ? i.css("whitespace") || "normal" : i.data("whitespace")) : void 0 === e.data("whitespace") ? e.css("whitespace") || "normal" : e.data("whitespace")),
                    (a.textAlign = n ? (void 0 === i.data("textalign") ? i.css("textalign") || "inherit" : i.data("textalign")) : void 0 === e.data("textalign") ? e.css("textalign") || "inherit" : e.data("textalign")),
                    (a.zIndex = n ? (void 0 === i.data("zIndex") ? i.css("zIndex") || "inherit" : i.data("zIndex")) : void 0 === e.data("zIndex") ? e.css("zIndex") || "inherit" : e.data("zIndex")),
                    -1 !== jQuery.inArray(e.data("layertype"), ["video", "image", "audio"]) || e.is("img")
                        ? (a.lineHeight = 0)
                        : (a.lineHeight = n
                              ? void 0 === i.data("lineheight")
                                  ? parseInt(i.css("lineHeight"), 0) || 0
                                  : i.data("lineheight")
                              : void 0 === e.data("lineheight")
                              ? parseInt(e.css("lineHeight"), 0) || 0
                              : e.data("lineheight")),
                    (a.letterSpacing = n
                        ? void 0 === i.data("letterspacing")
                            ? parseFloat(i.css("letterSpacing"), 0) || 0
                            : i.data("letterspacing")
                        : void 0 === e.data("letterspacing")
                        ? parseFloat(e.css("letterSpacing")) || 0
                        : e.data("letterspacing")),
                    (a.paddingTop = void 0 === e.data("paddingtop") ? parseInt(e.css("paddingTop"), 0) || 0 : e.data("paddingtop")),
                    (a.paddingBottom = void 0 === e.data("paddingbottom") ? parseInt(e.css("paddingBottom"), 0) || 0 : e.data("paddingbottom")),
                    (a.paddingLeft = void 0 === e.data("paddingleft") ? parseInt(e.css("paddingLeft"), 0) || 0 : e.data("paddingleft")),
                    (a.paddingRight = void 0 === e.data("paddingright") ? parseInt(e.css("paddingRight"), 0) || 0 : e.data("paddingright")),
                    (a.marginTop = void 0 === e.data("margintop") ? parseInt(e.css("marginTop"), 0) || 0 : e.data("margintop")),
                    (a.marginBottom = void 0 === e.data("marginbottom") ? parseInt(e.css("marginBottom"), 0) || 0 : e.data("marginbottom")),
                    (a.marginLeft = void 0 === e.data("marginleft") ? parseInt(e.css("marginLeft"), 0) || 0 : e.data("marginleft")),
                    (a.marginRight = void 0 === e.data("marginright") ? parseInt(e.css("marginRight"), 0) || 0 : e.data("marginright")),
                    (a.borderTopWidth = void 0 === e.data("bordertopwidth") ? parseInt(e.css("borderTopWidth"), 0) || 0 : e.data("bordertopwidth")),
                    (a.borderBottomWidth = void 0 === e.data("borderbottomwidth") ? parseInt(e.css("borderBottomWidth"), 0) || 0 : e.data("borderbottomwidth")),
                    (a.borderLeftWidth = void 0 === e.data("borderleftwidth") ? parseInt(e.css("borderLeftWidth"), 0) || 0 : e.data("borderleftwidth")),
                    (a.borderRightWidth = void 0 === e.data("borderrightwidth") ? parseInt(e.css("borderRightWidth"), 0) || 0 : e.data("borderrightwidth")),
                    "rekursive" != t)
                ) {
                    if (
                        ((a.color = void 0 === e.data("color") ? "nopredefinedcolor" : e.data("color")),
                        (a.whiteSpace = n ? (void 0 === i.data("whitespace") ? i.css("whiteSpace") || "nowrap" : i.data("whitespace")) : void 0 === e.data("whitespace") ? e.css("whiteSpace") || "nowrap" : e.data("whitespace")),
                        (a.textAlign = n ? (void 0 === i.data("textalign") ? i.css("textalign") || "inherit" : i.data("textalign")) : void 0 === e.data("textalign") ? e.css("textalign") || "inherit" : e.data("textalign")),
                        (a.fontWeight = n ? (void 0 === i.data("fontweight") ? parseInt(i.css("fontWeight"), 0) || 0 : i.data("fontweight")) : void 0 === e.data("fontweight") ? parseInt(e.css("fontWeight"), 0) || 0 : e.data("fontweight")),
                        (a.minWidth = void 0 === e.data("width") ? parseInt(e.css("minWidth"), 0) || 0 : e.data("width")),
                        (a.minHeight = void 0 === e.data("height") ? parseInt(e.css("minHeight"), 0) || 0 : e.data("height")),
                        null != e.data("videowidth") && null != e.data("videoheight"))
                    ) {
                        var r = e.data("videowidth"),
                            s = e.data("videoheight");
                        (r = "100%" === r ? "none" : r), (s = "100%" === s ? "none" : s), e.data("width", r), e.data("height", s);
                    }
                    (a.maxWidth = void 0 === e.data("width") ? parseInt(e.css("maxWidth"), 0) || "none" : e.data("width")),
                        (a.maxHeight = -1 !== jQuery.inArray(e.data("type"), ["column", "row"]) ? "none" : void 0 === e.data("height") ? parseInt(e.css("maxHeight"), 0) || "none" : e.data("height")),
                        (a.wan = void 0 === e.data("wan") ? parseInt(e.css("-webkit-transition"), 0) || "none" : e.data("wan")),
                        (a.moan = void 0 === e.data("moan") ? parseInt(e.css("-moz-animation-transition"), 0) || "none" : e.data("moan")),
                        (a.man = void 0 === e.data("man") ? parseInt(e.css("-ms-animation-transition"), 0) || "none" : e.data("man")),
                        (a.ani = void 0 === e.data("ani") ? parseInt(e.css("transition"), 0) || "none" : e.data("ani"));
                }
                return (
                    (a.styleProps = {
                        borderTopLeftRadius: e[0].style.borderTopLeftRadius,
                        borderTopRightRadius: e[0].style.borderTopRightRadius,
                        borderBottomRightRadius: e[0].style.borderBottomRightRadius,
                        borderBottomLeftRadius: e[0].style.borderBottomLeftRadius,
                        background: e[0].style.background,
                        boxShadow: e[0].style.boxShadow,
                        "background-color": e[0].style["background-color"],
                        "border-top-color": e[0].style["border-top-color"],
                        "border-bottom-color": e[0].style["border-bottom-color"],
                        "border-right-color": e[0].style["border-right-color"],
                        "border-left-color": e[0].style["border-left-color"],
                        "border-top-style": e[0].style["border-top-style"],
                        "border-bottom-style": e[0].style["border-bottom-style"],
                        "border-left-style": e[0].style["border-left-style"],
                        "border-right-style": e[0].style["border-right-style"],
                        "border-left-width": e[0].style["border-left-width"],
                        "border-right-width": e[0].style["border-right-width"],
                        "border-bottom-width": e[0].style["border-bottom-width"],
                        "border-top-width": e[0].style["border-top-width"],
                        color: e[0].style.color,
                        "text-decoration": e[0].style["text-decoration"],
                        "font-style": e[0].style["font-style"],
                    }),
                    ("" !== a.styleProps.background && void 0 !== a.styleProps.background && a.styleProps.background !== a.styleProps["background-color"]) || delete a.styleProps.background,
                    "" == a.styleProps.color && (a.styleProps.color = e.css("color")),
                    a
                );
            },
            X = function (a, n) {
                var r = new Object();
                return (
                    a &&
                        jQuery.each(a, function (e, t) {
                            var i = B(t, n)[n.curWinRange];
                            r[e] = void 0 !== i ? i : a[e];
                        }),
                    r
                );
            },
            y = function (e, t, i, a) {
                return "full" === (e = jQuery.isNumeric(e) ? e * t + "px" : e) ? a : "auto" === e || "none" === e ? i : e;
            },
            q = function (e, t, i, a) {
                var n = e.data();
                n = void 0 === n ? {} : n;
                try {
                    if ("BR" == e[0].nodeName || "br" == e[0].tagName) return !1;
                } catch (e) {}
                n.cssobj = void 0 === n.cssobj ? Y(e, i) : n.cssobj;
                var r = X(n.cssobj, t),
                    s = t.bw,
                    o = t.bh;
                "off" === a && (o = s = 1), "auto" == r.lineHeight && (r.lineHeight = r.fontSize + 4);
                var l = { Top: r.marginTop, Bottom: r.marginBottom, Left: r.marginLeft, Right: r.marginRight };
                if (
                    ("column" === n._nctype &&
                        (punchgs.TweenLite.set(n._column, {
                            paddingTop: Math.round(r.marginTop * o) + "px",
                            paddingBottom: Math.round(r.marginBottom * o) + "px",
                            paddingLeft: Math.round(r.marginLeft * s) + "px",
                            paddingRight: Math.round(r.marginRight * s) + "px",
                        }),
                        (l = { Top: 0, Bottom: 0, Left: 0, Right: 0 })),
                    !e.hasClass("tp-splitted"))
                ) {
                    if (
                        (e.css("-webkit-transition", "none"),
                        e.css("-moz-transition", "none"),
                        e.css("-ms-transition", "none"),
                        e.css("transition", "none"),
                        (void 0 !== e.data("transform_hover") || void 0 !== e.data("style_hover")) && punchgs.TweenLite.set(e, r.styleProps),
                        punchgs.TweenLite.set(e, {
                            fontSize: Math.round(r.fontSize * s) + "px",
                            fontWeight: r.fontWeight,
                            letterSpacing: Math.floor(r.letterSpacing * s) + "px",
                            paddingTop: Math.round(r.paddingTop * o) + "px",
                            paddingBottom: Math.round(r.paddingBottom * o) + "px",
                            paddingLeft: Math.round(r.paddingLeft * s) + "px",
                            paddingRight: Math.round(r.paddingRight * s) + "px",
                            marginTop: l.Top * o + "px",
                            marginBottom: l.Bottom * o + "px",
                            marginLeft: l.Left * s + "px",
                            marginRight: l.Right * s + "px",
                            borderTopWidth: Math.round(r.borderTopWidth * o) + "px",
                            borderBottomWidth: Math.round(r.borderBottomWidth * o) + "px",
                            borderLeftWidth: Math.round(r.borderLeftWidth * s) + "px",
                            borderRightWidth: Math.round(r.borderRightWidth * s) + "px",
                            lineHeight: Math.round(r.lineHeight * o) + "px",
                            textAlign: r.textAlign,
                            overwrite: "auto",
                        }),
                        "rekursive" != i)
                    ) {
                        var d = "slide" == r.basealign ? t.ulw : t.gridwidth[t.curWinRange],
                            c = "slide" == r.basealign ? t.ulh : t.gridheight[t.curWinRange],
                            u = y(r.maxWidth, s, "none", d),
                            h = y(r.maxHeight, o, "none", c),
                            p = y(r.minWidth, s, "0px", d),
                            f = y(r.minHeight, o, "0px", c);
                        if (
                            ((p = void 0 === p ? 0 : p),
                            (f = void 0 === f ? 0 : f),
                            (u = void 0 === u ? "none" : u),
                            (h = void 0 === h ? "none" : h),
                            n._isgroup &&
                                ("#1/1#" === p && (p = u = d),
                                "#1/2#" === p && (p = u = d / 2),
                                "#1/3#" === p && (p = u = d / 3),
                                "#1/4#" === p && (p = u = d / 4),
                                "#1/5#" === p && (p = u = d / 5),
                                "#1/6#" === p && (p = u = d / 6),
                                "#2/3#" === p && (p = u = (d / 3) * 2),
                                "#3/4#" === p && (p = u = (d / 4) * 3),
                                "#2/5#" === p && (p = u = (d / 5) * 2),
                                "#3/5#" === p && (p = u = (d / 5) * 3),
                                "#4/5#" === p && (p = u = (d / 5) * 4),
                                "#3/6#" === p && (p = u = (d / 6) * 3),
                                "#4/6#" === p && (p = u = (d / 6) * 4),
                                "#5/6#" === p && (p = u = (d / 6) * 5)),
                            n._ingroup && ((n._groupw = p), (n._grouph = f)),
                            punchgs.TweenLite.set(e, { maxWidth: u, maxHeight: h, minWidth: p, minHeight: f, whiteSpace: r.whiteSpace, textAlign: r.textAlign, overwrite: "auto" }),
                            "nopredefinedcolor" != r.color && punchgs.TweenLite.set(e, { color: r.color, overwrite: "auto" }),
                            null != n.svg_src)
                        ) {
                            var g =
                                "nopredefinedcolor" != r.color && null != r.color
                                    ? r.color
                                    : null != r.css && "nopredefinedcolor" != r.css.color && null != r.css.color
                                    ? r.css.color
                                    : null != r.styleProps.color
                                    ? r.styleProps.color
                                    : null != r.styleProps.css && null != r.styleProps.css.color && r.styleProps.css.color;
                            0 != g && (punchgs.TweenLite.set(e.find("svg"), { fill: g, overwrite: "auto" }), punchgs.TweenLite.set(e.find("svg path"), { fill: g, overwrite: "auto" }));
                        }
                    }
                    "column" === n._nctype &&
                        (void 0 === n._column_bg_set &&
                            ((n._column_bg_set = e.css("backgroundColor")),
                            (n._column_bg_image = e.css("backgroundImage")),
                            (n._column_bg_image_repeat = e.css("backgroundRepeat")),
                            (n._column_bg_image_position = e.css("backgroundPosition")),
                            (n._column_bg_image_size = e.css("backgroundSize")),
                            (n._column_bg_opacity = e.data("bgopacity")),
                            (n._column_bg_opacity = void 0 === n._column_bg_opacity ? 1 : n._column_bg_opacity),
                            punchgs.TweenLite.set(e, { backgroundColor: "transparent", backgroundImage: "" })),
                        setTimeout(function () {
                            w(e, t);
                        }, 1),
                        n._cbgc_auto &&
                            0 < n._cbgc_auto.length &&
                            ((n._cbgc_auto[0].style.backgroundSize = n._column_bg_image_size),
                            jQuery.isArray(r.marginLeft)
                                ? punchgs.TweenLite.set(n._cbgc_auto, {
                                      borderTopWidth: r.marginTop[t.curWinRange] * o + "px",
                                      borderLeftWidth: r.marginLeft[t.curWinRange] * s + "px",
                                      borderRightWidth: r.marginRight[t.curWinRange] * s + "px",
                                      borderBottomWidth: r.marginBottom[t.curWinRange] * o + "px",
                                      backgroundColor: n._column_bg_set,
                                      backgroundImage: n._column_bg_image,
                                      backgroundRepeat: n._column_bg_image_repeat,
                                      backgroundPosition: n._column_bg_image_position,
                                      opacity: n._column_bg_opacity,
                                  })
                                : punchgs.TweenLite.set(n._cbgc_auto, {
                                      borderTopWidth: r.marginTop * o + "px",
                                      borderLeftWidth: r.marginLeft * s + "px",
                                      borderRightWidth: r.marginRight * s + "px",
                                      borderBottomWidth: r.marginBottom * o + "px",
                                      backgroundColor: n._column_bg_set,
                                      backgroundImage: n._column_bg_image,
                                      backgroundRepeat: n._column_bg_image_repeat,
                                      backgroundPosition: n._column_bg_image_position,
                                      opacity: n._column_bg_opacity,
                                  }))),
                        setTimeout(function () {
                            e.css("-webkit-transition", e.data("wan")), e.css("-moz-transition", e.data("moan")), e.css("-ms-transition", e.data("man")), e.css("transition", e.data("ani"));
                        }, 30);
                }
            },
            w = function (e, t) {
                var i,
                    a,
                    n,
                    r = e.data();
                r._cbgc_man &&
                    0 < r._cbgc_man.length &&
                    (jQuery.isArray(r.cssobj.marginLeft)
                        ? (r.cssobj.marginLeft[t.curWinRange], t.bw, (i = r.cssobj.marginTop[t.curWinRange] * t.bh), (a = r.cssobj.marginBottom[t.curWinRange] * t.bh), r.cssobj.marginRight[t.curWinRange])
                        : (r.cssobj.marginLeft, t.bw, (i = r.cssobj.marginTop * t.bh), (a = r.cssobj.marginBottom * t.bh), r.cssobj.marginRight),
                    t.bw,
                    (n = r._row.hasClass("rev_break_columns") ? "100%" : r._row.height() - (i + a) + "px"),
                    (r._cbgc_man[0].style.backgroundSize = r._column_bg_image_size),
                    punchgs.TweenLite.set(r._cbgc_man, {
                        width: "100%",
                        height: n,
                        backgroundColor: r._column_bg_set,
                        backgroundImage: r._column_bg_image,
                        backgroundRepeat: r._column_bg_image_repeat,
                        backgroundPosition: r._column_bg_image_position,
                        overwrite: "auto",
                        opacity: r._column_bg_opacity,
                    }));
            },
            u = function (e, t) {
                var i = e.data();
                if (e.hasClass("rs-pendulum") && null == i._loop_timeline) {
                    i._loop_timeline = new punchgs.TimelineLite();
                    var a = null == e.data("startdeg") ? -20 : e.data("startdeg"),
                        n = null == e.data("enddeg") ? 20 : e.data("enddeg"),
                        r = null == e.data("speed") ? 2 : e.data("speed"),
                        s = null == e.data("origin") ? "50% 50%" : e.data("origin"),
                        o = null == e.data("easing") ? punchgs.Power2.easeInOut : e.data("easing");
                    (a *= t),
                        (n *= t),
                        i._loop_timeline.append(new punchgs.TweenLite.fromTo(e, r, { force3D: "auto", rotation: a, transformOrigin: s }, { rotation: n, ease: o })),
                        i._loop_timeline.append(
                            new punchgs.TweenLite.fromTo(
                                e,
                                r,
                                { force3D: "auto", rotation: n, transformOrigin: s },
                                {
                                    rotation: a,
                                    ease: o,
                                    onComplete: function () {
                                        i._loop_timeline.restart();
                                    },
                                }
                            )
                        );
                }
                if (
                    (e.hasClass("rs-rotate") &&
                        null == i._loop_timeline &&
                        ((i._loop_timeline = new punchgs.TimelineLite()),
                        (a = null == e.data("startdeg") ? 0 : e.data("startdeg")),
                        (n = null == e.data("enddeg") ? 360 : e.data("enddeg")),
                        (r = null == e.data("speed") ? 2 : e.data("speed")),
                        (s = null == e.data("origin") ? "50% 50%" : e.data("origin")),
                        (o = null == e.data("easing") ? punchgs.Power2.easeInOut : e.data("easing")),
                        (a *= t),
                        (n *= t),
                        i._loop_timeline.append(
                            new punchgs.TweenLite.fromTo(
                                e,
                                r,
                                { force3D: "auto", rotation: a, transformOrigin: s },
                                {
                                    rotation: n,
                                    ease: o,
                                    onComplete: function () {
                                        i._loop_timeline.restart();
                                    },
                                }
                            )
                        )),
                    e.hasClass("rs-slideloop") && null == i._loop_timeline)
                ) {
                    i._loop_timeline = new punchgs.TimelineLite();
                    var l = null == e.data("xs") ? 0 : e.data("xs"),
                        d = null == e.data("ys") ? 0 : e.data("ys"),
                        c = null == e.data("xe") ? 0 : e.data("xe"),
                        u = null == e.data("ye") ? 0 : e.data("ye");
                    (r = null == e.data("speed") ? 2 : e.data("speed")),
                        (o = null == e.data("easing") ? punchgs.Power2.easeInOut : e.data("easing")),
                        (l *= t),
                        (d *= t),
                        (c *= t),
                        (u *= t),
                        i._loop_timeline.append(new punchgs.TweenLite.fromTo(e, r, { force3D: "auto", x: l, y: d }, { x: c, y: u, ease: o })),
                        i._loop_timeline.append(
                            new punchgs.TweenLite.fromTo(
                                e,
                                r,
                                { force3D: "auto", x: c, y: u },
                                {
                                    x: l,
                                    y: d,
                                    onComplete: function () {
                                        i._loop_timeline.restart();
                                    },
                                }
                            )
                        );
                }
                if (e.hasClass("rs-pulse") && null == i._loop_timeline) {
                    i._loop_timeline = new punchgs.TimelineLite();
                    var h = null == e.data("zoomstart") ? 0 : e.data("zoomstart"),
                        p = null == e.data("zoomend") ? 0 : e.data("zoomend");
                    (r = null == e.data("speed") ? 2 : e.data("speed")),
                        (o = null == e.data("easing") ? punchgs.Power2.easeInOut : e.data("easing")),
                        i._loop_timeline.append(new punchgs.TweenLite.fromTo(e, r, { force3D: "auto", scale: h }, { scale: p, ease: o })),
                        i._loop_timeline.append(
                            new punchgs.TweenLite.fromTo(
                                e,
                                r,
                                { force3D: "auto", scale: p },
                                {
                                    scale: h,
                                    onComplete: function () {
                                        i._loop_timeline.restart();
                                    },
                                }
                            )
                        );
                }
                if (e.hasClass("rs-wave") && null == i._loop_timeline) {
                    i._loop_timeline = new punchgs.TimelineLite();
                    var f = null == e.data("angle") ? 10 : parseInt(e.data("angle"), 0),
                        g = null == e.data("radius") ? 10 : parseInt(e.data("radius"), 0),
                        m = ((r = null == e.data("speed") ? -20 : e.data("speed")), (s = null == e.data("origin") ? "50% 50%" : e.data("origin")).split(" ")),
                        v = new Object();
                    1 <= m.length ? ((v.x = m[0]), (v.y = m[1])) : ((v.x = "50%"), (v.y = "50%")), (g *= t);
                    var y = (parseInt(v.x, 0) / 100 - 0.5) * e.width(),
                        w = (parseInt(v.y, 0) / 100 - 0.5) * e.height(),
                        _ = { a: 0, ang: f, element: e, unit: g, xoffset: 0 + y, yoffset: -1 * g + w },
                        b = parseInt(f, 0),
                        x = new punchgs.TweenLite.fromTo(_, r, { a: 0 + b }, { a: 360 + b, force3D: "auto", ease: punchgs.Linear.easeNone });
                    x.eventCallback(
                        "onUpdate",
                        function (e) {
                            var t = e.a * (Math.PI / 180),
                                i = e.yoffset + e.unit * (1 - Math.sin(t)),
                                a = e.xoffset + Math.cos(t) * e.unit;
                            punchgs.TweenLite.to(e.element, 0.1, { force3D: "auto", x: a, y: i });
                        },
                        [_]
                    ),
                        x.eventCallback(
                            "onComplete",
                            function (e) {
                                e._loop_timeline.restart();
                            },
                            [i]
                        ),
                        i._loop_timeline.append(x);
                }
            },
            r = function (e) {
                e.closest(".rs-pendulum, .rs-slideloop, .rs-pulse, .rs-wave").each(function () {
                    null != this._loop_timeline && (this._loop_timeline.pause(), (this._loop_timeline = null));
                });
            };
    })(jQuery),
    (function (e) {
        "use strict";
        var P = jQuery.fn.revolution,
            R = P.is_mobile(),
            t = { alias: "Navigation Min JS", name: "revolution.extensions.navigation.min.js", min_core: "5.4.0", version: "1.3.5" };
        jQuery.extend(!0, P, {
            hideUnHideNav: function (e) {
                var t = e.c.width(),
                    i = e.navigation.arrows,
                    a = e.navigation.bullets,
                    n = e.navigation.thumbnails,
                    r = e.navigation.tabs;
                v(i) && s(e.c.find(".tparrows"), i.hide_under, t, i.hide_over),
                    v(a) && s(e.c.find(".tp-bullets"), a.hide_under, t, a.hide_over),
                    v(n) && s(e.c.parent().find(".tp-thumbs"), n.hide_under, t, n.hide_over),
                    v(r) && s(e.c.parent().find(".tp-tabs"), r.hide_under, t, r.hide_over),
                    d(e);
            },
            resizeThumbsTabs: function (e, t) {
                if ((e.navigation && e.navigation.tabs.enable) || (e.navigation && e.navigation.thumbnails.enable)) {
                    var i = (jQuery(window).width() - 480) / 500,
                        a = new punchgs.TimelineLite(),
                        n = e.navigation.tabs,
                        r = e.navigation.thumbnails,
                        s = e.navigation.bullets;
                    if (
                        (a.pause(), (i = 1 < i ? 1 : i < 0 ? 0 : i), v(n) && (t || n.width > n.min_width) && l(i, a, e.c, n, e.slideamount, "tab"), v(r) && (t || r.width > r.min_width) && l(i, a, e.c, r, e.slideamount, "thumb"), v(s) && t)
                    ) {
                        var o = e.c.find(".tp-bullets");
                        o.find(".tp-bullet").each(function (e) {
                            var t = jQuery(this),
                                i = e + 1,
                                a = t.outerWidth() + parseInt(void 0 === s.space ? 0 : s.space, 0),
                                n = t.outerHeight() + parseInt(void 0 === s.space ? 0 : s.space, 0);
                            "vertical" === s.direction
                                ? (t.css({ top: (i - 1) * n + "px", left: "0px" }), o.css({ height: (i - 1) * n + t.outerHeight(), width: t.outerWidth() }))
                                : (t.css({ left: (i - 1) * a + "px", top: "0px" }), o.css({ width: (i - 1) * a + t.outerWidth(), height: t.outerHeight() }));
                        });
                    }
                    a.play(), d(e);
                }
                return !0;
            },
            updateNavIndexes: function (e) {
                function t(e) {
                    0 < i.find(e).lenght &&
                        i.find(e).each(function (e) {
                            jQuery(this).data("liindex", e);
                        });
                }
                var i = e.c;
                t(".tp-tab"), t(".tp-bullet"), t(".tp-thumb"), P.resizeThumbsTabs(e, !0), P.manageNavigation(e);
            },
            manageNavigation: function (e) {
                var t = P.getHorizontalOffset(e.c.parent(), "left"),
                    i = P.getHorizontalOffset(e.c.parent(), "right");
                v(e.navigation.bullets) &&
                    ("fullscreen" != e.sliderLayout &&
                        "fullwidth" != e.sliderLayout &&
                        ((e.navigation.bullets.h_offset_old = void 0 === e.navigation.bullets.h_offset_old ? e.navigation.bullets.h_offset : e.navigation.bullets.h_offset_old),
                        (e.navigation.bullets.h_offset = "center" === e.navigation.bullets.h_align ? e.navigation.bullets.h_offset_old + t / 2 - i / 2 : e.navigation.bullets.h_offset_old + t - i)),
                    T(e.c.find(".tp-bullets"), e.navigation.bullets, e)),
                    v(e.navigation.thumbnails) && T(e.c.parent().find(".tp-thumbs"), e.navigation.thumbnails, e),
                    v(e.navigation.tabs) && T(e.c.parent().find(".tp-tabs"), e.navigation.tabs, e),
                    v(e.navigation.arrows) &&
                        ("fullscreen" != e.sliderLayout &&
                            "fullwidth" != e.sliderLayout &&
                            ((e.navigation.arrows.left.h_offset_old = void 0 === e.navigation.arrows.left.h_offset_old ? e.navigation.arrows.left.h_offset : e.navigation.arrows.left.h_offset_old),
                            (e.navigation.arrows.left.h_offset = "right" === e.navigation.arrows.left.h_align ? e.navigation.arrows.left.h_offset_old + i : e.navigation.arrows.left.h_offset_old + t),
                            (e.navigation.arrows.right.h_offset_old = void 0 === e.navigation.arrows.right.h_offset_old ? e.navigation.arrows.right.h_offset : e.navigation.arrows.right.h_offset_old),
                            (e.navigation.arrows.right.h_offset = "right" === e.navigation.arrows.right.h_align ? e.navigation.arrows.right.h_offset_old + i : e.navigation.arrows.right.h_offset_old + t)),
                        T(e.c.find(".tp-leftarrow.tparrows"), e.navigation.arrows.left, e),
                        T(e.c.find(".tp-rightarrow.tparrows"), e.navigation.arrows.right, e)),
                    v(e.navigation.thumbnails) && p(e.c.parent().find(".tp-thumbs"), e.navigation.thumbnails),
                    v(e.navigation.tabs) && p(e.c.parent().find(".tp-tabs"), e.navigation.tabs);
            },
            createNavigation: function (s, o) {
                if ("stop" === P.compare_version(t).check) return !1;
                var l = s.parent(),
                    d = o.navigation.arrows,
                    a = o.navigation.bullets,
                    c = o.navigation.thumbnails,
                    u = o.navigation.tabs,
                    e = v(d),
                    n = v(a),
                    r = v(c),
                    h = v(u);
                i(s, o),
                    f(s, o),
                    e && _(s, d, o),
                    o.li.each(function (e) {
                        var t = jQuery(o.li[o.li.length - 1 - e]),
                            i = jQuery(this);
                        n && (o.navigation.bullets.rtl ? x(s, a, t, o) : x(s, a, i, o)),
                            r && (o.navigation.thumbnails.rtl ? C(s, c, t, "tp-thumb", o) : C(s, c, i, "tp-thumb", o)),
                            h && (o.navigation.tabs.rtl ? C(s, u, t, "tp-tab", o) : C(s, u, i, "tp-tab", o));
                    }),
                    s.bind("revolution.slide.onafterswap revolution.nextslide.waiting", function () {
                        var i = 0 == s.find(".next-revslide").length ? s.find(".active-revslide").data("index") : s.find(".next-revslide").data("index");
                        s.find(".tp-bullet").each(function () {
                            var e = jQuery(this);
                            e.data("liref") === i ? e.addClass("selected") : e.removeClass("selected");
                        }),
                            l.find(".tp-thumb, .tp-tab").each(function () {
                                var e = jQuery(this);
                                e.data("liref") === i ? (e.addClass("selected"), e.hasClass("tp-tab") ? p(l.find(".tp-tabs"), u) : p(l.find(".tp-thumbs"), c)) : e.removeClass("selected");
                            });
                        var a = 0,
                            n = !1;
                        o.thumbs &&
                            jQuery.each(o.thumbs, function (e, t) {
                                (a = !1 === n ? e : a), (n = t.id === i || e === i || n);
                            });
                        var e = 0 < a ? a - 1 : o.slideamount - 1,
                            t = a + 1 == o.slideamount ? 0 : a + 1;
                        if (!0 === d.enable) {
                            var r = d.tmp;
                            if (
                                (null != o.thumbs[e] &&
                                    jQuery.each(o.thumbs[e].params, function (e, t) {
                                        r = r.replace(t.from, t.to);
                                    }),
                                d.left.j.html(r),
                                (r = d.tmp),
                                t > o.slideamount)
                            )
                                return;
                            jQuery.each(o.thumbs[t].params, function (e, t) {
                                r = r.replace(t.from, t.to);
                            }),
                                d.right.j.html(r),
                                d.rtl
                                    ? (punchgs.TweenLite.set(d.left.j.find(".tp-arr-imgholder"), { backgroundImage: "url(" + o.thumbs[t].src + ")" }),
                                      punchgs.TweenLite.set(d.right.j.find(".tp-arr-imgholder"), { backgroundImage: "url(" + o.thumbs[e].src + ")" }))
                                    : (punchgs.TweenLite.set(d.left.j.find(".tp-arr-imgholder"), { backgroundImage: "url(" + o.thumbs[e].src + ")" }),
                                      punchgs.TweenLite.set(d.right.j.find(".tp-arr-imgholder"), { backgroundImage: "url(" + o.thumbs[t].src + ")" }));
                        }
                    }),
                    m(d),
                    m(a),
                    m(c),
                    m(u),
                    l.on("mouseenter mousemove", function () {
                        l.hasClass("tp-mouseover") ||
                            (l.addClass("tp-mouseover"),
                            punchgs.TweenLite.killDelayedCallsTo(w),
                            e && d.hide_onleave && w(l.find(".tparrows"), d, "show"),
                            n && a.hide_onleave && w(l.find(".tp-bullets"), a, "show"),
                            r && c.hide_onleave && w(l.find(".tp-thumbs"), c, "show"),
                            h && u.hide_onleave && w(l.find(".tp-tabs"), u, "show"),
                            R && (l.removeClass("tp-mouseover"), y(s, o)));
                    }),
                    l.on("mouseleave", function () {
                        l.removeClass("tp-mouseover"), y(s, o);
                    }),
                    e && d.hide_onleave && w(l.find(".tparrows"), d, "hide", 0),
                    n && a.hide_onleave && w(l.find(".tp-bullets"), a, "hide", 0),
                    r && c.hide_onleave && w(l.find(".tp-thumbs"), c, "hide", 0),
                    h && u.hide_onleave && w(l.find(".tp-tabs"), u, "hide", 0),
                    r && g(l.find(".tp-thumbs"), o),
                    h && g(l.find(".tp-tabs"), o),
                    "carousel" === o.sliderType && g(s, o, !0),
                    ("on" === o.navigation.touch.touchOnDesktop || ("on" == o.navigation.touch.touchenabled && R)) && g(s, o, "swipebased");
            },
        });
        var p = function (e, t) {
                var i = (e.hasClass("tp-thumbs"), e.hasClass("tp-thumbs") ? ".tp-thumb-mask" : ".tp-tab-mask"),
                    a = e.hasClass("tp-thumbs") ? ".tp-thumbs-inner-wrapper" : ".tp-tabs-inner-wrapper",
                    n = e.hasClass("tp-thumbs") ? ".tp-thumb" : ".tp-tab",
                    r = e.find(i),
                    s = r.find(a),
                    o = t.direction,
                    l = "vertical" === o ? r.find(n).first().outerHeight(!0) + t.space : r.find(n).first().outerWidth(!0) + t.space,
                    d = "vertical" === o ? r.height() : r.width(),
                    c = parseInt(r.find(n + ".selected").data("liindex"), 0),
                    u = d / l,
                    h = "vertical" === o ? r.height() : r.width(),
                    p = 0 - c * l,
                    f = "vertical" === o ? s.height() : s.width(),
                    g = p < 0 - (f - h) ? 0 - (f - h) : 0 < g ? 0 : p,
                    m = s.data("offset");
                2 < u && ((g = p - (m + l) <= 0 ? (p - (m + l) < 0 - l ? m : g + l) : g), (g = p - l + m + d < l && p + (Math.round(u) - 2) * l < m ? p + (Math.round(u) - 2) * l : g)),
                    (g = g < 0 - (f - h) ? 0 - (f - h) : 0 < g ? 0 : g),
                    "vertical" !== o && r.width() >= s.width() && (g = 0),
                    "vertical" === o && r.height() >= s.height() && (g = 0),
                    e.hasClass("dragged") ||
                        ("vertical" === o
                            ? s.data("tmmove", punchgs.TweenLite.to(s, 0.5, { top: g + "px", ease: punchgs.Power3.easeInOut }))
                            : s.data("tmmove", punchgs.TweenLite.to(s, 0.5, { left: g + "px", ease: punchgs.Power3.easeInOut })),
                        s.data("offset", g));
            },
            l = function (e, i, t, a, n, r) {
                var s = t.parent().find(".tp-" + r + "s"),
                    o = s.find(".tp-" + r + "s-inner-wrapper"),
                    l = s.find(".tp-" + r + "-mask"),
                    d = a.width * e < a.min_width ? a.min_width : Math.round(a.width * e),
                    c = Math.round((d / a.width) * a.height),
                    u = "vertical" === a.direction ? d : d * n + a.space * (n - 1),
                    h = "vertical" === a.direction ? c * n + a.space * (n - 1) : c,
                    p = "vertical" === a.direction ? { width: d + "px" } : { height: c + "px" };
                i.add(punchgs.TweenLite.set(s, p)), i.add(punchgs.TweenLite.set(o, { width: u + "px", height: h + "px" })), i.add(punchgs.TweenLite.set(l, { width: u + "px", height: h + "px" }));
                var f = o.find(".tp-" + r);
                return (
                    f &&
                        jQuery.each(f, function (e, t) {
                            "vertical" === a.direction
                                ? i.add(punchgs.TweenLite.set(t, { top: e * (c + parseInt(void 0 === a.space ? 0 : a.space, 0)), width: d + "px", height: c + "px" }))
                                : "horizontal" === a.direction && i.add(punchgs.TweenLite.set(t, { left: e * (d + parseInt(void 0 === a.space ? 0 : a.space, 0)), width: d + "px", height: c + "px" }));
                        }),
                    i
                );
            },
            i = function (t, i) {
                "on" === i.navigation.keyboardNavigation &&
                    jQuery(document).keydown(function (e) {
                        (("horizontal" == i.navigation.keyboard_direction && 39 == e.keyCode) || ("vertical" == i.navigation.keyboard_direction && 40 == e.keyCode)) &&
                            ((i.sc_indicator = "arrow"), (i.sc_indicator_dir = 0), P.callingNewSlide(t, 1)),
                            (("horizontal" == i.navigation.keyboard_direction && 37 == e.keyCode) || ("vertical" == i.navigation.keyboard_direction && 38 == e.keyCode)) &&
                                ((i.sc_indicator = "arrow"), (i.sc_indicator_dir = 1), P.callingNewSlide(t, -1));
                    });
            },
            f = function (f, g) {
                if ("on" === g.navigation.mouseScrollNavigation || "carousel" === g.navigation.mouseScrollNavigation) {
                    (g.isIEEleven = !!navigator.userAgent.match(/Trident.*rv\:11\./)), (g.isSafari = !!navigator.userAgent.match(/safari/i)), (g.ischrome = !!navigator.userAgent.match(/chrome/i));
                    var m = g.ischrome ? -49 : g.isIEEleven || g.isSafari ? -9 : navigator.userAgent.match(/mozilla/i) ? -29 : -49,
                        v = g.ischrome ? 49 : g.isIEEleven || g.isSafari ? 9 : navigator.userAgent.match(/mozilla/i) ? 29 : 49;
                    f.on("mousewheel DOMMouseScroll", function (e) {
                        var t,
                            i,
                            a,
                            n,
                            r,
                            s =
                                ((t = e.originalEvent),
                                (r = n = a = i = 0),
                                "detail" in t && (a = t.detail),
                                "wheelDelta" in t && (a = -t.wheelDelta / 120),
                                "wheelDeltaY" in t && (a = -t.wheelDeltaY / 120),
                                "wheelDeltaX" in t && (i = -t.wheelDeltaX / 120),
                                "axis" in t && t.axis === t.HORIZONTAL_AXIS && ((i = a), (a = 0)),
                                (n = 1 * i),
                                (r = 1 * a),
                                "deltaY" in t && (r = t.deltaY),
                                "deltaX" in t && (n = t.deltaX),
                                (n || r) && t.deltaMode && (t.deltaMode, (n *= 1), (r *= 1)),
                                n && !i && (i = n < 1 ? -1 : 1),
                                r && !a && (a = r < 1 ? -1 : 1),
                                (300 < (r = navigator.userAgent.match(/mozilla/i) ? 10 * r : r) || r < -300) && (r /= 10),
                                { spinX: i, spinY: a, pixelX: n, pixelY: r }),
                            o = f.find(".tp-revslider-slidesli.active-revslide").index(),
                            l = f.find(".tp-revslider-slidesli.processing-revslide").index(),
                            d = (-1 != o && 0 == o) || (-1 != l && 0 == l),
                            c = (-1 != o && o == g.slideamount - 1) || (1 != l && l == g.slideamount - 1),
                            u = !0;
                        "carousel" == g.navigation.mouseScrollNavigation && (d = c = !1),
                            -1 == l
                                ? s.pixelY < m
                                    ? (d || ((g.sc_indicator = "arrow"), "reverse" !== g.navigation.mouseScrollReverse && ((g.sc_indicator_dir = 1), P.callingNewSlide(f, -1)), (u = !1)),
                                      c || ((g.sc_indicator = "arrow"), "reverse" === g.navigation.mouseScrollReverse && ((g.sc_indicator_dir = 0), P.callingNewSlide(f, 1)), (u = !1)))
                                    : v < s.pixelY &&
                                      (c || ((g.sc_indicator = "arrow"), "reverse" !== g.navigation.mouseScrollReverse && ((g.sc_indicator_dir = 0), P.callingNewSlide(f, 1)), (u = !1)),
                                      d || ((g.sc_indicator = "arrow"), "reverse" === g.navigation.mouseScrollReverse && ((g.sc_indicator_dir = 1), P.callingNewSlide(f, -1)), (u = !1)))
                                : (u = !1);
                        var h = g.c.offset().top - jQuery("body").scrollTop(),
                            p = h + g.c.height();
                        return (
                            "carousel" != g.navigation.mouseScrollNavigation
                                ? ("reverse" !== g.navigation.mouseScrollReverse && ((0 < h && 0 < s.pixelY) || (p < jQuery(window).height() && s.pixelY < 0)) && (u = !0),
                                  "reverse" === g.navigation.mouseScrollReverse && ((h < 0 && s.pixelY < 0) || (p > jQuery(window).height() && 0 < s.pixelY)) && (u = !0))
                                : (u = !1),
                            0 == u ? (e.preventDefault(e), !1) : void 0
                        );
                    });
                }
            },
            I = function (e, t, i) {
                return !0 === (e = R ? jQuery(i.target).closest("." + e).length || jQuery(i.srcElement).closest("." + e).length : jQuery(i.toElement).closest("." + e).length || jQuery(i.originalTarget).closest("." + e).length) || 1 === e
                    ? 1
                    : 0;
            },
            g = function (S, j, e) {
                var L = j.carousel;
                jQuery(".bullet, .bullets, .tp-bullets, .tparrows").addClass("noSwipe"), (L.Limit = "endless");
                var t = (R || P.get_browser(), S),
                    i = "vertical" === j.navigation.thumbnails.direction || "vertical" === j.navigation.tabs.direction ? "none" : "vertical",
                    O = j.navigation.touch.swipe_direction || "horizontal";
                (i = "swipebased" == e && "vertical" == O ? "none" : e ? "vertical" : i),
                    jQuery.fn.swipetp || (jQuery.fn.swipetp = jQuery.fn.swipe),
                    (jQuery.fn.swipetp.defaults && jQuery.fn.swipetp.defaults.excludedElements) || jQuery.fn.swipetp.defaults || (jQuery.fn.swipetp.defaults = new Object()),
                    (jQuery.fn.swipetp.defaults.excludedElements = "label, button, input, select, textarea, .noSwipe"),
                    t.swipetp({
                        allowPageScroll: i,
                        triggerOnTouchLeave: !0,
                        treshold: j.navigation.touch.swipe_treshold,
                        fingers: j.navigation.touch.swipe_min_touches,
                        excludeElements: jQuery.fn.swipetp.defaults.excludedElements,
                        swipeStatus: function (e, t, i, a, n, r, s) {
                            var o = I("rev_slider_wrapper", 0, e),
                                l = I("tp-thumbs", 0, e),
                                d = I("tp-tabs", 0, e),
                                c = !!jQuery(this)
                                    .attr("class")
                                    .match(/tp-tabs|tp-thumb/gi);
                            if (
                                "carousel" === j.sliderType &&
                                ((("move" === t || "end" === t || "cancel" == t) && j.dragStartedOverSlider && !j.dragStartedOverThumbs && !j.dragStartedOverTabs) || ("start" === t && 0 < o && 0 === l && 0 === d))
                            ) {
                                if (R && ("up" === i || "down" === i)) return;
                                switch (((j.dragStartedOverSlider = !0), (a = i && i.match(/left|up/g) ? Math.round(-1 * a) : (a = Math.round(1 * a))), t)) {
                                    case "start":
                                        void 0 !== L.positionanim && (L.positionanim.kill(), (L.slide_globaloffset = "off" === L.infinity ? L.slide_offset : P.simp(L.slide_offset, L.maxwidth))),
                                            (L.overpull = "none"),
                                            L.wrap.addClass("dragged");
                                        break;
                                    case "move":
                                        if (
                                            (j.c.find(".tp-withaction").addClass("tp-temporarydisabled"),
                                            (L.slide_offset = "off" === L.infinity ? L.slide_globaloffset + a : P.simp(L.slide_globaloffset + a, L.maxwidth)),
                                            "off" === L.infinity)
                                        ) {
                                            var u = "center" === L.horizontal_align ? (L.wrapwidth / 2 - L.slide_width / 2 - L.slide_offset) / L.slide_width : (0 - L.slide_offset) / L.slide_width;
                                            ("none" !== L.overpull && 0 !== L.overpull) || !(u < 0 || u > j.slideamount - 1)
                                                ? 0 <= u && u <= j.slideamount - 1 && ((0 <= u && a > L.overpull) || (u <= j.slideamount - 1 && a < L.overpull)) && (L.overpull = 0)
                                                : (L.overpull = a),
                                                (L.slide_offset =
                                                    u < 0
                                                        ? L.slide_offset + (L.overpull - a) / 1.1 + Math.sqrt(Math.abs((L.overpull - a) / 1.1))
                                                        : u > j.slideamount - 1
                                                        ? L.slide_offset + (L.overpull - a) / 1.1 - Math.sqrt(Math.abs((L.overpull - a) / 1.1))
                                                        : L.slide_offset);
                                        }
                                        P.organiseCarousel(j, i, !0, !0);
                                        break;
                                    case "end":
                                    case "cancel":
                                        (L.slide_globaloffset = L.slide_offset),
                                            L.wrap.removeClass("dragged"),
                                            P.carouselToEvalPosition(j, i),
                                            (j.dragStartedOverSlider = !1),
                                            (j.dragStartedOverThumbs = !1),
                                            (j.dragStartedOverTabs = !1),
                                            setTimeout(function () {
                                                j.c.find(".tp-withaction").removeClass("tp-temporarydisabled");
                                            }, 19);
                                }
                            } else {
                                if ((("move" !== t && "end" !== t && "cancel" != t) || j.dragStartedOverSlider || (!j.dragStartedOverThumbs && !j.dragStartedOverTabs)) && !("start" === t && 0 < o && (0 < l || 0 < d))) {
                                    if ("end" == t && !c) {
                                        if (((j.sc_indicator = "arrow"), ("horizontal" == O && "left" == i) || ("vertical" == O && "up" == i))) return (j.sc_indicator_dir = 0), P.callingNewSlide(j.c, 1), !1;
                                        if (("horizontal" == O && "right" == i) || ("vertical" == O && "down" == i)) return (j.sc_indicator_dir = 1), P.callingNewSlide(j.c, -1), !1;
                                    }
                                    return (j.dragStartedOverSlider = !1), (j.dragStartedOverThumbs = !1), !(j.dragStartedOverTabs = !1);
                                }
                                0 < l && (j.dragStartedOverThumbs = !0), 0 < d && (j.dragStartedOverTabs = !0);
                                var h = j.dragStartedOverThumbs ? ".tp-thumbs" : ".tp-tabs",
                                    p = j.dragStartedOverThumbs ? ".tp-thumb-mask" : ".tp-tab-mask",
                                    f = j.dragStartedOverThumbs ? ".tp-thumbs-inner-wrapper" : ".tp-tabs-inner-wrapper",
                                    g = j.dragStartedOverThumbs ? ".tp-thumb" : ".tp-tab",
                                    m = j.dragStartedOverThumbs ? j.navigation.thumbnails : j.navigation.tabs;
                                a = i && i.match(/left|up/g) ? Math.round(-1 * a) : (a = Math.round(1 * a));
                                var v = S.parent().find(p),
                                    y = v.find(f),
                                    w = m.direction,
                                    _ = "vertical" === w ? y.height() : y.width(),
                                    b = "vertical" === w ? v.height() : v.width(),
                                    x = "vertical" === w ? v.find(g).first().outerHeight(!0) + m.space : v.find(g).first().outerWidth(!0) + m.space,
                                    T = void 0 === y.data("offset") ? 0 : parseInt(y.data("offset"), 0),
                                    C = 0;
                                switch (t) {
                                    case "start":
                                        S.parent().find(h).addClass("dragged"), (T = "vertical" === w ? y.position().top : y.position().left), y.data("offset", T), y.data("tmmove") && y.data("tmmove").pause();
                                        break;
                                    case "move":
                                        if (_ <= b) return !1;
                                        C = 0 < (C = T + a) ? ("horizontal" === w ? C - y.width() * (((C / y.width()) * C) / y.width()) : C - y.height() * (((C / y.height()) * C) / y.height())) : C;
                                        var k = "vertical" === w ? 0 - (y.height() - v.height()) : 0 - (y.width() - v.width());
                                        (C = C < k ? ("horizontal" === w ? C + (((y.width() * (C - k)) / y.width()) * (C - k)) / y.width() : C + (((y.height() * (C - k)) / y.height()) * (C - k)) / y.height()) : C),
                                            "vertical" === w ? punchgs.TweenLite.set(y, { top: C + "px" }) : punchgs.TweenLite.set(y, { left: C + "px" });
                                        break;
                                    case "end":
                                    case "cancel":
                                        if (c)
                                            return (
                                                (C = T + a),
                                                (C = 0 < (C = "vertical" === w ? (C < 0 - (y.height() - v.height()) ? 0 - (y.height() - v.height()) : C) : C < 0 - (y.width() - v.width()) ? 0 - (y.width() - v.width()) : C) ? 0 : C),
                                                (C = Math.abs(a) > x / 10 ? (a <= 0 ? Math.floor(C / x) * x : Math.ceil(C / x) * x) : a < 0 ? Math.ceil(C / x) * x : Math.floor(C / x) * x),
                                                (C = 0 < (C = "vertical" === w ? (C < 0 - (y.height() - v.height()) ? 0 - (y.height() - v.height()) : C) : C < 0 - (y.width() - v.width()) ? 0 - (y.width() - v.width()) : C) ? 0 : C),
                                                "vertical" === w ? punchgs.TweenLite.to(y, 0.5, { top: C + "px", ease: punchgs.Power3.easeOut }) : punchgs.TweenLite.to(y, 0.5, { left: C + "px", ease: punchgs.Power3.easeOut }),
                                                (C = C || ("vertical" === w ? y.position().top : y.position().left)),
                                                y.data("offset", C),
                                                y.data("distance", a),
                                                setTimeout(function () {
                                                    (j.dragStartedOverSlider = !1), (j.dragStartedOverThumbs = !1), (j.dragStartedOverTabs = !1);
                                                }, 100),
                                                S.parent().find(h).removeClass("dragged"),
                                                !1
                                            );
                                }
                            }
                        },
                    });
            },
            m = function (e) {
                (e.hide_delay = jQuery.isNumeric(parseInt(e.hide_delay, 0)) ? e.hide_delay / 1e3 : 0.2), (e.hide_delay_mobile = jQuery.isNumeric(parseInt(e.hide_delay_mobile, 0)) ? e.hide_delay_mobile / 1e3 : 0.2);
            },
            v = function (e) {
                return e && e.enable;
            },
            a = function (e) {
                return e && e.enable && !0 === e.hide_onleave && (void 0 === e.position || !e.position.match(/outer/g));
            },
            y = function (e, t) {
                var i = e.parent();
                a(t.navigation.arrows) && punchgs.TweenLite.delayedCall(R ? t.navigation.arrows.hide_delay_mobile : t.navigation.arrows.hide_delay, w, [i.find(".tparrows"), t.navigation.arrows, "hide"]),
                    a(t.navigation.bullets) && punchgs.TweenLite.delayedCall(R ? t.navigation.bullets.hide_delay_mobile : t.navigation.bullets.hide_delay, w, [i.find(".tp-bullets"), t.navigation.bullets, "hide"]),
                    a(t.navigation.thumbnails) && punchgs.TweenLite.delayedCall(R ? t.navigation.thumbnails.hide_delay_mobile : t.navigation.thumbnails.hide_delay, w, [i.find(".tp-thumbs"), t.navigation.thumbnails, "hide"]),
                    a(t.navigation.tabs) && punchgs.TweenLite.delayedCall(R ? t.navigation.tabs.hide_delay_mobile : t.navigation.tabs.hide_delay, w, [i.find(".tp-tabs"), t.navigation.tabs, "hide"]);
            },
            w = function (e, t, i, a) {
                switch (((a = void 0 === a ? 0.5 : a), i)) {
                    case "show":
                        punchgs.TweenLite.to(e, a, { autoAlpha: 1, ease: punchgs.Power3.easeInOut, overwrite: "auto" });
                        break;
                    case "hide":
                        punchgs.TweenLite.to(e, a, { autoAlpha: 0, ease: punchgs.Power3.easeInOu, overwrite: "auto" });
                }
            },
            _ = function (e, t, i) {
                (t.style = void 0 === t.style ? "" : t.style),
                    (t.left.style = void 0 === t.left.style ? "" : t.left.style),
                    (t.right.style = void 0 === t.right.style ? "" : t.right.style),
                    0 === e.find(".tp-leftarrow.tparrows").length && e.append('<div class="tp-leftarrow tparrows ' + t.style + " " + t.left.style + '">' + t.tmp + "</div>"),
                    0 === e.find(".tp-rightarrow.tparrows").length && e.append('<div class="tp-rightarrow tparrows ' + t.style + " " + t.right.style + '">' + t.tmp + "</div>");
                var a = e.find(".tp-leftarrow.tparrows"),
                    n = e.find(".tp-rightarrow.tparrows");
                t.rtl
                    ? (a.click(function () {
                          (i.sc_indicator = "arrow"), (i.sc_indicator_dir = 0), e.revnext();
                      }),
                      n.click(function () {
                          (i.sc_indicator = "arrow"), (i.sc_indicator_dir = 1), e.revprev();
                      }))
                    : (n.click(function () {
                          (i.sc_indicator = "arrow"), (i.sc_indicator_dir = 0), e.revnext();
                      }),
                      a.click(function () {
                          (i.sc_indicator = "arrow"), (i.sc_indicator_dir = 1), e.revprev();
                      })),
                    (t.right.j = e.find(".tp-rightarrow.tparrows")),
                    (t.left.j = e.find(".tp-leftarrow.tparrows")),
                    (t.padding_top = parseInt(i.carousel.padding_top || 0, 0)),
                    (t.padding_bottom = parseInt(i.carousel.padding_bottom || 0, 0)),
                    T(a, t.left, i),
                    T(n, t.right, i),
                    (t.left.opt = i),
                    (t.right.opt = i),
                    ("outer-left" != t.position && "outer-right" != t.position) || (i.outernav = !0);
            },
            h = function (e, t, i) {
                var a = e.outerHeight(!0),
                    n = (e.outerWidth(!0), null == t.opt ? 0 : 0 == i.conh ? i.height : i.conh),
                    r =
                        "layergrid" == t.container
                            ? "fullscreen" == i.sliderLayout
                                ? i.height / 2 - (i.gridheight[i.curWinRange] * i.bh) / 2
                                : "on" == i.autoHeight || (null != i.minHeight && 0 < i.minHeight)
                                ? n / 2 - (i.gridheight[i.curWinRange] * i.bh) / 2
                                : 0
                            : 0,
                    s =
                        "top" === t.v_align
                            ? { top: "0px", y: Math.round(t.v_offset + r) + "px" }
                            : "center" === t.v_align
                            ? { top: "50%", y: Math.round(0 - a / 2 + t.v_offset) + "px" }
                            : { top: "100%", y: Math.round(0 - (a + t.v_offset + r)) + "px" };
                e.hasClass("outer-bottom") || punchgs.TweenLite.set(e, s);
            },
            b = function (e, t, i) {
                var a = (e.outerHeight(!0), e.outerWidth(!0)),
                    n = "layergrid" == t.container ? ("carousel" === i.sliderType ? 0 : i.width / 2 - (i.gridwidth[i.curWinRange] * i.bw) / 2) : 0,
                    r =
                        "left" === t.h_align
                            ? { left: "0px", x: Math.round(t.h_offset + n) + "px" }
                            : "center" === t.h_align
                            ? { left: "50%", x: Math.round(0 - a / 2 + t.h_offset) + "px" }
                            : { left: "100%", x: Math.round(0 - (a + t.h_offset + n)) + "px" };
                punchgs.TweenLite.set(e, r);
            },
            T = function (e, t, i) {
                var a =
                        0 < e.closest(".tp-simpleresponsive").length
                            ? e.closest(".tp-simpleresponsive")
                            : 0 < e.closest(".tp-revslider-mainul").length
                            ? e.closest(".tp-revslider-mainul")
                            : 0 < e.closest(".rev_slider_wrapper").length
                            ? e.closest(".rev_slider_wrapper")
                            : e.parent().find(".tp-revslider-mainul"),
                    n = a.width(),
                    r = a.height();
                if (
                    (h(e, t, i),
                    b(e, t, i),
                    "outer-left" !== t.position || ("fullwidth" != t.sliderLayout && "fullscreen" != t.sliderLayout)
                        ? "outer-right" !== t.position || ("fullwidth" != t.sliderLayout && "fullscreen" != t.sliderLayout) || punchgs.TweenLite.set(e, { right: 0 - e.outerWidth() + "px", x: t.h_offset + "px" })
                        : punchgs.TweenLite.set(e, { left: 0 - e.outerWidth() + "px", x: t.h_offset + "px" }),
                    e.hasClass("tp-thumbs") || e.hasClass("tp-tabs"))
                ) {
                    var s = e.data("wr_padding"),
                        o = e.data("maxw"),
                        l = e.data("maxh"),
                        d = e.hasClass("tp-thumbs") ? e.find(".tp-thumb-mask") : e.find(".tp-tab-mask"),
                        c = parseInt(t.padding_top || 0, 0),
                        u = parseInt(t.padding_bottom || 0, 0);
                    n < o && "outer-left" !== t.position && "outer-right" !== t.position
                        ? (punchgs.TweenLite.set(e, { left: "0px", x: 0, maxWidth: n - 2 * s + "px" }), punchgs.TweenLite.set(d, { maxWidth: n - 2 * s + "px" }))
                        : (punchgs.TweenLite.set(e, { maxWidth: o + "px" }), punchgs.TweenLite.set(d, { maxWidth: o + "px" })),
                        r < l + 2 * s && "outer-bottom" !== t.position && "outer-top" !== t.position
                            ? (punchgs.TweenLite.set(e, { top: "0px", y: 0, maxHeight: c + u + (r - 2 * s) + "px" }), punchgs.TweenLite.set(d, { maxHeight: c + u + (r - 2 * s) + "px" }))
                            : (punchgs.TweenLite.set(e, { maxHeight: l + "px" }), punchgs.TweenLite.set(d, { maxHeight: l + "px" })),
                        "outer-left" !== t.position && "outer-right" !== t.position && (u = c = 0),
                        !0 === t.span && "vertical" === t.direction
                            ? (punchgs.TweenLite.set(e, { maxHeight: c + u + (r - 2 * s) + "px", height: c + u + (r - 2 * s) + "px", top: 0 - c, y: 0 }), h(d, t, i))
                            : !0 === t.span && "horizontal" === t.direction && (punchgs.TweenLite.set(e, { maxWidth: "100%", width: n - 2 * s + "px", left: 0, x: 0 }), b(d, t, i));
                }
            },
            x = function (e, t, i, a) {
                0 === e.find(".tp-bullets").length && ((t.style = void 0 === t.style ? "" : t.style), e.append('<div class="tp-bullets ' + t.style + " " + t.direction + '"></div>'));
                var n = e.find(".tp-bullets"),
                    r = i.data("index"),
                    s = t.tmp;
                jQuery.each(a.thumbs[i.index()].params, function (e, t) {
                    s = s.replace(t.from, t.to);
                }),
                    n.append('<div class="justaddedbullet tp-bullet">' + s + "</div>");
                var o = e.find(".justaddedbullet"),
                    l = e.find(".tp-bullet").length,
                    d = o.outerWidth() + parseInt(void 0 === t.space ? 0 : t.space, 0),
                    c = o.outerHeight() + parseInt(void 0 === t.space ? 0 : t.space, 0);
                "vertical" === t.direction
                    ? (o.css({ top: (l - 1) * c + "px", left: "0px" }), n.css({ height: (l - 1) * c + o.outerHeight(), width: o.outerWidth() }))
                    : (o.css({ left: (l - 1) * d + "px", top: "0px" }), n.css({ width: (l - 1) * d + o.outerWidth(), height: o.outerHeight() })),
                    o.find(".tp-bullet-image").css({ backgroundImage: "url(" + a.thumbs[i.index()].src + ")" }),
                    o.data("liref", r),
                    o.click(function () {
                        (a.sc_indicator = "bullet"), e.revcallslidewithid(r), e.find(".tp-bullet").removeClass("selected"), jQuery(this).addClass("selected");
                    }),
                    o.removeClass("justaddedbullet"),
                    (t.padding_top = parseInt(a.carousel.padding_top || 0, 0)),
                    (t.padding_bottom = parseInt(a.carousel.padding_bottom || 0, 0)),
                    (t.opt = a),
                    ("outer-left" != t.position && "outer-right" != t.position) || (a.outernav = !0),
                    n.addClass("nav-pos-hor-" + t.h_align),
                    n.addClass("nav-pos-ver-" + t.v_align),
                    n.addClass("nav-dir-" + t.direction),
                    T(n, t, a);
            },
            C = function (t, e, i, a, n) {
                var r = "tp-thumb" === a ? ".tp-thumbs" : ".tp-tabs",
                    s = "tp-thumb" === a ? ".tp-thumb-mask" : ".tp-tab-mask",
                    o = "tp-thumb" === a ? ".tp-thumbs-inner-wrapper" : ".tp-tabs-inner-wrapper",
                    l = "tp-thumb" === a ? ".tp-thumb" : ".tp-tab",
                    d = "tp-thumb" === a ? ".tp-thumb-image" : ".tp-tab-image";
                if (((e.visibleAmount = e.visibleAmount > n.slideamount ? n.slideamount : e.visibleAmount), (e.sliderLayout = n.sliderLayout), 0 === t.parent().find(r).length)) {
                    e.style = void 0 === e.style ? "" : e.style;
                    var c =
                        '<div class="' +
                        a +
                        "s " +
                        (!0 === e.span ? "tp-span-wrapper" : "") +
                        " " +
                        e.position +
                        " " +
                        e.style +
                        '"><div class="' +
                        a +
                        '-mask"><div class="' +
                        a +
                        's-inner-wrapper" style="position:relative;"></div></div></div>';
                    "outer-top" === e.position ? t.parent().prepend(c) : "outer-bottom" === e.position ? t.after(c) : t.append(c),
                        (e.padding_top = parseInt(n.carousel.padding_top || 0, 0)),
                        (e.padding_bottom = parseInt(n.carousel.padding_bottom || 0, 0)),
                        ("outer-left" != e.position && "outer-right" != e.position) || (n.outernav = !0);
                }
                var u = i.data("index"),
                    h = t.parent().find(r),
                    p = h.find(s),
                    f = p.find(o),
                    g = "horizontal" === e.direction ? e.width * e.visibleAmount + e.space * (e.visibleAmount - 1) : e.width,
                    m = "horizontal" === e.direction ? e.height : e.height * e.visibleAmount + e.space * (e.visibleAmount - 1),
                    v = e.tmp;
                jQuery.each(n.thumbs[i.index()].params, function (e, t) {
                    v = v.replace(t.from, t.to);
                }),
                    f.append('<div data-liindex="' + i.index() + '" data-liref="' + u + '" class="justaddedthumb ' + a + '" style="width:' + e.width + "px;height:" + e.height + 'px;">' + v + "</div>");
                var y = h.find(".justaddedthumb"),
                    w = h.find(l).length,
                    _ = y.outerWidth() + parseInt(void 0 === e.space ? 0 : e.space, 0),
                    b = y.outerHeight() + parseInt(void 0 === e.space ? 0 : e.space, 0);
                y.find(d).css({ backgroundImage: "url(" + n.thumbs[i.index()].src + ")" }),
                    "vertical" === e.direction
                        ? (y.css({ top: (w - 1) * b + "px", left: "0px" }), f.css({ height: (w - 1) * b + y.outerHeight(), width: y.outerWidth() }))
                        : (y.css({ left: (w - 1) * _ + "px", top: "0px" }), f.css({ width: (w - 1) * _ + y.outerWidth(), height: y.outerHeight() })),
                    h.data("maxw", g),
                    h.data("maxh", m),
                    h.data("wr_padding", e.wrapper_padding);
                var x = "outer-top" === e.position || "outer-bottom" === e.position ? "relative" : "absolute";
                ("outer-top" !== e.position && "outer-bottom" !== e.position) || e.h_align,
                    p.css({ maxWidth: g + "px", maxHeight: m + "px", overflow: "hidden", position: "relative" }),
                    h.css({ maxWidth: g + "px", maxHeight: m + "px", overflow: "visible", position: x, background: e.wrapper_color, padding: e.wrapper_padding + "px", boxSizing: "contet-box" }),
                    y.click(function () {
                        n.sc_indicator = "bullet";
                        var e = t.parent().find(o).data("distance");
                        (e = void 0 === e ? 0 : e), Math.abs(e) < 10 && (t.revcallslidewithid(u), t.parent().find(r).removeClass("selected"), jQuery(this).addClass("selected"));
                    }),
                    y.removeClass("justaddedthumb"),
                    (e.opt = n),
                    h.addClass("nav-pos-hor-" + e.h_align),
                    h.addClass("nav-pos-ver-" + e.v_align),
                    h.addClass("nav-dir-" + e.direction),
                    T(h, e, n);
            },
            d = function (e) {
                var t = e.c.parent().find(".outer-top"),
                    i = e.c.parent().find(".outer-bottom");
                (e.top_outer = t.hasClass("tp-forcenotvisible") ? 0 : t.outerHeight() || 0), (e.bottom_outer = i.hasClass("tp-forcenotvisible") ? 0 : i.outerHeight() || 0);
            },
            s = function (e, t, i, a) {
                i < t || a < i ? e.addClass("tp-forcenotvisible") : e.removeClass("tp-forcenotvisible");
            };
    })(jQuery),
    (function (e) {
        "use strict";
        var P = jQuery.fn.revolution,
            R = P.is_mobile(),
            t = { alias: "Navigation Min JS", name: "revolution.extensions.navigation.min.js", min_core: "5.4.0", version: "1.3.5" };
        jQuery.extend(!0, P, {
            hideUnHideNav: function (e) {
                var t = e.c.width(),
                    i = e.navigation.arrows,
                    a = e.navigation.bullets,
                    n = e.navigation.thumbnails,
                    r = e.navigation.tabs;
                v(i) && s(e.c.find(".tparrows"), i.hide_under, t, i.hide_over),
                    v(a) && s(e.c.find(".tp-bullets"), a.hide_under, t, a.hide_over),
                    v(n) && s(e.c.parent().find(".tp-thumbs"), n.hide_under, t, n.hide_over),
                    v(r) && s(e.c.parent().find(".tp-tabs"), r.hide_under, t, r.hide_over),
                    d(e);
            },
            resizeThumbsTabs: function (e, t) {
                if ((e.navigation && e.navigation.tabs.enable) || (e.navigation && e.navigation.thumbnails.enable)) {
                    var i = (jQuery(window).width() - 480) / 500,
                        a = new punchgs.TimelineLite(),
                        n = e.navigation.tabs,
                        r = e.navigation.thumbnails,
                        s = e.navigation.bullets;
                    if (
                        (a.pause(), (i = 1 < i ? 1 : i < 0 ? 0 : i), v(n) && (t || n.width > n.min_width) && l(i, a, e.c, n, e.slideamount, "tab"), v(r) && (t || r.width > r.min_width) && l(i, a, e.c, r, e.slideamount, "thumb"), v(s) && t)
                    ) {
                        var o = e.c.find(".tp-bullets");
                        o.find(".tp-bullet").each(function (e) {
                            var t = jQuery(this),
                                i = e + 1,
                                a = t.outerWidth() + parseInt(void 0 === s.space ? 0 : s.space, 0),
                                n = t.outerHeight() + parseInt(void 0 === s.space ? 0 : s.space, 0);
                            "vertical" === s.direction
                                ? (t.css({ top: (i - 1) * n + "px", left: "0px" }), o.css({ height: (i - 1) * n + t.outerHeight(), width: t.outerWidth() }))
                                : (t.css({ left: (i - 1) * a + "px", top: "0px" }), o.css({ width: (i - 1) * a + t.outerWidth(), height: t.outerHeight() }));
                        });
                    }
                    a.play(), d(e);
                }
                return !0;
            },
            updateNavIndexes: function (e) {
                function t(e) {
                    0 < i.find(e).lenght &&
                        i.find(e).each(function (e) {
                            jQuery(this).data("liindex", e);
                        });
                }
                var i = e.c;
                t(".tp-tab"), t(".tp-bullet"), t(".tp-thumb"), P.resizeThumbsTabs(e, !0), P.manageNavigation(e);
            },
            manageNavigation: function (e) {
                var t = P.getHorizontalOffset(e.c.parent(), "left"),
                    i = P.getHorizontalOffset(e.c.parent(), "right");
                v(e.navigation.bullets) &&
                    ("fullscreen" != e.sliderLayout &&
                        "fullwidth" != e.sliderLayout &&
                        ((e.navigation.bullets.h_offset_old = void 0 === e.navigation.bullets.h_offset_old ? e.navigation.bullets.h_offset : e.navigation.bullets.h_offset_old),
                        (e.navigation.bullets.h_offset = "center" === e.navigation.bullets.h_align ? e.navigation.bullets.h_offset_old + t / 2 - i / 2 : e.navigation.bullets.h_offset_old + t - i)),
                    T(e.c.find(".tp-bullets"), e.navigation.bullets, e)),
                    v(e.navigation.thumbnails) && T(e.c.parent().find(".tp-thumbs"), e.navigation.thumbnails, e),
                    v(e.navigation.tabs) && T(e.c.parent().find(".tp-tabs"), e.navigation.tabs, e),
                    v(e.navigation.arrows) &&
                        ("fullscreen" != e.sliderLayout &&
                            "fullwidth" != e.sliderLayout &&
                            ((e.navigation.arrows.left.h_offset_old = void 0 === e.navigation.arrows.left.h_offset_old ? e.navigation.arrows.left.h_offset : e.navigation.arrows.left.h_offset_old),
                            (e.navigation.arrows.left.h_offset = "right" === e.navigation.arrows.left.h_align ? e.navigation.arrows.left.h_offset_old + i : e.navigation.arrows.left.h_offset_old + t),
                            (e.navigation.arrows.right.h_offset_old = void 0 === e.navigation.arrows.right.h_offset_old ? e.navigation.arrows.right.h_offset : e.navigation.arrows.right.h_offset_old),
                            (e.navigation.arrows.right.h_offset = "right" === e.navigation.arrows.right.h_align ? e.navigation.arrows.right.h_offset_old + i : e.navigation.arrows.right.h_offset_old + t)),
                        T(e.c.find(".tp-leftarrow.tparrows"), e.navigation.arrows.left, e),
                        T(e.c.find(".tp-rightarrow.tparrows"), e.navigation.arrows.right, e)),
                    v(e.navigation.thumbnails) && p(e.c.parent().find(".tp-thumbs"), e.navigation.thumbnails),
                    v(e.navigation.tabs) && p(e.c.parent().find(".tp-tabs"), e.navigation.tabs);
            },
            createNavigation: function (s, o) {
                if ("stop" === P.compare_version(t).check) return !1;
                var l = s.parent(),
                    d = o.navigation.arrows,
                    a = o.navigation.bullets,
                    c = o.navigation.thumbnails,
                    u = o.navigation.tabs,
                    e = v(d),
                    n = v(a),
                    r = v(c),
                    h = v(u);
                i(s, o),
                    f(s, o),
                    e && _(s, d, o),
                    o.li.each(function (e) {
                        var t = jQuery(o.li[o.li.length - 1 - e]),
                            i = jQuery(this);
                        n && (o.navigation.bullets.rtl ? x(s, a, t, o) : x(s, a, i, o)),
                            r && (o.navigation.thumbnails.rtl ? C(s, c, t, "tp-thumb", o) : C(s, c, i, "tp-thumb", o)),
                            h && (o.navigation.tabs.rtl ? C(s, u, t, "tp-tab", o) : C(s, u, i, "tp-tab", o));
                    }),
                    s.bind("revolution.slide.onafterswap revolution.nextslide.waiting", function () {
                        var i = 0 == s.find(".next-revslide").length ? s.find(".active-revslide").data("index") : s.find(".next-revslide").data("index");
                        s.find(".tp-bullet").each(function () {
                            var e = jQuery(this);
                            e.data("liref") === i ? e.addClass("selected") : e.removeClass("selected");
                        }),
                            l.find(".tp-thumb, .tp-tab").each(function () {
                                var e = jQuery(this);
                                e.data("liref") === i ? (e.addClass("selected"), e.hasClass("tp-tab") ? p(l.find(".tp-tabs"), u) : p(l.find(".tp-thumbs"), c)) : e.removeClass("selected");
                            });
                        var a = 0,
                            n = !1;
                        o.thumbs &&
                            jQuery.each(o.thumbs, function (e, t) {
                                (a = !1 === n ? e : a), (n = t.id === i || e === i || n);
                            });
                        var e = 0 < a ? a - 1 : o.slideamount - 1,
                            t = a + 1 == o.slideamount ? 0 : a + 1;
                        if (!0 === d.enable) {
                            var r = d.tmp;
                            if (
                                (null != o.thumbs[e] &&
                                    jQuery.each(o.thumbs[e].params, function (e, t) {
                                        r = r.replace(t.from, t.to);
                                    }),
                                d.left.j.html(r),
                                (r = d.tmp),
                                t > o.slideamount)
                            )
                                return;
                            jQuery.each(o.thumbs[t].params, function (e, t) {
                                r = r.replace(t.from, t.to);
                            }),
                                d.right.j.html(r),
                                d.rtl
                                    ? (punchgs.TweenLite.set(d.left.j.find(".tp-arr-imgholder"), { backgroundImage: "url(" + o.thumbs[t].src + ")" }),
                                      punchgs.TweenLite.set(d.right.j.find(".tp-arr-imgholder"), { backgroundImage: "url(" + o.thumbs[e].src + ")" }))
                                    : (punchgs.TweenLite.set(d.left.j.find(".tp-arr-imgholder"), { backgroundImage: "url(" + o.thumbs[e].src + ")" }),
                                      punchgs.TweenLite.set(d.right.j.find(".tp-arr-imgholder"), { backgroundImage: "url(" + o.thumbs[t].src + ")" }));
                        }
                    }),
                    m(d),
                    m(a),
                    m(c),
                    m(u),
                    l.on("mouseenter mousemove", function () {
                        l.hasClass("tp-mouseover") ||
                            (l.addClass("tp-mouseover"),
                            punchgs.TweenLite.killDelayedCallsTo(w),
                            e && d.hide_onleave && w(l.find(".tparrows"), d, "show"),
                            n && a.hide_onleave && w(l.find(".tp-bullets"), a, "show"),
                            r && c.hide_onleave && w(l.find(".tp-thumbs"), c, "show"),
                            h && u.hide_onleave && w(l.find(".tp-tabs"), u, "show"),
                            R && (l.removeClass("tp-mouseover"), y(s, o)));
                    }),
                    l.on("mouseleave", function () {
                        l.removeClass("tp-mouseover"), y(s, o);
                    }),
                    e && d.hide_onleave && w(l.find(".tparrows"), d, "hide", 0),
                    n && a.hide_onleave && w(l.find(".tp-bullets"), a, "hide", 0),
                    r && c.hide_onleave && w(l.find(".tp-thumbs"), c, "hide", 0),
                    h && u.hide_onleave && w(l.find(".tp-tabs"), u, "hide", 0),
                    r && g(l.find(".tp-thumbs"), o),
                    h && g(l.find(".tp-tabs"), o),
                    "carousel" === o.sliderType && g(s, o, !0),
                    ("on" === o.navigation.touch.touchOnDesktop || ("on" == o.navigation.touch.touchenabled && R)) && g(s, o, "swipebased");
            },
        });
        var p = function (e, t) {
                var i = (e.hasClass("tp-thumbs"), e.hasClass("tp-thumbs") ? ".tp-thumb-mask" : ".tp-tab-mask"),
                    a = e.hasClass("tp-thumbs") ? ".tp-thumbs-inner-wrapper" : ".tp-tabs-inner-wrapper",
                    n = e.hasClass("tp-thumbs") ? ".tp-thumb" : ".tp-tab",
                    r = e.find(i),
                    s = r.find(a),
                    o = t.direction,
                    l = "vertical" === o ? r.find(n).first().outerHeight(!0) + t.space : r.find(n).first().outerWidth(!0) + t.space,
                    d = "vertical" === o ? r.height() : r.width(),
                    c = parseInt(r.find(n + ".selected").data("liindex"), 0),
                    u = d / l,
                    h = "vertical" === o ? r.height() : r.width(),
                    p = 0 - c * l,
                    f = "vertical" === o ? s.height() : s.width(),
                    g = p < 0 - (f - h) ? 0 - (f - h) : 0 < g ? 0 : p,
                    m = s.data("offset");
                2 < u && ((g = p - (m + l) <= 0 ? (p - (m + l) < 0 - l ? m : g + l) : g), (g = p - l + m + d < l && p + (Math.round(u) - 2) * l < m ? p + (Math.round(u) - 2) * l : g)),
                    (g = g < 0 - (f - h) ? 0 - (f - h) : 0 < g ? 0 : g),
                    "vertical" !== o && r.width() >= s.width() && (g = 0),
                    "vertical" === o && r.height() >= s.height() && (g = 0),
                    e.hasClass("dragged") ||
                        ("vertical" === o
                            ? s.data("tmmove", punchgs.TweenLite.to(s, 0.5, { top: g + "px", ease: punchgs.Power3.easeInOut }))
                            : s.data("tmmove", punchgs.TweenLite.to(s, 0.5, { left: g + "px", ease: punchgs.Power3.easeInOut })),
                        s.data("offset", g));
            },
            l = function (e, i, t, a, n, r) {
                var s = t.parent().find(".tp-" + r + "s"),
                    o = s.find(".tp-" + r + "s-inner-wrapper"),
                    l = s.find(".tp-" + r + "-mask"),
                    d = a.width * e < a.min_width ? a.min_width : Math.round(a.width * e),
                    c = Math.round((d / a.width) * a.height),
                    u = "vertical" === a.direction ? d : d * n + a.space * (n - 1),
                    h = "vertical" === a.direction ? c * n + a.space * (n - 1) : c,
                    p = "vertical" === a.direction ? { width: d + "px" } : { height: c + "px" };
                i.add(punchgs.TweenLite.set(s, p)), i.add(punchgs.TweenLite.set(o, { width: u + "px", height: h + "px" })), i.add(punchgs.TweenLite.set(l, { width: u + "px", height: h + "px" }));
                var f = o.find(".tp-" + r);
                return (
                    f &&
                        jQuery.each(f, function (e, t) {
                            "vertical" === a.direction
                                ? i.add(punchgs.TweenLite.set(t, { top: e * (c + parseInt(void 0 === a.space ? 0 : a.space, 0)), width: d + "px", height: c + "px" }))
                                : "horizontal" === a.direction && i.add(punchgs.TweenLite.set(t, { left: e * (d + parseInt(void 0 === a.space ? 0 : a.space, 0)), width: d + "px", height: c + "px" }));
                        }),
                    i
                );
            },
            i = function (t, i) {
                "on" === i.navigation.keyboardNavigation &&
                    jQuery(document).keydown(function (e) {
                        (("horizontal" == i.navigation.keyboard_direction && 39 == e.keyCode) || ("vertical" == i.navigation.keyboard_direction && 40 == e.keyCode)) &&
                            ((i.sc_indicator = "arrow"), (i.sc_indicator_dir = 0), P.callingNewSlide(t, 1)),
                            (("horizontal" == i.navigation.keyboard_direction && 37 == e.keyCode) || ("vertical" == i.navigation.keyboard_direction && 38 == e.keyCode)) &&
                                ((i.sc_indicator = "arrow"), (i.sc_indicator_dir = 1), P.callingNewSlide(t, -1));
                    });
            },
            f = function (f, g) {
                if ("on" === g.navigation.mouseScrollNavigation || "carousel" === g.navigation.mouseScrollNavigation) {
                    (g.isIEEleven = !!navigator.userAgent.match(/Trident.*rv\:11\./)), (g.isSafari = !!navigator.userAgent.match(/safari/i)), (g.ischrome = !!navigator.userAgent.match(/chrome/i));
                    var m = g.ischrome ? -49 : g.isIEEleven || g.isSafari ? -9 : navigator.userAgent.match(/mozilla/i) ? -29 : -49,
                        v = g.ischrome ? 49 : g.isIEEleven || g.isSafari ? 9 : navigator.userAgent.match(/mozilla/i) ? 29 : 49;
                    f.on("mousewheel DOMMouseScroll", function (e) {
                        var t,
                            i,
                            a,
                            n,
                            r,
                            s =
                                ((t = e.originalEvent),
                                (r = n = a = i = 0),
                                "detail" in t && (a = t.detail),
                                "wheelDelta" in t && (a = -t.wheelDelta / 120),
                                "wheelDeltaY" in t && (a = -t.wheelDeltaY / 120),
                                "wheelDeltaX" in t && (i = -t.wheelDeltaX / 120),
                                "axis" in t && t.axis === t.HORIZONTAL_AXIS && ((i = a), (a = 0)),
                                (n = 1 * i),
                                (r = 1 * a),
                                "deltaY" in t && (r = t.deltaY),
                                "deltaX" in t && (n = t.deltaX),
                                (n || r) && t.deltaMode && (t.deltaMode, (n *= 1), (r *= 1)),
                                n && !i && (i = n < 1 ? -1 : 1),
                                r && !a && (a = r < 1 ? -1 : 1),
                                (300 < (r = navigator.userAgent.match(/mozilla/i) ? 10 * r : r) || r < -300) && (r /= 10),
                                { spinX: i, spinY: a, pixelX: n, pixelY: r }),
                            o = f.find(".tp-revslider-slidesli.active-revslide").index(),
                            l = f.find(".tp-revslider-slidesli.processing-revslide").index(),
                            d = (-1 != o && 0 == o) || (-1 != l && 0 == l),
                            c = (-1 != o && o == g.slideamount - 1) || (1 != l && l == g.slideamount - 1),
                            u = !0;
                        "carousel" == g.navigation.mouseScrollNavigation && (d = c = !1),
                            -1 == l
                                ? s.pixelY < m
                                    ? (d || ((g.sc_indicator = "arrow"), "reverse" !== g.navigation.mouseScrollReverse && ((g.sc_indicator_dir = 1), P.callingNewSlide(f, -1)), (u = !1)),
                                      c || ((g.sc_indicator = "arrow"), "reverse" === g.navigation.mouseScrollReverse && ((g.sc_indicator_dir = 0), P.callingNewSlide(f, 1)), (u = !1)))
                                    : v < s.pixelY &&
                                      (c || ((g.sc_indicator = "arrow"), "reverse" !== g.navigation.mouseScrollReverse && ((g.sc_indicator_dir = 0), P.callingNewSlide(f, 1)), (u = !1)),
                                      d || ((g.sc_indicator = "arrow"), "reverse" === g.navigation.mouseScrollReverse && ((g.sc_indicator_dir = 1), P.callingNewSlide(f, -1)), (u = !1)))
                                : (u = !1);
                        var h = g.c.offset().top - jQuery("body").scrollTop(),
                            p = h + g.c.height();
                        return (
                            "carousel" != g.navigation.mouseScrollNavigation
                                ? ("reverse" !== g.navigation.mouseScrollReverse && ((0 < h && 0 < s.pixelY) || (p < jQuery(window).height() && s.pixelY < 0)) && (u = !0),
                                  "reverse" === g.navigation.mouseScrollReverse && ((h < 0 && s.pixelY < 0) || (p > jQuery(window).height() && 0 < s.pixelY)) && (u = !0))
                                : (u = !1),
                            0 == u ? (e.preventDefault(e), !1) : void 0
                        );
                    });
                }
            },
            I = function (e, t, i) {
                return !0 === (e = R ? jQuery(i.target).closest("." + e).length || jQuery(i.srcElement).closest("." + e).length : jQuery(i.toElement).closest("." + e).length || jQuery(i.originalTarget).closest("." + e).length) || 1 === e
                    ? 1
                    : 0;
            },
            g = function (S, j, e) {
                var L = j.carousel;
                jQuery(".bullet, .bullets, .tp-bullets, .tparrows").addClass("noSwipe"), (L.Limit = "endless");
                var t = (R || P.get_browser(), S),
                    i = "vertical" === j.navigation.thumbnails.direction || "vertical" === j.navigation.tabs.direction ? "none" : "vertical",
                    O = j.navigation.touch.swipe_direction || "horizontal";
                (i = "swipebased" == e && "vertical" == O ? "none" : e ? "vertical" : i),
                    jQuery.fn.swipetp || (jQuery.fn.swipetp = jQuery.fn.swipe),
                    (jQuery.fn.swipetp.defaults && jQuery.fn.swipetp.defaults.excludedElements) || jQuery.fn.swipetp.defaults || (jQuery.fn.swipetp.defaults = new Object()),
                    (jQuery.fn.swipetp.defaults.excludedElements = "label, button, input, select, textarea, .noSwipe"),
                    t.swipetp({
                        allowPageScroll: i,
                        triggerOnTouchLeave: !0,
                        treshold: j.navigation.touch.swipe_treshold,
                        fingers: j.navigation.touch.swipe_min_touches,
                        excludeElements: jQuery.fn.swipetp.defaults.excludedElements,
                        swipeStatus: function (e, t, i, a, n, r, s) {
                            var o = I("rev_slider_wrapper", 0, e),
                                l = I("tp-thumbs", 0, e),
                                d = I("tp-tabs", 0, e),
                                c = !!jQuery(this)
                                    .attr("class")
                                    .match(/tp-tabs|tp-thumb/gi);
                            if (
                                "carousel" === j.sliderType &&
                                ((("move" === t || "end" === t || "cancel" == t) && j.dragStartedOverSlider && !j.dragStartedOverThumbs && !j.dragStartedOverTabs) || ("start" === t && 0 < o && 0 === l && 0 === d))
                            ) {
                                if (R && ("up" === i || "down" === i)) return;
                                switch (((j.dragStartedOverSlider = !0), (a = i && i.match(/left|up/g) ? Math.round(-1 * a) : (a = Math.round(1 * a))), t)) {
                                    case "start":
                                        void 0 !== L.positionanim && (L.positionanim.kill(), (L.slide_globaloffset = "off" === L.infinity ? L.slide_offset : P.simp(L.slide_offset, L.maxwidth))),
                                            (L.overpull = "none"),
                                            L.wrap.addClass("dragged");
                                        break;
                                    case "move":
                                        if (
                                            (j.c.find(".tp-withaction").addClass("tp-temporarydisabled"),
                                            (L.slide_offset = "off" === L.infinity ? L.slide_globaloffset + a : P.simp(L.slide_globaloffset + a, L.maxwidth)),
                                            "off" === L.infinity)
                                        ) {
                                            var u = "center" === L.horizontal_align ? (L.wrapwidth / 2 - L.slide_width / 2 - L.slide_offset) / L.slide_width : (0 - L.slide_offset) / L.slide_width;
                                            ("none" !== L.overpull && 0 !== L.overpull) || !(u < 0 || u > j.slideamount - 1)
                                                ? 0 <= u && u <= j.slideamount - 1 && ((0 <= u && a > L.overpull) || (u <= j.slideamount - 1 && a < L.overpull)) && (L.overpull = 0)
                                                : (L.overpull = a),
                                                (L.slide_offset =
                                                    u < 0
                                                        ? L.slide_offset + (L.overpull - a) / 1.1 + Math.sqrt(Math.abs((L.overpull - a) / 1.1))
                                                        : u > j.slideamount - 1
                                                        ? L.slide_offset + (L.overpull - a) / 1.1 - Math.sqrt(Math.abs((L.overpull - a) / 1.1))
                                                        : L.slide_offset);
                                        }
                                        P.organiseCarousel(j, i, !0, !0);
                                        break;
                                    case "end":
                                    case "cancel":
                                        (L.slide_globaloffset = L.slide_offset),
                                            L.wrap.removeClass("dragged"),
                                            P.carouselToEvalPosition(j, i),
                                            (j.dragStartedOverSlider = !1),
                                            (j.dragStartedOverThumbs = !1),
                                            (j.dragStartedOverTabs = !1),
                                            setTimeout(function () {
                                                j.c.find(".tp-withaction").removeClass("tp-temporarydisabled");
                                            }, 19);
                                }
                            } else {
                                if ((("move" !== t && "end" !== t && "cancel" != t) || j.dragStartedOverSlider || (!j.dragStartedOverThumbs && !j.dragStartedOverTabs)) && !("start" === t && 0 < o && (0 < l || 0 < d))) {
                                    if ("end" == t && !c) {
                                        if (((j.sc_indicator = "arrow"), ("horizontal" == O && "left" == i) || ("vertical" == O && "up" == i))) return (j.sc_indicator_dir = 0), P.callingNewSlide(j.c, 1), !1;
                                        if (("horizontal" == O && "right" == i) || ("vertical" == O && "down" == i)) return (j.sc_indicator_dir = 1), P.callingNewSlide(j.c, -1), !1;
                                    }
                                    return (j.dragStartedOverSlider = !1), (j.dragStartedOverThumbs = !1), !(j.dragStartedOverTabs = !1);
                                }
                                0 < l && (j.dragStartedOverThumbs = !0), 0 < d && (j.dragStartedOverTabs = !0);
                                var h = j.dragStartedOverThumbs ? ".tp-thumbs" : ".tp-tabs",
                                    p = j.dragStartedOverThumbs ? ".tp-thumb-mask" : ".tp-tab-mask",
                                    f = j.dragStartedOverThumbs ? ".tp-thumbs-inner-wrapper" : ".tp-tabs-inner-wrapper",
                                    g = j.dragStartedOverThumbs ? ".tp-thumb" : ".tp-tab",
                                    m = j.dragStartedOverThumbs ? j.navigation.thumbnails : j.navigation.tabs;
                                a = i && i.match(/left|up/g) ? Math.round(-1 * a) : (a = Math.round(1 * a));
                                var v = S.parent().find(p),
                                    y = v.find(f),
                                    w = m.direction,
                                    _ = "vertical" === w ? y.height() : y.width(),
                                    b = "vertical" === w ? v.height() : v.width(),
                                    x = "vertical" === w ? v.find(g).first().outerHeight(!0) + m.space : v.find(g).first().outerWidth(!0) + m.space,
                                    T = void 0 === y.data("offset") ? 0 : parseInt(y.data("offset"), 0),
                                    C = 0;
                                switch (t) {
                                    case "start":
                                        S.parent().find(h).addClass("dragged"), (T = "vertical" === w ? y.position().top : y.position().left), y.data("offset", T), y.data("tmmove") && y.data("tmmove").pause();
                                        break;
                                    case "move":
                                        if (_ <= b) return !1;
                                        C = 0 < (C = T + a) ? ("horizontal" === w ? C - y.width() * (((C / y.width()) * C) / y.width()) : C - y.height() * (((C / y.height()) * C) / y.height())) : C;
                                        var k = "vertical" === w ? 0 - (y.height() - v.height()) : 0 - (y.width() - v.width());
                                        (C = C < k ? ("horizontal" === w ? C + (((y.width() * (C - k)) / y.width()) * (C - k)) / y.width() : C + (((y.height() * (C - k)) / y.height()) * (C - k)) / y.height()) : C),
                                            "vertical" === w ? punchgs.TweenLite.set(y, { top: C + "px" }) : punchgs.TweenLite.set(y, { left: C + "px" });
                                        break;
                                    case "end":
                                    case "cancel":
                                        if (c)
                                            return (
                                                (C = T + a),
                                                (C = 0 < (C = "vertical" === w ? (C < 0 - (y.height() - v.height()) ? 0 - (y.height() - v.height()) : C) : C < 0 - (y.width() - v.width()) ? 0 - (y.width() - v.width()) : C) ? 0 : C),
                                                (C = Math.abs(a) > x / 10 ? (a <= 0 ? Math.floor(C / x) * x : Math.ceil(C / x) * x) : a < 0 ? Math.ceil(C / x) * x : Math.floor(C / x) * x),
                                                (C = 0 < (C = "vertical" === w ? (C < 0 - (y.height() - v.height()) ? 0 - (y.height() - v.height()) : C) : C < 0 - (y.width() - v.width()) ? 0 - (y.width() - v.width()) : C) ? 0 : C),
                                                "vertical" === w ? punchgs.TweenLite.to(y, 0.5, { top: C + "px", ease: punchgs.Power3.easeOut }) : punchgs.TweenLite.to(y, 0.5, { left: C + "px", ease: punchgs.Power3.easeOut }),
                                                (C = C || ("vertical" === w ? y.position().top : y.position().left)),
                                                y.data("offset", C),
                                                y.data("distance", a),
                                                setTimeout(function () {
                                                    (j.dragStartedOverSlider = !1), (j.dragStartedOverThumbs = !1), (j.dragStartedOverTabs = !1);
                                                }, 100),
                                                S.parent().find(h).removeClass("dragged"),
                                                !1
                                            );
                                }
                            }
                        },
                    });
            },
            m = function (e) {
                (e.hide_delay = jQuery.isNumeric(parseInt(e.hide_delay, 0)) ? e.hide_delay / 1e3 : 0.2), (e.hide_delay_mobile = jQuery.isNumeric(parseInt(e.hide_delay_mobile, 0)) ? e.hide_delay_mobile / 1e3 : 0.2);
            },
            v = function (e) {
                return e && e.enable;
            },
            a = function (e) {
                return e && e.enable && !0 === e.hide_onleave && (void 0 === e.position || !e.position.match(/outer/g));
            },
            y = function (e, t) {
                var i = e.parent();
                a(t.navigation.arrows) && punchgs.TweenLite.delayedCall(R ? t.navigation.arrows.hide_delay_mobile : t.navigation.arrows.hide_delay, w, [i.find(".tparrows"), t.navigation.arrows, "hide"]),
                    a(t.navigation.bullets) && punchgs.TweenLite.delayedCall(R ? t.navigation.bullets.hide_delay_mobile : t.navigation.bullets.hide_delay, w, [i.find(".tp-bullets"), t.navigation.bullets, "hide"]),
                    a(t.navigation.thumbnails) && punchgs.TweenLite.delayedCall(R ? t.navigation.thumbnails.hide_delay_mobile : t.navigation.thumbnails.hide_delay, w, [i.find(".tp-thumbs"), t.navigation.thumbnails, "hide"]),
                    a(t.navigation.tabs) && punchgs.TweenLite.delayedCall(R ? t.navigation.tabs.hide_delay_mobile : t.navigation.tabs.hide_delay, w, [i.find(".tp-tabs"), t.navigation.tabs, "hide"]);
            },
            w = function (e, t, i, a) {
                switch (((a = void 0 === a ? 0.5 : a), i)) {
                    case "show":
                        punchgs.TweenLite.to(e, a, { autoAlpha: 1, ease: punchgs.Power3.easeInOut, overwrite: "auto" });
                        break;
                    case "hide":
                        punchgs.TweenLite.to(e, a, { autoAlpha: 0, ease: punchgs.Power3.easeInOu, overwrite: "auto" });
                }
            },
            _ = function (e, t, i) {
                (t.style = void 0 === t.style ? "" : t.style),
                    (t.left.style = void 0 === t.left.style ? "" : t.left.style),
                    (t.right.style = void 0 === t.right.style ? "" : t.right.style),
                    0 === e.find(".tp-leftarrow.tparrows").length && e.append('<div class="tp-leftarrow tparrows ' + t.style + " " + t.left.style + '">' + t.tmp + "</div>"),
                    0 === e.find(".tp-rightarrow.tparrows").length && e.append('<div class="tp-rightarrow tparrows ' + t.style + " " + t.right.style + '">' + t.tmp + "</div>");
                var a = e.find(".tp-leftarrow.tparrows"),
                    n = e.find(".tp-rightarrow.tparrows");
                t.rtl
                    ? (a.click(function () {
                          (i.sc_indicator = "arrow"), (i.sc_indicator_dir = 0), e.revnext();
                      }),
                      n.click(function () {
                          (i.sc_indicator = "arrow"), (i.sc_indicator_dir = 1), e.revprev();
                      }))
                    : (n.click(function () {
                          (i.sc_indicator = "arrow"), (i.sc_indicator_dir = 0), e.revnext();
                      }),
                      a.click(function () {
                          (i.sc_indicator = "arrow"), (i.sc_indicator_dir = 1), e.revprev();
                      })),
                    (t.right.j = e.find(".tp-rightarrow.tparrows")),
                    (t.left.j = e.find(".tp-leftarrow.tparrows")),
                    (t.padding_top = parseInt(i.carousel.padding_top || 0, 0)),
                    (t.padding_bottom = parseInt(i.carousel.padding_bottom || 0, 0)),
                    T(a, t.left, i),
                    T(n, t.right, i),
                    (t.left.opt = i),
                    (t.right.opt = i),
                    ("outer-left" != t.position && "outer-right" != t.position) || (i.outernav = !0);
            },
            h = function (e, t, i) {
                var a = e.outerHeight(!0),
                    n = (e.outerWidth(!0), null == t.opt ? 0 : 0 == i.conh ? i.height : i.conh),
                    r =
                        "layergrid" == t.container
                            ? "fullscreen" == i.sliderLayout
                                ? i.height / 2 - (i.gridheight[i.curWinRange] * i.bh) / 2
                                : "on" == i.autoHeight || (null != i.minHeight && 0 < i.minHeight)
                                ? n / 2 - (i.gridheight[i.curWinRange] * i.bh) / 2
                                : 0
                            : 0,
                    s =
                        "top" === t.v_align
                            ? { top: "0px", y: Math.round(t.v_offset + r) + "px" }
                            : "center" === t.v_align
                            ? { top: "50%", y: Math.round(0 - a / 2 + t.v_offset) + "px" }
                            : { top: "100%", y: Math.round(0 - (a + t.v_offset + r)) + "px" };
                e.hasClass("outer-bottom") || punchgs.TweenLite.set(e, s);
            },
            b = function (e, t, i) {
                var a = (e.outerHeight(!0), e.outerWidth(!0)),
                    n = "layergrid" == t.container ? ("carousel" === i.sliderType ? 0 : i.width / 2 - (i.gridwidth[i.curWinRange] * i.bw) / 2) : 0,
                    r =
                        "left" === t.h_align
                            ? { left: "0px", x: Math.round(t.h_offset + n) + "px" }
                            : "center" === t.h_align
                            ? { left: "50%", x: Math.round(0 - a / 2 + t.h_offset) + "px" }
                            : { left: "100%", x: Math.round(0 - (a + t.h_offset + n)) + "px" };
                punchgs.TweenLite.set(e, r);
            },
            T = function (e, t, i) {
                var a =
                        0 < e.closest(".tp-simpleresponsive").length
                            ? e.closest(".tp-simpleresponsive")
                            : 0 < e.closest(".tp-revslider-mainul").length
                            ? e.closest(".tp-revslider-mainul")
                            : 0 < e.closest(".rev_slider_wrapper").length
                            ? e.closest(".rev_slider_wrapper")
                            : e.parent().find(".tp-revslider-mainul"),
                    n = a.width(),
                    r = a.height();
                if (
                    (h(e, t, i),
                    b(e, t, i),
                    "outer-left" !== t.position || ("fullwidth" != t.sliderLayout && "fullscreen" != t.sliderLayout)
                        ? "outer-right" !== t.position || ("fullwidth" != t.sliderLayout && "fullscreen" != t.sliderLayout) || punchgs.TweenLite.set(e, { right: 0 - e.outerWidth() + "px", x: t.h_offset + "px" })
                        : punchgs.TweenLite.set(e, { left: 0 - e.outerWidth() + "px", x: t.h_offset + "px" }),
                    e.hasClass("tp-thumbs") || e.hasClass("tp-tabs"))
                ) {
                    var s = e.data("wr_padding"),
                        o = e.data("maxw"),
                        l = e.data("maxh"),
                        d = e.hasClass("tp-thumbs") ? e.find(".tp-thumb-mask") : e.find(".tp-tab-mask"),
                        c = parseInt(t.padding_top || 0, 0),
                        u = parseInt(t.padding_bottom || 0, 0);
                    n < o && "outer-left" !== t.position && "outer-right" !== t.position
                        ? (punchgs.TweenLite.set(e, { left: "0px", x: 0, maxWidth: n - 2 * s + "px" }), punchgs.TweenLite.set(d, { maxWidth: n - 2 * s + "px" }))
                        : (punchgs.TweenLite.set(e, { maxWidth: o + "px" }), punchgs.TweenLite.set(d, { maxWidth: o + "px" })),
                        r < l + 2 * s && "outer-bottom" !== t.position && "outer-top" !== t.position
                            ? (punchgs.TweenLite.set(e, { top: "0px", y: 0, maxHeight: c + u + (r - 2 * s) + "px" }), punchgs.TweenLite.set(d, { maxHeight: c + u + (r - 2 * s) + "px" }))
                            : (punchgs.TweenLite.set(e, { maxHeight: l + "px" }), punchgs.TweenLite.set(d, { maxHeight: l + "px" })),
                        "outer-left" !== t.position && "outer-right" !== t.position && (u = c = 0),
                        !0 === t.span && "vertical" === t.direction
                            ? (punchgs.TweenLite.set(e, { maxHeight: c + u + (r - 2 * s) + "px", height: c + u + (r - 2 * s) + "px", top: 0 - c, y: 0 }), h(d, t, i))
                            : !0 === t.span && "horizontal" === t.direction && (punchgs.TweenLite.set(e, { maxWidth: "100%", width: n - 2 * s + "px", left: 0, x: 0 }), b(d, t, i));
                }
            },
            x = function (e, t, i, a) {
                0 === e.find(".tp-bullets").length && ((t.style = void 0 === t.style ? "" : t.style), e.append('<div class="tp-bullets ' + t.style + " " + t.direction + '"></div>'));
                var n = e.find(".tp-bullets"),
                    r = i.data("index"),
                    s = t.tmp;
                jQuery.each(a.thumbs[i.index()].params, function (e, t) {
                    s = s.replace(t.from, t.to);
                }),
                    n.append('<div class="justaddedbullet tp-bullet">' + s + "</div>");
                var o = e.find(".justaddedbullet"),
                    l = e.find(".tp-bullet").length,
                    d = o.outerWidth() + parseInt(void 0 === t.space ? 0 : t.space, 0),
                    c = o.outerHeight() + parseInt(void 0 === t.space ? 0 : t.space, 0);
                "vertical" === t.direction
                    ? (o.css({ top: (l - 1) * c + "px", left: "0px" }), n.css({ height: (l - 1) * c + o.outerHeight(), width: o.outerWidth() }))
                    : (o.css({ left: (l - 1) * d + "px", top: "0px" }), n.css({ width: (l - 1) * d + o.outerWidth(), height: o.outerHeight() })),
                    o.find(".tp-bullet-image").css({ backgroundImage: "url(" + a.thumbs[i.index()].src + ")" }),
                    o.data("liref", r),
                    o.click(function () {
                        (a.sc_indicator = "bullet"), e.revcallslidewithid(r), e.find(".tp-bullet").removeClass("selected"), jQuery(this).addClass("selected");
                    }),
                    o.removeClass("justaddedbullet"),
                    (t.padding_top = parseInt(a.carousel.padding_top || 0, 0)),
                    (t.padding_bottom = parseInt(a.carousel.padding_bottom || 0, 0)),
                    (t.opt = a),
                    ("outer-left" != t.position && "outer-right" != t.position) || (a.outernav = !0),
                    n.addClass("nav-pos-hor-" + t.h_align),
                    n.addClass("nav-pos-ver-" + t.v_align),
                    n.addClass("nav-dir-" + t.direction),
                    T(n, t, a);
            },
            C = function (t, e, i, a, n) {
                var r = "tp-thumb" === a ? ".tp-thumbs" : ".tp-tabs",
                    s = "tp-thumb" === a ? ".tp-thumb-mask" : ".tp-tab-mask",
                    o = "tp-thumb" === a ? ".tp-thumbs-inner-wrapper" : ".tp-tabs-inner-wrapper",
                    l = "tp-thumb" === a ? ".tp-thumb" : ".tp-tab",
                    d = "tp-thumb" === a ? ".tp-thumb-image" : ".tp-tab-image";
                if (((e.visibleAmount = e.visibleAmount > n.slideamount ? n.slideamount : e.visibleAmount), (e.sliderLayout = n.sliderLayout), 0 === t.parent().find(r).length)) {
                    e.style = void 0 === e.style ? "" : e.style;
                    var c =
                        '<div class="' +
                        a +
                        "s " +
                        (!0 === e.span ? "tp-span-wrapper" : "") +
                        " " +
                        e.position +
                        " " +
                        e.style +
                        '"><div class="' +
                        a +
                        '-mask"><div class="' +
                        a +
                        's-inner-wrapper" style="position:relative;"></div></div></div>';
                    "outer-top" === e.position ? t.parent().prepend(c) : "outer-bottom" === e.position ? t.after(c) : t.append(c),
                        (e.padding_top = parseInt(n.carousel.padding_top || 0, 0)),
                        (e.padding_bottom = parseInt(n.carousel.padding_bottom || 0, 0)),
                        ("outer-left" != e.position && "outer-right" != e.position) || (n.outernav = !0);
                }
                var u = i.data("index"),
                    h = t.parent().find(r),
                    p = h.find(s),
                    f = p.find(o),
                    g = "horizontal" === e.direction ? e.width * e.visibleAmount + e.space * (e.visibleAmount - 1) : e.width,
                    m = "horizontal" === e.direction ? e.height : e.height * e.visibleAmount + e.space * (e.visibleAmount - 1),
                    v = e.tmp;
                jQuery.each(n.thumbs[i.index()].params, function (e, t) {
                    v = v.replace(t.from, t.to);
                }),
                    f.append('<div data-liindex="' + i.index() + '" data-liref="' + u + '" class="justaddedthumb ' + a + '" style="width:' + e.width + "px;height:" + e.height + 'px;">' + v + "</div>");
                var y = h.find(".justaddedthumb"),
                    w = h.find(l).length,
                    _ = y.outerWidth() + parseInt(void 0 === e.space ? 0 : e.space, 0),
                    b = y.outerHeight() + parseInt(void 0 === e.space ? 0 : e.space, 0);
                y.find(d).css({ backgroundImage: "url(" + n.thumbs[i.index()].src + ")" }),
                    "vertical" === e.direction
                        ? (y.css({ top: (w - 1) * b + "px", left: "0px" }), f.css({ height: (w - 1) * b + y.outerHeight(), width: y.outerWidth() }))
                        : (y.css({ left: (w - 1) * _ + "px", top: "0px" }), f.css({ width: (w - 1) * _ + y.outerWidth(), height: y.outerHeight() })),
                    h.data("maxw", g),
                    h.data("maxh", m),
                    h.data("wr_padding", e.wrapper_padding);
                var x = "outer-top" === e.position || "outer-bottom" === e.position ? "relative" : "absolute";
                ("outer-top" !== e.position && "outer-bottom" !== e.position) || e.h_align,
                    p.css({ maxWidth: g + "px", maxHeight: m + "px", overflow: "hidden", position: "relative" }),
                    h.css({ maxWidth: g + "px", maxHeight: m + "px", overflow: "visible", position: x, background: e.wrapper_color, padding: e.wrapper_padding + "px", boxSizing: "contet-box" }),
                    y.click(function () {
                        n.sc_indicator = "bullet";
                        var e = t.parent().find(o).data("distance");
                        (e = void 0 === e ? 0 : e), Math.abs(e) < 10 && (t.revcallslidewithid(u), t.parent().find(r).removeClass("selected"), jQuery(this).addClass("selected"));
                    }),
                    y.removeClass("justaddedthumb"),
                    (e.opt = n),
                    h.addClass("nav-pos-hor-" + e.h_align),
                    h.addClass("nav-pos-ver-" + e.v_align),
                    h.addClass("nav-dir-" + e.direction),
                    T(h, e, n);
            },
            d = function (e) {
                var t = e.c.parent().find(".outer-top"),
                    i = e.c.parent().find(".outer-bottom");
                (e.top_outer = t.hasClass("tp-forcenotvisible") ? 0 : t.outerHeight() || 0), (e.bottom_outer = i.hasClass("tp-forcenotvisible") ? 0 : i.outerHeight() || 0);
            },
            s = function (e, t, i, a) {
                i < t || a < i ? e.addClass("tp-forcenotvisible") : e.removeClass("tp-forcenotvisible");
            };
    })(jQuery),
    (function (e) {
        "use strict";
        function b(e, t) {
            e.lastscrolltop = t;
        }
        var x = jQuery.fn.revolution,
            T = x.is_mobile(),
            a = { alias: "Parallax Min JS", name: "revolution.extensions.parallax.min.js", min_core: "5.4.5", version: "2.2.3" };
        jQuery.extend(!0, x, {
            checkForParallax: function (v, y) {
                function e(e) {
                    if ("3D" == w.type || "3d" == w.type) {
                        e.find(".slotholder").wrapAll('<div class="dddwrapper" style="width:100%;height:100%;position:absolute;top:0px;left:0px;overflow:hidden"></div>'),
                            e.find(".tp-parallax-wrap").wrapAll('<div class="dddwrapper-layer" style="width:100%;height:100%;position:absolute;top:0px;left:0px;z-index:5;overflow:' + w.ddd_layer_overflow + ';"></div>'),
                            e.find(".rs-parallaxlevel-tobggroup").closest(".tp-parallax-wrap").wrapAll('<div class="dddwrapper-layertobggroup" style="position:absolute;top:0px;left:0px;z-index:50;width:100%;height:100%"></div>');
                        var t = e.find(".dddwrapper"),
                            i = e.find(".dddwrapper-layer");
                        e.find(".dddwrapper-layertobggroup").appendTo(t),
                            "carousel" == y.sliderType && ("on" == w.ddd_shadow && t.addClass("dddwrappershadow"), punchgs.TweenLite.set(t, { borderRadius: y.carousel.border_radius })),
                            punchgs.TweenLite.set(e, { overflow: "visible", transformStyle: "preserve-3d", perspective: 1600 }),
                            punchgs.TweenLite.set(t, { force3D: "auto", transformOrigin: "50% 50%" }),
                            punchgs.TweenLite.set(i, { force3D: "auto", transformOrigin: "50% 50%", zIndex: 5 }),
                            punchgs.TweenLite.set(y.ul, { transformStyle: "preserve-3d", transformPerspective: 1600 });
                    }
                }
                if ("stop" === x.compare_version(a).check) return !1;
                var w = y.parallax;
                if (!w.done) {
                    if (((w.done = !0), T && "on" == w.disable_onmobile)) return !1;
                    ("3D" != w.type && "3d" != w.type) ||
                        (punchgs.TweenLite.set(y.c, { overflow: w.ddd_overflow }),
                        punchgs.TweenLite.set(y.ul, { overflow: w.ddd_overflow }),
                        "carousel" != y.sliderType &&
                            "on" == w.ddd_shadow &&
                            (y.c.prepend('<div class="dddwrappershadow"></div>'),
                            punchgs.TweenLite.set(y.c.find(".dddwrappershadow"), {
                                force3D: "auto",
                                transformPerspective: 1600,
                                transformOrigin: "50% 50%",
                                width: "100%",
                                height: "100%",
                                position: "absolute",
                                top: 0,
                                left: 0,
                                zIndex: 0,
                            }))),
                        y.li.each(function () {
                            e(jQuery(this));
                        }),
                        ("3D" == w.type || "3d" == w.type) &&
                            0 < y.c.find(".tp-static-layers").length &&
                            (punchgs.TweenLite.set(y.c.find(".tp-static-layers"), { top: 0, left: 0, width: "100%", height: "100%" }), e(y.c.find(".tp-static-layers"))),
                        (w.pcontainers = new Array()),
                        (w.pcontainer_depths = new Array()),
                        (w.bgcontainers = new Array()),
                        (w.bgcontainer_depths = new Array()),
                        y.c.find(".tp-revslider-slidesli .slotholder, .tp-revslider-slidesli .rs-background-video-layer").each(function () {
                            var e = jQuery(this),
                                t = e.data("bgparallax") || y.parallax.bgparallax;
                            void 0 !== (t = "on" == t ? 1 : t) && "off" !== t && (w.bgcontainers.push(e), w.bgcontainer_depths.push(y.parallax.levels[parseInt(t, 0) - 1] / 100));
                        });
                    for (var t = 1; t <= w.levels.length; t++)
                        y.c.find(".rs-parallaxlevel-" + t).each(function () {
                            var e = jQuery(this).closest(".tp-parallax-wrap");
                            e.data("parallaxlevel", w.levels[t - 1]), e.addClass("tp-parallax-container"), w.pcontainers.push(e), w.pcontainer_depths.push(w.levels[t - 1]);
                        });
                    ("mouse" != w.type && "scroll+mouse" != w.type && "mouse+scroll" != w.type && "3D" != w.type && "3d" != w.type) ||
                        (v.mouseenter(function (e) {
                            var t = v.find(".active-revslide"),
                                i = v.offset().top,
                                a = v.offset().left,
                                n = e.pageX - a,
                                r = e.pageY - i;
                            t.data("enterx", n), t.data("entery", r);
                        }),
                        v.on("mousemove.hoverdir, mouseleave.hoverdir, trigger3dpath", function (d, e) {
                            var t = e && e.li ? e.li : v.find(".active-revslide");
                            if ("enterpoint" == w.origo) {
                                var i = v.offset().top,
                                    a = v.offset().left;
                                null == t.data("enterx") && t.data("enterx", d.pageX - a), null == t.data("entery") && t.data("entery", d.pageY - i);
                                var n = t.data("enterx") || d.pageX - a,
                                    r = t.data("entery") || d.pageY - i,
                                    c = n - (d.pageX - a),
                                    u = r - (d.pageY - i),
                                    h = w.speed / 1e3 || 0.4;
                            } else (i = v.offset().top), (a = v.offset().left), (c = y.conw / 2 - (d.pageX - a)), (u = y.conh / 2 - (d.pageY - i)), (h = w.speed / 1e3 || 3);
                            "mouseleave" == d.type && ((c = w.ddd_lasth || 0), (u = w.ddd_lastv || 0), (h = 1.5));
                            for (var s = 0; s < w.pcontainers.length; s++) {
                                var o = w.pcontainers[s],
                                    l = w.pcontainer_depths[s],
                                    p = "3D" == w.type || "3d" == w.type ? l / 200 : l / 100,
                                    f = c * p,
                                    g = u * p;
                                "scroll+mouse" == w.type || "mouse+scroll" == w.type
                                    ? punchgs.TweenLite.to(o, h, { force3D: "auto", x: f, ease: punchgs.Power3.easeOut, overwrite: "all" })
                                    : punchgs.TweenLite.to(o, h, { force3D: "auto", x: f, y: g, ease: punchgs.Power3.easeOut, overwrite: "all" });
                            }
                            if ("3D" == w.type || "3d" == w.type) {
                                var m = ".tp-revslider-slidesli .dddwrapper, .dddwrappershadow, .tp-revslider-slidesli .dddwrapper-layer, .tp-static-layers .dddwrapper-layer";
                                "carousel" === y.sliderType && (m = ".tp-revslider-slidesli .dddwrapper, .tp-revslider-slidesli .dddwrapper-layer, .tp-static-layers .dddwrapper-layer"),
                                    y.c.find(m).each(function () {
                                        var e = jQuery(this),
                                            t = w.levels[w.levels.length - 1] / 200,
                                            i = c * t,
                                            a = u * t,
                                            n = 0 == y.conw ? 0 : Math.round((c / y.conw) * t * 100) || 0,
                                            r = 0 == y.conh ? 0 : Math.round((u / y.conh) * t * 100) || 0,
                                            s = e.closest("li"),
                                            o = 0,
                                            l = !1;
                                        e.hasClass("dddwrapper-layer") && ((o = w.ddd_z_correction || 65), (l = !0)),
                                            e.hasClass("dddwrapper-layer") && (a = i = 0),
                                            s.hasClass("active-revslide") || "carousel" != y.sliderType
                                                ? "on" != w.ddd_bgfreeze || l
                                                    ? punchgs.TweenLite.to(e, h, { rotationX: r, rotationY: -n, x: i, z: o, y: a, ease: punchgs.Power3.easeOut, overwrite: "all" })
                                                    : punchgs.TweenLite.to(e, 0.5, { force3D: "auto", rotationY: 0, rotationX: 0, z: 0, ease: punchgs.Power3.easeOut, overwrite: "all" })
                                                : punchgs.TweenLite.to(e, 0.5, { force3D: "auto", rotationY: 0, x: 0, y: 0, rotationX: 0, z: 0, ease: punchgs.Power3.easeOut, overwrite: "all" }),
                                            "mouseleave" == d.type && punchgs.TweenLite.to(jQuery(this), 3.8, { z: 0, ease: punchgs.Power3.easeOut });
                                    });
                            }
                        }),
                        T &&
                            (window.ondeviceorientation = function (d) {
                                var e = Math.round(d.beta || 0) - 70,
                                    t = Math.round(d.gamma || 0),
                                    i = v.find(".active-revslide");
                                if (jQuery(window).width() > jQuery(window).height()) {
                                    var a = t;
                                    (t = e), (e = a);
                                }
                                var n = v.width(),
                                    r = v.height(),
                                    c = (360 / n) * t,
                                    u = (180 / r) * e,
                                    h = w.speed / 1e3 || 3,
                                    s = [];
                                if (
                                    (i.find(".tp-parallax-container").each(function (e) {
                                        s.push(jQuery(this));
                                    }),
                                    v.find(".tp-static-layers .tp-parallax-container").each(function () {
                                        s.push(jQuery(this));
                                    }),
                                    jQuery.each(s, function () {
                                        var e = jQuery(this),
                                            t = parseInt(e.data("parallaxlevel"), 0) / 100,
                                            i = c * t * 2,
                                            a = u * t * 4;
                                        punchgs.TweenLite.to(e, h, { force3D: "auto", x: i, y: a, ease: punchgs.Power3.easeOut, overwrite: "all" });
                                    }),
                                    "3D" == w.type || "3d" == w.type)
                                ) {
                                    var o = ".tp-revslider-slidesli .dddwrapper, .dddwrappershadow, .tp-revslider-slidesli .dddwrapper-layer, .tp-static-layers .dddwrapper-layer";
                                    "carousel" === y.sliderType && (o = ".tp-revslider-slidesli .dddwrapper, .tp-revslider-slidesli .dddwrapper-layer, .tp-static-layers .dddwrapper-layer"),
                                        y.c.find(o).each(function () {
                                            var e = jQuery(this),
                                                t = w.levels[w.levels.length - 1] / 200,
                                                i = c * t,
                                                a = u * t * 3,
                                                n = 0 == y.conw ? 0 : Math.round((c / y.conw) * t * 500) || 0,
                                                r = 0 == y.conh ? 0 : Math.round((u / y.conh) * t * 700) || 0,
                                                s = e.closest("li"),
                                                o = 0,
                                                l = !1;
                                            e.hasClass("dddwrapper-layer") && ((o = w.ddd_z_correction || 65), (l = !0)),
                                                e.hasClass("dddwrapper-layer") && (a = i = 0),
                                                s.hasClass("active-revslide") || "carousel" != y.sliderType
                                                    ? "on" != w.ddd_bgfreeze || l
                                                        ? punchgs.TweenLite.to(e, h, { rotationX: r, rotationY: -n, x: i, z: o, y: a, ease: punchgs.Power3.easeOut, overwrite: "all" })
                                                        : punchgs.TweenLite.to(e, 0.5, { force3D: "auto", rotationY: 0, rotationX: 0, z: 0, ease: punchgs.Power3.easeOut, overwrite: "all" })
                                                    : punchgs.TweenLite.to(e, 0.5, { force3D: "auto", rotationY: 0, z: 0, x: 0, y: 0, rotationX: 0, ease: punchgs.Power3.easeOut, overwrite: "all" }),
                                                "mouseleave" == d.type && punchgs.TweenLite.to(jQuery(this), 3.8, { z: 0, ease: punchgs.Power3.easeOut });
                                        });
                                }
                            }));
                    var i = y.scrolleffect;
                    if (((i.bgs = new Array()), i.on)) {
                        if ("on" === i.on_slidebg) for (t = 0; t < y.allslotholder.length; t++) i.bgs.push(y.allslotholder[t]);
                        (i.multiplicator_layers = parseFloat(i.multiplicator_layers)), (i.multiplicator = parseFloat(i.multiplicator));
                    }
                    void 0 !== i.layers && 0 === i.layers.length && (i.layers = !1), void 0 !== i.bgs && 0 === i.bgs.length && (i.bgs = !1), x.scrollTicker(y, v);
                }
            },
            scrollTicker: function (t, e) {
                1 != t.scrollTicker &&
                    ((t.scrollTicker = !0),
                    T
                        ? (punchgs.TweenLite.ticker.fps(150),
                          punchgs.TweenLite.ticker.addEventListener(
                              "tick",
                              function () {
                                  x.scrollHandling(t);
                              },
                              e,
                              !1,
                              1
                          ))
                        : document.addEventListener(
                              "scroll",
                              function (e) {
                                  x.scrollHandling(t, !0);
                              },
                              { passive: !0 }
                          )),
                    x.scrollHandling(t, !0);
            },
            scrollHandling: function (e, t, i) {
                if (
                    ((e.lastwindowheight = e.lastwindowheight || window.innerHeight),
                    (e.conh = 0 === e.conh || void 0 === e.conh ? (e.infullscreenmode ? e.minHeight : e.c.height()) : e.conh),
                    e.lastscrolltop == window.scrollY && !e.duringslidechange && !t)
                )
                    return !1;
                punchgs.TweenLite.delayedCall(0.2, b, [e, window.scrollY]);
                var a = e.c[0].getBoundingClientRect(),
                    n = e.viewPort,
                    r = e.parallax,
                    s = a.top < 0 || a.height > e.lastwindowheight ? a.top / a.height : a.bottom > e.lastwindowheight ? (a.bottom - e.lastwindowheight) / a.height : 0;
                if (((e.scrollproc = s), x.callBackHandling && x.callBackHandling(e, "parallax", "start"), n.enable)) {
                    var o = 1 - Math.abs(s);
                    (o = o < 0 ? 0 : o),
                        jQuery.isNumeric(n.visible_area) || (-1 !== n.visible_area.indexOf("%") && (n.visible_area = parseInt(n.visible_area) / 100)),
                        1 - n.visible_area <= o ? e.inviewport || ((e.inviewport = !0), x.enterInViewPort(e)) : e.inviewport && ((e.inviewport = !1), x.leaveViewPort(e));
                }
                if (T && "on" == r.disable_onmobile) return !1;
                if ("3d" != r.type && "3D" != r.type) {
                    if (("scroll" == r.type || "scroll+mouse" == r.type || "mouse+scroll" == r.type) && r.pcontainers)
                        for (var l = 0; l < r.pcontainers.length; l++)
                            if (0 < r.pcontainers[l].length) {
                                var d = r.pcontainers[l],
                                    c = r.pcontainer_depths[l] / 100,
                                    u = Math.round(s * (-c * e.conh) * 10) / 10 || 0,
                                    h = void 0 !== i ? i : r.speedls / 1e3 || 0;
                                d.data("parallaxoffset", u), punchgs.TweenLite.to(d, h, { overwrite: "auto", force3D: "auto", y: u });
                            }
                    if (r.bgcontainers)
                        for (l = 0; l < r.bgcontainers.length; l++) {
                            var p = r.bgcontainers[l];
                            (u = s * (-r.bgcontainer_depths[l] * e.conh) || 0), (h = void 0 !== i ? i : r.speedbg / 1e3 || 0);
                            punchgs.TweenLite.to(p, h, { position: "absolute", top: "0px", left: "0px", backfaceVisibility: "hidden", force3D: "true", y: u + "px" });
                        }
                }
                var f = e.scrolleffect;
                if (f.on && ("on" !== f.disable_on_mobile || !T)) {
                    var g = Math.abs(s) - f.tilt / 100;
                    if (((g = g < 0 ? 0 : g), !1 !== f.layers)) {
                        var m = 1 - g * f.multiplicator_layers,
                            v = { backfaceVisibility: "hidden", force3D: "true", z: 0.001, perspective: 600 };
                        if (("top" == f.direction && 0 <= s && (m = 1), "bottom" == f.direction && s <= 0 && (m = 1), (m = 1 < m ? 1 : m < 0 ? 0 : m), "on" === f.fade && (v.opacity = m), "on" === f.scale)) {
                            var y = m;
                            v.scale = 1 - y + 1;
                        }
                        if ("on" === f.blur) {
                            var w = (1 - m) * f.maxblur;
                            (v["-webkit-filter"] = "blur(" + w + "px)"), (v.filter = "blur(" + w + "px)");
                        }
                        if ("on" === f.grayscale) {
                            var _ = "grayscale(" + 100 * (1 - m) + "%)";
                            (v["-webkit-filter"] = void 0 === v["-webkit-filter"] ? _ : v["-webkit-filter"] + " " + _), (v.filter = void 0 === v.filter ? _ : v.filter + " " + _);
                        }
                        punchgs.TweenLite.set(f.layers, v);
                    }
                    if (!1 !== f.bgs) {
                        (m = 1 - g * f.multiplicator), (v = { backfaceVisibility: "hidden", force3D: "true" });
                        if (("top" == f.direction && 0 <= s && (m = 1), "bottom" == f.direction && s <= 0 && (m = 1), (m = 1 < m ? 1 : m < 0 ? 0 : m), "on" === f.fade && (v.opacity = m), "on" === f.scale)) {
                            y = m;
                            punchgs.TweenLite.set(jQuery(".tp-kbimg-wrap"), { transformOrigin: "50% 50%", scale: y, force3D: !0 });
                        }
                        if ("on" === f.blur) {
                            w = (1 - m) * f.maxblur;
                            (v["-webkit-filter"] = "blur(" + w + "px)"), (v.filter = "blur(" + w + "px)");
                        }
                        if ("on" === f.grayscale) {
                            _ = "grayscale(" + 100 * (1 - m) + "%)";
                            (v["-webkit-filter"] = void 0 === v["-webkit-filter"] ? _ : v["-webkit-filter"] + " " + _), (v.filter = void 0 === v.filter ? _ : v.filter + " " + _);
                        }
                        punchgs.TweenLite.set(f.bgs, v);
                    }
                }
                x.callBackHandling && x.callBackHandling(e, "parallax", "end");
            },
        });
    })(jQuery),
    (function (e) {
        "use strict";
        var T = jQuery.fn.revolution,
            l = { alias: "SlideAnimations Min JS", name: "revolution.extensions.slideanims.min.js", min_core: "5.4.5", version: "1.8" };
        jQuery.extend(!0, T, {
            animateSlide: function (e, t, i, a, n, r, s, o) {
                return "stop" === T.compare_version(l).check ? o : d(e, t, i, a, n, r, s, o);
            },
        });
        var he = function (e, t, i, a) {
                var n = e,
                    r = n.find(".defaultimg"),
                    s = r.data("mediafilter"),
                    o = n.data("zoomstart"),
                    l = n.data("rotationstart");
                null != r.data("currotate") && (l = r.data("currotate")), null != r.data("curscale") && "box" == a ? (o = 100 * r.data("curscale")) : null != r.data("curscale") && (o = r.data("curscale")), T.slotSize(r, t);
                var d = r.attr("src"),
                    c = r.data("bgcolor"),
                    u = t.width,
                    h = t.height,
                    p = r.data("fxof");
                void 0 === c && (c = r.css("backgroundColor")), "on" == t.autoHeight && (h = t.c.height()), null == p && (p = 0);
                var f = 0,
                    g = r.data("bgfit"),
                    m = r.data("bgrepeat"),
                    v = r.data("bgposition");
                null == g && (g = "cover"), null == m && (m = "no-repeat"), null == v && (v = "center center");
                var y;
                switch (
                    ((y = void 0 !== c && 0 <= c.indexOf("gradient") ? "background:" + c : "background-color:" + c + ";background-image:url(" + d + ");background-repeat:" + m + ";background-size:" + g + ";background-position:" + v), a)
                ) {
                    case "box":
                        for (var w = 0, _ = 0, b = 0; b < t.slots; b++) {
                            for (var x = (_ = 0); x < t.slots; x++)
                                n.append(
                                    '<div class="slot" style="position:absolute;top:' +
                                        (0 + _) +
                                        "px;left:" +
                                        (p + w) +
                                        "px;width:" +
                                        t.slotw +
                                        "px;height:" +
                                        t.sloth +
                                        'px;overflow:hidden;"><div class="slotslide ' +
                                        s +
                                        '" data-x="' +
                                        w +
                                        '" data-y="' +
                                        _ +
                                        '" style="position:absolute;top:0px;left:0px;width:' +
                                        t.slotw +
                                        "px;height:" +
                                        t.sloth +
                                        'px;overflow:hidden;"><div style="position:absolute;top:' +
                                        (0 - _) +
                                        "px;left:" +
                                        (0 - w) +
                                        "px;width:" +
                                        u +
                                        "px;height:" +
                                        h +
                                        "px;" +
                                        y +
                                        ';"></div></div></div>'
                                ),
                                    (_ += t.sloth),
                                    null != o && null != l && punchgs.TweenLite.set(n.find(".slot").last(), { rotationZ: l });
                            w += t.slotw;
                        }
                        break;
                    case "vertical":
                    case "horizontal":
                        if ("horizontal" == a)
                            for (i || (f = 0 - t.slotw), x = 0; x < t.slots; x++)
                                n.append(
                                    '<div class="slot" style="position:absolute;top:0px;left:' +
                                        (p + x * t.slotw) +
                                        "px;overflow:hidden;width:" +
                                        (t.slotw + 0.3) +
                                        "px;height:" +
                                        h +
                                        'px"><div class="slotslide ' +
                                        s +
                                        '" style="position:absolute;top:0px;left:' +
                                        f +
                                        "px;width:" +
                                        (t.slotw + 0.6) +
                                        "px;height:" +
                                        h +
                                        'px;overflow:hidden;"><div style="position:absolute;top:0px;left:' +
                                        (0 - x * t.slotw) +
                                        "px;width:" +
                                        u +
                                        "px;height:" +
                                        h +
                                        "px;" +
                                        y +
                                        ';"></div></div></div>'
                                ),
                                    null != o && null != l && punchgs.TweenLite.set(n.find(".slot").last(), { rotationZ: l });
                        else
                            for (i || (f = 0 - t.sloth), x = 0; x < t.slots + 2; x++)
                                n.append(
                                    '<div class="slot" style="position:absolute;top:' +
                                        (0 + x * t.sloth) +
                                        "px;left:" +
                                        p +
                                        "px;overflow:hidden;width:" +
                                        u +
                                        "px;height:" +
                                        t.sloth +
                                        'px"><div class="slotslide ' +
                                        s +
                                        '" style="position:absolute;top:' +
                                        f +
                                        "px;left:0px;width:" +
                                        u +
                                        "px;height:" +
                                        t.sloth +
                                        'px;overflow:hidden;"><div style="position:absolute;top:' +
                                        (0 - x * t.sloth) +
                                        "px;left:0px;width:" +
                                        u +
                                        "px;height:" +
                                        h +
                                        "px;" +
                                        y +
                                        ';"></div></div></div>'
                                ),
                                    null != o && null != l && punchgs.TweenLite.set(n.find(".slot").last(), { rotationZ: l });
                }
            },
            pe = function (e, t) {
                return null == t || jQuery.isNumeric(e) ? e : null == e ? e : e.split(",")[t];
            },
            d = function (a, e, x, t, i, n, r, s) {
                var o = x[0].opt,
                    l = i.index(),
                    d = t.index() < l ? 1 : 0;
                "arrow" == o.sc_indicator && (d = o.sc_indicator_dir);
                var c = (function (e, i, t, a) {
                        var n = x[0].opt,
                            r = punchgs.Power1.easeIn,
                            s = punchgs.Power1.easeOut,
                            o = punchgs.Power1.easeInOut,
                            l = punchgs.Power2.easeIn,
                            d = punchgs.Power2.easeOut,
                            c = punchgs.Power2.easeInOut,
                            u = (punchgs.Power3.easeIn, punchgs.Power3.easeOut),
                            h = punchgs.Power3.easeInOut,
                            p = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45],
                            f = [16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 27],
                            g = 0,
                            m = 1,
                            v = 0,
                            y = 0,
                            w =
                                (new Array(),
                                [
                                    ["boxslide", 0, 1, 10, 0, "box", !1, null, 0, s, s, 500, 6],
                                    ["boxfade", 1, 0, 10, 0, "box", !1, null, 1, o, o, 700, 5],
                                    ["slotslide-horizontal", 2, 0, 0, 200, "horizontal", !0, !1, 2, c, c, 700, 3],
                                    ["slotslide-vertical", 3, 0, 0, 200, "vertical", !0, !1, 3, c, c, 700, 3],
                                    ["curtain-1", 4, 3, 0, 0, "horizontal", !0, !0, 4, s, s, 300, 5],
                                    ["curtain-2", 5, 3, 0, 0, "horizontal", !0, !0, 5, s, s, 300, 5],
                                    ["curtain-3", 6, 3, 25, 0, "horizontal", !0, !0, 6, s, s, 300, 5],
                                    ["slotzoom-horizontal", 7, 0, 0, 400, "horizontal", !0, !0, 7, s, s, 300, 7],
                                    ["slotzoom-vertical", 8, 0, 0, 0, "vertical", !0, !0, 8, d, d, 500, 8],
                                    ["slotfade-horizontal", 9, 0, 0, 1e3, "horizontal", !0, null, 9, d, d, 2e3, 10],
                                    ["slotfade-vertical", 10, 0, 0, 1e3, "vertical", !0, null, 10, d, d, 2e3, 10],
                                    ["fade", 11, 0, 1, 300, "horizontal", !0, null, 11, c, c, 1e3, 1],
                                    ["crossfade", 11, 1, 1, 300, "horizontal", !0, null, 11, c, c, 1e3, 1],
                                    ["fadethroughdark", 11, 2, 1, 300, "horizontal", !0, null, 11, c, c, 1e3, 1],
                                    ["fadethroughlight", 11, 3, 1, 300, "horizontal", !0, null, 11, c, c, 1e3, 1],
                                    ["fadethroughtransparent", 11, 4, 1, 300, "horizontal", !0, null, 11, c, c, 1e3, 1],
                                    ["slideleft", 12, 0, 1, 0, "horizontal", !0, !0, 12, h, h, 1e3, 1],
                                    ["slideup", 13, 0, 1, 0, "horizontal", !0, !0, 13, h, h, 1e3, 1],
                                    ["slidedown", 14, 0, 1, 0, "horizontal", !0, !0, 14, h, h, 1e3, 1],
                                    ["slideright", 15, 0, 1, 0, "horizontal", !0, !0, 15, h, h, 1e3, 1],
                                    ["slideoverleft", 12, 7, 1, 0, "horizontal", !0, !0, 12, h, h, 1e3, 1],
                                    ["slideoverup", 13, 7, 1, 0, "horizontal", !0, !0, 13, h, h, 1e3, 1],
                                    ["slideoverdown", 14, 7, 1, 0, "horizontal", !0, !0, 14, h, h, 1e3, 1],
                                    ["slideoverright", 15, 7, 1, 0, "horizontal", !0, !0, 15, h, h, 1e3, 1],
                                    ["slideremoveleft", 12, 8, 1, 0, "horizontal", !0, !0, 12, h, h, 1e3, 1],
                                    ["slideremoveup", 13, 8, 1, 0, "horizontal", !0, !0, 13, h, h, 1e3, 1],
                                    ["slideremovedown", 14, 8, 1, 0, "horizontal", !0, !0, 14, h, h, 1e3, 1],
                                    ["slideremoveright", 15, 8, 1, 0, "horizontal", !0, !0, 15, h, h, 1e3, 1],
                                    ["papercut", 16, 0, 0, 600, "", null, null, 16, h, h, 1e3, 2],
                                    ["3dcurtain-horizontal", 17, 0, 20, 100, "vertical", !1, !0, 17, o, o, 500, 7],
                                    ["3dcurtain-vertical", 18, 0, 10, 100, "horizontal", !1, !0, 18, o, o, 500, 5],
                                    ["cubic", 19, 0, 20, 600, "horizontal", !1, !0, 19, h, h, 500, 1],
                                    ["cube", 19, 0, 20, 600, "horizontal", !1, !0, 20, h, h, 500, 1],
                                    ["flyin", 20, 0, 4, 600, "vertical", !1, !0, 21, u, h, 500, 1],
                                    ["turnoff", 21, 0, 1, 500, "horizontal", !1, !0, 22, h, h, 500, 1],
                                    ["incube", 22, 0, 20, 200, "horizontal", !1, !0, 23, c, c, 500, 1],
                                    ["cubic-horizontal", 23, 0, 20, 500, "vertical", !1, !0, 24, d, d, 500, 1],
                                    ["cube-horizontal", 23, 0, 20, 500, "vertical", !1, !0, 25, d, d, 500, 1],
                                    ["incube-horizontal", 24, 0, 20, 500, "vertical", !1, !0, 26, c, c, 500, 1],
                                    ["turnoff-vertical", 25, 0, 1, 200, "horizontal", !1, !0, 27, c, c, 500, 1],
                                    ["fadefromright", 12, 1, 1, 0, "horizontal", !0, !0, 28, c, c, 1e3, 1],
                                    ["fadefromleft", 15, 1, 1, 0, "horizontal", !0, !0, 29, c, c, 1e3, 1],
                                    ["fadefromtop", 14, 1, 1, 0, "horizontal", !0, !0, 30, c, c, 1e3, 1],
                                    ["fadefrombottom", 13, 1, 1, 0, "horizontal", !0, !0, 31, c, c, 1e3, 1],
                                    ["fadetoleftfadefromright", 12, 2, 1, 0, "horizontal", !0, !0, 32, c, c, 1e3, 1],
                                    ["fadetorightfadefromleft", 15, 2, 1, 0, "horizontal", !0, !0, 33, c, c, 1e3, 1],
                                    ["fadetobottomfadefromtop", 14, 2, 1, 0, "horizontal", !0, !0, 34, c, c, 1e3, 1],
                                    ["fadetotopfadefrombottom", 13, 2, 1, 0, "horizontal", !0, !0, 35, c, c, 1e3, 1],
                                    ["parallaxtoright", 15, 3, 1, 0, "horizontal", !0, !0, 36, c, l, 1500, 1],
                                    ["parallaxtoleft", 12, 3, 1, 0, "horizontal", !0, !0, 37, c, l, 1500, 1],
                                    ["parallaxtotop", 14, 3, 1, 0, "horizontal", !0, !0, 38, c, r, 1500, 1],
                                    ["parallaxtobottom", 13, 3, 1, 0, "horizontal", !0, !0, 39, c, r, 1500, 1],
                                    ["scaledownfromright", 12, 4, 1, 0, "horizontal", !0, !0, 40, c, l, 1e3, 1],
                                    ["scaledownfromleft", 15, 4, 1, 0, "horizontal", !0, !0, 41, c, l, 1e3, 1],
                                    ["scaledownfromtop", 14, 4, 1, 0, "horizontal", !0, !0, 42, c, l, 1e3, 1],
                                    ["scaledownfrombottom", 13, 4, 1, 0, "horizontal", !0, !0, 43, c, l, 1e3, 1],
                                    ["zoomout", 13, 5, 1, 0, "horizontal", !0, !0, 44, c, l, 1e3, 1],
                                    ["zoomin", 13, 6, 1, 0, "horizontal", !0, !0, 45, c, l, 1e3, 1],
                                    ["slidingoverlayup", 27, 0, 1, 0, "horizontal", !0, !0, 47, o, s, 2e3, 1],
                                    ["slidingoverlaydown", 28, 0, 1, 0, "horizontal", !0, !0, 48, o, s, 2e3, 1],
                                    ["slidingoverlayright", 30, 0, 1, 0, "horizontal", !0, !0, 49, o, s, 2e3, 1],
                                    ["slidingoverlayleft", 29, 0, 1, 0, "horizontal", !0, !0, 50, o, s, 2e3, 1],
                                    ["parallaxcirclesup", 31, 0, 1, 0, "horizontal", !0, !0, 51, c, r, 1500, 1],
                                    ["parallaxcirclesdown", 32, 0, 1, 0, "horizontal", !0, !0, 52, c, r, 1500, 1],
                                    ["parallaxcirclesright", 33, 0, 1, 0, "horizontal", !0, !0, 53, c, r, 1500, 1],
                                    ["parallaxcirclesleft", 34, 0, 1, 0, "horizontal", !0, !0, 54, c, r, 1500, 1],
                                    ["notransition", 26, 0, 1, 0, "horizontal", !0, null, 46, c, l, 1e3, 1],
                                    ["parallaxright", 15, 3, 1, 0, "horizontal", !0, !0, 55, c, l, 1500, 1],
                                    ["parallaxleft", 12, 3, 1, 0, "horizontal", !0, !0, 56, c, l, 1500, 1],
                                    ["parallaxup", 14, 3, 1, 0, "horizontal", !0, !0, 57, c, r, 1500, 1],
                                    ["parallaxdown", 13, 3, 1, 0, "horizontal", !0, !0, 58, c, r, 1500, 1],
                                    ["grayscale", 11, 5, 1, 300, "horizontal", !0, null, 11, c, c, 1e3, 1],
                                    ["grayscalecross", 11, 6, 1, 300, "horizontal", !0, null, 11, c, c, 1e3, 1],
                                    ["brightness", 11, 7, 1, 300, "horizontal", !0, null, 11, c, c, 1e3, 1],
                                    ["brightnesscross", 11, 8, 1, 300, "horizontal", !0, null, 11, c, c, 1e3, 1],
                                    ["blurlight", 11, 9, 1, 300, "horizontal", !0, null, 11, c, c, 1e3, 1],
                                    ["blurlightcross", 11, 10, 1, 300, "horizontal", !0, null, 11, c, c, 1e3, 1],
                                    ["blurstrong", 11, 9, 1, 300, "horizontal", !0, null, 11, c, c, 1e3, 1],
                                    ["blurstrongcross", 11, 10, 1, 300, "horizontal", !0, null, 11, c, c, 1e3, 1],
                                ]);
                        if (
                            ((n.duringslidechange = !0),
                            (n.testanims = !1),
                            1 == n.testanims &&
                                ((n.nexttesttransform = void 0 === n.nexttesttransform ? 34 : n.nexttesttransform + 1),
                                (n.nexttesttransform = 70 < n.nexttesttransform ? 0 : n.nexttesttransform),
                                (i = w[n.nexttesttransform][0]),
                                console.log(i + "  " + n.nexttesttransform + "  " + w[n.nexttesttransform][1] + "  " + w[n.nexttesttransform][2])),
                            jQuery.each(["parallaxcircles", "slidingoverlay", "slide", "slideover", "slideremove", "parallax", "parralaxto"], function (e, t) {
                                i == t + "horizontal" && (i = 1 != a ? t + "left" : t + "right"), i == t + "vertical" && (i = 1 != a ? t + "up" : t + "down");
                            }),
                            "random" == i && ((i = Math.round(Math.random() * w.length - 1)), w.length - 1 < i && (i = w.length - 1)),
                            "random-static" == i && ((i = Math.round(Math.random() * p.length - 1)), p.length - 1 < i && (i = p.length - 1), (i = p[i])),
                            "random-premium" == i && ((i = Math.round(Math.random() * f.length - 1)), f.length - 1 < i && (i = f.length - 1), (i = f[i])),
                            1 == n.isJoomla && null != window.MooTools && -1 != [12, 13, 14, 15, 16, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45].indexOf(i))
                        ) {
                            var _ = Math.round(Math.random() * (f.length - 2)) + 1;
                            f.length - 1 < _ && (_ = f.length - 1), 0 == _ && (_ = 1), (i = f[_]);
                        }
                        jQuery.each(w, function (e, t) {
                            (t[0] != i && t[8] != i) || ((g = t[1]), (m = t[2]), (v = y)), (y += 1);
                        }),
                            30 < g && (g = 30),
                            g < 0 && (g = 0);
                        var b = new Object();
                        return (b.nexttrans = g), (b.STA = w[v]), (b.specials = m), b;
                    })(0, e, 0, d),
                    u = c.STA,
                    h = c.specials;
                (a = c.nexttrans), "on" == n.data("kenburns") && (a = 11);
                var p = t.data("nexttransid") || 0,
                    f = pe(t.data("masterspeed"), p);
                (f = (f = "default" === f ? u[11] : "random" === f ? Math.round(1e3 * Math.random() + 300) : null != f ? parseInt(f, 0) : u[11]) > o.delay ? o.delay : f),
                    (f += u[4]),
                    (o.slots = pe(t.data("slotamount"), p)),
                    (o.slots = null == o.slots || "default" == o.slots ? u[12] : "random" == o.slots ? Math.round(12 * Math.random() + 4) : o.slots),
                    (o.slots = o.slots < 1 ? ("boxslide" == e ? Math.round(6 * Math.random() + 3) : "flyin" == e ? Math.round(4 * Math.random() + 1) : o.slots) : o.slots),
                    (o.slots = (4 == a || 5 == a || 6 == a) && o.slots < 3 ? 3 : o.slots),
                    (o.slots = 0 != u[3] ? Math.min(o.slots, u[3]) : o.slots),
                    (o.slots = 9 == a ? o.width / o.slots : 10 == a ? o.height / o.slots : o.slots),
                    (o.rotate = pe(t.data("rotate"), p)),
                    (o.rotate = null == o.rotate || "default" == o.rotate ? 0 : 999 == o.rotate || "random" == o.rotate ? Math.round(360 * Math.random()) : o.rotate),
                    (o.rotate = o.ie || o.ie9 ? 0 : o.rotate),
                    11 != a && (null != u[7] && he(r, o, u[7], u[5]), null != u[6] && he(n, o, u[6], u[5])),
                    s.add(punchgs.TweenLite.set(n.find(".defaultvid"), { y: 0, x: 0, top: 0, left: 0, scale: 1 }), 0),
                    s.add(punchgs.TweenLite.set(r.find(".defaultvid"), { y: 0, x: 0, top: 0, left: 0, scale: 1 }), 0),
                    s.add(punchgs.TweenLite.set(n.find(".defaultvid"), { y: "+0%", x: "+0%" }), 0),
                    s.add(punchgs.TweenLite.set(r.find(".defaultvid"), { y: "+0%", x: "+0%" }), 0),
                    s.add(punchgs.TweenLite.set(n, { autoAlpha: 1, y: "+0%", x: "+0%" }), 0),
                    s.add(punchgs.TweenLite.set(r, { autoAlpha: 1, y: "+0%", x: "+0%" }), 0),
                    s.add(punchgs.TweenLite.set(n.parent(), { backgroundColor: "transparent" }), 0),
                    s.add(punchgs.TweenLite.set(r.parent(), { backgroundColor: "transparent" }), 0);
                var g,
                    m = pe(t.data("easein"), p),
                    v = pe(t.data("easeout"), p);
                if (((m = "default" === m ? u[9] || punchgs.Power2.easeInOut : m || u[9] || punchgs.Power2.easeInOut), (v = "default" === v ? u[10] || punchgs.Power2.easeInOut : v || u[10] || punchgs.Power2.easeInOut), 0 == a)) {
                    var y = Math.ceil(o.height / o.sloth),
                        w = 0;
                    n.find(".slotslide").each(function (e) {
                        var t = jQuery(this);
                        (w += 1) == y && (w = 0), s.add(punchgs.TweenLite.from(t, f / 600, { opacity: 0, top: 0 - o.sloth, left: 0 - o.slotw, rotation: o.rotate, force3D: "auto", ease: m }), (15 * e + 30 * w) / 1500);
                    });
                }
                1 == a &&
                    n.find(".slotslide").each(function (e) {
                        var t = jQuery(this),
                            i = Math.random() * f + 300,
                            a = 500 * Math.random() + 200;
                        g < i + a && (g = a + a), s.add(punchgs.TweenLite.from(t, i / 1e3, { autoAlpha: 0, force3D: "auto", rotation: o.rotate, ease: m }), a / 1e3);
                    });
                if (2 == a) {
                    var _ = new punchgs.TimelineLite();
                    r.find(".slotslide").each(function () {
                        var e = jQuery(this);
                        _.add(punchgs.TweenLite.to(e, f / 1e3, { left: o.slotw, ease: m, force3D: "auto", rotation: 0 - o.rotate }), 0), s.add(_, 0);
                    }),
                        n.find(".slotslide").each(function () {
                            var e = jQuery(this);
                            _.add(punchgs.TweenLite.from(e, f / 1e3, { left: 0 - o.slotw, ease: m, force3D: "auto", rotation: o.rotate }), 0), s.add(_, 0);
                        });
                }
                if (
                    (3 == a &&
                        ((_ = new punchgs.TimelineLite()),
                        r.find(".slotslide").each(function () {
                            var e = jQuery(this);
                            _.add(punchgs.TweenLite.to(e, f / 1e3, { top: o.sloth, ease: m, rotation: o.rotate, force3D: "auto", transformPerspective: 600 }), 0), s.add(_, 0);
                        }),
                        n.find(".slotslide").each(function () {
                            var e = jQuery(this);
                            _.add(punchgs.TweenLite.from(e, f / 1e3, { top: 0 - o.sloth, rotation: o.rotate, ease: v, force3D: "auto", transformPerspective: 600 }), 0), s.add(_, 0);
                        })),
                    4 == a || 5 == a)
                ) {
                    setTimeout(function () {
                        r.find(".defaultimg").css({ opacity: 0 });
                    }, 100);
                    var b = f / 1e3;
                    (_ = new punchgs.TimelineLite()),
                        r.find(".slotslide").each(function (e) {
                            var t = jQuery(this),
                                i = (e * b) / o.slots;
                            5 == a && (i = ((o.slots - e - 1) * b) / o.slots / 1.5),
                                _.add(punchgs.TweenLite.to(t, 3 * b, { transformPerspective: 600, force3D: "auto", top: 0 + o.height, opacity: 0.5, rotation: o.rotate, ease: m, delay: i }), 0),
                                s.add(_, 0);
                        }),
                        n.find(".slotslide").each(function (e) {
                            var t = jQuery(this),
                                i = (e * b) / o.slots;
                            5 == a && (i = ((o.slots - e - 1) * b) / o.slots / 1.5),
                                _.add(punchgs.TweenLite.from(t, 3 * b, { top: 0 - o.height, opacity: 0.5, rotation: o.rotate, force3D: "auto", ease: punchgs.eo, delay: i }), 0),
                                s.add(_, 0);
                        });
                }
                if (
                    (6 == a &&
                        (o.slots < 2 && (o.slots = 2),
                        o.slots % 2 && (o.slots = o.slots + 1),
                        (_ = new punchgs.TimelineLite()),
                        setTimeout(function () {
                            r.find(".defaultimg").css({ opacity: 0 });
                        }, 100),
                        r.find(".slotslide").each(function (e) {
                            var t = jQuery(this);
                            if (e + 1 < o.slots / 2) var i = 90 * (e + 2);
                            else i = 90 * (2 + o.slots - e);
                            _.add(punchgs.TweenLite.to(t, (f + i) / 1e3, { top: 0 + o.height, opacity: 1, force3D: "auto", rotation: o.rotate, ease: m }), 0), s.add(_, 0);
                        }),
                        n.find(".slotslide").each(function (e) {
                            var t = jQuery(this);
                            if (e + 1 < o.slots / 2) var i = 90 * (e + 2);
                            else i = 90 * (2 + o.slots - e);
                            _.add(punchgs.TweenLite.from(t, (f + i) / 1e3, { top: 0 - o.height, opacity: 1, force3D: "auto", rotation: o.rotate, ease: v }), 0), s.add(_, 0);
                        })),
                    7 == a &&
                        ((f *= 2) > o.delay && (f = o.delay),
                        (_ = new punchgs.TimelineLite()),
                        setTimeout(function () {
                            r.find(".defaultimg").css({ opacity: 0 });
                        }, 100),
                        r.find(".slotslide").each(function () {
                            var e = jQuery(this).find("div");
                            _.add(
                                punchgs.TweenLite.to(e, f / 1e3, {
                                    left: 0 - o.slotw / 2 + "px",
                                    top: 0 - o.height / 2 + "px",
                                    width: 2 * o.slotw + "px",
                                    height: 2 * o.height + "px",
                                    opacity: 0,
                                    rotation: o.rotate,
                                    force3D: "auto",
                                    ease: m,
                                }),
                                0
                            ),
                                s.add(_, 0);
                        }),
                        n.find(".slotslide").each(function (e) {
                            var t = jQuery(this).find("div");
                            _.add(
                                punchgs.TweenLite.fromTo(
                                    t,
                                    f / 1e3,
                                    { left: 0, top: 0, opacity: 0, transformPerspective: 600 },
                                    { left: 0 - e * o.slotw + "px", ease: v, force3D: "auto", top: "0px", width: o.width, height: o.height, opacity: 1, rotation: 0, delay: 0.1 }
                                ),
                                0
                            ),
                                s.add(_, 0);
                        })),
                    8 == a &&
                        ((f *= 3) > o.delay && (f = o.delay),
                        (_ = new punchgs.TimelineLite()),
                        r.find(".slotslide").each(function () {
                            var e = jQuery(this).find("div");
                            _.add(
                                punchgs.TweenLite.to(e, f / 1e3, {
                                    left: 0 - o.width / 2 + "px",
                                    top: 0 - o.sloth / 2 + "px",
                                    width: 2 * o.width + "px",
                                    height: 2 * o.sloth + "px",
                                    force3D: "auto",
                                    ease: m,
                                    opacity: 0,
                                    rotation: o.rotate,
                                }),
                                0
                            ),
                                s.add(_, 0);
                        }),
                        n.find(".slotslide").each(function (e) {
                            var t = jQuery(this).find("div");
                            _.add(
                                punchgs.TweenLite.fromTo(
                                    t,
                                    f / 1e3,
                                    { left: 0, top: 0, opacity: 0, force3D: "auto" },
                                    { left: "0px", top: 0 - e * o.sloth + "px", width: n.find(".defaultimg").data("neww") + "px", height: n.find(".defaultimg").data("newh") + "px", opacity: 1, ease: v, rotation: 0 }
                                ),
                                0
                            ),
                                s.add(_, 0);
                        })),
                    (9 != a && 10 != a) ||
                        n.find(".slotslide").each(function (e) {
                            var t = jQuery(this);
                            s.add(punchgs.TweenLite.fromTo(t, f / 2e3, { autoAlpha: 0, force3D: "auto", transformPerspective: 600 }, { autoAlpha: 1, ease: m, delay: (e * o.slots) / 100 / 2e3 }), 0);
                        }),
                    27 == a || 28 == a || 29 == a || 30 == a)
                ) {
                    var T = n.find(".slot"),
                        C = 27 == a || 29 == a ? "-100%" : "+100%",
                        k = 27 == a || 29 == a ? "+100%" : "-100%",
                        S = 27 == a || 29 == a ? "-80%" : "80%",
                        j = 27 == a || 29 == a ? "+80%" : "-80%",
                        L = 27 == a || 29 == a ? "+10%" : "-10%",
                        O = { overwrite: "all" },
                        P = { autoAlpha: 0, zIndex: 1, force3D: "auto", ease: m },
                        R = { position: "inherit", autoAlpha: 0, overwrite: "all", zIndex: 1 },
                        I = { autoAlpha: 1, force3D: "auto", ease: v },
                        A = { overwrite: "all", zIndex: 2, opacity: 1, autoAlpha: 1 },
                        Q = { autoAlpha: 1, force3D: "auto", overwrite: "all", ease: m },
                        M = { overwrite: "all", zIndex: 2, autoAlpha: 1 },
                        z = { autoAlpha: 1, force3D: "auto", ease: m },
                        D = 1 == (27 == a || 28 == a ? 1 : 2) ? "y" : "x";
                    (O[D] = "0px"),
                        (P[D] = C),
                        (R[D] = L),
                        (I[D] = "0%"),
                        (A[D] = k),
                        (Q[D] = C),
                        (M[D] = S),
                        (z[D] = j),
                        T.append('<span style="background-color:rgba(0,0,0,0.6);width:100%;height:100%;position:absolute;top:0px;left:0px;display:block;z-index:2"></span>'),
                        s.add(punchgs.TweenLite.fromTo(r, f / 1e3, O, P), 0),
                        s.add(punchgs.TweenLite.fromTo(n.find(".defaultimg"), f / 2e3, R, I), f / 2e3),
                        s.add(punchgs.TweenLite.fromTo(T, f / 1e3, A, Q), 0),
                        s.add(punchgs.TweenLite.fromTo(T.find(".slotslide div"), f / 1e3, M, z), 0);
                }
                if (31 == a || 32 == a || 33 == a || 34 == a) {
                    (f = 6e3), (m = punchgs.Power3.easeInOut);
                    var F = f / 1e3;
                    (mas = F - F / 5),
                        (_nt = a),
                        (fy = 31 == _nt ? "+100%" : 32 == _nt ? "-100%" : "0%"),
                        (fx = 33 == _nt ? "+100%" : 34 == _nt ? "-100%" : "0%"),
                        (ty = 31 == _nt ? "-100%" : 32 == _nt ? "+100%" : "0%"),
                        (tx = 33 == _nt ? "-100%" : 34 == _nt ? "+100%" : "0%"),
                        s.add(punchgs.TweenLite.fromTo(r, F - 0.2 * F, { y: 0, x: 0 }, { y: ty, x: tx, ease: v }), 0.2 * F),
                        s.add(punchgs.TweenLite.fromTo(n, F, { y: fy, x: fx }, { y: "0%", x: "0%", ease: m }), 0),
                        n.find(".slot").remove(),
                        n.find(".defaultimg").clone().appendTo(n).addClass("slot"),
                        (function (e, u, h, t, p) {
                            var i = e.find(".slot"),
                                f = [2, 1.2, 0.9, 0.7, 0.55, 0.42],
                                g = e.width(),
                                m = e.height();
                            i.wrap('<div class="slot-circle-wrapper" style="overflow:hidden;position:absolute;border:1px solid #fff"></div>');
                            for (var a = 0; a < 6; a++) i.parent().clone(!1).appendTo(nextsh);
                            e.find(".slot-circle-wrapper").each(function (e) {
                                if (e < 6) {
                                    var t = jQuery(this),
                                        i = t.find(".slot"),
                                        a = m < g ? f[e] * g : f[e] * m,
                                        n = a / 2 - g / 2 + 0,
                                        r = a / 2 - m / 2 + 0,
                                        s = {
                                            scale: 1,
                                            transformOrigo: "50% 50%",
                                            width: a + "px",
                                            height: a + "px",
                                            top: m / 2 - a / 2 + "px",
                                            left: (33 == h ? g / 2 - a / 2 : 34 == h ? g - a : g / 2 - a / 2) + "px",
                                            borderRadius: 0 != e ? "50%" : "0",
                                        },
                                        o = { scale: 1, top: m / 2 - a / 2, left: g / 2 - a / 2, ease: p },
                                        l = { width: g, height: m, autoAlpha: 1, top: r + "px", position: "absolute", left: (33 == h ? n : 34 == h ? n + g / 2 : n) + "px" },
                                        d = { top: r + "px", left: n + "px", ease: p },
                                        c = u;
                                    mtl.add(punchgs.TweenLite.fromTo(t, c, s, o), 0), mtl.add(punchgs.TweenLite.fromTo(i, c, l, d), 0), mtl.add(punchgs.TweenLite.fromTo(t, 0.001, { autoAlpha: 0 }, { autoAlpha: 1 }), 0);
                                }
                            });
                        })(n, F, _nt, 0, m);
                }
                if (11 == a) {
                    12 < h && (h = 0);
                    var E = 2 == h ? "#000000" : 3 == h ? "#ffffff" : "transparent";
                    switch (h) {
                        case 0:
                            s.add(punchgs.TweenLite.fromTo(n, f / 1e3, { autoAlpha: 0 }, { autoAlpha: 1, force3D: "auto", ease: m }), 0);
                            break;
                        case 1:
                            s.add(punchgs.TweenLite.fromTo(n, f / 1e3, { autoAlpha: 0 }, { autoAlpha: 1, force3D: "auto", ease: m }), 0),
                                s.add(punchgs.TweenLite.fromTo(r, f / 1e3, { autoAlpha: 1 }, { autoAlpha: 0, force3D: "auto", ease: m }), 0);
                            break;
                        case 2:
                        case 3:
                        case 4:
                            s.add(punchgs.TweenLite.set(r.parent(), { backgroundColor: E, force3D: "auto" }), 0),
                                s.add(punchgs.TweenLite.set(n.parent(), { backgroundColor: "transparent", force3D: "auto" }), 0),
                                s.add(punchgs.TweenLite.to(r, f / 2e3, { autoAlpha: 0, force3D: "auto", ease: m }), 0),
                                s.add(punchgs.TweenLite.fromTo(n, f / 2e3, { autoAlpha: 0 }, { autoAlpha: 1, force3D: "auto", ease: m }), f / 2e3);
                            break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                        case 11:
                        case 12:
                            var N =
                                    "blur(" +
                                    (0 <= jQuery.inArray(h, [9, 10]) ? 5 : 0 <= jQuery.inArray(h, [11, 12]) ? 10 : 0) +
                                    "px) grayscale(" +
                                    (0 <= jQuery.inArray(h, [5, 6, 7, 8]) ? 100 : 0) +
                                    "%) brightness(" +
                                    (0 <= jQuery.inArray(h, [7, 8]) ? 300 : 0) +
                                    "%)",
                                H = "blur(0px) grayscale(0%) brightness(100%)";
                            s.add(punchgs.TweenLite.fromTo(n, f / 1e3, { autoAlpha: 0, filter: N, "-webkit-filter": N }, { autoAlpha: 1, filter: H, "-webkit-filter": H, force3D: "auto", ease: m }), 0),
                                0 <= jQuery.inArray(h, [6, 8, 10]) &&
                                    s.add(punchgs.TweenLite.fromTo(r, f / 1e3, { autoAlpha: 1, filter: H, "-webkit-filter": H }, { autoAlpha: 0, force3D: "auto", ease: m, filter: N, "-webkit-filter": N }), 0);
                    }
                    s.add(punchgs.TweenLite.set(n.find(".defaultimg"), { autoAlpha: 1 }), 0), s.add(punchgs.TweenLite.set(r.find("defaultimg"), { autoAlpha: 1 }), 0);
                }
                if (
                    (26 == a &&
                        ((f = 0),
                        s.add(punchgs.TweenLite.fromTo(n, f / 1e3, { autoAlpha: 0 }, { autoAlpha: 1, force3D: "auto", ease: m }), 0),
                        s.add(punchgs.TweenLite.to(r, f / 1e3, { autoAlpha: 0, force3D: "auto", ease: m }), 0),
                        s.add(punchgs.TweenLite.set(n.find(".defaultimg"), { autoAlpha: 1 }), 0),
                        s.add(punchgs.TweenLite.set(r.find("defaultimg"), { autoAlpha: 1 }), 0)),
                    12 == a || 13 == a || 14 == a || 15 == a)
                ) {
                    (f = f) > o.delay && (f = o.delay),
                        setTimeout(function () {
                            punchgs.TweenLite.set(r.find(".defaultimg"), { autoAlpha: 0 });
                        }, 100);
                    var W = o.width,
                        B = o.height,
                        V = n.find(".slotslide, .defaultvid"),
                        Y = 0,
                        X = 0,
                        q = 1,
                        U = 1,
                        G = 1,
                        Z = f / 1e3,
                        J = Z;
                    ("fullwidth" != o.sliderLayout && "fullscreen" != o.sliderLayout) || ((W = V.width()), (B = V.height())),
                        12 == a ? (Y = W) : 15 == a ? (Y = 0 - W) : 13 == a ? (X = B) : 14 == a && (X = 0 - B),
                        1 == h && (q = 0),
                        2 == h && (q = 0),
                        3 == h && (Z = f / 1300),
                        (4 != h && 5 != h) || (U = 0.6),
                        6 == h && (U = 1.4),
                        (5 != h && 6 != h) || ((G = 1.4), (X = Y = B = W = q = 0)),
                        6 == h && (G = 0.6),
                        7 == h && (B = W = 0);
                    var $ = n.find(".slotslide"),
                        K = r.find(".slotslide, .defaultvid");
                    if (
                        (s.add(punchgs.TweenLite.set(i, { zIndex: 15 }), 0),
                        s.add(punchgs.TweenLite.set(t, { zIndex: 20 }), 0),
                        8 == h
                            ? (s.add(punchgs.TweenLite.set(i, { zIndex: 20 }), 0),
                              s.add(punchgs.TweenLite.set(t, { zIndex: 15 }), 0),
                              s.add(punchgs.TweenLite.set($, { left: 0, top: 0, scale: 1, opacity: 1, rotation: 0, ease: m, force3D: "auto" }), 0))
                            : s.add(punchgs.TweenLite.from($, Z, { left: Y, top: X, scale: G, opacity: q, rotation: o.rotate, ease: m, force3D: "auto" }), 0),
                        (4 != h && 5 != h) || (B = W = 0),
                        1 != h)
                    )
                        switch (a) {
                            case 12:
                                s.add(punchgs.TweenLite.to(K, J, { left: 0 - W + "px", force3D: "auto", scale: U, opacity: q, rotation: o.rotate, ease: v }), 0);
                                break;
                            case 15:
                                s.add(punchgs.TweenLite.to(K, J, { left: W + "px", force3D: "auto", scale: U, opacity: q, rotation: o.rotate, ease: v }), 0);
                                break;
                            case 13:
                                s.add(punchgs.TweenLite.to(K, J, { top: 0 - B + "px", force3D: "auto", scale: U, opacity: q, rotation: o.rotate, ease: v }), 0);
                                break;
                            case 14:
                                s.add(punchgs.TweenLite.to(K, J, { top: B + "px", force3D: "auto", scale: U, opacity: q, rotation: o.rotate, ease: v }), 0);
                        }
                }
                if (16 == a) {
                    (_ = new punchgs.TimelineLite()),
                        s.add(punchgs.TweenLite.set(i, { position: "absolute", "z-index": 20 }), 0),
                        s.add(punchgs.TweenLite.set(t, { position: "absolute", "z-index": 15 }), 0),
                        i.wrapInner('<div class="tp-half-one" style="position:relative; width:100%;height:100%"></div>'),
                        i.find(".tp-half-one").clone(!0).appendTo(i).addClass("tp-half-two"),
                        i.find(".tp-half-two").removeClass("tp-half-one"),
                        (W = o.width),
                        (B = o.height),
                        "on" == o.autoHeight && (B = x.height()),
                        i.find(".tp-half-one .defaultimg").wrap('<div class="tp-papercut" style="width:' + W + "px;height:" + B + 'px;"></div>'),
                        i.find(".tp-half-two .defaultimg").wrap('<div class="tp-papercut" style="width:' + W + "px;height:" + B + 'px;"></div>'),
                        i.find(".tp-half-two .defaultimg").css({ position: "absolute", top: "-50%" }),
                        i.find(".tp-half-two .tp-caption").wrapAll('<div style="position:absolute;top:-50%;left:0px;"></div>'),
                        s.add(
                            punchgs.TweenLite.set(i.find(".tp-half-two"), { width: W, height: B, overflow: "hidden", zIndex: 15, position: "absolute", top: B / 2, left: "0px", transformPerspective: 600, transformOrigin: "center bottom" }),
                            0
                        ),
                        s.add(
                            punchgs.TweenLite.set(i.find(".tp-half-one"), {
                                width: W,
                                height: B / 2,
                                overflow: "visible",
                                zIndex: 10,
                                position: "absolute",
                                top: "0px",
                                left: "0px",
                                transformPerspective: 600,
                                transformOrigin: "center top",
                            }),
                            0
                        ),
                        i.find(".defaultimg");
                    var ee = Math.round(20 * Math.random() - 10),
                        te = Math.round(20 * Math.random() - 10),
                        ie = Math.round(20 * Math.random() - 10),
                        ae = 0.4 * Math.random() - 0.2,
                        ne = 0.4 * Math.random() - 0.2,
                        re = 1 * Math.random() + 1,
                        se = 1 * Math.random() + 1,
                        oe = 0.3 * Math.random() + 0.3;
                    s.add(punchgs.TweenLite.set(i.find(".tp-half-one"), { overflow: "hidden" }), 0),
                        s.add(
                            punchgs.TweenLite.fromTo(
                                i.find(".tp-half-one"),
                                f / 800,
                                { width: W, height: B / 2, position: "absolute", top: "0px", left: "0px", force3D: "auto", transformOrigin: "center top" },
                                { scale: re, rotation: ee, y: 0 - B - B / 4, autoAlpha: 0, ease: m }
                            ),
                            0
                        ),
                        s.add(
                            punchgs.TweenLite.fromTo(
                                i.find(".tp-half-two"),
                                f / 800,
                                { width: W, height: B, overflow: "hidden", position: "absolute", top: B / 2, left: "0px", force3D: "auto", transformOrigin: "center bottom" },
                                {
                                    scale: se,
                                    rotation: te,
                                    y: B + B / 4,
                                    ease: m,
                                    autoAlpha: 0,
                                    onComplete: function () {
                                        punchgs.TweenLite.set(i, { position: "absolute", "z-index": 15 }),
                                            punchgs.TweenLite.set(t, { position: "absolute", "z-index": 20 }),
                                            0 < i.find(".tp-half-one").length && (i.find(".tp-half-one .defaultimg").unwrap(), i.find(".tp-half-one .slotholder").unwrap()),
                                            i.find(".tp-half-two").remove();
                                    },
                                }
                            ),
                            0
                        ),
                        _.add(punchgs.TweenLite.set(n.find(".defaultimg"), { autoAlpha: 1 }), 0),
                        null != i.html() &&
                            s.add(
                                punchgs.TweenLite.fromTo(
                                    t,
                                    (f - 200) / 1e3,
                                    { scale: oe, x: (o.width / 4) * ae, y: (B / 4) * ne, rotation: ie, force3D: "auto", transformOrigin: "center center", ease: v },
                                    { autoAlpha: 1, scale: 1, x: 0, y: 0, rotation: 0 }
                                ),
                                0
                            ),
                        s.add(_, 0);
                }
                if (
                    (17 == a &&
                        n.find(".slotslide").each(function (e) {
                            var t = jQuery(this);
                            s.add(
                                punchgs.TweenLite.fromTo(
                                    t,
                                    f / 800,
                                    { opacity: 0, rotationY: 0, scale: 0.9, rotationX: -110, force3D: "auto", transformPerspective: 600, transformOrigin: "center center" },
                                    { opacity: 1, top: 0, left: 0, scale: 1, rotation: 0, rotationX: 0, force3D: "auto", rotationY: 0, ease: m, delay: 0.06 * e }
                                ),
                                0
                            );
                        }),
                    18 == a &&
                        n.find(".slotslide").each(function (e) {
                            var t = jQuery(this);
                            s.add(
                                punchgs.TweenLite.fromTo(
                                    t,
                                    f / 500,
                                    { autoAlpha: 0, rotationY: 110, scale: 0.9, rotationX: 10, force3D: "auto", transformPerspective: 600, transformOrigin: "center center" },
                                    { autoAlpha: 1, top: 0, left: 0, scale: 1, rotation: 0, rotationX: 0, force3D: "auto", rotationY: 0, ease: m, delay: 0.06 * e }
                                ),
                                0
                            );
                        }),
                    19 == a || 22 == a)
                ) {
                    (_ = new punchgs.TimelineLite()),
                        s.add(punchgs.TweenLite.set(i, { zIndex: 20 }), 0),
                        s.add(punchgs.TweenLite.set(t, { zIndex: 20 }), 0),
                        setTimeout(function () {
                            r.find(".defaultimg").css({ opacity: 0 });
                        }, 100);
                    var le = 90,
                        de = ((q = 1), "center center ");
                    1 == d && (le = -90),
                        19 == a ? ((de = de + "-" + o.height / 2), (q = 0)) : (de += o.height / 2),
                        punchgs.TweenLite.set(x, { transformStyle: "flat", backfaceVisibility: "hidden", transformPerspective: 600 }),
                        n.find(".slotslide").each(function (e) {
                            var t = jQuery(this);
                            _.add(
                                punchgs.TweenLite.fromTo(
                                    t,
                                    f / 1e3,
                                    { transformStyle: "flat", backfaceVisibility: "hidden", left: 0, rotationY: o.rotate, z: 10, top: 0, scale: 1, force3D: "auto", transformPerspective: 600, transformOrigin: de, rotationX: le },
                                    { left: 0, rotationY: 0, top: 0, z: 0, scale: 1, force3D: "auto", rotationX: 0, delay: (50 * e) / 1e3, ease: m }
                                ),
                                0
                            ),
                                _.add(punchgs.TweenLite.to(t, 0.1, { autoAlpha: 1, delay: (50 * e) / 1e3 }), 0),
                                s.add(_);
                        }),
                        r.find(".slotslide").each(function (e) {
                            var t = jQuery(this),
                                i = -90;
                            1 == d && (i = 90),
                                _.add(
                                    punchgs.TweenLite.fromTo(
                                        t,
                                        f / 1e3,
                                        { transformStyle: "flat", backfaceVisibility: "hidden", autoAlpha: 1, rotationY: 0, top: 0, z: 0, scale: 1, force3D: "auto", transformPerspective: 600, transformOrigin: de, rotationX: 0 },
                                        { autoAlpha: 1, rotationY: o.rotate, top: 0, z: 10, scale: 1, rotationX: i, delay: (50 * e) / 1e3, force3D: "auto", ease: v }
                                    ),
                                    0
                                ),
                                s.add(_);
                        }),
                        s.add(punchgs.TweenLite.set(i, { zIndex: 18 }), 0);
                }
                if (20 == a) {
                    if (
                        (setTimeout(function () {
                            r.find(".defaultimg").css({ opacity: 0 });
                        }, 100),
                        1 == d)
                    ) {
                        var ce = -o.width;
                        (le = 80), (de = "20% 70% -" + o.height / 2);
                    } else (ce = o.width), (le = -80), (de = "80% 70% -" + o.height / 2);
                    n.find(".slotslide").each(function (e) {
                        var t = jQuery(this),
                            i = (50 * e) / 1e3;
                        s.add(
                            punchgs.TweenLite.fromTo(
                                t,
                                f / 1e3,
                                { left: ce, rotationX: 40, z: -600, opacity: q, top: 0, scale: 1, force3D: "auto", transformPerspective: 600, transformOrigin: de, transformStyle: "flat", rotationY: le },
                                { left: 0, rotationX: 0, opacity: 1, top: 0, z: 0, scale: 1, rotationY: 0, delay: i, ease: m }
                            ),
                            0
                        );
                    }),
                        r.find(".slotslide").each(function (e) {
                            var t = jQuery(this),
                                i = (50 * e) / 1e3;
                            if (((i = 0 < e ? i + f / 9e3 : 0), 1 != d))
                                var a = -o.width / 2,
                                    n = 30,
                                    r = "20% 70% -" + o.height / 2;
                            else (a = o.width / 2), (n = -30), (r = "80% 70% -" + o.height / 2);
                            (v = punchgs.Power2.easeInOut),
                                s.add(
                                    punchgs.TweenLite.fromTo(
                                        t,
                                        f / 1e3,
                                        { opacity: 1, rotationX: 0, top: 0, z: 0, scale: 1, left: 0, force3D: "auto", transformPerspective: 600, transformOrigin: r, transformStyle: "flat", rotationY: 0 },
                                        { opacity: 1, rotationX: 20, top: 0, z: -600, left: a, force3D: "auto", rotationY: n, delay: i, ease: v }
                                    ),
                                    0
                                );
                        });
                }
                if (21 == a || 25 == a) {
                    setTimeout(function () {
                        r.find(".defaultimg").css({ opacity: 0 });
                    }, 100),
                        (le = 90),
                        (ce = -o.width);
                    var ue = -le;
                    1 == d
                        ? 25 == a
                            ? ((de = "center top 0"), (le = o.rotate))
                            : ((de = "left center 0"), (ue = o.rotate))
                        : ((ce = o.width), (le = -90), 25 == a ? ((de = "center bottom 0"), (ue = -le), (le = o.rotate)) : ((de = "right center 0"), (ue = o.rotate))),
                        n.find(".slotslide").each(function (e) {
                            var t = jQuery(this),
                                i = f / 1.5 / 3;
                            s.add(
                                punchgs.TweenLite.fromTo(
                                    t,
                                    (2 * i) / 1e3,
                                    { left: 0, transformStyle: "flat", rotationX: ue, z: 0, autoAlpha: 0, top: 0, scale: 1, force3D: "auto", transformPerspective: 1200, transformOrigin: de, rotationY: le },
                                    { left: 0, rotationX: 0, top: 0, z: 0, autoAlpha: 1, scale: 1, rotationY: 0, force3D: "auto", delay: i / 1e3, ease: m }
                                ),
                                0
                            );
                        }),
                        1 != d
                            ? ((ce = -o.width), (le = 90), 25 == a ? ((de = "center top 0"), (ue = -le), (le = o.rotate)) : ((de = "left center 0"), (ue = o.rotate)))
                            : ((ce = o.width), (le = -90), 25 == a ? ((de = "center bottom 0"), (ue = -le), (le = o.rotate)) : ((de = "right center 0"), (ue = o.rotate))),
                        r.find(".slotslide").each(function (e) {
                            var t = jQuery(this);
                            s.add(
                                punchgs.TweenLite.fromTo(
                                    t,
                                    f / 1e3,
                                    { left: 0, transformStyle: "flat", rotationX: 0, z: 0, autoAlpha: 1, top: 0, scale: 1, force3D: "auto", transformPerspective: 1200, transformOrigin: de, rotationY: 0 },
                                    { left: 0, rotationX: ue, top: 0, z: 0, autoAlpha: 1, force3D: "auto", scale: 1, rotationY: le, ease: v }
                                ),
                                0
                            );
                        });
                }
                return (
                    (23 != a && 24 != a) ||
                        (setTimeout(function () {
                            r.find(".defaultimg").css({ opacity: 0 });
                        }, 100),
                        (le = -90),
                        (q = 1) == d && (le = 90),
                        23 == a ? ((de = "center center -" + o.width / 2), (q = 0)) : (de = "center center " + o.width / 2),
                        punchgs.TweenLite.set(x, { transformStyle: "preserve-3d", backfaceVisibility: "hidden", perspective: 2500 }),
                        n.find(".slotslide").each(function (e) {
                            var t = jQuery(this);
                            s.add(
                                punchgs.TweenLite.fromTo(
                                    t,
                                    f / 1e3,
                                    { left: 0, rotationX: o.rotate, force3D: "auto", opacity: q, top: 0, scale: 1, transformPerspective: 1200, transformOrigin: de, rotationY: le },
                                    { left: 0, rotationX: 0, autoAlpha: 1, top: 0, z: 0, scale: 1, rotationY: 0, delay: (50 * e) / 500, ease: m }
                                ),
                                0
                            );
                        }),
                        (le = 90),
                        1 == d && (le = -90),
                        r.find(".slotslide").each(function (e) {
                            var t = jQuery(this);
                            s.add(
                                punchgs.TweenLite.fromTo(
                                    t,
                                    f / 1e3,
                                    { left: 0, rotationX: 0, top: 0, z: 0, scale: 1, force3D: "auto", transformStyle: "flat", transformPerspective: 1200, transformOrigin: de, rotationY: 0 },
                                    { left: 0, rotationX: o.rotate, top: 0, scale: 1, rotationY: le, delay: (50 * e) / 500, ease: v }
                                ),
                                0
                            ),
                                23 == a && s.add(punchgs.TweenLite.fromTo(t, f / 2e3, { autoAlpha: 1 }, { autoAlpha: 0, delay: (50 * e) / 500 + f / 3e3, ease: v }), 0);
                        })),
                    s
                );
            };
    })(jQuery),
    (function (e) {
        "use strict";
        var L = jQuery.fn.revolution,
            O = L.is_mobile(),
            P = (L.is_android(), { alias: "Video Min JS", name: "revolution.extensions.video.min.js", min_core: "5.4.8", version: "2.2.2" });
        function R(e) {
            return null == e ? -1 : jQuery.isNumeric(e) ? e : 1 < e.split(":").length ? 60 * parseInt(e.split(":")[0], 0) + parseInt(e.split(":")[1], 0) : e;
        }
        jQuery.extend(!0, L, {
            preLoadAudio: function (e, i) {
                if ("stop" === L.compare_version(P).check) return !1;
                e.find(".tp-audiolayer").each(function () {
                    var e = jQuery(this),
                        t = {};
                    0 === e.find("audio").length &&
                        ((t.src = null != e.data("videomp4") ? e.data("videomp4") : ""),
                        (t.pre = e.data("videopreload") || ""),
                        void 0 === e.attr("id") && e.attr("audio-layer-" + Math.round(199999 * Math.random())),
                        (t.id = e.attr("id")),
                        (t.status = "prepared"),
                        (t.start = jQuery.now()),
                        (t.waittime = 1e3 * e.data("videopreloadwait") || 5e3),
                        ("auto" != t.pre && "canplaythrough" != t.pre && "canplay" != t.pre && "progress" != t.pre) || (void 0 === i.audioqueue && (i.audioqueue = []), i.audioqueue.push(t), L.manageVideoLayer(e, i)));
                });
            },
            preLoadAudioDone: function (i, e, a) {
                e.audioqueue &&
                    0 < e.audioqueue.length &&
                    jQuery.each(e.audioqueue, function (e, t) {
                        i.data("videomp4") !== t.src || (t.pre !== a && "auto" !== t.pre) || (t.status = "loaded");
                    });
            },
            resetVideo: function (e, t, i, a) {
                var n = e.data();
                switch (n.videotype) {
                    case "youtube":
                        n.player;
                        try {
                            if ("on" == n.forcerewind) {
                                var r = -1 == (l = R(e.data("videostartat"))),
                                    s = 1 === n.bgvideo || 0 < e.find(".tp-videoposter").length;
                                null != n.player && ((l = -1 == l ? 0 : l), n.player.seekTo(l), n.player.pauseVideo());
                            }
                        } catch (e) {}
                        0 == e.find(".tp-videoposter").length && 1 !== n.bgvideo && !0 !== i && punchgs.TweenLite.to(e.find("iframe"), 0.3, { autoAlpha: 1, display: "block", ease: punchgs.Power3.easeInOut });
                        break;
                    case "vimeo":
                        var o = e.data("vimeoplayer");
                        try {
                            if ("on" == n.forcerewind) {
                                var l = R(n.videostartat);
                                (r = -1 == l),
                                    (s = 1 === n.bgvideo || 0 < e.find(".tp-videoposter").length),
                                    ((0 !== (l = -1 == l ? 0 : l) && !r) || s) &&
                                        o.pause().then(function () {
                                            o.setCurrentTime(l);
                                        });
                            }
                        } catch (e) {}
                        0 == e.find(".tp-videoposter").length && 1 !== n.bgvideo && !0 !== i && punchgs.TweenLite.to(e.find("iframe"), 0.3, { autoAlpha: 1, display: "block", ease: punchgs.Power3.easeInOut });
                        break;
                    case "html5":
                        if (O && 1 == n.disablevideoonmobile) return !1;
                        var d = "html5" == n.audio ? "audio" : "video",
                            c = e.find(d),
                            u = c[0];
                        if ((punchgs.TweenLite.to(c, 0.3, { autoAlpha: 1, display: "block", ease: punchgs.Power3.easeInOut }), "on" == n.forcerewind && !e.hasClass("videoisplaying")))
                            try {
                                (l = R(n.videostartat)), (u.currentTime = -1 == l ? 0 : l);
                            } catch (e) {}
                        ("mute" == n.volume || L.lastToggleState(e.videomutetoggledby) || !0 === t.globalmute) && (u.muted = !0);
                }
            },
            isVideoMuted: function (e, t) {
                var i = !1,
                    a = e.data();
                switch (a.videotype) {
                    case "youtube":
                        try {
                            i = a.player.isMuted();
                        } catch (e) {}
                        break;
                    case "vimeo":
                        try {
                            "mute" == a.volume && (i = !0);
                        } catch (e) {}
                        break;
                    case "html5":
                        var n = "html5" == a.audio ? "audio" : "video";
                        e.find(n)[0].muted && (i = !0);
                }
                return i;
            },
            muteVideo: function (e, t) {
                var i = e.data();
                switch (i.videotype) {
                    case "youtube":
                        try {
                            i.player.mute();
                        } catch (e) {}
                        break;
                    case "vimeo":
                        try {
                            var a = e.data("vimeoplayer");
                            e.data("volume", "mute"), a.setVolume(0);
                        } catch (e) {}
                        break;
                    case "html5":
                        var n = "html5" == i.audio ? "audio" : "video";
                        e.find(n)[0].muted = !0;
                }
            },
            unMuteVideo: function (e, t) {
                if (!0 !== t.globalmute) {
                    var i = e.data();
                    switch (i.videotype) {
                        case "youtube":
                            try {
                                i.player.unMute();
                            } catch (e) {}
                            break;
                        case "vimeo":
                            try {
                                var a = e.data("vimeoplayer");
                                e.data("volume", "1"), a.setVolume(1);
                            } catch (e) {}
                            break;
                        case "html5":
                            var n = "html5" == i.audio ? "audio" : "video";
                            e.find(n)[0].muted = !1;
                    }
                }
            },
            stopVideo: function (e, t) {
                var i = e.data();
                switch ((t.leaveViewPortBasedStop || (t.lastplayedvideos = []), (t.leaveViewPortBasedStop = !1), i.videotype)) {
                    case "youtube":
                        try {
                            var a = i.player;
                            if (2 === a.getPlayerState() || 5 === a.getPlayerState()) return;
                            a.pauseVideo(),
                                (i.youtubepausecalled = !0),
                                setTimeout(function () {
                                    i.youtubepausecalled = !1;
                                }, 80);
                        } catch (e) {
                            console.log("Issue at YouTube Video Pause:"), console.log(e);
                        }
                        break;
                    case "vimeo":
                        try {
                            e.data("vimeoplayer").pause(),
                                (i.vimeopausecalled = !0),
                                setTimeout(function () {
                                    i.vimeopausecalled = !1;
                                }, 80);
                        } catch (e) {
                            console.log("Issue at Vimeo Video Pause:"), console.log(e);
                        }
                        break;
                    case "html5":
                        var n = "html5" == i.audio ? "audio" : "video",
                            r = e.find(n),
                            s = r[0];
                        null != r && null != s && s.pause();
                }
            },
            playVideo: function (i, a) {
                clearTimeout(i.data("videoplaywait"));
                var e = i.data();
                switch (e.videotype) {
                    case "youtube":
                        if (0 == i.find("iframe").length) i.append(i.data("videomarkup")), A(i, a, !0);
                        else if (null != e.player.playVideo) {
                            var t = R(i.data("videostartat")),
                                n = e.player.getCurrentTime();
                            1 == i.data("nextslideatend-triggered") && ((n = -1), i.data("nextslideatend-triggered", 0)), -1 != t && n < t && e.player.seekTo(t), !0 !== e.youtubepausecalled && e.player.playVideo();
                        } else
                            i.data(
                                "videoplaywait",
                                setTimeout(function () {
                                    !0 !== e.youtubepausecalled && L.playVideo(i, a);
                                }, 50)
                            );
                        break;
                    case "vimeo":
                        if (0 == i.find("iframe").length) i.removeData("vimeoplayer"), i.append(i.data("videomarkup")), A(i, a, !0);
                        else if (i.hasClass("rs-apiready")) {
                            var r,
                                s = i.find("iframe").attr("id");
                            i.data("vimeoplayer") ? (r = i.data("vimeoplayer")) : ((r = new Vimeo.Player(s)), i.data("vimeoplayer", r)),
                                r.getPaused()
                                    ? setTimeout(function () {
                                          var e = R(i.data("videostartat")),
                                              t = i.data("currenttime");
                                          t || (t = 0), 1 == i.data("nextslideatend-triggered") && ((t = -1), i.data("nextslideatend-triggered", 0)), -1 != e && t < e && r.setCurrentTime(e), r.play();
                                      }, 510)
                                    : i.data(
                                          "videoplaywait",
                                          setTimeout(function () {
                                              !0 !== e.vimeopausecalled && L.playVideo(i, a);
                                          }, 50)
                                      );
                        } else
                            i.data(
                                "videoplaywait",
                                setTimeout(function () {
                                    !0 !== e.vimeopausecalled && L.playVideo(i, a);
                                }, 50)
                            );
                        break;
                    case "html5":
                        var o = "html5" == e.audio ? "audio" : "video",
                            l = i.find(o),
                            d = l[0];
                        1 != l.parent().data("metaloaded")
                            ? I(
                                  d,
                                  "loadedmetadata",
                                  (function (e) {
                                      L.resetVideo(e, a), d.play();
                                      var t = R(e.data("videostartat")),
                                          i = d.currentTime;
                                      1 == e.data("nextslideatend-triggered") && ((i = -1), e.data("nextslideatend-triggered", 0)), -1 != t && i < t && (d.currentTime = t);
                                  })(i)
                              )
                            : (d.play(), (t = R(i.data("videostartat"))), (n = d.currentTime), 1 == i.data("nextslideatend-triggered") && ((n = -1), i.data("nextslideatend-triggered", 0)), -1 != t && n < t && (d.currentTime = t));
                }
            },
            isVideoPlaying: function (i, e) {
                var a = !1;
                return (
                    null != e.playingvideos &&
                        jQuery.each(e.playingvideos, function (e, t) {
                            i.attr("id") == t.attr("id") && (a = !0);
                        }),
                    a
                );
            },
            removeMediaFromList: function (e, t) {
                C(e, t);
            },
            prepareCoveredVideo: function (e, t) {
                if ((!t.hasClass("tp-caption") || t.hasClass("coverscreenvideo")) && (void 0 === t.data("vimeoid") || void 0 !== t.data("vimeoplayerloaded"))) {
                    var i = {};
                    (i.ifr = t.find("iframe, video")), (i.asp = t.data("aspectratio")), (i.wa = i.asp.split(":")[0]), (i.ha = i.asp.split(":")[1]), (i.vd = i.wa / i.ha);
                    var a = "carousel" !== e.sliderType ? e.conw : t.closest(".tp-revslider-slidesli").width();
                    if (0 === a || 0 === e.conh)
                        return (
                            L.setSize(e),
                            clearTimeout(i.ifr.data("resizelistener")),
                            void i.ifr.data(
                                "resizelistener",
                                setTimeout(function () {
                                    L.prepareCoveredVideo(e, t);
                                }, 100)
                            )
                        );
                    var n = a / e.conh,
                        r = (n / i.vd) * 100,
                        s = (i.vd / n) * 100;
                    n > i.vd
                        ? punchgs.TweenLite.set(i.ifr, { height: r + "%", width: "100%", top: -(r - 100) / 2 + "%", left: "0px", position: "absolute" })
                        : punchgs.TweenLite.set(i.ifr, { width: s + "%", height: "100%", left: -(s - 100) / 2 + "%", top: "0px", position: "absolute" }),
                        i.ifr.hasClass("resizelistener") ||
                            (i.ifr.addClass("resizelistener"),
                            jQuery(window).resize(function () {
                                L.prepareCoveredVideo(e, t),
                                    clearTimeout(i.ifr.data("resizelistener")),
                                    i.ifr.data(
                                        "resizelistener",
                                        setTimeout(function () {
                                            L.prepareCoveredVideo(e, t);
                                        }, 90)
                                    );
                            }));
                }
            },
            checkVideoApis: function (e, t, i) {
                if (
                    (location.protocol,
                    (null != e.data("ytid") || (0 < e.find("iframe").length && 0 < e.find("iframe").attr("src").toLowerCase().indexOf("youtube"))) && (t.youtubeapineeded = !0),
                    (null != e.data("ytid") || (0 < e.find("iframe").length && 0 < e.find("iframe").attr("src").toLowerCase().indexOf("youtube"))) && 0 == i.addedyt)
                ) {
                    (t.youtubestarttime = jQuery.now()), (i.addedyt = 1);
                    var a = document.createElement("script");
                    a.src = "https://www.youtube.com/iframe_api";
                    var n = document.getElementsByTagName("script")[0],
                        r = !0;
                    jQuery("head")
                        .find("*")
                        .each(function () {
                            "https://www.youtube.com/iframe_api" == jQuery(this).attr("src") && (r = !1);
                        }),
                        r && n.parentNode.insertBefore(a, n);
                }
                if (
                    ((null != e.data("vimeoid") || (0 < e.find("iframe").length && 0 < e.find("iframe").attr("src").toLowerCase().indexOf("vimeo"))) && (t.vimeoapineeded = !0),
                    (null != e.data("vimeoid") || (0 < e.find("iframe").length && 0 < e.find("iframe").attr("src").toLowerCase().indexOf("vimeo"))) && 0 == i.addedvim)
                ) {
                    (t.vimeostarttime = jQuery.now()), (i.addedvim = 1);
                    var s = document.createElement("script");
                    (n = document.getElementsByTagName("script")[0]),
                        (r = !0),
                        (s.src = "https://player.vimeo.com/api/player.js"),
                        jQuery("head")
                            .find("*")
                            .each(function () {
                                "https://player.vimeo.com/api/player.js" == jQuery(this).attr("src") && (r = !1);
                            }),
                        r && n.parentNode.insertBefore(s, n);
                }
                return i;
            },
            manageVideoLayer: function (a, n, e, t) {
                if ("stop" === L.compare_version(P).check) return !1;
                var i = a.data(),
                    r = i.videoattributes,
                    s = i.ytid,
                    o = i.vimeoid,
                    l = "auto" === i.videopreload || "canplay" === i.videopreload || "canplaythrough" === i.videopreload || "progress" === i.videopreload ? "auto" : i.videopreload,
                    d = i.videomp4,
                    c = i.videowebm,
                    u = i.videoogv,
                    h = i.allowfullscreenvideo,
                    p = i.videocontrols,
                    f = "http",
                    g = "loop" == i.videoloop ? "loop" : "loopandnoslidestop" == i.videoloop ? "loop" : "",
                    m = null != d || null != c ? "html5" : null != s && 1 < String(s).length ? "youtube" : null != o && 1 < String(o).length ? "vimeo" : "none",
                    v = "html5" == i.audio ? "audio" : "video",
                    y = "html5" == m && 0 == a.find(v).length ? "html5" : "youtube" == m && 0 == a.find("iframe").length ? "youtube" : "vimeo" == m && 0 == a.find("iframe").length ? "vimeo" : "none";
                switch (((g = !0 === i.nextslideatend ? "" : g), (i.videotype = m), y)) {
                    case "html5":
                        "controls" != p && (p = ""), (v = "video"), "html5" == i.audio && ((v = "audio"), a.addClass("tp-audio-html5"));
                        var w = "";
                        "video" === v &&
                            (L.is_mobile() || L.isSafari11()) &&
                            ("on" === i.autoplay || "true" === i.autoplay || !0 === i.autoplay ? (w = "muted playsinline autoplay") : (1 != i.videoinline && "true" !== i.videoinline && 1 !== i.videoinline) || (w += " playsinline"));
                        var _ = "<" + v + " " + w + ' style="object-fit:cover;background-size:cover;visible:hidden;width:100%; height:100%" class="" ' + g + ' preload="' + l + '">';
                        "auto" == l && (n.mediapreload = !0),
                            "video" === v
                                ? (null != c && "firefox" == L.get_browser().toLowerCase() && (_ = _ + '<source src="' + c + '" type="video/webm" />'),
                                  null != d && (_ = _ + '<source src="' + d + '" type="video/mp4" />'),
                                  null != u && (_ = _ + '<source src="' + u + '" type="video/ogg" />'))
                                : "audio" === v && (null != d && (_ = _ + '<source src="' + d + '" type="audio/mpeg" />'), null != u && (_ = _ + '<source src="' + u + '" type="audio/ogg" />')),
                            (_ = _ + "</" + v + ">");
                        var b = "";
                        ("true" !== h && !0 !== h) || (b = '<div class="tp-video-button-wrap"><button  type="button" class="tp-video-button tp-vid-full-screen">Full-Screen</button></div>'),
                            "controls" == p &&
                                (_ =
                                    _ +
                                    '<div class="tp-video-controls"><div class="tp-video-button-wrap"><button type="button" class="tp-video-button tp-vid-play-pause">Play</button></div><div class="tp-video-seek-bar-wrap"><input  type="range" class="tp-seek-bar" value="0"></div><div class="tp-video-button-wrap"><button  type="button" class="tp-video-button tp-vid-mute">Mute</button></div><div class="tp-video-vol-bar-wrap"><input  type="range" class="tp-volume-bar" min="0" max="1" step="0.1" value="1"></div>' +
                                    b +
                                    "</div>"),
                            a.data("videomarkup", _),
                            a.append(_),
                            ((O && 1 == a.data("disablevideoonmobile")) || L.isIE(8)) && a.find(v).remove(),
                            a.find(v).each(function (e) {
                                var t,
                                    i = jQuery(this);
                                i.parent().hasClass("html5vid") || i.wrap('<div class="html5vid" style="position:relative;top:0px;left:0px;width:100%;height:100%; overflow:hidden;"></div>'),
                                    1 != i.parent().data("metaloaded") && I(this, "loadedmetadata", (Q((t = a), n), void L.resetVideo(t, n)));
                            });
                        break;
                    case "youtube":
                        (f = "https"),
                            "none" == p && -1 == (r = r.replace("controls=1", "controls=0")).toLowerCase().indexOf("controls") && (r += "&controls=0"),
                            (!0 === i.videoinline || "true" === i.videoinline || 1 === i.videoinline || a.hasClass("rs-background-video-layer") || "on" === a.data("autoplay")) && (r += "&playsinline=1");
                        var x = R(a.data("videostartat")),
                            T = R(a.data("videoendat"));
                        -1 != x && (r = r + "&start=" + x), -1 != T && (r = r + "&end=" + T);
                        var C = r.split("origin=" + f + "://"),
                            k = "";
                        1 < C.length ? ((k = C[0] + "origin=" + f + "://"), self.location.href.match(/www/gi) && !C[1].match(/www/gi) && (k += "www."), (k += C[1])) : (k = r);
                        var S = "true" === h || !0 === h ? "allowfullscreen" : "";
                        a.data("videomarkup", '<iframe type="text/html" src="' + f + "://www.youtube-nocookie.com/embed/" + s + "?" + k + '" ' + S + ' width="100%" height="100%" style="opacity:0;width:100%;height:100%"></iframe>');
                        break;
                    case "vimeo":
                        (f = "https"),
                            a.data(
                                "videomarkup",
                                '<iframe src="' +
                                    f +
                                    "://player.vimeo.com/video/" +
                                    o +
                                    "?" +
                                    r +
                                    '" webkitallowfullscreen mozallowfullscreen allowfullscreen width="100%" height="100%" style="opacity:0;visibility:hidden;width:100%;height:100%"></iframe>'
                            );
                }
                var j = O && "on" == a.data("noposteronmobile");
                if (null != i.videoposter && 2 < i.videoposter.length && !j)
                    0 == a.find(".tp-videoposter").length &&
                        a.append(
                            '<div class="tp-videoposter noSwipe" style="cursor:pointer; position:absolute;top:0px;left:0px;width:100%;height:100%;z-index:3;background-image:url(' +
                                i.videoposter +
                                '); background-size:cover;background-position:center center;"></div>'
                        ),
                        0 == a.find("iframe").length &&
                            a.find(".tp-videoposter").click(function () {
                                if ((L.playVideo(a, n), O)) {
                                    if (1 == a.data("disablevideoonmobile")) return !1;
                                    punchgs.TweenLite.to(a.find(".tp-videoposter"), 0.3, { autoAlpha: 0, force3D: "auto", ease: punchgs.Power3.easeInOut }),
                                        punchgs.TweenLite.to(a.find("iframe"), 0.3, { autoAlpha: 1, display: "block", ease: punchgs.Power3.easeInOut });
                                }
                            });
                else {
                    if (O && 1 == a.data("disablevideoonmobile")) return !1;
                    0 != a.find("iframe").length || ("youtube" != m && "vimeo" != m) || (a.removeData("vimeoplayer"), a.append(a.data("videomarkup")), A(a, n, !1));
                }
                "none" != a.data("dottedoverlay") && null != a.data("dottedoverlay") && 1 != a.find(".tp-dottedoverlay").length && a.append('<div class="tp-dottedoverlay ' + a.data("dottedoverlay") + '"></div>'),
                    a.addClass("HasListener"),
                    1 == a.data("bgvideo") && (a.data("ytid") ? punchgs.TweenLite.set(a.find("iframe"), { opacity: 0 }) : punchgs.TweenLite.set(a.find("video, iframe"), { autoAlpha: 0 }));
            },
        });
        var I = function (e, t, i) {
                e.addEventListener ? e.addEventListener(t, i, { capture: !1, passive: !0 }) : e.attachEvent(t, i, { capture: !1, passive: !0 });
            },
            w = function (e, t, i) {
                var a = {};
                return (a.video = e), (a.videotype = t), (a.settings = i), a;
            },
            _ = function (e, t) {
                if (1 == t.data("bgvideo") || 1 == t.data("forcecover")) {
                    1 === t.data("forcecover") && t.removeClass("fullscreenvideo").addClass("coverscreenvideo");
                    var i = t.data("aspectratio");
                    void 0 === i && i.split(":").length <= 1 && t.data("aspectratio", "16:9"), L.prepareCoveredVideo(e, t);
                }
            },
            A = function (o, n, e) {
                var l = o.data(),
                    t = o.find("iframe"),
                    i = "iframe" + Math.round(1e5 * Math.random() + 1),
                    r = l.videoloop,
                    s = "loopandnoslidestop" != r;
                if (((r = "loop" == r || "loopandnoslidestop" == r), _(n, o), t.attr("id", i), e && o.data("startvideonow", !0), 1 !== o.data("videolistenerexist")))
                    switch (l.videotype) {
                        case "youtube":
                            var d = new YT.Player(i, {
                                events: {
                                    onStateChange: function (e) {
                                        var t = o.closest(".tp-simpleresponsive"),
                                            i = (l.videorate, o.data("videostart"), x());
                                        if (e.data == YT.PlayerState.PLAYING)
                                            punchgs.TweenLite.to(o.find(".tp-videoposter"), 0.3, { autoAlpha: 0, force3D: "auto", ease: punchgs.Power3.easeInOut }),
                                                punchgs.TweenLite.to(o.find("iframe"), 0.3, { autoAlpha: 1, display: "block", ease: punchgs.Power3.easeInOut }),
                                                "mute" == o.data("volume") || L.lastToggleState(o.data("videomutetoggledby")) || !0 === n.globalmute ? d.mute() : (d.unMute(), d.setVolume(parseInt(o.data("volume"), 0) || 75)),
                                                (n.videoplaying = !0),
                                                T(o, n),
                                                s ? n.c.trigger("stoptimer") : (n.videoplaying = !1),
                                                n.c.trigger("revolution.slide.onvideoplay", w(d, "youtube", o.data())),
                                                L.toggleState(l.videotoggledby);
                                        else {
                                            if (0 == e.data && r) {
                                                var a = R(o.data("videostartat"));
                                                -1 != a && d.seekTo(a), d.playVideo(), L.toggleState(l.videotoggledby);
                                            }
                                            i ||
                                                (0 != e.data && 2 != e.data) ||
                                                !(("on" == o.data("showcoveronpause") && 0 < o.find(".tp-videoposter").length) || (1 === o.data("bgvideo") && 0 < o.find(".rs-fullvideo-cover").length)) ||
                                                (1 === o.data("bgvideo")
                                                    ? punchgs.TweenLite.to(o.find(".rs-fullvideo-cover"), 0.1, { autoAlpha: 1, force3D: "auto", ease: punchgs.Power3.easeInOut })
                                                    : punchgs.TweenLite.to(o.find(".tp-videoposter"), 0.1, { autoAlpha: 1, force3D: "auto", ease: punchgs.Power3.easeInOut }),
                                                punchgs.TweenLite.to(o.find("iframe"), 0.1, { autoAlpha: 0, ease: punchgs.Power3.easeInOut })),
                                                -1 != e.data &&
                                                    3 != e.data &&
                                                    ((n.videoplaying = !1),
                                                    (n.tonpause = !1),
                                                    C(o, n),
                                                    t.trigger("starttimer"),
                                                    n.c.trigger("revolution.slide.onvideostop", w(d, "youtube", o.data())),
                                                    (null != n.currentLayerVideoIsPlaying && n.currentLayerVideoIsPlaying.attr("id") != o.attr("id")) || L.unToggleState(l.videotoggledby)),
                                                0 == e.data && 1 == o.data("nextslideatend")
                                                    ? (b(), o.data("nextslideatend-triggered", 1), n.c.revnext(), C(o, n))
                                                    : (C(o, n),
                                                      (n.videoplaying = !1),
                                                      t.trigger("starttimer"),
                                                      n.c.trigger("revolution.slide.onvideostop", w(d, "youtube", o.data())),
                                                      (null != n.currentLayerVideoIsPlaying && n.currentLayerVideoIsPlaying.attr("id") != o.attr("id")) || L.unToggleState(l.videotoggledby));
                                        }
                                    },
                                    onReady: function (e) {
                                        var t,
                                            i = L.is_mobile(),
                                            a = o.hasClass("tp-videolayer");
                                        if (i || L.isSafari11()) {
                                            var n = a && "off" !== o.data("autoplay");
                                            (o.hasClass("rs-background-video-layer") || n) &&
                                                ((i && a) ||
                                                    ((t = !0),
                                                    d.setVolume(0),
                                                    o.data("volume", "mute"),
                                                    d.mute(),
                                                    clearTimeout(o.data("mobilevideotimr")),
                                                    o.data(
                                                        "mobilevideotimr",
                                                        setTimeout(function () {
                                                            d.playVideo();
                                                        }, 500)
                                                    )));
                                        }
                                        t || "mute" != o.data("volume") || (d.setVolume(0), d.mute());
                                        var r = l.videorate;
                                        if (
                                            (o.data("videostart"),
                                            o.addClass("rs-apiready"),
                                            null != r && e.target.setPlaybackRate(parseFloat(r)),
                                            o.find(".tp-videoposter").unbind("click"),
                                            o.find(".tp-videoposter").click(function () {
                                                O || d.playVideo();
                                            }),
                                            o.data("startvideonow"))
                                        ) {
                                            l.player.playVideo();
                                            var s = R(o.data("videostartat"));
                                            -1 != s && l.player.seekTo(s);
                                        }
                                        o.data("videolistenerexist", 1);
                                    },
                                },
                            });
                            o.data("player", d);
                            break;
                        case "vimeo":
                            for (var a, c = t.attr("src"), u = {}, h = c, p = /([^&=]+)=([^&]*)/g; (a = p.exec(h)); ) u[decodeURIComponent(a[1])] = decodeURIComponent(a[2]);
                            c = (c = null != u.player_id ? c.replace(u.player_id, i) : c + "&player_id=" + i).replace(/&api=0|&api=1/g, "");
                            var f = L.is_mobile(),
                                g = o.data("autoplay"),
                                m = (o.data("volume"), f || L.isSafari11());
                            o.hasClass("rs-background-video-layer"),
                                (g = "on" === g || "true" === g || !0 === g) && m && ((c += "?autoplay=1&autopause=0&muted=1&background=1&playsinline=1"), o.data({ vimeoplaysinline: !0, volume: "mute" })),
                                t.attr("src", c),
                                (d = o.find("iframe")[0]),
                                jQuery("#" + i),
                                o.data("vimeoplayer") ? (y = o.data("vimeoplayer")) : ((y = new Vimeo.Player(i)), o.data("vimeoplayer", y)),
                                y.on("loaded", function (e) {
                                    var t = {};
                                    y.getVideoWidth().then(function (e) {
                                        (t.width = e), void 0 !== t.width && void 0 !== t.height && (o.data("aspectratio", t.width + ":" + t.height), o.data("vimeoplayerloaded", !0), _(n, o));
                                    }),
                                        y.getVideoHeight().then(function (e) {
                                            (t.height = e), void 0 !== t.width && void 0 !== t.height && (o.data("aspectratio", t.width + ":" + t.height), o.data("vimeoplayerloaded", !0), _(n, o));
                                        });
                                }),
                                o.addClass("rs-apiready"),
                                y.on("play", function (e) {
                                    o.data("nextslidecalled", 0),
                                        punchgs.TweenLite.to(o.find(".tp-videoposter"), 0.3, { autoAlpha: 0, force3D: "auto", ease: punchgs.Power3.easeInOut }),
                                        punchgs.TweenLite.to(o.find("iframe"), 0.3, { autoAlpha: 1, display: "block", ease: punchgs.Power3.easeInOut }),
                                        n.c.trigger("revolution.slide.onvideoplay", w(y, "vimeo", o.data())),
                                        (n.videoplaying = !0),
                                        T(o, n),
                                        s ? n.c.trigger("stoptimer") : (n.videoplaying = !1),
                                        o.data("vimeoplaysinline") ||
                                            ("mute" == o.data("volume") || L.lastToggleState(o.data("videomutetoggledby")) || !0 === n.globalmute ? y.setVolume(0) : y.setVolume(parseInt(o.data("volume"), 0) / 100 || 0.75),
                                            L.toggleState(l.videotoggledby));
                                }),
                                y.on("timeupdate", function (e) {
                                    var t = R(o.data("videoendat"));
                                    if ((o.data("currenttime", e.seconds), 0 != t && Math.abs(t - e.seconds) < 1 && t > e.seconds && 1 != o.data("nextslidecalled")))
                                        if (r) {
                                            y.play();
                                            var i = R(o.data("videostartat"));
                                            -1 != i && y.setCurrentTime(i);
                                        } else 1 == o.data("nextslideatend") && (o.data("nextslideatend-triggered", 1), o.data("nextslidecalled", 1), n.c.revnext()), y.pause();
                                }),
                                y.on("ended", function (e) {
                                    C(o, n),
                                        (n.videoplaying = !1),
                                        n.c.trigger("starttimer"),
                                        n.c.trigger("revolution.slide.onvideostop", w(y, "vimeo", o.data())),
                                        1 == o.data("nextslideatend") && (o.data("nextslideatend-triggered", 1), n.c.revnext()),
                                        (null != n.currentLayerVideoIsPlaying && n.currentLayerVideoIsPlaying.attr("id") != o.attr("id")) || L.unToggleState(l.videotoggledby);
                                }),
                                y.on("pause", function (e) {
                                    (("on" == o.data("showcoveronpause") && 0 < o.find(".tp-videoposter").length) || (1 === o.data("bgvideo") && 0 < o.find(".rs-fullvideo-cover").length)) &&
                                        (1 === o.data("bgvideo")
                                            ? punchgs.TweenLite.to(o.find(".rs-fullvideo-cover"), 0.1, { autoAlpha: 1, force3D: "auto", ease: punchgs.Power3.easeInOut })
                                            : punchgs.TweenLite.to(o.find(".tp-videoposter"), 0.1, { autoAlpha: 1, force3D: "auto", ease: punchgs.Power3.easeInOut }),
                                        punchgs.TweenLite.to(o.find("iframe"), 0.1, { autoAlpha: 0, ease: punchgs.Power3.easeInOut })),
                                        (n.videoplaying = !1),
                                        (n.tonpause = !1),
                                        C(o, n),
                                        n.c.trigger("starttimer"),
                                        n.c.trigger("revolution.slide.onvideostop", w(y, "vimeo", o.data())),
                                        (null != n.currentLayerVideoIsPlaying && n.currentLayerVideoIsPlaying.attr("id") != o.attr("id")) || L.unToggleState(l.videotoggledby);
                                }),
                                o.find(".tp-videoposter").unbind("click"),
                                o.find(".tp-videoposter").click(function () {
                                    if (!O) return y.play(), !1;
                                }),
                                o.data("startvideonow") && (y.play(), -1 != (v = R(o.data("videostartat"))) && y.setCurrentTime(v)),
                                o.data("videolistenerexist", 1);
                    }
                else {
                    var v = R(o.data("videostartat"));
                    switch (l.videotype) {
                        case "youtube":
                            e && (l.player.playVideo(), -1 != v && l.player.seekTo());
                            break;
                        case "vimeo":
                            var y;
                            e && ((y = o.data("vimeoplayer")).play(), -1 != v && y.seekTo(v));
                    }
                }
            },
            b = function () {
                document.exitFullscreen ? document.exitFullscreen() : document.mozCancelFullScreen ? document.mozCancelFullScreen() : document.webkitExitFullscreen && document.webkitExitFullscreen();
            },
            x = function () {
                try {
                    if (void 0 !== window.fullScreen) return window.fullScreen;
                    var e = 5;
                    return jQuery.browser.webkit && /Apple Computer/.test(navigator.vendor) && (e = 42), screen.width == window.innerWidth && Math.abs(screen.height - window.innerHeight) < e;
                } catch (e) {}
            },
            Q = function (n, r, e) {
                if (O && 1 == n.data("disablevideoonmobile")) return !1;
                var s = n.data(),
                    t = "html5" == s.audio ? "audio" : "video",
                    i = n.find(t),
                    o = i[0],
                    a = i.parent(),
                    l = s.videoloop,
                    d = "loopandnoslidestop" != l;
                if (
                    ((l = "loop" == l || "loopandnoslidestop" == l),
                    a.data("metaloaded", 1),
                    1 != n.data("bgvideo") || ("none" !== s.videoloop && !1 !== s.videoloop) || (d = !1),
                    null == i.attr("control") &&
                        (0 != n.find(".tp-video-play-button").length || O || n.append('<div class="tp-video-play-button"><i class="revicon-right-dir"></i><span class="tp-revstop">&nbsp;</span></div>'),
                        n.find("video, .tp-poster, .tp-video-play-button").click(function () {
                            n.hasClass("videoisplaying") ? o.pause() : o.play();
                        })),
                    1 == n.data("forcecover") || n.hasClass("fullscreenvideo") || 1 == n.data("bgvideo"))
                )
                    if (1 == n.data("forcecover") || 1 == n.data("bgvideo")) {
                        a.addClass("fullcoveredvideo");
                        var c = n.data("aspectratio");
                        (void 0 !== c && 1 != c.split(":").length) || n.data("aspectratio", "16:9"), L.prepareCoveredVideo(r, n);
                    } else a.addClass("fullscreenvideo");
                var u = n.find(".tp-vid-play-pause")[0],
                    h = n.find(".tp-vid-mute")[0],
                    p = n.find(".tp-vid-full-screen")[0],
                    f = n.find(".tp-seek-bar")[0],
                    g = n.find(".tp-volume-bar")[0];
                null != u &&
                    I(u, "click", function () {
                        1 == o.paused ? o.play() : o.pause();
                    }),
                    null != h &&
                        I(h, "click", function () {
                            0 == o.muted ? ((o.muted = !0), (h.innerHTML = "Unmute")) : ((o.muted = !1), (h.innerHTML = "Mute"));
                        }),
                    null != p &&
                        p &&
                        I(p, "click", function () {
                            o.requestFullscreen ? o.requestFullscreen() : o.mozRequestFullScreen ? o.mozRequestFullScreen() : o.webkitRequestFullscreen && o.webkitRequestFullscreen();
                        }),
                    null != f &&
                        (I(f, "change", function () {
                            var e = o.duration * (f.value / 100);
                            o.currentTime = e;
                        }),
                        I(f, "mousedown", function () {
                            n.addClass("seekbardragged"), o.pause();
                        }),
                        I(f, "mouseup", function () {
                            n.removeClass("seekbardragged"), o.play();
                        })),
                    I(o, "canplaythrough", function () {
                        L.preLoadAudioDone(n, r, "canplaythrough");
                    }),
                    I(o, "canplay", function () {
                        L.preLoadAudioDone(n, r, "canplay");
                    }),
                    I(o, "progress", function () {
                        L.preLoadAudioDone(n, r, "progress");
                    }),
                    I(o, "timeupdate", function () {
                        var e = (100 / o.duration) * o.currentTime,
                            t = R(n.data("videoendat")),
                            i = o.currentTime;
                        if ((null != f && (f.value = e), 0 != t && -1 != t && Math.abs(t - i) <= 0.3 && i < t && 1 != n.data("nextslidecalled")))
                            if (l) {
                                o.play();
                                var a = R(n.data("videostartat"));
                                -1 != a && (o.currentTime = a);
                            } else
                                1 == n.data("nextslideatend") &&
                                    (n.data("nextslideatend-triggered", 1),
                                    n.data("nextslidecalled", 1),
                                    (r.just_called_nextslide_at_htmltimer = !0),
                                    r.c.revnext(),
                                    setTimeout(function () {
                                        r.just_called_nextslide_at_htmltimer = !1;
                                    }, 1e3)),
                                    o.pause();
                    }),
                    null != g &&
                        I(g, "change", function () {
                            o.volume = g.value;
                        }),
                    I(o, "play", function () {
                        n.data("nextslidecalled", 0);
                        var e = n.data("volume");
                        (e = null != e && "mute" != e ? parseFloat(e) / 100 : e),
                            L.is_mobile() || L.isSafari11() || (!0 === r.globalmute ? (o.muted = !0) : (o.muted = !1), 1 < e && (e /= 100), "mute" == e ? (o.muted = !0) : null != e && (o.volume = e)),
                            n.addClass("videoisplaying");
                        var t = "html5" == s.audio ? "audio" : "video";
                        T(n, r),
                            d && "audio" != t
                                ? ((r.videoplaying = !0), r.c.trigger("stoptimer"), r.c.trigger("revolution.slide.onvideoplay", w(o, "html5", s)))
                                : ((r.videoplaying = !1), "audio" != t && r.c.trigger("starttimer"), r.c.trigger("revolution.slide.onvideostop", w(o, "html5", s))),
                            punchgs.TweenLite.to(n.find(".tp-videoposter"), 0.3, { autoAlpha: 0, force3D: "auto", ease: punchgs.Power3.easeInOut }),
                            punchgs.TweenLite.to(n.find(t), 0.3, { autoAlpha: 1, display: "block", ease: punchgs.Power3.easeInOut });
                        var i = n.find(".tp-vid-play-pause")[0],
                            a = n.find(".tp-vid-mute")[0];
                        null != i && (i.innerHTML = "Pause"), null != a && o.muted && (a.innerHTML = "Unmute"), L.toggleState(s.videotoggledby);
                    }),
                    I(o, "pause", function (e) {
                        var t = "html5" == s.audio ? "audio" : "video";
                        !x() &&
                            0 < n.find(".tp-videoposter").length &&
                            "on" == n.data("showcoveronpause") &&
                            !n.hasClass("seekbardragged") &&
                            (punchgs.TweenLite.to(n.find(".tp-videoposter"), 0.3, { autoAlpha: 1, force3D: "auto", ease: punchgs.Power3.easeInOut }), punchgs.TweenLite.to(n.find(t), 0.3, { autoAlpha: 0, ease: punchgs.Power3.easeInOut })),
                            n.removeClass("videoisplaying"),
                            (r.videoplaying = !1),
                            C(n, r),
                            "audio" != t && r.c.trigger("starttimer"),
                            r.c.trigger("revolution.slide.onvideostop", w(o, "html5", n.data()));
                        var i = n.find(".tp-vid-play-pause")[0];
                        null != i && (i.innerHTML = "Play"), (null != r.currentLayerVideoIsPlaying && r.currentLayerVideoIsPlaying.attr("id") != n.attr("id")) || L.unToggleState(s.videotoggledby);
                    }),
                    I(o, "ended", function () {
                        b(),
                            C(n, r),
                            (r.videoplaying = !1),
                            C(n, r),
                            "audio" != t && r.c.trigger("starttimer"),
                            r.c.trigger("revolution.slide.onvideostop", w(o, "html5", n.data())),
                            !0 === n.data("nextslideatend") &&
                                0 < o.currentTime &&
                                (1 == !r.just_called_nextslide_at_htmltimer && (n.data("nextslideatend-triggered", 1), r.c.revnext(), (r.just_called_nextslide_at_htmltimer = !0)),
                                setTimeout(function () {
                                    r.just_called_nextslide_at_htmltimer = !1;
                                }, 1500)),
                            n.removeClass("videoisplaying");
                    });
            },
            T = function (e, i) {
                null == i.playingvideos && (i.playingvideos = new Array()),
                    e.data("stopallvideos") &&
                        null != i.playingvideos &&
                        0 < i.playingvideos.length &&
                        ((i.lastplayedvideos = jQuery.extend(!0, [], i.playingvideos)),
                        jQuery.each(i.playingvideos, function (e, t) {
                            L.stopVideo(t, i);
                        })),
                    i.playingvideos.push(e),
                    (i.currentLayerVideoIsPlaying = e);
            },
            C = function (e, t) {
                null != t.playingvideos && 0 <= jQuery.inArray(e, t.playingvideos) && t.playingvideos.splice(jQuery.inArray(e, t.playingvideos), 1);
            };
    })(jQuery);
//# sourceMappingURL=scripts.min.js.map
