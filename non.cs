// Assuming 'startDate' is a DateTime object with an initial value.
// The original code adds 23 hours and 50 minutes to 'startDate' to calculate 'endDate'.

// Optimized code:
// Instead of calling 'AddHours' and 'AddMinutes' separately, we can add both time spans in a single call to 'Add'.
// This reduces the method calls and makes the code more concise and efficient.

DateTime endDate = startDate.Add(new TimeSpan(23, 50, 0));

// Note: The 'TimeSpan' constructor is used here to create a time span of 23 hours and 50 minutes.
// The 'Add' method then adds this time span to 'startDate' to get 'endDate'.
