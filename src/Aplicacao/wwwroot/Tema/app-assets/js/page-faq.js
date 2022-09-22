$(document).ready(function () {
  // stories swipper
  var swiperLength = $(".swiper-slide").length;
  if (swiperLength) {
    swiperLength = Math.floor(swiperLength / 2)
  }
  var mySwiper = new Swiper('.swiper-centered-slides', {
    slidesPerView: 'auto',
    initialSlide: swiperLength,
    centeredSlides: true,
    spaceBetween: 30,
    navigation: {
      nextEl: '.swiper-button-next',
      prevEl: '.swiper-button-prev',
    },
    // active slide on click
    slideToClickedSlide: true
  });

  activeSlide(swiperLength);

  // Active slide change on swipe
  mySwiper.on('slideChange', function () {
    activeSlide(mySwiper.realIndex);
  });

  //add class active content of active slide
  function activeSlide(index) {
    var slideEl = mySwiper.slides[index]
    var slideId = $(slideEl).attr('id');
    $(".wrapper-content").removeClass("active");
    $("[data-faq=" + slideId + "]").addClass('active')
  };
});
