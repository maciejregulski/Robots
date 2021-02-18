# Robots

## Application in C # that simulates the process of producing elements and reports the progress to the UI.
To process a single element, paint it with three colors: blue, red, green. The elements are painted by robots. Each robot can only paint one element at the time. Painting each element takes a certain amount of time.

## Robot functions:
 + Red robot paints with red paint.
 + Green robot paints with green paint.
 + Blue robot paints with blue paint.

## The process of making a finished element requires:
 1. Item is initialy in a raw parts warehouse.
 2. The item is transferred to a inactive robot. The robot paints the element in the appropriate color.
 3. The element can not be painted more than once with the same color.
 4. If the element has not yet been painted with all three colors, it is returned to the raw parts warehouse.
 5. The elements painted with all the required colors are transferred to the finished items warehouse.
