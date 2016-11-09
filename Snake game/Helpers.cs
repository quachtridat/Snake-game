namespace Snake_game {
    public static class Helpers {
        public static string ToRgbString(System.Drawing.Color color, string separator) => $"{color.R}{separator}{color.G}{separator}{color.B}";
        public static System.Drawing.Color GetColorFromRgbString(string value, params char[] separators) {
            string[] rgb = value.Split(separators, System.StringSplitOptions.RemoveEmptyEntries);
            if (rgb.Length != 3) throw new System.FormatException(@"Invalid Color RGB string!");
            return System.Drawing.Color.FromArgb(System.Convert.ToInt32(rgb[0]), System.Convert.ToInt32(rgb[1]), System.Convert.ToInt32(rgb[2]));
        }
        public static System.Drawing.Point GetPointFromXyString(string value, params char[] separators) {
            string[] xy = value.Split(separators, System.StringSplitOptions.RemoveEmptyEntries);
            if (xy.Length != 2) throw new System.FormatException(@"Invalid Point XY string!");
            return new System.Drawing.Point(System.Convert.ToInt32(xy[0]), System.Convert.ToInt32(xy[1]));
        }
        public static void AddKeysToSection(IniParser.Model.SectionData sectionData, params IniParser.Model.KeyData[] keyDatas) {
            foreach (IniParser.Model.KeyData keyData in keyDatas) sectionData.Keys.AddKey(keyData);
        }
    }
}
