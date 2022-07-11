namespace BlazorServerTailwind.Shared
{
    public partial class NavMenu
    {
        private bool isExpanded { get; set; }
        private string showItems { get; set; } = "hidden";

        public async Task ToggleNavBar()
        {
            isExpanded = !isExpanded;

            if (isExpanded) await Task.Delay(300);
            showItems = isExpanded ? "block" : "hidden";
            StateHasChanged();
        }
    }
}
