﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListView_Toast
{
	[Activity(Label = "ListItem")]
	public class ListItem
	{
		public string Title { get; set; }
		public string Description { get; set; }
	}
}
