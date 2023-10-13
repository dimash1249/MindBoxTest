from pyspark.sql import SparkSession, DataFrame

spark = SparkSession.builder.appName("MindBox").getOrCreate()

categories_df = spark.createDataFrame([
    (1, "Fruit"),
    (2, "Vegetable"),
    (3, "Product")], ["id", "category_name"],
)

products_df = spark.createDataFrame([
    (1, "Product 1"),
    (2, "Product 2"),
    (3, "Product 3"),
    (4, "Product 4"),
    (5, "Product 5"),
    (6, "Product 6"),
    (7, "Product 7"),
    (8, "Product 8"),
    (9, "Product 9"),
    (10, "Product 10"), ],
    ["id", "product_name", ]
)

products_categories_df = spark.createDataFrame([
    (1, 1),
    (2, 3),
    (3, 2),
    (3, 4),
    (3, 4),
    (2, 5),
    (1, 6),
    (2, 7),
    (2, 8),
    (3, 2),
    (1, 8),
    (2, 9),
    (1, 10)],
    ["category_id", "product_id", ]
)

df_data = (products_df.join(products_categories_df,
                            products_df.id == products_categories_df.product_id, how='left')
           .join(categories_df, products_categories_df.category_id == categories_df.id, how='left')
           .select(['category_name', 'product_name'])
           )

df_data.orderBy("category_id", "product_id", ).show(truncate=True)

spark.stop()

# Это первый раз когда я работаю с PySpark, мой навык как быстрая обучаемость, без чужык подсказок, с помощью гугл и
# документация я решил данную задачу.
