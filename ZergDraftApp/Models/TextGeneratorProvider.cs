using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SandS.Algorithm.Library.GeneratorNamespace;

namespace ZergDraftApp.Models
{
	public static class TextGeneratorProvider
	{
		public static TextGenerator TextGenerator { get; } = new TextGenerator();
	}
}