using System;

namespace ListViewImagePerf.Forms
{
    public class ItemDto
    {
        public string ImageUrl => $"https://picsum.photos/1000/1000?random={Guid.NewGuid()}";

        public string Location => new Bogus.DataSets.Address().FullAddress();
    }
}