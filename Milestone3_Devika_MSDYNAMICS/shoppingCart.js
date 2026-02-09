class ShoppingCart {
    constructor() {
        this.items = [];
        this.discount = 0;
    }
    addItem(item) {
        const {name,price,quantity} = item;
        this.items.push({ name,price,quantity});
    }
        removeItem(name) {
            this.items = this.items.filter(item => item.name !== name);
        }
        calculateTotal() {
            return this.items.reduce((sum, item) => sum+item.price*item.quantity,0
        );
        }
        applyDiscount(code) {
            const discounts={
                SAVE10: 0.1,
                SAVE20: 0.2,
                SAVE30: 0.3
            };
            this.discount = discounts[code] || 0;
        }
        calculateTax(rate) {
            return this.calculateTotal()*rate;
        }
        checkout(rate) {
            const total=this.calculateTotal();
            const tax=this.calculateTax(rate);
            const discountAmount=total*this.discount;
            this.items=[];
            this.discount=0;
            return total+tax-discountAmount;
        }
    }
    module.exports=ShoppingCart;
