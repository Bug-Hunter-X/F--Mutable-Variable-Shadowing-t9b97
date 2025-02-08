let mutable x = 10

let addOne () = 
  x <- x + 1
  x

let y = addOne ()
printf "%d %d" x y