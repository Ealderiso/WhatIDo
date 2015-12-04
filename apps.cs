using System;

namespace WindowsFormsApplication1
{
    //https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.110).aspx?cs-save-lang=1&cs-lang=csharp#code-snippet-1

    internal class apps : IEquatable<apps>
    {
        public string AppName { get; set; }
        public int AppID { get; set; }

        public override string ToString()
        {
            return AppName;
        }

        public bool Equals(apps other)
        {
            if (other == null) return false;
            return (this.AppID.Equals(other.AppID));
        }
    }
}