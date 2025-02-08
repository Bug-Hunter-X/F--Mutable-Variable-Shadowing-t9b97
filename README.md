# F# Mutable Variable Shadowing Bug

This example demonstrates a common error in F# involving mutable variables and shadowing.  The function `addOne` modifies the mutable variable `x`, but the value of `x` outside the function remains unchanged due to shadowing. This can be confusing for developers familiar with imperative programming but new to F#'s functional aspects.

The solution offers ways to correctly modify the mutable variable.