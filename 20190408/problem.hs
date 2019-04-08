-- Given a list of numbers and a number k, return whether any two numbers from the list add up to k.

problem :: [Int] -> Int -> Bool
problem xs k = if filter (==k) (helper xs xs) /= [] then True else False

helper _ [] = []
helper xs (y:ys) = [x + y | x <- xs] ++ helper xs ys

-- time taken: ~8 minutes
