using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ZergDraftApp.Models;

namespace ZergDraftApp.Controllers
{
	public static class Common
	{
		public static Random Random { get; } = new Random();
	}

	public class Schedule
	{
		public static Schedule GetNewOne()
		{
			return new Schedule
			{
				Days = new List<ScheduleDay>
				{
					new ScheduleDay
					{
						Date = new DateTime(2017, 2, 3, 0,0,0,DateTimeKind.Utc),
						Blocks = new List<ScheduleDayBlock>
						{
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 3, 6, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 3, 7, 30, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Busy
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 3, 8, 00, 00, DateTimeKind.Utc),IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 3, 9, 00, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Tentative
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 3, 11, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 3, 13, 00, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Streaming
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 3, 13, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 3, 15, 00, 00, DateTimeKind.Utc),IsStrict = false},
								Type = ScheduleDayBlockType.Learing
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 3, 15, 00, 00, DateTimeKind.Utc),IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 3, 19, 00, 00, DateTimeKind.Utc),IsStrict = false},
								Type = ScheduleDayBlockType.Streaming
							},
						},
					},

					new ScheduleDay
					{
						Date = new DateTime(2017, 2, 4,0,0,0, DateTimeKind.Utc),
						Blocks = new List<ScheduleDayBlock>
						{
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 4, 6, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 4, 7, 30, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Busy
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 4, 8, 00, 00, DateTimeKind.Utc),IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 4, 9, 00, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Tentative
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 4, 9, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 4, 9, 30, 00, DateTimeKind.Utc),IsStrict = false},
								Type = ScheduleDayBlockType.Avaliable
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 4, 9, 30, 00, DateTimeKind.Utc),IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 4, 15, 00, 00, DateTimeKind.Utc),IsStrict = false},
								Type = ScheduleDayBlockType.Learing
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 4, 15, 00, 00, DateTimeKind.Utc),IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 4, 19, 00, 00, DateTimeKind.Utc),IsStrict = false},
								Type = ScheduleDayBlockType.Streaming
							},
						},
					},

					new ScheduleDay
					{
						Date = new DateTime(2017, 2, 5,0,0,0, DateTimeKind.Utc),
						Blocks = new List<ScheduleDayBlock>
						{
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 5, 6, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 5, 7, 30, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Busy
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 5, 12, 00, 00, DateTimeKind.Utc),IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 5, 15, 00, 00, DateTimeKind.Utc),IsStrict = false},
								Type = ScheduleDayBlockType.Learing
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 5, 15, 00, 00, DateTimeKind.Utc),IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 5, 19, 00, 00, DateTimeKind.Utc),IsStrict = false},
								Type = ScheduleDayBlockType.Streaming
							},
						},
					},

					new ScheduleDay
					{
						Date = new DateTime(2017, 2, 6,0,0,0, DateTimeKind.Utc),
						Blocks = new List<ScheduleDayBlock>
						{
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 6, 6, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 6, 7, 30, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Busy
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 6, 7, 30, 00, DateTimeKind.Utc),IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 6, 9, 00, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Tentative
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 6, 9, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 6, 13, 00, 00, DateTimeKind.Utc),IsStrict = false},
								Type = ScheduleDayBlockType.Avaliable
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 6, 13, 00, 00, DateTimeKind.Utc),IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 6, 15, 00, 00, DateTimeKind.Utc),IsStrict = false},
								Type = ScheduleDayBlockType.Learing
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 6, 15, 00, 00, DateTimeKind.Utc),IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 6, 19, 00, 00, DateTimeKind.Utc),IsStrict = false},
								Type = ScheduleDayBlockType.Streaming
							},
						},
					},

					new ScheduleDay
					{
						Date = new DateTime(2017, 2, 7,0,0,0, DateTimeKind.Utc),
						Blocks = new List<ScheduleDayBlock>
						{
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 7, 6, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 7, 7, 30, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Busy
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 7, 7, 30, 00, DateTimeKind.Utc),IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 7, 9, 00, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Tentative
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 7, 9, 00, 00, DateTimeKind.Utc) ,IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 7, 19, 00, 00, DateTimeKind.Utc),IsStrict = false},
								Type = ScheduleDayBlockType.Streaming
							},
						},
					},

					new ScheduleDay
					{
						Date = new DateTime(2017, 2, 8,0,0,0, DateTimeKind.Utc),
						Blocks = new List<ScheduleDayBlock>
						{
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 8, 6, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 8, 19, 00, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Busy
							},
						},
					},

					new ScheduleDay
					{
						Date = new DateTime(2017, 2, 9,0,0,0, DateTimeKind.Utc),
						Blocks = new List<ScheduleDayBlock>
						{
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 9, 6, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 9, 7, 30, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Busy
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 9, 7, 30, 00, DateTimeKind.Utc),IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 9, 9, 00, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Tentative
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 9, 9, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 9, 13, 00, 00, DateTimeKind.Utc),IsStrict = false},
								Type = ScheduleDayBlockType.Streaming
							},
						},
					},

					new ScheduleDay
					{
						Date = new DateTime(2017, 2, 10,0,0,0, DateTimeKind.Utc),
						Blocks = new List<ScheduleDayBlock>
						{
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 10, 6, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 10, 7, 00, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Busy
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 10, 7, 00, 00, DateTimeKind.Utc),IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 10, 9, 00, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Tentative
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 10, 9, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 10, 13, 00, 00, DateTimeKind.Utc),IsStrict = false},
								Type = ScheduleDayBlockType.Streaming
							},
						},
					},

					new ScheduleDay
					{
						Date = new DateTime(2017, 2, 11,0,0,0, DateTimeKind.Utc),
						Blocks = new List<ScheduleDayBlock>
						{
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 11, 6, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 11, 19, 00, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Busy
							},
						},
					},

					new ScheduleDay
					{
						Date = new DateTime(2017, 2, 12,0,0,0, DateTimeKind.Utc),
						Blocks = new List<ScheduleDayBlock>
						{
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 12, 6, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 12, 7, 30, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Busy
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 12, 7, 30, 00, DateTimeKind.Utc),IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 12, 9, 00, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Tentative
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 12, 9, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 12, 13, 00, 00, DateTimeKind.Utc),IsStrict = false},
								Type = ScheduleDayBlockType.Streaming
							},
						},
					},

					new ScheduleDay
					{
						Date = new DateTime(2017, 2, 13,0,0,0, DateTimeKind.Utc),
						Blocks = new List<ScheduleDayBlock>
						{
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 13, 6, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 13, 7, 30, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Busy
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 13, 7, 30, 00, DateTimeKind.Utc),IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 13, 9, 00, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Tentative
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 13, 9, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 13, 13, 00, 00, DateTimeKind.Utc),IsStrict = false},
								Type = ScheduleDayBlockType.Streaming
							},
						},
					},

					new ScheduleDay
					{
						Date = new DateTime(2017, 2, 14,0,0,0, DateTimeKind.Utc),
						Blocks = new List<ScheduleDayBlock>
						{
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 14, 6, 00, 00, DateTimeKind.Utc)},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 14, 7, 30, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Busy
							},
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 14, 7, 30, 00, DateTimeKind.Utc),IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 14, 9, 00, 00, DateTimeKind.Utc)},
								Type = ScheduleDayBlockType.Tentative
							},
						},
					},

					new ScheduleDay
					{
						Date = new DateTime(2017, 2, 15,0,0,0, DateTimeKind.Utc),
						Blocks = new List<ScheduleDayBlock>
						{
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 15, 8, 00, 00, DateTimeKind.Utc),IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 15, 19, 00, 00, DateTimeKind.Utc),IsStrict = false},
								Type = ScheduleDayBlockType.Tentative
							},
						},
					},

					new ScheduleDay
					{
						Date = new DateTime(2017, 2, 16,0,0,0, DateTimeKind.Utc),
						Blocks = new List<ScheduleDayBlock>
						{
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 16, 6, 00, 00, DateTimeKind.Utc),IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 16, 19, 00, 00, DateTimeKind.Utc),IsStrict = false},
								Type = ScheduleDayBlockType.Tentative
							},
						},
					},

					new ScheduleDay
					{
						Date = new DateTime(2017, 2, 17,0,0,0, DateTimeKind.Utc),
						Blocks = new List<ScheduleDayBlock>
						{
							new ScheduleDayBlock
							{
								Start = new MyDateTime {DateTime = new DateTime(2017, 2, 17, 7, 00, 00, DateTimeKind.Utc),IsStrict = false},
								End = new MyDateTime {DateTime = new DateTime(2017, 2, 17, 18, 00, 00, DateTimeKind.Utc),IsStrict = false},
								Type = ScheduleDayBlockType.Tentative
							},
						},
					},
				}
			};
		}

		public Schedule()
		{
			this.Days = new List<ScheduleDay>();
		}

		public IList<ScheduleDay> Days { get; set; }
	}

	public class ScheduleDay
	{
		public ScheduleDay()
		{
			this.Blocks = new List<ScheduleDayBlock>();
		}

		public IList<ScheduleDayBlock> Blocks { get; set; }

		public DateTime Date { get; set; }
	}

	public class ScheduleDayBlock
	{
		public MyDateTime Start { get; set; }
		public MyDateTime End { get; set; }
		public ScheduleDayBlockType Type { get; set; }
	}

	public class MyDateTime
	{
		public MyDateTime(bool isStrict = true)
		{
			this.IsStrict = isStrict;
		}

		public bool IsStrict { get; set; }
		public DateTime DateTime { get; set; }
	}

	public enum ScheduleDayBlockType
	{
		Avaliable = 0,
		Busy = 1,
		Tentative = 2,
		Learing = 3,
		Streaming = 4,
	}

	public class HomeController : Controller
	{
		// GET: Home
		public ActionResult Index()
		{
			if (UserProvider.Role == UserRole.None)
			{
				return new HttpUnauthorizedResult();
			}

			Schedule s = Schedule.GetNewOne();
			return View(s);
		}

		public ActionResult Feedbacks()
		{
			return View();
		}

		public ActionResult Contacts()
		{
			return View();
		}
	}
}