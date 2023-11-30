// Class definition

var KTBootstrapDatepicker = function () {

    var arrows;
    if (KTUtil.isRTL()) {
        arrows = {
            leftArrow: '<i class="la la-angle-right"></i>',
            rightArrow: '<i class="la la-angle-left"></i>'
        }
    } else {
        arrows = {
            leftArrow: '<i class="la la-angle-left"></i>',
            rightArrow: '<i class="la la-angle-right"></i>'
        }
    }
    
    // Private functions
    var demos = function () {
        // minimum setup
        $('#kt_datepicker_1, #kt_datepicker_1_validate').datepicker({
            rtl: KTUtil.isRTL(),
            todayHighlight: true,
            orientation: "bottom left",
            templates: arrows
        });

        // minimum setup for modal demo
        $('#kt_datepicker_1_modal').datepicker({
            rtl: KTUtil.isRTL(),
            todayHighlight: true,
            orientation: "bottom left",
            templates: arrows
        });

        // input group layout 
        $('#kt_datepicker_2, #kt_datepicker_2_validate').datepicker({
            rtl: KTUtil.isRTL(),
            todayHighlight: true,
            orientation: "bottom left",
            templates: arrows
        });

        // input group layout for modal demo
        $('#kt_datepicker_2_modal').datepicker({
            rtl: KTUtil.isRTL(),
            todayHighlight: true,
            orientation: "bottom left",
            templates: arrows
        });        

        // enable clear button 
        $('#kt_datepicker_3, #kt_datepicker_3_validate').datepicker({
            rtl: false,
            todayBtn: "linked",
            clearBtn: true,
            todayHighlight: true,
            templates: arrows,
            format: 'dd.mm.yyyy',
            weekStart: 1,
            autoclose: true
        });

        // enable clear button for modal demo
        $('#kt_datepicker_3_modal').datepicker({
            rtl: false,
            todayBtn: "linked",
            clearBtn: true,
            todayHighlight: true,
            templates: arrows,
            format: 'dd.mm.yyyy',
            weekStart: 1,
            autoclose: true
        });

        $('#kt_datepicker_3').mask('00.00.0000', { placeholder: "dd.mm.yyyy" });

        // enable clear button 
        $('#kt_datepicker_3_1, #kt_datepicker_3_1_validate').datepicker({
            rtl: false,
            todayBtn: "linked",
            clearBtn: true,
            todayHighlight: true,
            templates: arrows,
            format: 'dd.mm.yyyy',
            weekStart: 1,
            autoclose: true
        });

        // enable clear button for modal demo
        $('#kt_datepicker_3_1_modal').datepicker({
            rtl: false,
            todayBtn: "linked",
            clearBtn: true,
            todayHighlight: true,
            templates: arrows,
            format: 'dd.mm.yyyy',
            weekStart: 1,
            autoclose: true
        });

        $('#kt_datepicker_3_1').mask('00.00.0000', { placeholder: "dd.mm.yyyy" });


        // enable clear button 
        $('#kt_datepicker_3_2, #kt_datepicker_3_2_validate').datepicker({
            rtl: false,
            todayBtn: "linked",
            clearBtn: true,
            todayHighlight: true,
            templates: arrows,
            format: 'dd.mm.yyyy',
            weekStart: 1,
            autoclose: true
        });

        // enable clear button for modal demo
        $('#kt_datepicker_3_2_modal').datepicker({
            rtl: false,
            todayBtn: "linked",
            clearBtn: true,
            todayHighlight: true,
            templates: arrows,
            format: 'dd.mm.yyyy',
            weekStart: 1,
            autoclose: true
        });

        $('#kt_datepicker_3_2').mask('00.00.0000', { placeholder: "dd.mm.yyyy" });


        // enable clear button 
        $('#kt_datepicker_3_3, #kt_datepicker_3_3_validate').datepicker({
            rtl: false,
            todayBtn: "linked",
            clearBtn: true,
            todayHighlight: true,
            templates: arrows,
            format: 'dd.mm.yyyy',
            weekStart: 1,
            autoclose: true
        });

        // enable clear button for modal demo
        $('#kt_datepicker_3_3_modal').datepicker({
            rtl: false,
            todayBtn: "linked",
            clearBtn: true,
            todayHighlight: true,
            templates: arrows,
            format: 'dd.mm.yyyy',
            weekStart: 1,
            autoclose: true
        });

        $('#kt_datepicker_3_3').mask('00.00.0000', { placeholder: "dd.mm.yyyy" });

        // enable clear button 
        $('#kt_datepicker_3_4, #kt_datepicker_3_4_validate').datepicker({
            rtl: false,
            todayBtn: "linked",
            clearBtn: true,
            todayHighlight: true,
            templates: arrows,
            format: 'dd.mm.yyyy',
            weekStart: 1,
            autoclose: true
        });

        // enable clear button for modal demo
        $('#kt_datepicker_3_4_modal').datepicker({
            rtl: false,
            todayBtn: "linked",
            clearBtn: true,
            todayHighlight: true,
            templates: arrows,
            format: 'dd.mm.yyyy',
            weekStart: 1,
            autoclose: true
        });

        $('#kt_datepicker_3_4').mask('00.00.0000', { placeholder: "dd.mm.yyyy" });


        // enable clear button 
        $('#kt_datepicker_3_5, #kt_datepicker_3_5_validate').datepicker({
            rtl: false,
            todayBtn: "linked",
            clearBtn: true,
            todayHighlight: true,
            templates: arrows,
            format: 'dd.mm.yyyy',
            weekStart: 1,
            autoclose: true
        });

        // enable clear button for modal demo
        $('#kt_datepicker_3_5_modal').datepicker({
            rtl: false,
            todayBtn: "linked",
            clearBtn: true,
            todayHighlight: true,
            templates: arrows,
            format: 'dd.mm.yyyy',
            weekStart: 1,
            autoclose: true
        });

        $('#kt_datepicker_3_5').mask('00.00.0000', { placeholder: "dd.mm.yyyy" });



        // orientation 
        $('#kt_datepicker_4_1').datepicker({
            rtl: KTUtil.isRTL(),
            orientation: "top left",
            todayHighlight: true,
            templates: arrows
        });

        $('#kt_datepicker_4_2').datepicker({
            rtl: KTUtil.isRTL(),
            orientation: "top right",
            todayHighlight: true,
            templates: arrows
        });

        $('#kt_datepicker_4_3').datepicker({
            rtl: KTUtil.isRTL(),
            orientation: "bottom left",
            todayHighlight: true,
            templates: arrows
        });

        $('#kt_datepicker_4_4').datepicker({
            rtl: KTUtil.isRTL(),
            orientation: "bottom right",
            todayHighlight: true,
            templates: arrows
        });

        // range picker
        $('#kt_datepicker_5').datepicker({
            rtl: KTUtil.isRTL(),
            todayHighlight: true,
            templates: arrows
        });

         // inline picker
        $('#kt_datepicker_6').datepicker({
            rtl: KTUtil.isRTL(),
            todayHighlight: true,
            templates: arrows
        });
    }

    return {
        // public functions
        init: function() {
            demos(); 
        }
    };
}();

jQuery(document).ready(function() {    
    KTBootstrapDatepicker.init();
});