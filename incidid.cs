// Generates a random delay duration between a specified range in milliseconds
async Task RandomDelay(int minSeconds, int maxSeconds)
{
    // Ensure the minimum value is not greater than the maximum value
    if (minSeconds > maxSeconds)
    {
        throw new ArgumentException("Minimum seconds should be less than or equal to maximum seconds");
    }

    // Calculate the random delay duration within the specified range
    int delayDuration = new Random().Next(minSeconds, maxSeconds + 1) * 1000;

    // Await the delay
    await Task.Delay(delayDuration);
}

// Usage of the RandomDelay method
await RandomDelay(60, 180);
