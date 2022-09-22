/*=========================================================================================
	File Name: user-profile.js
	Description: User Profile
	----------------------------------------------------------------------------------------
	Item Name: Apex - Responsive Admin Theme
	Author: PIXINVENT
	Author URL: http://www.themeforest.net/user/pixinvent
==========================================================================================*/

$(document).ready(function () {
  // stories swipper
  var swiperLength = $(".swiper-slide").length;
  if (swiperLength) {
    swiperLength = Math.floor(swiperLength / 2)
  }
  var mySwiperStories = new Swiper('.user-profile-stories', {
    slidesPerView: 'auto',
    initialSlide: swiperLength,
    centeredSlides: true,
    spaceBetween: 15,
  });
});
