using System;

namespace Demo.Core.DTOs.Response
{
    public class GetPanelBeaterClientsDTO
    {
        public Guid ClientId { get; set; }
        public string ClientName { get; set; }
    }
    public class SearchPanelBeaterClientsDTO : SearchDTO
    {
        public string ClientId { get; set; }
    }
}