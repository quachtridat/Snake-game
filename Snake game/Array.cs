namespace Snake_game {
    class Array {
        public static void Populate<T>(T[] arr, T value) {
            for (int i = 0; i < arr.Length; ++i) arr[i] = value;
        }
    }
}
