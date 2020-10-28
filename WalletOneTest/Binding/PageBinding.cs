namespace WalletOneTest.Binding
{
    public class PageBinding
    {
        /// <summary>
        /// Number of skipped items
        /// </summary>
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of items per page
        /// </summary>
        public int Limit { get; set; }
    }
}
