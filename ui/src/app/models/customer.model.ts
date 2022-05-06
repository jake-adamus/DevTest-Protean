export interface CustomerModel {
    customerId: number;
    customerName: string;
    customerType: CustomerType;
  }

  export enum CustomerType {
    Small = 1,
    Large = 2,
}