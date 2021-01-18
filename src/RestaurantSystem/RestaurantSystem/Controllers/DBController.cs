using RestaurantSystem.Data;
using RestaurantSystem.Data.Models;
using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Controllers
{
    public class DBController
    {
        RestaurantDbContext db;

        public void CreateDB()
        {
            db = new RestaurantDbContext();
            db.Database.CreateIfNotExists();
        }

        public void CreateRoles()
        {
            Role admin = db.Roles.SingleOrDefault(r => r.Name == "admin");
            Role waiter = db.Roles.SingleOrDefault(r => r.Name == "waiter");

            if (admin == null)
            {
                db.Roles.Add(new Role
                {
                    Name = "admin"
                });
            }

            if (waiter == null)
            {
                db.Roles.Add(new Role
                {
                    Name = "waiter"
                });
            }

            db.SaveChanges();
        }

        public void CreateAdminEmployer()
        {
            Employee admin = db.Employees.SingleOrDefault(e => e.FirstName == "admin");

            if (admin == null)
            {
                db.Employees.Add(new Employee
                {
                    FirstName = "admin",
                    LastName = "admin",
                    Salary = 0
                });

                db.SaveChanges();
            }
        }

        public void CreateAdminAccount()
        {
            User admin = db.Users.SingleOrDefault(u => u.Username == "admin");
            int roleId = db.Roles.SingleOrDefault(r => r.Name == "admin").Id;
            int employerId = db.Employees.SingleOrDefault(e => e.FirstName == "admin").EmpId;

            if (admin == null)
            {
                db.Users.Add(new User
                {
                    Username = "admin",
                    Password = "admin",
                    RoleId = roleId,
                    EmployeеId = employerId
                });

                db.SaveChanges();
            }
        }

        public void CreateSupplier()
        {
            Supplier supplier = db.Suppliers.SingleOrDefault(s => s.Name == "Канзас");

            if(supplier == null)
            {
                db.Suppliers.Add(new Supplier
                {
                    Name = "Канзас",
                    PhoneNumber = "0882764871",
                    AvailableDays="понеделник, вторник, сряда, четвъртък, петък, събота, неделя"
                });

                db.SaveChanges();
            }
        }

        public void CreateYearAccounting()
        {
            string year = DateTime.Now.Year.ToString();

            string dateString = year.ToString() + "0101T00:00:00Z";
            DateTime today = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);

            YearAccountings acc = db.YearAccountings.SingleOrDefault(a => a.Date == today);

            if(acc == null)
            {
                db.YearAccountings.Add(new YearAccountings
                {
                    Date = today,
                    YearExpense = 0,
                    YearIncome = 0,
                    YearProfit = 0
                });

                db.SaveChanges();
            }
        }

        public void CreateMonthAccounting()
        {
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();

            if (month.Length < 2)
            {
                month = "0" + month;
            }

            string dateString = year.ToString() + month.ToString() + "01T00:00:00Z";
            DateTime today = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);

            MonthAccountings acc = db.MonthAccountings.SingleOrDefault(a => a.Date == today);

            if(acc == null)
            {
                db.MonthAccountings.Add(new MonthAccountings
                {
                    Date = today,
                    MonthExpense = 0,
                    MonthIncome = 0,
                    MonthProfit = 0,
                    YearAccountingId = 1
                });

                db.SaveChanges();
            }
        }

        public void CreateDayAccounting()
        {
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();

            if (month.Length < 2)
            {
                month = "0" + month;
            }

            if (day.Length < 2)
            {
                day = "0" + day;
            }

            string dateString = year.ToString() + month.ToString() + day.ToString() + "T00:00:00Z";
            DateTime today = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);

            DayAccountings acc = db.DayAccountings.SingleOrDefault(a => a.Date == today);

            if(acc == null)
            {
                db.DayAccountings.Add(new DayAccountings
                {
                    DayExpense = 0,
                    DayIncome = 0,
                    DayProfit = 0,
                    Date = today,
                    MonthAccountingId = 1
                });

                db.SaveChanges();
            }
        }

        public void CreateEmployerReport()
        {
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();

            if (month.Length < 2)
            {
                month = "0" + month;
            }

            if (day.Length < 2)
            {
                day = "0" + day;
            }

            string dateString = year.ToString() + month.ToString() + day.ToString() + "T00:00:00Z";
            DateTime today = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);

            EmployerReport empRep = db.EmployerReports.SingleOrDefault(er => er.EmpId == 2);
            Dish dish = db.Dishes.SingleOrDefault(d => d.DishName == "Снежанка");

            if (empRep == null)
            {
                db.EmployerReports.Add(new EmployerReport
                {
                    Bill = dish.DishSellingPrice,
                    EmpId = 2,
                    ReportDate = today,
                    DayAccountingId = 1,
                    Id = 1
                });

                DishEmployerReports der = new DishEmployerReports
                {
                    DishId = dish.Id,
                    EmployerReportId = 1
                };

                db.DishEmployerReports.Add(der);

                db.SaveChanges();

                ICollection<EmployerReport> reports = new HashSet<EmployerReport>();
                reports.Add(empRep);

                db.SaveChanges();
            }

        }

        public List<Employee> GetEmployers()
        {
            return db.Employees.Select(e => e).ToList();
        }

        public Employee GetEmployeeByFirstAndLastName(string firstName, string lastName)
        {
            return db.Employees.SingleOrDefault(e => e.FirstName == firstName && e.LastName == lastName);
        }

        public String GetEmployerJobPosition(string firstName, string lastName)
        {
            return GetEmployeeByFirstAndLastName(firstName, lastName).JobPosition;
        }

        public String GetEmployerUserName(string firstName, string lastName)
        {
            Employee employer = db.Employees.SingleOrDefault(e => e.FirstName == firstName && e.LastName == lastName);
            User user = db.Users.SingleOrDefault(u => u.EmployeеId == employer.EmpId);
            
            if(user != null)
            {
                return user.Username;
            }
            else
            {
                return "";
            }
        }

        public String GetEmployerPassword(string firstName, string lastName)
        {
            Employee employer = db.Employees.SingleOrDefault(e => e.FirstName == firstName && e.LastName == lastName);
            User user = db.Users.SingleOrDefault(u => u.EmployeеId == employer.EmpId);

            if(user != null)
            {
                return user.Password;
            }
            else
            {
                return "";
            }
        }

        public void AddUserToDataBase(string username, string password, string roleName, string firstName, string lastName)
        {
            Employee employer = db.Employees.SingleOrDefault(e => e.FirstName == firstName && e.LastName == lastName);
            Role role = GetRoleByName(roleName);
            User existingUser = db.Users.SingleOrDefault(u => u.EmployeеId == employer.EmpId);

            if (existingUser == null)
            {
                User user = new User
                {
                    Username = username,
                    Password = password,
                    EmployeеId = employer.EmpId,
                    Employer = employer,
                    Role = role,
                    RoleId = role.Id
                };

                db.Users.Add(user);
            }
            else
            {
                existingUser.Username = username;
                existingUser.Password = password;
            }

            db.SaveChanges();
        }

        public Role GetRoleByName(string name)
        {
            return db.Roles.SingleOrDefault(r => r.Name == name);
        }

        public void AddProduct(string name, int quantity, double price, double dlprice)
        {
            db.Products.Add(new Product
            {
                Name = name,
                Quantity = quantity,
                Price = price,
                DeliveryPrice = dlprice
            });

            db.SaveChanges();
        }

        public ICollection<Product> LoadProducts()
        {
            return db.Products
                .Select(p => p)
                .ToArray();
        }

        public void EditProduct(string name, int quantity, double price, double dlprice)
        {
            Product product = db.Products.SingleOrDefault(p => p.Name == name);
            if (product != null)
            {
                product.Name = name;
                product.Quantity = quantity;
                product.Price = price;
                product.DeliveryPrice = dlprice;

                db.SaveChanges();
            }
        }

        public Product SelectProductByName(string name)
        {
            Product product = db.Products.SingleOrDefault(p => p.Name == name);
            return product;
        }

        public Product SelectProductById(int id)
        {
            Product product = db.Products.SingleOrDefault(p => p.Id == id);
            return product;
        }

        public void AddDish(string dName, double dPrice, double dWeight, ICollection<int> productsInDish, string productsQuantities)
        {
            double makingPrice = 0;
            string[] productsQuantitiesSplitted = productsQuantities.Split(' ');
            int counter = 0;

            foreach(int prId in productsInDish)
            {
                Product pr = SelectProductById(prId);
                makingPrice += pr.Price * double.Parse(productsQuantitiesSplitted[counter]);
                counter++;
            }

            Dish dish = new Dish
            {
                DishName = dName,
                DishSellingPrice = dPrice,
                DishWeight = dWeight,
                ProductsQuantity = productsQuantities,
                DishMakingPrice = makingPrice
            };

            db.Dishes.Add(dish);

            db.SaveChanges();

            var currentDish = db.Dishes.FirstOrDefault(d => d.DishName == dName);

            foreach (int id in productsInDish)
            {
                db.DishProducts.Add(new DishProducts
                {
                    DishId = currentDish.Id,
                    ProductId = id
                });
            }

            db.SaveChanges();
        }

        public Dish SelectDishByName(string name)
        {
            Dish dish = db.Dishes.SingleOrDefault(d => d.DishName == name);
            return dish;
        }

        public ICollection<Dish> LoadDishes()
        {
            return db.Dishes
                .Select(d => d)
                .ToArray();
        }

        public void EditDish(string dName, double dPrice, double dWeight, ICollection<Product> productsInDish, string productsQuantities)
        {
            Dish dish = db.Dishes.SingleOrDefault(d => d.DishName == dName);
            var productsIds = db.DishProducts.Select(p => p.ProductId).ToList();
            if (dish != null)
            {
                dish.DishSellingPrice = dPrice;
                dish.DishWeight = dWeight;

                var dishProducts = db.DishProducts.Where(dp => dp.DishId == dish.Id).ToList();

                db.DishProducts.RemoveRange(dishProducts);

                foreach (var product in productsInDish)
                {
                    var editedDishProduct = new DishProducts
                    {
                        DishId = dish.Id,
                        ProductId = product.Id
                    };

                    db.DishProducts.Add(editedDishProduct);
                }

                dish.ProductsQuantity = productsQuantities;

                double makingPrice = 0;
                string[] productsQuantitiesSplitted = productsQuantities.Split(' ');
                int counter = 0;

                foreach (Product pr in productsInDish)
                {
                    makingPrice += pr.Price * double.Parse(productsQuantitiesSplitted[counter]);
                    counter++;
                }

                dish.DishMakingPrice = makingPrice;
            }

            db.SaveChanges();
        }

        public void AddProductsToDish(Dish dish, ICollection<Product> products)
        {

            foreach(Product product in products)
            {
                db.Products.Add(product);
            }

            db.Dishes.Add(dish);

            db.SaveChanges();
        }

        public bool RemoveDish(string dName)
        {

            Dish dish = db.Dishes.SingleOrDefault(d => d.DishName == dName);
            if (dish != null)
            {
                db.Dishes.Remove(dish);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<DishProducts> SelectAllDishProducts(int id)
        {
            return db.DishProducts.Where(dp => dp.DishId == id).ToList();
        }

        public Dish SelectDishById(int id)
        {
            return db.Dishes.FirstOrDefault(d => d.Id == id);
        }

        public ICollection<Supplier> LoadSuppliers()
        {
            return db.Suppliers
                .Select(p => p)
                .ToArray();
        }

        public void AddSupplier(string supplierName , string supplierPhone , string supplierAvailableDays)
        {
            Supplier supplier = new Supplier
            {
                Name = supplierName,
                PhoneNumber = supplierPhone,
                AvailableDays = supplierAvailableDays
            };

            db.Suppliers.Add(supplier);

            db.SaveChanges();
        }

        public void EditSupplier(string supplierName, string supplierPhone, string supplierAvailableDays)
        {
            Supplier supplier = db.Suppliers.SingleOrDefault(p => p.Name == supplierName);
            if (supplier != null)
            {
                supplier.Name = supplierName;
                supplier.PhoneNumber = supplierPhone;
                supplier.AvailableDays = supplierAvailableDays;

                db.SaveChanges();
            }
        }

        public Supplier SelectSupplierByDay(string day)
        {
            ICollection<Supplier> suppliers = new HashSet<Supplier>();
            DateTime dt = DateTime.UtcNow;
            string today = dt.ToString("dddd");

            suppliers = db.Suppliers
                .Select(p => p)
                .ToArray();

            foreach (Supplier supplier in suppliers)
            {
                if (supplier.AvailableDays.Split(',').ToArray().Contains(today))
                {
                    return supplier;
                }
            }

            return null;

        }

        public ICollection<Product> GetDeliveryProducts(int id)
        {
            ICollection<Product> products = new HashSet<Product>();
            ICollection<DeliveryProducts2> dp = db.DeliveryProducts2.Select(p => p).ToArray();
            foreach (DeliveryProducts2 dp2 in dp)
            {
                if (dp2.DeliveryId == id)
                {
                    products.Add(db.Products.SingleOrDefault(p => p.Id == dp2.ProductId));
                }
            }
            return products;

        }

        public void AddDeliveryBasedOnProductQuantity()
        {
            ICollection<Product> products = LoadProducts();
            ICollection<Product> deliveryProducts = new HashSet<Product>();
            ICollection<Delivery> deliveries = LoadDeliveries();

            double deliveryPrice = 0;
            int deliveryQuantity = 0;

            DateTime dt = DateTime.UtcNow;
            string today = dt.ToString("dddd");
            Supplier supplier = SelectSupplierByDay(today);

            if (supplier != null)
            {
                foreach (Product product in products)
                {
                    if (product.Quantity <= 5)
                    {
                        deliveryProducts.Add(product);
                    }
                }
                if (deliveryProducts.Count() > 0)
                {
                    Delivery delivery = new Delivery
                    {
                        DeliveryQuantity = deliveryQuantity,
                        DeliveryPrice = deliveryPrice,
                        DeliveryDate = dt,
                        Approved = false,
                        Products = deliveryProducts,
                        Supplier = supplier
                    };

                    foreach (Product product in deliveryProducts)
                    {
                        AddProductsToDelivery(delivery, deliveryProducts);
                        db.DeliveryProducts2.Add(new DeliveryProducts2 { DeliveryId = delivery.Id, ProductId = product.Id });
                    }

                    foreach (var dl in deliveries)
                    {
                        if (dl.DeliveryDate < delivery.DeliveryDate && !(dl.Approved))
                        {
                            db.Deliveries.Remove(dl);                           
                        }
                    }
                    db.Deliveries.Add(delivery);
                    supplier.Deliveries.Add(delivery);
                    db.SaveChanges();
                }
            }
        } 

        public ICollection<Delivery> LoadDeliveries()
        {
            return db.Deliveries
                .Select(d => d)
                .ToArray();
        }

        //прави неодобрени доставки 
        public void AddDelivery(string productName, int productQuantity, string supplierName)
        {
            ICollection<Delivery> deliveries = LoadDeliveries();

            Product product = db.Products.SingleOrDefault(p => p.Name == productName);
            Supplier supplier = db.Suppliers.SingleOrDefault(s => s.Name == supplierName);

            foreach (Delivery dl in deliveries)
            {
                ICollection<Product> products = GetDeliveryProducts(dl.Id);

                if (dl.Supplier.Name == supplier.Name)
                {
                    if (products.Contains(product))
                    {
                        dl.DeliveryQuantity += productQuantity;
                        dl.DeliveryPrice += productQuantity * product.DeliveryPrice;
                        dl.DeliveryDate = DateTime.UtcNow;

                        db.SaveChanges();
                        break;                       
                    }
                    else if (dl.Supplier.Name == supplier.Name)
                    {
                        dl.Products.Add(product);
                        dl.DeliveryQuantity += productQuantity;
                        dl.DeliveryPrice += productQuantity * product.DeliveryPrice;
                        dl.DeliveryDate = DateTime.UtcNow;

                        db.DeliveryProducts2.Add(new DeliveryProducts2 { DeliveryId = dl.Id, ProductId = product.Id });
                        db.SaveChanges();
                        break;
                    }
                }
                else if(dl.Supplier.Name != supplier.Name && !(products.Contains(product)))
                {
                     ICollection<Product> deliveryProducts = new HashSet<Product>();
                     deliveryProducts.Add(product);
                     product.Quantity += productQuantity;

                     Delivery delivery = new Delivery
                     {
                         DeliveryQuantity = productQuantity,
                         DeliveryPrice = productQuantity*product.DeliveryPrice,
                         DeliveryDate = DateTime.UtcNow,
                         Approved = false,
                         Products = deliveryProducts,
                         Supplier = supplier
                     };
                     foreach (Product pr in deliveryProducts)
                     {
                         AddProductsToDelivery(delivery, deliveryProducts);
                         db.DeliveryProducts2.Add(new DeliveryProducts2 { DeliveryId = delivery.Id, ProductId = product.Id });
                     }                  
                     
                     supplier.Deliveries.Add(delivery);
                     db.Deliveries.Add(delivery);
                     db.SaveChanges();
                     break;
                }
            }           
        }

        //проверява ако има вече доставчик, който няма продукта и го добавя към него
        //проверява ако доставчика има от продуктите и добавя към тях количество
        //ако количеството за добавяне+количеството на продукта стане 0 маха продукта от доствката
        public void EditDelivery(string productName,int productQuantity,string supplierName)
        {
            ICollection<Delivery> deliveries = LoadDeliveries();

            Product product = db.Products.SingleOrDefault(p => p.Name == productName);
            Supplier supplier = db.Suppliers.SingleOrDefault(s => s.Name == supplierName);

            foreach (Delivery dl in deliveries)
            {
                ICollection<Product> products = GetDeliveryProducts(dl.Id);

                if (dl.Supplier.Name == supplier.Name)
                {
                    if (productQuantity+product.Quantity <= 0)
                    {                        
                        products.Remove(product);

                        if (products.Count == 0)
                        {
                            db.Deliveries.Remove(dl);
                            db.SaveChanges();
                        }
                        else
                        {
                            db.Deliveries.Remove(dl);
                            Delivery delivery = new Delivery
                            {
                                DeliveryDate = DateTime.UtcNow,
                                Approved = false,
                                Products = products,
                                Supplier = supplier
                            };
                            foreach (Product pr in products)
                            {
                                AddProductsToDelivery(delivery, products);
                                db.DeliveryProducts2.Add(new DeliveryProducts2 { DeliveryId = delivery.Id, ProductId = pr.Id });
                            }

                            supplier.Deliveries.Add(delivery);
                            db.Deliveries.Add(delivery);
                            db.SaveChanges();
                        }
                    }
                    else if (products.Contains(product))
                    {
                        product.Quantity +=productQuantity;
                        dl.DeliveryQuantity += productQuantity;
                        dl.DeliveryPrice += productQuantity * product.DeliveryPrice;
                        dl.DeliveryDate = DateTime.UtcNow;

                        break;
                    }
                    else if (dl.Supplier.Name == supplier.Name)
                    {
                        product.Quantity += productQuantity;

                        dl.Products.Add(product);
                        dl.DeliveryQuantity += productQuantity;
                        dl.DeliveryPrice += productQuantity * product.DeliveryPrice;
                        dl.DeliveryDate = DateTime.UtcNow;

                        db.DeliveryProducts2.Add(new DeliveryProducts2 { DeliveryId = dl.Id, ProductId = product.Id });
                        break;
                    }
                }
            

            }
        }

        //одобрява поръчка базирано на цена на доствката и доствчик
        public void ApproveDelivery(string supplierName)
        {
            ICollection<Delivery> deliveries = LoadDeliveries();           

            Supplier supplier = db.Suppliers.SingleOrDefault(s => s.Name == supplierName);

            foreach (Delivery dl in deliveries)
            {
                if (dl.Supplier == supplier)
                {
                    dl.Approved = true;
                    db.SaveChanges();
                    break;
                }
                
            }
        }                 

        public void AddProductsToDelivery(Delivery delivery, ICollection<Product> productsInDelivery)
        {
            delivery.Products = productsInDelivery;
            foreach (Product product in delivery.Products)
            {
                product.Deliveries.Add(delivery);               
            }
        }
       
        public bool AddElectricityExpense(string dateString, double elValue)
        {
            DateTime expenseDate = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);

            Expenses checkExpense = db.Expenses.SingleOrDefault(ex => ex.Name == "Ток" && ex.ExpenseDate == expenseDate);

            if (checkExpense != null)
            {
                return false;
            }
            else
            {
                Expenses expense = new Expenses
                {
                    Name = "Ток",
                    Value = elValue,
                    ExpenseDate = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ",
                                System.Globalization.CultureInfo.InvariantCulture)
                };

                db.Expenses.Add(expense);
                db.SaveChanges();
                return true;
            }
        }

        public bool AddWaterExpense(string dateString, double wValue)
        {
            DateTime expenseDate = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);

            Expenses checkExpense = db.Expenses.SingleOrDefault(ex => ex.Name == "Вода" && ex.ExpenseDate == expenseDate);

            if (checkExpense != null)
            {
                return false;
            }
            else
            {
                Expenses expense = new Expenses
                {
                    Name = "Вода",
                    Value = wValue,
                    ExpenseDate = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ",
                                System.Globalization.CultureInfo.InvariantCulture)
                };

                db.Expenses.Add(expense);
                db.SaveChanges();
                return true;
            }
        }

        public bool AddInternetExpense(string dateString, double iValue)
        {
            DateTime expenseDate = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);

            Expenses checkExpense = db.Expenses.SingleOrDefault(ex => ex.Name == "Интернет" && ex.ExpenseDate == expenseDate);

            if (checkExpense != null)
            {
                return false;
            }
            else
            {
                Expenses expense = new Expenses
                {
                    Name = "Интернет",
                    Value = iValue,
                    ExpenseDate = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ",
                              System.Globalization.CultureInfo.InvariantCulture)
                };

                db.Expenses.Add(expense);
                db.SaveChanges();
                return true;
            }
        }

        public List<Expenses> GetExpenses(string dateString)
        {
            DateTime expenseDate = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);

            Expenses electricityExpense = db.Expenses.SingleOrDefault(e => e.ExpenseDate == expenseDate && e.Name == "Ток");
            Expenses waterExpense = db.Expenses.SingleOrDefault(e => e.ExpenseDate == expenseDate && e.Name == "Вода");
            Expenses internetExpense = db.Expenses.SingleOrDefault(e => e.ExpenseDate == expenseDate && e.Name == "Интернет");

            List<Expenses> expenses = new List<Expenses>()
            {
                electricityExpense,
                waterExpense,
                internetExpense
            };

            List<int> indexesToRemove = new List<int>();

            foreach(Expenses expense in expenses)
            {
                if(expense == null)
                {
                    indexesToRemove.Add(expenses.IndexOf(expense));
                }
            }

            foreach(int index in indexesToRemove)
            {
                expenses.RemoveAt(index);
            }

            return expenses;
        }

        public bool EditExpenses(string dateString, double eValue, double wValue, double iValue)
        {
            DateTime expenseDate = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);

            List<Expenses> expenses = db.Expenses.Where(ex => ex.ExpenseDate == expenseDate).ToList();

            bool check = false;

            while(expenses.Count < 3)
            {
                expenses.Add(new Expenses
                {
                    Name = "невалиден"
                });
            }

            foreach(Expenses expense in expenses)
            {
                if (expense.Name == "Ток" && eValue != 0)
                {
                    expense.Value = eValue;
                    check = true;
                }
                else if (expense.Name == "Ток" && eValue == 0)
                {
                    continue;
                }
                else if (expense.Name == "Вода" && wValue != 0)
                {
                    expense.Value = wValue;
                    check = true;
                }
                else if(expense.Name == "Вода" && wValue == 0)
                {
                    continue;
                }
                else if (expense.Name == "Интернет" && iValue != 0)
                {
                    expense.Value = iValue;
                    check = true;
                }
                else if (expense.Name == "Интернет" && iValue == 0)
                {
                    continue;
                }
                else if(expense.Name == "невалиден" && check == true)
                {
                    break;
                }
                else
                {
                    return false;
                }
            }
            db.SaveChanges();
            return true;
        }

        public double GetDayReportExpenses(String dateString)
        {
            DateTime today = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);
            List<EmployerReport> todayReports = db.EmployerReports.Where(er => er.ReportDate == today).ToList();
            List<Dish> dishes = new List<Dish>();
            double productsInTodayDishesPrice = 0;

            foreach(EmployerReport report in todayReports)
            {
                List<DishEmployerReports> dishEmpReps = db.DishEmployerReports.Where(der => der.EmployerReportId == report.Id).ToList();
                foreach(DishEmployerReports empRep in dishEmpReps)
                {
                    dishes.Add(SelectDishById(empRep.DishId));
                }
                foreach (Dish dish in dishes)
                {
                    productsInTodayDishesPrice += dish.DishMakingPrice;
                }
            }

            return productsInTodayDishesPrice;
        }

        public double GetDayReportIncomes(String dateString)
        {
            DateTime today = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);
            List<EmployerReport> todayReports = db.EmployerReports.Where(er => er.ReportDate == today).ToList();
            double reportsBills = 0;

            foreach(EmployerReport report in todayReports)
            {
                reportsBills += report.Bill;
            }

            return reportsBills;
        }

        public List<EmployerReport> GetDayReports(string dateString)
        {
            DateTime today = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);
            List<EmployerReport> todayReports = db.EmployerReports.Where(er => er.ReportDate == today).ToList();
            return todayReports;
        }

        public void AddDayAccounting(string dateString, double expenses, double incomes, double profit, List<EmployerReport> dayReports)
        {
            DateTime day = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);
            DayAccountings dayAccounting = db.DayAccountings.SingleOrDefault(da => da.Date == day);
            MonthAccountings monthAccounting = db.MonthAccountings.SingleOrDefault(ma => ma.Date.Month == day.Month);

            if(dayAccounting == null)
            {
                if(monthAccounting == null)
                {
                    db.MonthAccountings.Add(new MonthAccountings
                    {
                        MonthExpense = expenses,
                        MonthIncome = incomes,
                        MonthProfit = profit,
                        Date = day
                    });

                    MonthAccountings newMonthAccounting = db.MonthAccountings.SingleOrDefault(ma => ma.Date.Month == day.Month);
                    DayAccountings newDayAccounting = new DayAccountings
                    {
                        DayExpense = expenses,
                        DayIncome = incomes,
                        DayProfit = profit,
                        Date = day,
                        EmployerReports = dayReports,
                        MonthAccountings = newMonthAccounting
                    };

                    db.DayAccountings.Add(newDayAccounting);
                    newMonthAccounting.DayAccountings.Add(newDayAccounting);

                    db.SaveChanges();
                }
                else
                {
                    DayAccountings newDayAccounting = new DayAccountings
                    {
                        DayExpense = expenses,
                        DayIncome = incomes,
                        DayProfit = profit,
                        Date = day,
                        EmployerReports = dayReports,
                        MonthAccountings = monthAccounting
                    };

                    db.DayAccountings.Add(newDayAccounting);
                    monthAccounting.DayAccountings.Add(newDayAccounting);
                    monthAccounting.MonthExpense += newDayAccounting.DayExpense;
                    monthAccounting.MonthIncome += newDayAccounting.DayIncome;
                    monthAccounting.MonthProfit += newDayAccounting.DayProfit;

                    db.SaveChanges();
                }
            }
        }
    }
}
