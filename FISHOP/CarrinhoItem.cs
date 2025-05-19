namespace FISHOP
{
    public class CarrinhoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Source { get; set; }
        public string Price { get; set; }
        public float Rating { get; set; }
        public string ImageUrl { get; set; }
        public int Quantidade { get; set; } = 1;

        private decimal _valorNumerico;

        public decimal ValorNumerico
        {
            get
            {
                if (_valorNumerico == 0 && !string.IsNullOrEmpty(Price))
                {
                    var precoLimpo = new string(Price.Where(c => char.IsDigit(c) || c == ',' || c == '.').ToArray());
                    precoLimpo = precoLimpo.Replace(',', '.');

                    if (decimal.TryParse(precoLimpo, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal valor))
                        _valorNumerico = valor;
                }
                return _valorNumerico;
            }
            set => _valorNumerico = value;
        }
    }
}
