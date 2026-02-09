//define typescript
type ServiceRequest= {
    name:string;
    email:string;
    service:string;
    description:string;
};
//use data
const demoRequest:ServiceRequest={
    name:"Demo User",
    email:"demo@example.com",
    service:"Water",
    description:"Demo request for validation"
};
const printRequest=(req:ServiceRequest): void => {
    console.log(`Request raised by ${req.name} for ${req.service}`);
};
printRequest(demoRequest);

