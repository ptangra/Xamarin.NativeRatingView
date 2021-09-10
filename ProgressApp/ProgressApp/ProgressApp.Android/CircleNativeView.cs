using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgressApp.Droid
{
	public class CircleNativeView : Android.Views.View
	{
		public int valueCircles = 1;
		private Context mContext;
		Paint backgroundPaint;
		int radius = 60;

		public CircleNativeView(Context context) : base(context)
		{
			init(context);
			SetMinimumHeight(200);
			SetMinimumWidth(200);
		}

		public CircleNativeView(Context context, IAttributeSet attrs)
			: base(context, attrs)
		{
			init(context);
		}
		public CircleNativeView(
			Context context, IAttributeSet attrs, int defStyle)
			: base(context, attrs, defStyle)
		{
			init(context);
		}
		public void SetValue(int Value)
		{
			valueCircles = Value;
		}
		public void SetColor(Color color)
		{
			backgroundPaint = new Paint { Color = color };
		}
		protected override void OnDraw(Canvas canvas)
		{
			drawCircles(canvas);
		}
		private void drawCircles(Canvas canvas)
		{
			int spacing = Width / valueCircles;
			int shift = spacing / 2;
			int bottomMargin = 10;

			for (int i = 0; i < valueCircles; i++)
			{
				int x = i * spacing + shift;
				int y = Height - radius * 2 - bottomMargin;
				canvas.DrawCircle(x, y, radius, backgroundPaint);
			}
		}
		private void init(Context ctx)
		{
			mContext = ctx;
		}
		public void RefreshView()
		{
			Invalidate();
		}
	}
}