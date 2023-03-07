/*
 Navicat Premium Data Transfer

 Source Server         : Local DB
 Source Server Type    : MySQL
 Source Server Version : 100425 (10.4.25-MariaDB)
 Source Host           : localhost:3306
 Source Schema         : resturant

 Target Server Type    : MySQL
 Target Server Version : 100425 (10.4.25-MariaDB)
 File Encoding         : 65001

 Date: 17/01/2023 10:10:28
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for categories
-- ----------------------------
DROP TABLE IF EXISTS `categories`;
CREATE TABLE `categories`  (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_danish_ci NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 5 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_danish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of categories
-- ----------------------------
INSERT INTO `categories` VALUES (1, 'Appetizers');
INSERT INTO `categories` VALUES (2, 'Entrees');
INSERT INTO `categories` VALUES (3, 'Desserts');
INSERT INTO `categories` VALUES (4, 'Beverages');

-- ----------------------------
-- Table structure for order_items
-- ----------------------------
DROP TABLE IF EXISTS `order_items`;
CREATE TABLE `order_items`  (
  `id` int NOT NULL AUTO_INCREMENT,
  `order_id` int NOT NULL,
  `product_id` int NOT NULL,
  `quantity` int NOT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `order_id`(`order_id` ASC) USING BTREE,
  INDEX `product_id`(`product_id` ASC) USING BTREE,
  CONSTRAINT `order_items_ibfk_1` FOREIGN KEY (`order_id`) REFERENCES `orders` (`id`) ON DELETE CASCADE ON UPDATE RESTRICT,
  CONSTRAINT `order_items_ibfk_2` FOREIGN KEY (`product_id`) REFERENCES `products` (`id`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 21 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_danish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of order_items
-- ----------------------------
INSERT INTO `order_items` VALUES (1, 1, 1, 3);
INSERT INTO `order_items` VALUES (2, 1, 2, 1);
INSERT INTO `order_items` VALUES (3, 1, 6, 2);
INSERT INTO `order_items` VALUES (4, 1, 14, 1);
INSERT INTO `order_items` VALUES (5, 2, 1, 3);
INSERT INTO `order_items` VALUES (6, 2, 2, 1);
INSERT INTO `order_items` VALUES (7, 2, 6, 2);
INSERT INTO `order_items` VALUES (8, 2, 14, 1);
INSERT INTO `order_items` VALUES (9, 3, 1, 3);
INSERT INTO `order_items` VALUES (10, 3, 2, 1);
INSERT INTO `order_items` VALUES (11, 3, 6, 2);
INSERT INTO `order_items` VALUES (12, 3, 14, 1);
INSERT INTO `order_items` VALUES (13, 4, 1, 3);
INSERT INTO `order_items` VALUES (14, 4, 2, 1);
INSERT INTO `order_items` VALUES (15, 4, 6, 2);
INSERT INTO `order_items` VALUES (16, 4, 14, 1);
INSERT INTO `order_items` VALUES (17, 5, 1, 3);
INSERT INTO `order_items` VALUES (18, 5, 2, 1);
INSERT INTO `order_items` VALUES (19, 5, 6, 2);
INSERT INTO `order_items` VALUES (20, 5, 14, 1);

-- ----------------------------
-- Table structure for orders
-- ----------------------------
DROP TABLE IF EXISTS `orders`;
CREATE TABLE `orders`  (
  `id` int NOT NULL AUTO_INCREMENT,
  `stand_id` int NOT NULL,
  `order_datetime` datetime NOT NULL,
  `total_cost` decimal(10, 2) NOT NULL,
  `created_at` datetime NOT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `stand_id`(`stand_id` ASC) USING BTREE,
  CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`stand_id`) REFERENCES `stands` (`id`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 6 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_danish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of orders
-- ----------------------------
INSERT INTO `orders` VALUES (1, 1, '2023-01-17 09:13:11', 81.00, '2023-01-17 09:13:11');
INSERT INTO `orders` VALUES (2, 1, '2023-01-17 09:13:13', 81.00, '2023-01-17 09:13:13');
INSERT INTO `orders` VALUES (3, 1, '2023-01-17 09:13:13', 81.00, '2023-01-17 09:13:13');
INSERT INTO `orders` VALUES (4, 1, '2023-01-17 09:13:13', 81.00, '2023-01-17 09:13:13');
INSERT INTO `orders` VALUES (5, 1, '2023-01-17 09:13:13', 81.00, '2023-01-17 09:13:13');

-- ----------------------------
-- Table structure for products
-- ----------------------------
DROP TABLE IF EXISTS `products`;
CREATE TABLE `products`  (
  `id` int NOT NULL AUTO_INCREMENT,
  `image` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_danish_ci NULL DEFAULT NULL,
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_danish_ci NOT NULL,
  `is_promotional` tinyint(1) NULL DEFAULT NULL,
  `expiry_date` date NULL DEFAULT NULL,
  `cost_price` decimal(10, 2) NOT NULL,
  `sale_price` decimal(10, 2) NOT NULL,
  `category_id` int NOT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `category_id`(`category_id` ASC) USING BTREE,
  CONSTRAINT `products_ibfk_1` FOREIGN KEY (`category_id`) REFERENCES `categories` (`id`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 26 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_danish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of products
-- ----------------------------
INSERT INTO `products` VALUES (1, 'pizza_margherita.jpg', 'Pizza Margherita', 0, '2022-12-31', 12.99, 14.99, 1);
INSERT INTO `products` VALUES (2, 'pizza_pepperoni.jpg', 'Pizza Pepperoni', 0, '2022-12-31', 14.99, 16.99, 1);
INSERT INTO `products` VALUES (3, 'spaghetti_bolognese.jpg', 'Spaghetti Bolognese', 1, '2022-11-30', 9.99, 11.99, 2);
INSERT INTO `products` VALUES (4, 'chicken_parmesan.jpg', 'Chicken Parmesan', 0, '2022-12-31', 17.99, 19.99, 3);
INSERT INTO `products` VALUES (5, 'grilled_salmon.jpg', 'Grilled Salmon', 0, '2022-12-31', 21.99, 23.99, 4);
INSERT INTO `products` VALUES (6, 'garlic_bread.jpg', 'Garlic Bread', 0, '2022-12-31', 4.99, 5.99, 1);
INSERT INTO `products` VALUES (7, 'bruschetta.jpg', 'Bruschetta', 0, '2022-12-31', 6.99, 7.99, 1);
INSERT INTO `products` VALUES (8, 'caprese_salad.jpg', 'Caprese Salad', 1, '2022-11-30', 8.99, 9.99, 1);
INSERT INTO `products` VALUES (9, 'fettuccine_alfredo.jpg', 'Fettuccine Alfredo', 0, '2022-12-31', 12.99, 14.99, 2);
INSERT INTO `products` VALUES (10, 'lasagna.jpg', 'Lasagna', 0, '2022-12-31', 14.99, 16.99, 2);
INSERT INTO `products` VALUES (11, 'baked_ziti.jpg', 'Baked Ziti', 1, '2022-11-30', 9.99, 11.99, 2);
INSERT INTO `products` VALUES (12, 'roasted_chicken.jpg', 'Roasted Chicken', 0, '2022-12-31', 17.99, 19.99, 3);
INSERT INTO `products` VALUES (13, 'steak.jpg', 'Steak', 0, '2022-12-31', 21.99, 23.99, 3);
INSERT INTO `products` VALUES (14, 'tiramisu.jpg', 'Tiramisu', 0, '2022-12-31', 6.99, 7.99, 4);
INSERT INTO `products` VALUES (15, 'cheesecake.jpg', 'Cheesecake', 0, '2022-12-31', 8.99, 9.99, 4);
INSERT INTO `products` VALUES (16, 'chocolate_cake.jpg', 'Chocolate Cake', 1, '2022-11-30', 10.99, 11.99, 4);
INSERT INTO `products` VALUES (17, 'soda.jpg', 'Soda', 0, '2022-12-31', 2.99, 3.99, 4);
INSERT INTO `products` VALUES (18, 'iced_tea.jpg', 'Iced Tea', 0, '2022-12-31', 2.99, 3.99, 4);
INSERT INTO `products` VALUES (19, 'lemonade.jpg', 'Lemonade', 1, '2022-11-30', 3.99, 4.99, 4);
INSERT INTO `products` VALUES (20, 'coffee.jpg', 'Coffee', 0, '2022-12-31', 2.99, 3.99, 4);
INSERT INTO `products` VALUES (21, 'lasagna.jpg', 'Lasagna', 0, '2022-12-31', 12.99, 14.99, 2);
INSERT INTO `products` VALUES (22, 'steak_frites.jpg', 'Steak Frites', 0, '2022-12-31', 24.99, 29.99, 3);
INSERT INTO `products` VALUES (23, 'creme_brulee.jpg', 'Crème Brûlée', 1, '2022-11-30', 6.99, 8.99, 4);
INSERT INTO `products` VALUES (24, 'mojito.jpg', 'Mojito', 0, '2022-12-31', 8.99, 10.99, 4);
INSERT INTO `products` VALUES (25, 'cosmopolitan.jpg', 'Cosmopolitan', 0, '2022-12-31', 12.99, 14.99, 4);

-- ----------------------------
-- Table structure for stands
-- ----------------------------
DROP TABLE IF EXISTS `stands`;
CREATE TABLE `stands`  (
  `id` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 5 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_danish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of stands
-- ----------------------------
INSERT INTO `stands` VALUES (1);
INSERT INTO `stands` VALUES (2);
INSERT INTO `stands` VALUES (3);
INSERT INTO `stands` VALUES (4);

SET FOREIGN_KEY_CHECKS = 1;
