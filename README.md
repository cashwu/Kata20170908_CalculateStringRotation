# [Calculate String Rotation](https://www.codewars.com/kata/a-rule-of-divisibility-by-13/csharp)

---

Write a function that receives two strings and returns n, where n is equal to the number of characters we should shift the first string forward to match the second.

For instance, take the strings "fatigue" and "tiguefa". In this case, the first string has been rotated 5 characters forward to produce the second string, so 5 would be returned.

If the second string isn't a valid rotation of the first string, the method returns -1.
Examples:

```csharp
"coffee", "eecoff" => 2
"eecoff", "coffee" => 4
"moose", "Moose" => -1
"isn't", "'tisn" => 2
"Esham", "Esham" => 0
"dog", "god" => -1
```
For Swift, your function should return an Int?. So rather than returning -1 when the second string isn't a valid rotation of the first, return nil.

```Swift
shiftedDiff("coffee", "eecoff") => 2
shiftedDiff("eecoff", "coffee") => 4
shiftedDiff("moose", "Moose") => nil
shiftedDiff("isn't", "'tisn") => 2
shiftedDiff("Esham", "Esham") => 0
shiftedDiff("dog", "god") => nil
```

---

### 中文大意

第二個字串是第一個字串旋轉而成，返回需要旋轉幾次才可以變成第二個字串
