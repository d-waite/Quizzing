using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace Quizzing.Components.Pages
{
	public class Question()
	{
		private QuestionType type = QuestionType.Speed;
		private int pointAmt = 0;

		public QuestionType Type { get { return type; } set { type = value; } }
		public int PointAmt { get { return pointAmt; } set { pointAmt = value; } }
	}
}
