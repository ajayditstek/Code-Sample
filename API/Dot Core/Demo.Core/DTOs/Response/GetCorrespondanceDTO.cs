using System;

namespace Demo.Core.DTOs.Response
{
    public class GetCorrespondanceDTO
    {
        public Guid CorrespondenceId { get; set; }
        public Guid? ClaimId { get; set; }
        public string Username { get; set; }
        public string MessageCategory { get; set; }
        public string MessageType { get; set; }
        public string MessageContent { get; set; }
        public string MessageSubject { get; set; }
        public string Recipients { get; set; }
        public DateTime? SentDate { get; set; }
        public DateTime? LogDate { get; set; }
    }

    public class SearchCorrespondanceDTO : SearchDTO
    {
        public string ClaimId { get; set; }
    }
}