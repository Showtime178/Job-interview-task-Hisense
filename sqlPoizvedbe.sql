-- Vse naslove knjig avtorja “J.K. Rowling”, ki so na zalogi v vsaj enem skladišču

SELECT DISTINCT b.Title
FROM Book b
INNER JOIN Warehouse_Book wb ON b.ISBN = wb.BookISBN
WHERE b.AuthorName = 'J.K. Rowling' AND wb.Count > 0;

-- Vse naslove knjig, katere ima stranka “Beli Zajec” v shopping basketu in je cena knjige večja od 52,2 EUR.

SELECT DISTINCT b.Title
FROM Book b
INNER JOIN ShoppingBasket_Book sb ON b.ISBN = sb.BookISBN
INNER JOIN ShoppingBasket s ON sb.ShoppingBasketID = s.ID
WHERE b.Title = 'Beli Zajec' AND b.Price > 52.2;

-- Vse knjige, ki so bile kupljene več kot 11 krat 

SELECT b.Title, SUM(sb.Count) AS TotalPurchases
FROM Book b
INNER JOIN ShoppingBasket_Book sb ON b.ISBN = sb.BookISBN
GROUP BY b.Title
HAVING SUM(sb.Count) > 11
