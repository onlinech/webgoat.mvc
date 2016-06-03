// taken from http://jsfiddle.net/BaylorRae/vwvAd/
(function ($) {
    $.fn.flashMessage = function (options) {

        options = $.extend({
            text: 'Done',
            time: 10000,
            how: 'before',
            class_name: ''
        }, options);

        return $(this).each(function () {
            if ($(this).parent().find('.flashMessage').get(0))
                return;

            var message = $('<div />', {
                'class': 'flashMessage ' + options.class_name,
                text: options.text
            }).hide().fadeIn('fast');

            $(this).html(message);

            message.delay(options.time).fadeOut('normal', function () {
                $(this).remove();
            });

        });
    };
})(jQuery);