namespace TypingGame.Models
{
	public class Stats
	{
		public int Correct { get; set; }
		public int Missed { get; set; }
		public int Total { get
			{
				return Correct + Missed; //bisa langsung di custom
			}
			set { } } 
		//bisa ditambah private di set agar hanya bisa di get jadi ngga bisa di set lagi
		public int Accuracy { get; set; }

		//mengitung Total klik
		public void CountTotal()
		{
			Total = Correct + Missed;
		}

		public void CountAccuracy()
		{
			Accuracy = Correct * 100 / (Correct + Missed);
		}
	}
}
