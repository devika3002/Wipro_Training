class InventoryManager {
    constructor() {
        this.products=[];
    }
    addProduct(product) {
        const exists= this.products.find(p => p.productID === product.productID);
        if(exists) {
            throw new Error("Product already exists");
        }
        this.products.push(product);
    }
    getProductById(id) {
        return this.products.find(p => p.productID === id) || null;
    }
    updateProduct(id,data) {
        const product=this.getProductById(id);
        if(!product) {
            throw new Error("Product not found");
        }
        Object.assign(product,data);

    }
    deleteProduct(id) {
        const index=this.products.findIndex(p => p.productID === id);
        if(index === -1) {
            throw new Error("Product not found");
        }
        this.products.splice(index,1);
    }
    listProducts() {
        return this.products;
    }
}
module.exports = InventoryManager;