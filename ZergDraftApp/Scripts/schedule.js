(function () {
	var schedule = $(".schedule");
	var mvcModel = MvcModel;
	var times = $(".times").children();

	renderDays(mvcModel.Days, schedule);

	var b = getVerticalDeltaInPixelsBetween(times[0], $(".days"));
	$(".scheduleDayDate").css("margin-bottom", b + "px");

	alignDays(schedule.find(".scheduleDays > .days"));
	alignBottomDates(schedule.find(".scheduleDayDate:last-child"));

	function alignBottomDates(dates) {
		var count = dates.length;
		for (var i = 0; i < count; i++) {
			alignBottomDate(dates[i]);
		}
	}

	function alignBottomDate(date) {
		//var lineHeight = +getLineHeight(times[0]);

		//$(date).css("bottom", -lineHeight);
		//$(date).css("position", "absolute");
	}

	function alignDays(days) {
		var count = days.length;
		for (var i = 0; i < count; i++) {
			alignDay(days[i]);
		}
	}

	function alignDay(day) {
		alignBlocks($(day).find(".scheduleBlock"));
	}

	function alignBlocks(blocks) {
		var count = blocks.length;

		alignBlock(blocks[0], null); // block chain: margin to the next block

		for (var i = 1; i < count; i++) {
			alignBlock(blocks[i], blocks[i - 1]);
		}
	}

	function alignBlock(currentBlock, previousBlock) {
		var currentBlockStartDate = new Date(currentBlock.dataset["start"]);
		var currentBlockEndDate = new Date(currentBlock.dataset["end"]);
		var endDateTopPosition;
		var startDateTopPosition;
		var lineHeight = +getLineHeight(times[0]);

		if (previousBlock === null) {
			startDateTopPosition = +getTopPositionOfTime(currentBlockStartDate.getHours(), currentBlockStartDate.getMinutes());
			endDateTopPosition = +getTopPositionOfTime(currentBlockEndDate.getHours(), currentBlockEndDate.getMinutes());

			startDateTopPosition += lineHeight / 2;
			endDateTopPosition += lineHeight / 2;

			$(currentBlock).css("margin-top", startDateTopPosition);
			$(currentBlock).css("height", endDateTopPosition - startDateTopPosition);
		} else {
			startDateTopPosition = +getTopPositionOfTime(currentBlockStartDate.getHours(), currentBlockStartDate.getMinutes());
			endDateTopPosition = +getTopPositionOfTime(currentBlockEndDate.getHours(), currentBlockEndDate.getMinutes());

			startDateTopPosition += lineHeight / 2;
			endDateTopPosition += lineHeight / 2;

			$(currentBlock).css("height", endDateTopPosition - startDateTopPosition);
		}
	}

	function renderDays(days, parent) {
		var daysCount = days.length;

		for (var i = 0; i < daysCount; ++i) {
			renderDay(days[i], parent);
		}
	}

	function renderDay(day, parent) {
		var dateDiv = document.createElement('div');

		dateDiv.className = "scheduleDays";

		renderDayDate(day.Date, dateDiv);

		var blockDiv = document.createElement('div');
		blockDiv.className += "days";

		renderblocks(day.Blocks, blockDiv);

		dateDiv.append(blockDiv);

		renderDayDate(day.Date, dateDiv);
		parent.append(dateDiv);
	}

	function renderDayDate(date, parent) {
		var div = document.createElement('div');

		div.className = "scheduleDayDate";
		div.innerHTML += $.format.date(ParseDate(date), "d MMM, ddd");

		parent.append(div);
	}

	function ParseDate(cSharpDate) {
		var allIsNumbersRegex = new RegExp('[0-9]+');
		var dateInMilliseconds = allIsNumbersRegex.exec(cSharpDate);

		return new Date(+dateInMilliseconds);
	}

	function renderblocks(blocks, parent) {
		var div = document.createElement('div');

		div.className = "scheduleBlocks";

		var count = blocks.length;
		for (var i = 0; i < count; i++) {
			renderblock(blocks[i], parent);
		}

		return div;
	}

	function renderblock(block, parent) {
		var div = document.createElement('div');

		div.className = " scheduleBlock ";
		div.className += " flex-container ";
		div.className += ScheduleDayBlockTypes[block.Type];

		if (!block.Start.IsStrict) {
			div.className += " startIsNotStrict ";
		}

		if (!block.End.IsStrict) {
			div.className += " endIsNotStrict ";
		}

		div.innerHTML = '<div class="flex-row"><div class="flex-item">' + ScheduleDayBlockTypes[block.Type] + '</div></div>';

		div.dataset.start = ParseDate(block.Start.DateTime);
		div.dataset.end = ParseDate(block.End.DateTime);

		parent.append(div);
	}

	function getVerticalDeltaInPixelsBetween(lhsElement, rhsElement) {
		return Math.abs($(lhsElement).offset().top - $(rhsElement).offset().top);
	}

	function getTopPositionOfTime(hours, minutes) {
		var timeSrting = hours + ":00";
		var v;
		var a;
		var delta;

		a = times
			.filter(function (i) {
				return times[i].innerText === timeSrting;
			});

		v = +a.position().top;

		if (minutes + "" === "30") {
			delta = Math.abs(($(times[2]).position().top - $(times[0]).position().top) / 2);
			v += delta;
		}

		return v;
	}

	function getLineHeight(element) {
		var temp = document.createElement(element.nodeName);
		temp.setAttribute("style", "margin:0px;padding:0px;font-family:" + element.style.fontFamily + ";font-size:" + element.style.fontSize);
		temp.innerHTML = "test";
		temp = element.parentNode.appendChild(temp);
		var ret = temp.clientHeight;
		temp.parentNode.removeChild(temp);
		return ret;
	}
})();



(function ($) {
	$.fn.Hscroll = function (speed, scroll) {
		scroll = scroll === undefined ? 1 : scroll;
		speed = speed === undefined ? 1 : speed;
		$parent = $(this);
		if ($parent.data('Hscroll') !== undefined) return $parent;
		$parent.data('Hscroll', 1);
		var pass = $('<div>').css({
			position: "fixed",
			top: "0",
			width: "3px",
			height: "3px",
			"margin-top": "-1px",
			"margin-left": "-1px",
			background: "black",
			opacity: "0",
			"overflow-x": "scroll",
			"z-index": "10000"
		});
		pass.append($('<div>').height(get_max_width($parent) / speed));

		$('body').append(pass);
		if (scroll !== 0) {
			$parent.css('overflow-x', "scroll");
		} else {
			$parent.css('overflow-x', "hidden");
		}

		$parent.children().bind('mousemove', function (e, d) {
			pass.css('top', e.clientY);
			pass.css('left', e.clientX);
		});
		$(document).on('scroll', function (e) {
			pass.css({
				'top': -1,
				'left': -1
			});
		});
		pass.scroll(function () {
			$parent.scrollLeft(pass.scrollTop() * speed);
		});

		$parent.scroll(function () {
			pass.scrollTop($parent.scrollLeft() / speed);
		});
	};

	function get_max_width(element) {
		return Math.max.apply(null, element.children().map(function (a) {
			return $(this).outerWidth()
		}));
	}
})(jQuery);
$('.schedule').Hscroll(100, 10);