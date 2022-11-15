Решение 1 задания представлено в данном репозитории

Решение 2 задания прилагаю:

SELECT prod.name, cat.name FROM Products prod
    LEFT FOIN ProdCat prodcat ON prod.id = prodcat.products_id
    INNER JOIN Category cat ON cat.id = prodcat.category_id
ORDER BY prod.name;
