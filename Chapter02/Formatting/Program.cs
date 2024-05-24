int numberOfApples = 12;
decimal priceOfApple = 0.35M;

WriteLine("{0} apples cost {1:C}", numberOfApples, priceOfApple * numberOfApples);

string formatted = string.Format("{0} apples cost {1:C}", numberOfApples, priceOfApple * numberOfApples);
WriteLine(formatted);