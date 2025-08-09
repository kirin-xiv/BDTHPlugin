using System;

namespace BDTHPluginKirin
{
  public class PluginException : Exception
  {
    public PluginException() { }
    public PluginException(string message) : base($"BDTH Exception: {message}") { }
  }
}
