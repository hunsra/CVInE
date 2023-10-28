namespace CVInE
{
	public partial class MainPage : ContentPage
	{
		public static readonly BindableProperty ItemsProperty = BindableProperty.Create(nameof(Items), typeof(List<Item>), typeof(MainPage));
		public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create(nameof(SelectedItem), typeof(Item), typeof(MainPage));

		public List<Item> Items
		{
			get => (List<Item>)GetValue(ItemsProperty);
			set
			{
				SetValue(ItemsProperty, value);
				OnPropertyChanged();
			}
		}

		public Item SelectedItem
		{
			get => (Item)GetValue(SelectedItemProperty);

			set
			{
				SetValue(SelectedItemProperty, value);
				OnPropertyChanged();
			}
		}

		public MainPage()
		{
			BindingContext = this;

			Items = new List<Item>();

			for (int i = 0; i < 100; i++)
			{
				Items.Add(new Item() { Name = $"Item {i} Name" });
			}

			InitializeComponent();
		}
	}

}
