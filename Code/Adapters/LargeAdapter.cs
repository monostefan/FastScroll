using System;

using Android.Views;
using Android.Widget;

using Android.Support.V7.Widget;

namespace FastScroll
{
	public class LargeAdapter : BaseRecyclerAdapter
	{
		public class ViewHolder : RecyclerView.ViewHolder
		{
			public TextView Name { get; set; }

			public ViewHolder(View view) : base(view)
			{
			}
		}
			
		public LargeAdapter()
		{
		}

		private System.Collections.ObjectModel.ObservableCollection<string> items;

		public LargeAdapter(System.Collections.ObjectModel.ObservableCollection<string> data)
		{
			this.items = data;
		}

		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			View row = LayoutInflater.From(parent.Context).Inflate(Android.Resource.Layout.SimpleListItem1, parent, false);

			TextView name = row.FindViewById<TextView>(Android.Resource.Id.Text1);
            //name.SetHeight(250);

			ViewHolder view = new ViewHolder(row){ Name = name };
			return view;
		}

		public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
		{
			ViewHolder hold = holder as ViewHolder;
			hold.Name.Text = items[position];
		}

		public override int ItemCount {
			get {
				return this.items.Count;
			}
		}

		public override string GetTextToShowInBubble(int pos)
		{
			return items[pos][0].ToString();
		}
	}
}

