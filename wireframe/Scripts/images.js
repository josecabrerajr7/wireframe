$(function () {

    var filterList = {

        init: function () {

            // MixItUp plugin
            // http://mixitup.io
            $('#portfoliolist').mixItUp({
                targetSelector: '.mix',
                filterSelector: '.filter',
                effects: ['fade'],
                easing: 'snap',
                // call the hover effect
                onMixEnd: filterList.hoverEffect()
            });

        },

        hoverEffect: function () {

            // Simple parallax effect
            $('#portfoliolist .mix').hover(
                function () {
                    $(this).find('.label').stop().animate({ bottom: 0 }, 200, 'easeOutQuad');
                    $(this).find('img').stop().animate({ top: -30 }, 500, 'easeOutQuad');
                },
                function () {
                    $(this).find('.label').stop().animate({ bottom: -40 }, 200, 'easeInQuad');
                    $(this).find('img').stop().animate({ top: 0 }, 300, 'easeOutQuad');
                }
            );

        }

    };

    // Run the show!
    filterList.init();


});