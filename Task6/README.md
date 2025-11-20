### Why does the calculation produce an incorrect result?
Because both `marks` and `total` are integer types, the expression  
`marks / total * 100` performs integer division first, which removes the decimal part.  
For example, `45 / 50` becomes `0`, and then `0 * 100` still results in `0`.

### How can this be fixed?
Ensure the division happens using floating-point numbers by converting at least one value:

    double percentage = (double)marks / total * 100;
