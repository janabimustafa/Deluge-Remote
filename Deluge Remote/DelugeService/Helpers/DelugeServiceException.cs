using System;

namespace DelugeService.Helpers
{
    public class DelugeServiceException : Exception
    {
        public DelugeServiceException(string errorString) : base(errorString)
        {

        }
    }
}