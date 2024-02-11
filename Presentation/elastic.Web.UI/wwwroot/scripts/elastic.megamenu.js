'use strict';

var elastic = elastic || {};

elastic.megamenu = class {
	_settings = {
		wrapper: '.elastic-mega-menu'
	};

	_megaMenuEl = null;

	constructor(settings) {
		this._settings = _.defaultsDeep({}, this._settings, settings);
		this._megaMenuEl = document.querySelector(this._settings.wrapper);
		this.init();
	}

	init() {
		this.prepareEvents();
	}

	prepareEvents() {
		const menuItems = this._megaMenuEl.querySelectorAll(`ul:first-child > li`);
		const self = this;

		var hi = new elastic.hoverIntent(menuItems, {
			onEnter: function (targetItem) {
				const subContainer = targetItem.querySelector(".sub-container");
				if (subContainer == null)
					return;

				const hasFlash = targetItem.querySelectorAll(".flash");
				if (hasFlash != null)
					subContainer.classList.add("has-flash");

				targetItem.querySelector("i").classList.remove("fa-chevron-down");
				targetItem.querySelector("i").classList.add("fa-chevron-up");
				subContainer.classList.add("animate__animated", "animate__fadeIn");
				targetItem.classList.add('show');
			},
			onExit: function (targetItem) {
				const subContainer = targetItem.querySelector(".sub-container");

				if (subContainer == null)
					return;

				const hasFlash = targetItem.querySelectorAll(".flash");
				if (hasFlash != null)
					subContainer.classList.remove("has-flash");

				targetItem.querySelector("i").classList.remove("fa-chevron-up");
				targetItem.querySelector("i").classList.add("fa-chevron-down");
				targetItem.removeAttribute("class");
				targetItem.classList.remove('show');

				subContainer.classList.remove("animate__animated", "animate__fadeIn");
			},
			exitDelay: 400,
			interval: 100,
			sensitivity: 7,
		});
	}
}

