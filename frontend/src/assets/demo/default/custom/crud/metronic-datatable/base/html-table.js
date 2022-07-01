var DatatableHtmlTableDemo = {
    init: function () {
        var e;
        e = $(".m-datatable").mDatatable({
            data: {
                saveState: {
                    cookie: !1
                },
                pageSize : 100
            },
            search: {
                input: $("#generalSearch")
            },
            columns: [{
                field: "Deposit Paid",
                type: "number"
            }, {
                field: "Order Date",
                type: "date",
                format: "YYYY-MM-DD"
            }, {
                field: "Status",
                title: "Status",
                template: function (e) {
                    var t = {
                        1: {
                            title: "Pending",
                            class: "m-badge--brand"
                        },
                        2: {
                            title: "In Progress",
                            class: " m-badge--danger"
                        },
                        3: {
                            title: "Completed",
                            class: " m-badge--success"
                        },
                        4: {
                            title: "Success",
                            class: " m-badge--success"
                        },
                        5: {
                            title: "Info",
                            class: " m-badge--info"
                        },
                        6: {
                            title: "Danger",
                            class: " m-badge--danger"
                        },
                        7: {
                            title: "Warning",
                            class: " m-badge--warning"
                        }
                    };
                    return '<span class="m-badge ' + t[e.Status].class + ' m-badge--wide">' + t[e.Status].title + "</span>"
                }
            }, {
                field: "Type",
                title: "Type",
                template: function (e) {
                    var t = {
                        1: {
                            title: "Online",
                            state: "danger"
                        },
                        2: {
                            title: "Retail",
                            state: "primary"
                        },
                        3: {
                            title: "Direct",
                            state: "accent"
                        }
                    };
                    return '<span class="m-badge m-badge--' + t[e.Type].state + ' m-badge--dot"></span>&nbsp;<span class="m--font-bold m--font-' + t[e.Type].state + '">' + t[e.Type].title + "</span>"
                }
            }]
        }),

            $("#m_form_status").on("change", function () {
                e.search($(this).val().toLowerCase(), "Status")
            }),
            $("#m_form_type").on("change", function () {
                e.search($(this).val().toLowerCase(), "Type")
            }),
            $("#m_form_status, #m_form_type").selectpicker()

        var a;
        a = $(".m-datatable1").mDatatable({
            data: {
                saveState: {
                    cookie: !1
                }
            },
            search: {
                input: $("#generalSearch")
            },
            columns: [{
                field: "Deposit Paid",
                type: "number"
            }, {
                field: "Order Date",
                type: "date",
                format: "YYYY-MM-DD"
            }, {
                field: "Status",
                title: "Status",
                template: function (a) {
                    var t = {
                        1: {
                            title: "Pending",
                            class: "m-badge--brand"
                        },
                        2: {
                            title: "In Progress",
                            class: " m-badge--danger"
                        },
                        3: {
                            title: "Completed",
                            class: " m-badge--success"
                        },
                        4: {
                            title: "Success",
                            class: " m-badge--success"
                        },
                        5: {
                            title: "Info",
                            class: " m-badge--info"
                        },
                        6: {
                            title: "Danger",
                            class: " m-badge--danger"
                        },
                        7: {
                            title: "Warning",
                            class: " m-badge--warning"
                        }
                    };
                    return '<span class="m-badge ' + t[a.Status].class + ' m-badge--wide">' + t[a.Status].title + "</span>"
                }
            }, {
                field: "Type",
                title: "Type",
                template: function (a) {
                    var t = {
                        1: {
                            title: "Online",
                            state: "danger"
                        },
                        2: {
                            title: "Retail",
                            state: "primary"
                        },
                        3: {
                            title: "Direct",
                            state: "accent"
                        }
                    };
                    return '<span class="m-badge m-badge--' + t[a.Type].state + ' m-badge--dot"></span>&nbsp;<span class="m--font-bold m--font-' + t[a.Type].state + '">' + t[a.Type].title + "</span>"
                }
            }]
        }),

            $("#m_form_status").on("change", function () {
                a.search($(this).val().toLowerCase(), "Status")
            }),
            $("#m_form_type").on("change", function () {
                a.search($(this).val().toLowerCase(), "Type")
            }),
            $("#m_form_status, #m_form_type").selectpicker()

        var b;
        b = $(".m-datatable2").mDatatable({
            data: {
                saveState: {
                    cookie: !1
                }
            },
            search: {
                input: $("#generalSearch")
            },
            columns: [{
                field: "Deposit Paid",
                type: "number"
            }, {
                field: "Order Date",
                type: "date",
                format: "YYYY-MM-DD"
            }, {
                field: "Status",
                title: "Status",
                template: function (b) {
                    var t = {
                        1: {
                            title: "Pending",
                            class: "m-badge--brand"
                        },
                        2: {
                            title: "In Progress",
                            class: " m-badge--danger"
                        },
                        3: {
                            title: "Completed",
                            class: " m-badge--success"
                        },
                        4: {
                            title: "Success",
                            class: " m-badge--success"
                        },
                        5: {
                            title: "Info",
                            class: " m-badge--info"
                        },
                        6: {
                            title: "Danger",
                            class: " m-badge--danger"
                        },
                        7: {
                            title: "Warning",
                            class: " m-badge--warning"
                        }
                    };
                    return '<span class="m-badge ' + t[b.Status].class + ' m-badge--wide">' + t[b.Status].title + "</span>"
                }
            }, {
                field: "Type",
                title: "Type",
                template: function (b) {
                    var t = {
                        1: {
                            title: "Online",
                            state: "danger"
                        },
                        2: {
                            title: "Retail",
                            state: "primary"
                        },
                        3: {
                            title: "Direct",
                            state: "accent"
                        }
                    };
                    return '<span class="m-badge m-badge--' + t[b.Type].state + ' m-badge--dot"></span>&nbsp;<span class="m--font-bold m--font-' + t[b.Type].state + '">' + t[b.Type].title + "</span>"
                }
            }]
        }),

            $("#m_form_status").on("change", function () {
                b.search($(this).val().toLowerCase(), "Status")
            }),
            $("#m_form_type").on("change", function () {
                b.search($(this).val().toLowerCase(), "Type")
            }),
            $("#m_form_status, #m_form_type").selectpicker()
            
        var c;
        c = $(".m-datatable3").mDatatable({
            data: {
                saveState: {
                    cookie: !1
                }
            },
            search: {
                input: $("#generalSearch")
            },
            columns: [{
                field: "Deposit Paid",
                type: "number"
            }, {
                field: "Order Date",
                type: "date",
                format: "YYYY-MM-DD"
            }, {
                field: "Status",
                title: "Status",
                template: function (c) {
                    var t = {
                        1: {
                            title: "Pending",
                            class: "m-badge--brand"
                        },
                        2: {
                            title: "In Progress",
                            class: " m-badge--danger"
                        },
                        3: {
                            title: "Completed",
                            class: " m-badge--success"
                        },
                        4: {
                            title: "Success",
                            class: " m-badge--success"
                        },
                        5: {
                            title: "Info",
                            class: " m-badge--info"
                        },
                        6: {
                            title: "Danger",
                            class: " m-badge--danger"
                        },
                        7: {
                            title: "Warning",
                            class: " m-badge--warning"
                        }
                    };
                    return '<span class="m-badge ' + t[c.Status].class + ' m-badge--wide">' + t[c.Status].title + "</span>"
                }
            }, {
                field: "Type",
                title: "Type",
                template: function (c) {
                    var t = {
                        1: {
                            title: "Online",
                            state: "danger"
                        },
                        2: {
                            title: "Retail",
                            state: "primary"
                        },
                        3: {
                            title: "Direct",
                            state: "accent"
                        }
                    };
                    return '<span class="m-badge m-badge--' + t[c.Type].state + ' m-badge--dot"></span>&nbsp;<span class="m--font-bold m--font-' + t[c.Type].state + '">' + t[c.Type].title + "</span>"
                }
            }]
        }),

            $("#m_form_status").on("change", function () {
                c.search($(this).val().toLowerCase(), "Status")
            }),
            $("#m_form_type").on("change", function () {
                c.search($(this).val().toLowerCase(), "Type")
            }),
            $("#m_form_status, #m_form_type").selectpicker()

        var d;
        d = $(".m-datatable4").mDatatable({
            data: {
                saveState: {
                    cookie: !1
                }
            },
            search: {
                input: $("#generalSearch")
            },
            columns: [{
                field: "Deposit Paid",
                type: "number"
            }, {
                field: "Order Date",
                type: "date",
                format: "YYYY-MM-DD"
            }, {
                field: "Status",
                title: "Status",
                template: function (d) {
                    var t = {
                        1: {
                            title: "Pending",
                            class: "m-badge--brand"
                        },
                        2: {
                            title: "In Progress",
                            class: " m-badge--danger"
                        },
                        3: {
                            title: "Completed",
                            class: " m-badge--success"
                        },
                        4: {
                            title: "Success",
                            class: " m-badge--success"
                        },
                        5: {
                            title: "Info",
                            class: " m-badge--info"
                        },
                        6: {
                            title: "Danger",
                            class: " m-badge--danger"
                        },
                        7: {
                            title: "Warning",
                            class: " m-badge--warning"
                        }
                    };
                    return '<span class="m-badge ' + t[d.Status].class + ' m-badge--wide">' + t[d.Status].title + "</span>"
                }
            }, {
                field: "Type",
                title: "Type",
                template: function (d) {
                    var t = {
                        1: {
                            title: "Online",
                            state: "danger"
                        },
                        2: {
                            title: "Retail",
                            state: "primary"
                        },
                        3: {
                            title: "Direct",
                            state: "accent"
                        }
                    };
                    return '<span class="m-badge m-badge--' + t[d.Type].state + ' m-badge--dot"></span>&nbsp;<span class="m--font-bold m--font-' + t[d.Type].state + '">' + t[d.Type].title + "</span>"
                }
            }]
        }),

            $("#m_form_status").on("change", function () {
                d.search($(this).val().toLowerCase(), "Status")
            }),
            $("#m_form_type").on("change", function () {
                d.search($(this).val().toLowerCase(), "Type")
            }),
            $("#m_form_status, #m_form_type").selectpicker()

        var f;
        f = $(".m-datatable5").mDatatable({
            data: {
                saveState: {
                    cookie: !1
                }
            },
            search: {
                input: $("#generalSearch")
            },
            columns: [{
                field: "Deposit Paid",
                type: "number"
            }, {
                field: "Order Date",
                type: "date",
                format: "YYYY-MM-DD"
            }, {
                field: "Status",
                title: "Status",
                template: function (f) {
                    var t = {
                        1: {
                            title: "Pending",
                            class: "m-badge--brand"
                        },
                        2: {
                            title: "In Progress",
                            class: " m-badge--danger"
                        },
                        3: {
                            title: "Completed",
                            class: " m-badge--success"
                        },
                        4: {
                            title: "Success",
                            class: " m-badge--success"
                        },
                        5: {
                            title: "Info",
                            class: " m-badge--info"
                        },
                        6: {
                            title: "Danger",
                            class: " m-badge--danger"
                        },
                        7: {
                            title: "Warning",
                            class: " m-badge--warning"
                        }
                    };
                    return '<span class="m-badge ' + t[f.Status].class + ' m-badge--wide">' + t[f.Status].title + "</span>"
                }
            }, {
                field: "Type",
                title: "Type",
                template: function (f) {
                    var t = {
                        1: {
                            title: "Online",
                            state: "danger"
                        },
                        2: {
                            title: "Retail",
                            state: "primary"
                        },
                        3: {
                            title: "Direct",
                            state: "accent"
                        }
                    };
                    return '<span class="m-badge m-badge--' + t[f.Type].state + ' m-badge--dot"></span>&nbsp;<span class="m--font-bold m--font-' + t[f.Type].state + '">' + t[f.Type].title + "</span>"
                }
            }]
        }),

            $("#m_form_status").on("change", function () {
                f.search($(this).val().toLowerCase(), "Status")
            }),
            $("#m_form_type").on("change", function () {
                f.search($(this).val().toLowerCase(), "Type")
            }),
            $("#m_form_status, #m_form_type").selectpicker()

        var g;
        g = $(".m-datatable6").mDatatable({
            data: {
                saveState: {
                    cookie: !1
                }
            },
            search: {
                input: $("#generalSearch")
            },
            columns: [{
                field: "Deposit Paid",
                type: "number"
            }, {
                field: "Order Date",
                type: "date",
                format: "YYYY-MM-DD"
            }, {
                field: "Status",
                title: "Status",
                template: function (g) {
                    var t = {
                        1: {
                            title: "Pending",
                            class: "m-badge--brand"
                        },
                        2: {
                            title: "In Progress",
                            class: " m-badge--danger"
                        },
                        3: {
                            title: "Completed",
                            class: " m-badge--success"
                        },
                        4: {
                            title: "Success",
                            class: " m-badge--success"
                        },
                        5: {
                            title: "Info",
                            class: " m-badge--info"
                        },
                        6: {
                            title: "Danger",
                            class: " m-badge--danger"
                        },
                        7: {
                            title: "Warning",
                            class: " m-badge--warning"
                        }
                    };
                    return '<span class="m-badge ' + t[g.Status].class + ' m-badge--wide">' + t[g.Status].title + "</span>"
                }
            }, {
                field: "Type",
                title: "Type",
                template: function (g) {
                    var t = {
                        1: {
                            title: "Online",
                            state: "danger"
                        },
                        2: {
                            title: "Retail",
                            state: "primary"
                        },
                        3: {
                            title: "Direct",
                            state: "accent"
                        }
                    };
                    return '<span class="m-badge m-badge--' + t[g.Type].state + ' m-badge--dot"></span>&nbsp;<span class="m--font-bold m--font-' + t[g.Type].state + '">' + t[g.Type].title + "</span>"
                }
            }]
        }),

            $("#m_form_status").on("change", function () {
                g.search($(this).val().toLowerCase(), "Status")
            }),
            $("#m_form_type").on("change", function () {
                g.search($(this).val().toLowerCase(), "Type")
            }),
            $("#m_form_status, #m_form_type").selectpicker()
    }
};
jQuery(document).ready(function () {
    DatatableHtmlTableDemo.init()
});
