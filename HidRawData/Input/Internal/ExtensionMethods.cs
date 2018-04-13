namespace Djlastnight.Input.Internal
{
    using System.Management;

    internal static class Extensions
    {
        public static Win32_PnPEntity ToPnpEntity(this ManagementBaseObject input)
        {
            var output = new Win32_PnPEntity();
            foreach (var prop in input.Properties)
            {
                if (prop.Value == null)
                {
                    continue;
                }

                output.SetValue(prop.Name, prop.Value);
            }

            return output;
        }
    }
}