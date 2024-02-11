document.addEventListener("DOMContentLoaded", () => {
	const sliderComponentSwiper = new Swiper('.swiper.slider.component', {
		speed: 400,
		slidesPerView: 1,
		loop: true,
		//autoplay: {
		//	enabled:false,
		//	pauseOnMouseEnter: true,
		//	delay: 1000
		//},
		navigation: {
			nextEl: ".swiper.slider.component .swiper-button-next",
			prevEl: ".swiper.slider.component .swiper-button-prev",
		}
	});
});