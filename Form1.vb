﻿Public Class Form1
    '    'هذا ليس مشروع كامل وإنما الديكيومنت كما هي من الفوترة
    '    'هذا هو الكود الذي يوضح كيفية استخدام الديكيومنت في الفوترة
    '    JoFotara
    'The Technical Guide On Integration With the National E-invoicing System (JoFotara)
    'Prepared by:
    'JoFotara Technical Support Committee
    '2023
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE On INTEGRATION With THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 2
    'Technical Guide On Integration With Jofotara
    'Through the Application Programming Interface (API) (1.4)
    'Version No. Document Type Date Of Issue
    '1.1
    'Draft
    '12 Jan 2023
    '1.2
    'Draft
    '16 Jan 2023
    '1.3
    'Approved
    '23 Jan 2023
    '1.4
    'Approved
    '01 Dec 2023
    'Prepared by: JoFotara Technical Support Committee Name Work place Mobile Number
    'E-mail
    'Fadi Al-Hamad
    'ISTD
    '0790122303
    'Fadi.h@istd.gov.joKhaldoon Abu Yaman
    'ISTD
    '0799058372
    'Khaldoon.a@istd.gov.jo
    'Eng. Muhammad Al-Gharabli
    'ISTD
    '0789187087
    'Mohammad.ga@istd.gov.jo
    'With the participation Of:
    'Approved by: Approving Entity Date E-Invoicing Directorate 12 Jan 2023
    'Name Work place Name Work place
    'Eng. Ahmad Al Jawawdeh
    'ISTD
    'Heba Abu Al-Ajwah
    'ISTD
    'Eng. Mohammad Al-Sha'lan
    'ISTD
    'Majdi Asha
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE On INTEGRATION With THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 3
    'Table of Contents
    'Signing up On the system……………………………...……………………………………………………5
    'Sequence of procedures for sending an invoice ............................................................................................ 8
    '1) Components of JSON file ..................................................................................... 9
    '2) Components of e-invoice in XML format ............................................................ 9
    'First: The Income Invoice……………………………………………………………………………….Error! Bookmark Not defined.
    'A. Basic information of the invoice ........................................................................ 11
    'B. Seller's information (taxpayer)........................................................................... 13
    'C. Buyer's information ........................................................................................... 14
    'D. Seller's (taxpayer’s) sequence of income source ............................................... 16
    'E. Inputs of the total income invoice ...................................................................... 17
    'F. Inputs of income invoice items........................................................................... 19
    'Second: The credit invoice For income tax ................................................................................................. 21
    'A. Information on the credit invoice And refrence invoice .... Error! Bookmark Not defined.
    'B. Seller's information (taxpayer)........................................................................... 24
    'C. Buyer's information ........................................................................................... 25
    'D. Seller's (taxpayer’s) sequence of income source ............................................... 26
    'E. Reason for return ................................................................................................ 26
    'F. Inputs of the total credit invoice for income tax ................................................ 27
    'G. Inputs of the credit invoice for income tax items……………………….…..….29
    'Third: The Genral Sales Invoice ............................................................................................................... 358
    'A. Basic information of the invoice ........................................................................ 59
    'B. Seller's information (taxpayer)........................................................................... 34
    'C. Buyer's information ........................................................................................... 35
    'D. Seller's (taxpayer’s) sequence of income source ............................................... 37
    'E. Inputs of the total general invoice ...................................................................... 38
    'F. Inputs of the genral sales invoice items (goods)................................................ 40
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE On INTEGRATION With THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 4
    'Fourth: Credit invoice For General Sales ................................................................................................... 44
    'A. Basic information of the invoice ........................................................................ 45
    'B. Information of the refrence invoice .................................................................... 46
    'C. Seller's unformation (taxpayer) .......................................................................... 47
    'D. Buyer's information ........................................................................................... 48
    'E. Seller's (taxpayer’s) sequence of income source ............................................... 49
    'F. Reason for return ................................................................................................ 49
    'G. Total discount ………………………………...……………………….……….49
    'H. Total tax value intended to be returned………………………………..……….50
    'I. Inputs of the total credit invoice…………………..…………………………..53
    'J. Inputs of the credit invoice items……………………………………………...54
    'Fifth: The Special Sales Invoice ................................................................................................................. 58
    'A. Basic information of the invoice ........................................................................ 59
    'B. Seller's information (taxpayer)........................................................................... 61
    'C. Buyer's information ........................................................................................... 62
    'D. Seller's (taxpayer’s) sequence of income source ............................................... 64
    'E. Inputs of the total special invoice ....................................................................... 65
    'F. Inputs of the special sales invoice items (goods) ............................................... 67
    'Sixth: Credit Invoice For Special Sales ...................................................................................................... 72
    'A. Basic information of the invoice ........................................................................ 73
    'B. Information of the refrence invoice .................................................................... 74
    'C. Seller's unformation (taxpayer) .......................................................................... 76
    'D. Buyer's information ........................................................................................... 77
    'E. Seller's (taxpayer’s) sequence of income source ............................................... 78
    'F. Reason for return ................................................................................................ 78
    'G. Inputs of the total credit invoice for special sales tax …………………...…….79
    'H. Inputs of the credit invoice for special sales tax items………………………....81
    '3) Preparing And sending JSON file……………………………………………………………………….85
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE On INTEGRATION With THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 5
    'Signing up On the system
    'After sign-up Is complete
    '1. The taxpayer enters the invoicing system through the following screen:
    'Note Note
    'To To sign up sign up And create an account on the And create an account on the And create an account on the And create an account on the And create an account on the And create an account on the And create an account on the And create an account on the And create an account on the And create an account on the And create an account on the And create an account on the And create an account on the e-invoicing invoicinginvoicing system, please seesystem, please see system, please see system, please see system, please see system, please see system, please seesystem, please see the Procedures Guide the Procedures Guide the Procedures Guide the Procedures Guide the Procedures Guide the Procedures Guide the Procedures Guide the Procedures Guide the Procedures Guide the Procedures Guide to Join the Jordanian National E to Join the Jordanian National Eto Join the Jordanian National E to Join the Jordanian National E to Join the Jordanian National Eto Join the Jordanian National E to Join the Jordanian National E to Join the Jordanian National Eto Join the Jordanian National E to Join the Jordanian National E to Join the Jordanian National E-invoicing System invoicing System invoicing System invoicing System published on the published on the published on the published on the published on the ISTD's ISTD’s websitewebsitewebsite website: http://www.istd.gov.jo. http://www.istd.gov.jo. http://www.istd.gov.jo.http://www.istd.gov.jo.http://www.istd.gov.jo.http://www.istd.gov.jo. http://www.istd.gov.jo. http://www.istd.gov.jo.
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE On INTEGRATION With THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 6
    '2. Click on 'Linking Electronic Devices’, then click on ‘Link a New Device’.
    '1. Enter the username And the sequence of the income source, then click on the 'Add’ icon
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE On INTEGRATION With THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 7
    '3. The system will automatically create the 'Client ID’ and the ‘Secret Key’.
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE On INTEGRATION With THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 8
    'Sequence of procedures for sending an invoice
    'The sequence Of procedures For sending the e-invoice through linking With the national e-invoicing systemE-invoices are sent through linking With the national e-invoicing system, according To the following schematic diagram:
    'A diagram showing the sequence Of procedures For sending the e-invoice through linking With the national invoicing system
    'XML file(invoice details)
    'Result of sending the invoice
    'E-invoice
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE On INTEGRATION With THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 9
    '1) Components of JSON file
    'To generate the e-invoice And prepare it for sending in JSON file format, the e-invoice has to contain three components:
    'a. Client ID
    'b. Secret Key
    'c. The invoice in XML format
    '2) Components of e-invoice in XML format
    'The (UBL 2.1 Invoice) standard has been adopted as a structure for the e-invoice, And the elements below represent the start of the XML file And the references required to process this file according to the (UBL 2.1) standard: <?xml version="1.0" encoding="UTF-8"?> <Invoice xmlns="urn:oasis:names:specification:ubl:schema:xsd:Invoice-2" xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2" xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2" xmlns:ext="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2"> <cbc:ProfileID>reporting:1.0</cbc:ProfileID>
    'The following Is a detailed explanation Of Each component Of the e-invoice In XML format based On the type Of taxpayer:
    ' Income invoice For taxpayers who are unregistered in the sales tax.
    ' Creating an income invoice template
    ' Credit invoice for income tax template
    ' Sales invoice: For taxpayers who are registered in the sales tax.
    ' Creating a sales invoice
    ' Credit invoice for sales invoice template
    ' Special sales invoice template: For taxpayers who are registered in the special sales tax.
    ' Creating a special sales invoice template
    ' Credit invoice for special tax invoice template
    'Note
    'The Client ID And The Client ID And The Client ID And The Client ID And The Client ID And The Client ID And The Client ID And The Client ID And The Client ID And The Client ID And the Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National Secret Key are obtained from the Device Link screen In National E-invoicing invoicinginvoicing SystemSystemSystem
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE On INTEGRATION With THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 10
    'First: The Income Invoice
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE On INTEGRATION With THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 11
    'The elements shaded In yellow In the examples below indicate variables To be filled (mandotary) through the seller system. As For the The elements shaded In green indicate variables To be filled (Optional) through the seller system. And the rest Of the elements are a fixed description (unchangeable).
    'A. Basic information of the invoice <cbc:ID> invoice no. </cbc:ID> <cbc:UUID>serial no.</cbc:UUID> <cbc:IssueDate> invoice issue date </cbc:IssueDate> <cbc:InvoiceTypeCode name = "payment method" > 388</cbc:InvoiceTypeCode> <cbc:Note>invoice description Or remark</cbc:Note>
    '<cbc: DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode>
    '<cbc: TaxCurrencyCode>JOD</cbc:TaxCurrencyCode>
    '<cac: AdditionalDocumentReference>
    '<cbc: ID>ICV</cbc:ID> <cbc:UUID>invoice counter</cbc:UUID>
    '</cac:AdditionalDocumentReference> Description XML Element Invoice no. Is entered here <cbc:ID>invoice no.</cbc:ID> UUID (Universal Unique Identifier) Is a unique number generated by the taxpayer's system so that the ID and UUID together form a Primary Key to not duplicate the invoice sent on the system. <cbc:UUID>serial no.</cbc:UUID> The invoice date must be in the following format: dd-mm-yyyy, for example, 31-12-2022 <cbc:IssueDate>invoice issue date</cbc:IssueDate> The ‘name’ feature is to denote the payment method (cash,receivable) The codes contained in this example are for income invoices only. The no. (388) denotes a new invoice as described in the table below. <cbc:InvoiceTypeCode name="payment method">
    '388
    '</cbc:InvoiceTypeCode>
    'Create a New cash invoice <cbc:InvoiceTypeCode name = "011" > 388</cbc:InvoiceTypeCode> Create a New receivable invoice <cbc:InvoiceTypeCode name = "021" > 388</cbc:InvoiceTypeCode>
    'Used for adding any remark Or description to the invoice, Or any data the seller wishes to document. <cbc:Note> invoice description Or remark</cbc:Note>
    'The invoice counter Is created by the taxpayer. A counter created by the taxpayer For e-invoices starts In sequence from 1 To infinity according To the universal definition) Note
    '<cac: AdditionalDocumentReference>
    '<cbc: ID>ICV</cbc:ID> <cbc:UUID>invoice counter</cbc:UUID>
    '</cac:AdditionalDocumentReference>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE On INTEGRATION With THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 12
    'The taxpayer can costumize the sequence As preferred
    'مثال
    '<cbc: ID>EIN00001</cbc:ID> <cbc:UUID>0043e15e-740b-4e1b-889d-504afdb1d1d</cbc:UUID> <cbc:IssueDate>2023-10-30</cbc:IssueDate> <cbc:InvoiceTypeCode name = "011" > 388</cbc:InvoiceTypeCode> <cbc:Note>notes </cbc:Note> <cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode> <cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode> <cac:AdditionalDocumentReference> <cbc:ID>ICV</cbc:ID> <cbc:UUID>1</cbc:UUID> </cac:AdditionalDocumentReference>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE On INTEGRATION With THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 13
    'B. Seller's information (taxpayer)
    '<cac: AccountingSupplierParty>
    '<cac: Party>
    '<cac: PostalAddress>
    '<cac: Country>
    '<cbc: IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac: PartyTaxScheme> <cbc:CompanyID>Seller's TIN</cbc:CompanyID>
    '<cac: TaxScheme>
    '<cbc: ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac: PartyLegalEntity> <cbc:RegistrationName>Seller's name</cbc:RegistrationName>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '</cac:AccountingSupplierParty> Description XML Element Taxpayer's (seller’s) TIN <cbc:CompanyID>Seller’s TIN</cbc:CompanyID> Seller’s name as registered in the ISTD <cbc:RegistrationName>Seller’s name</cbc:RegistrationName> Example <cac:AccountingSupplierParty> <cac:Party> <cac:PostalAddress> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cbc:CompanyID>12345678</cbc:CompanyID> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> <cbc:RegistrationName>The Technical Company for Supplies</cbc:RegistrationName> </cac:PartyLegalEntity> </cac:Party> </cac:AccountingSupplierParty>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE On INTEGRATION With THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 14
    'C. Buyer's information
    '<cac: AccountingCustomerParty>
    '<cac: Party>
    '<cac: PartyIdentification> <cbc:ID schemeID = "type" > No.</cbc:ID>
    '</cac:PartyIdentification>
    '<cac: PostalAddress> <cbc:PostalZone>Postal Code</cbc:PostalZone>
    '<cac: Country>
    '<cbc: IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac: PartyTaxScheme>
    '<cac: TaxScheme>
    '<cbc: ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac: PartyLegalEntity> <cbc:RegistrationName>Buyer's name</cbc:RegistrationName>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '<cac: AccountingContact> <cbc:Telephone>Phone no.</cbc:Telephone>
    '</cac:AccountingContact>
    '</cac:AccountingCustomerParty> Description XML Element One of the options for the buyer's data is entered according to the following table: and it can only be numbers according to the following table: <cbc:ID schemeID=" type">no.</cbc:ID> Type No. NIN Buyer’s national identification number PN Document no. (passport, residence, ect.) TN Buyer’s TIN
    'Note
    'The buyer 's name is mandatory if the invoice The buyer’s name is mandatory if the invoice The buyer’s name is mandatory if the invoice The buyer’s name is mandatory if the invoice The buyer’s name is mandatory if the invoice The buyer’s name is mandatory if the invoice The buyer’s name is mandatory if the invoice The buyer’s name is mandatory if the invoice The buyer’s name is mandatory if the invoice The buyer’s name is mandatory if the invoice The buyer’s name is mandatory if the invoice The buyer’s name is mandatory if the invoice receivable or if the cash invoice value is more receivable or if the cash invoice value is more receivable or if the cash invoice value is more receivable or if the cash invoice value is more receivable or if the cash invoice value is more receivable or if the cash invoice value is more receivable or if the cash invoice value is more receivable or if the cash invoice value is more receivable or if the cash invoice value is more receivable or if the cash invoice value is more receivable or if the cash invoice value is more receivable or if the cash invoice value is more receivable or if the cash invoice value is more receivable or if the cash invoice value is more receivable or if the cash invoice value is more receivable or if the cash invoice value is more than 10000 JOD. than 10000 JOD.
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE On INTEGRATION With THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 15
    'Description XML Element
    'Buyer's postal code <cbc:PostalZone>Postal Code</cbc:PostalZone> Buyer’s name <cbc:RegistrationName>Buyer’s name</cbc:RegistrationName> Buyer’s phone number <cbc:Telephone>Buyer’s phone no.</cbc:Telephone> Example <cac:AccountingCustomerParty> <cac:Party> <cac:PartyIdentification> <cbc:ID schemeID="TN">33445544</cbc:ID> </cac:PartyIdentification> <cac:PostalAddress> <cbc:PostalZone>33554</cbc:PostalZone> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> <cbc:RegistrationName>Ahmad mohammad</cbc:RegistrationName> </cac:PartyLegalEntity> </cac:Party> <cac:AccountingContact> <cbc:Telephone>777888999</cbc:Telephone> </cac:AccountingContact> </cac:AccountingCustomerParty>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE On INTEGRATION With THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 16
    'D. Seller's (taxpayer’s) sequence of income source Description XML Element The taxpayer’s (seller’s) sequence of income source (activity)
    '<cac: SellerSupplierParty>
    '<cac: Party>
    '<cac: PartyIdentification> <cbc:ID>Sequence of income source</cbc:ID>
    '</cac:PartyIdentification>
    '</cac:Party>
    '</cac:SellerSupplierParty> Example <cac:SellerSupplierParty> <cac:Party> <cac:PartyIdentification> <cbc:ID>9932895</cbc:ID> </cac:PartyIdentification> </cac:Party> </cac:SellerSupplierParty>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE On INTEGRATION With THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 17
    'E. Inputs of the total income invoice
    '<cac: AllowanceCharge>
    '<cbc: ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc: AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID = "JO" > Total discount In JOD</cbc:Amount>
    '</cac:AllowanceCharge>
    '<cac: LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID = "JO" > Total invoice before discount</cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID = "JO" > Total invoice</cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID = "JO" > Total discount</cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID = "JO" > Total invoice</cbc:PayableAmount>
    '</cac:LegalMonetaryTotal> Description XML Element The total amount of discount on the goods, as the system does Not accept discounts on the invoice in general.
    '<cbc:Amount currencyID = "JO" > Total discount In JOD</cbc:Amount> Note: If the taxpayer system calculates the discount On the total invoice, the discount must be distributed To the goods And services before migrating the data To the e-invoicing system .
    'Total invoice before discount
    '<cbc:TaxExclusiveAmount currencyID = "JO" > Total invoice before discount </cbc:TaxExclusiveAmount>
    'Total invoice before discount = sum (price * quantity) Of all goods And services In the invoice. Total invoice
    '<cbc:TaxInclusiveAmount currencyID = "JO" > Total invoice</cbc:TaxInclusiveAmount> Total invoice = Total invoice before discount - Total discount amount Total discount
    '<cbc:AllowanceTotalAmount currencyID = "JO" > Total discount</cbc:AllowanceTotalAmount>
    'Total discount amount = Total discount amount For goods And services Total invoice
    '<cbc:PayableAmount currencyID = "JO" > Total invoice</cbc:PayableAmount> Total invoice = Total invoice before discount - Total discount amount Example <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID = "JO" > 2.0</cbc:Amount> </cac:AllowanceCharge> <cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID = "JO" > 66.0</cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID = "JO" > 64.0</cbc:TaxInclusiveAmount>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE On INTEGRATION With THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 18
    '<cbc:AllowanceTotalAmount currencyID = "JO" > 2.0</cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID = "JO" > 64.0</cbc:PayableAmount> </cac:LegalMonetaryTotal>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE On INTEGRATION With THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 19
    'F. Inputs of income invoice items
    '<cac: InvoiceLine> <cbc:ID>Serial no.</cbc:ID> <cbc:InvoicedQuantity unitCode = "PCE" > Quantity</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID = "JO" > (Unit Price * Quantity) – Discount on the good or service
    '</cbc:LineExtensionAmount>
    '<cac:Item> <cbc:Name>Good or service description</cbc:Name>
    '</cac:Item>
    '<cac:Price> <cbc:PriceAmount currencyID="JO">Unit price</cbc:PriceAmount>
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">Amount of discount</cbc:Amount>
    '</cac:AllowanceCharge>
    '</cac:Price>
    '</cac:InvoiceLine> Description XML Element A serial number that is unique for each good or service. It is not repeated on the single invoice level <cbc:ID>Serial no.</cbc:ID> The quantity of the same good or service.
    '<cbc:InvoicedQuantity unitCode="PCE"> Quantity</cbc:InvoicedQuantity> Total amount of the good or service = Unit price * Quantity - Discount on the good or service.
    '<cbc:LineExtensionAmount currencyID="JO"> (Unit Price * Quantity) – Discount on the good or service</cbc:LineExtensionAmount> The name of good or service, or its description is to be added. <cbc:Name>Good or service description</cbc:Name> The unit price of the good or service.
    '<cbc:PriceAmount currencyID="JO"> Unit price</cbc:PriceAmount> The amount of the discount on the good or service, if any, is to be added in JOD from the total price of the good or service.
    '<cbc:Amount currencyID="JO"> Discount amount</cbc:Amount>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 20
    'Example <cac:InvoiceLine>== Start of the first good or service <cbc:ID>1</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">33.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">64.00</cbc:LineExtensionAmount> <cac:Item> <cbc:Name>chocolate </cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">2.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine> <cac:InvoiceLine> == Start of the second good or service <cbc:ID>1</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">33.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">64.00</cbc:LineExtensionAmount> <cac:Item> <cbc:Name>chocolate</cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">2.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine>
    'Note
    'It is possible to add more than oneIt is possible to add more than one It is possible to add more than one It is possible to add more than one It is possible to add more than one It is possible to add more than oneIt is possible to add more than one It is possible to add more than one It is possible to add more than oneIt is possible to add more than oneIt is possible to add more than oneIt is possible to add more than one It is possible to add more than oneIt is possible to add more than one It is possible to add more than one good or service by or service by or service by or service by or service by or service by or service by or service by or service by or service by re -enteringentering enteringentering the data of the data of thethe data of the the data of the data of good or good orgood or service, as shown in the example service, as shown in the example service, as shown in the example service, as shown in the example service, as shown in the example service, as shown in the example service, as shown in the example service, as shown in the exampleservice, as shown in the example above above .
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 21
    'Second: The Credit Invoice of Income Tax
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 22
    'The elements shaded in yellow in the examples below indicate variables to be filled (mandotary) through the seller system. As for the The elements shaded in green indicate variables to be filled (optional) through the seller system. And the rest of the elements are a fixed description (unchangeable).
    'A. Information of the credit invoice and the reference invoice <cbc:ID> credit invoice no.</cbc:ID> <cbc:UUID> credit invoice serial no.</cbc:UUID> <cbc:IssueDate> credit invoice date </cbc:IssueDate> <cbc:InvoiceTypeCode name="payment method">381</cbc:InvoiceTypeCode> <cbc:Note>credit invoice description or remark</cbc:Note>
    '<cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode>
    '<cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode> <cac:BillingReference>
    '<cac:InvoiceDocumentReference> <cbc:ID> original reference invoice no.</cbc:ID> <cbc:UUID>no. of the original reference invoice </cbc:UUID> <cbc:DocumentDescription> total value of the original reference invoice
    '</cbc:DocumentDescription>
    '</cac:InvoiceDocumentReference>
    '</cac:BillingReference>
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID>invoice counter</cbc:UUID>
    '</cac:AdditionalDocumentReference> Description XML Element The credit invoice is entered here.
    '<cbc:ID>reference invoice no.</cbc:ID>
    'Notes Notes Notes
    'The return of an invoice process is The return of an invoice process is The return of an invoice process is The return of an invoice process is The return of an invoice process is The return of an invoice process is The return of an invoice process is The return of an invoice process is The return of an invoice process is The return of an invoice process is The return of an invoice process is The return of an invoice process is The return of an invoice process is The return of an invoice process is The return of an invoice process is The return of an invoice process is The return of an invoice process is The return of an invoice process is The return of an invoice process is The return of an invoice process is The return of an invoice process is The return of an invoice process is only allowed within the following conditions:only allowed within the following conditions:only allowed within the following conditions: only allowed within the following conditions:only allowed within the following conditions:only allowed within the following conditions: only allowed within the following conditions:only allowed within the following conditions: only allowed within the following conditions: only allowed within the following conditions:only allowed within the following conditions: only allowed within the following conditions:only allowed within the following conditions:only allowed within the following conditions:only allowed within the following conditions: only allowed within the following conditions:only allowed within the following conditions:only allowed within the following conditions: only allowed within the following conditions:only allowed within the following conditions: only allowed within the following conditions:only allowed within the following conditions:only allowed within the following conditions:only allowed within the following conditions:only allowed within the following conditions:only allowed within the following conditions:only allowed within the following conditions: only allowed within the following conditions: only allowed within the following conditions:only allowed within the following conditions:
    '1. The system allows return system allows return system allows return system allows returnsystem allows return system allows returnsystem allows return system allows return system allows returnsystem allows return s on quantitieson quantitieson quantitieson quantitieson quantitieson quantitieson quantitieson quantitieson quantities on quantities onlyonlyonly .
    '2. The system does not allow The system does not allow The system does not allow The system does not allow The system does not allow The system does not allow The system does not allow The system does not allow The system does not allow The system does not allow The system does not allow The system does not allow The system does not allow The system does not allow The system does not allow The system does not allow exceeding exceeding exceeding exceeding the the the quantities sold in the quantities sold in the quantities sold in the quantities sold in the quantities sold in the quantities sold in the quantities sold in the quantities sold in the quantities sold in the quantities sold in the quantities sold in the quantities sold in the quantities sold in the quantities sold in the originaloriginal originaloriginal originaloriginal invoice. invoice.invoice.invoice. invoice.
    '3. The system allows the taxpayer to The system allows the taxpayer to The system allows the taxpayer to The system allows the taxpayer to The system allows the taxpayer toThe system allows the taxpayer to The system allows the taxpayer toThe system allows the taxpayer to The system allows the taxpayer toThe system allows the taxpayer toThe system allows the taxpayer to The system allows the taxpayer toThe system allows the taxpayer toThe system allows the taxpayer toThe system allows the taxpayer toThe system allows the taxpayer toThe system allows the taxpayer toThe system allows the taxpayer to The system allows the taxpayer toThe system allows the taxpayer to send sendsend a return return return return of of of an invoice on the original invoice on the original invoiceinvoice on the original invoiceinvoice on the original invoice invoice on the original invoice on the original invoiceinvoice on the original invoiceinvoice on the original invoiceinvoice on the original invoiceinvoice on the original invoiceinvoice on the original invoiceinvoice on the original invoiceinvoice on the original invoiceinvoice on the original invoice invoice on the original invoiceinvoice on the original invoice invoice on the original invoiceinvoice on the original invoice invoice on the original invoice on the original invoiceinvoice on the original invoiceinvoice on the original invoice invoice on the original onceonceonceonce or more until all of the quantities or more until all of the quantities or more until all of the quantities or more until all of the quantities or more until all of the quantities or more until all of the quantities or more until all of the quantities or more until all of the quantities or more until all of the quantities or more until all of the quantities or more until all of the quantities or more until all of the quantities or more until all of the quantities or more until all of the quantities or more until all of the quantities or more until all of the quantities or more until all of the quantities or more until all of the quantities or more until all of the quantities or more until all of the quantities or more until all of the quantities or more until all of the quantities of theof theof theof theof theof the sold items are finished.sold items are finished. sold items are finished.sold items are finished. sold items are finished.sold items are finished. sold items are finished.sold items are finished.sold items are finished.sold items are finished. sold items are finished.
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 23
    'UUID (Universal Unique Identifier) is a unique number generated by the taxpayer's system so that the ID and UUID together form a (Primary Key) to not duplicate the invoice sent on the system. <cbc:UUID> credit invoice serial no. </cbc:UUID> The invoice date must be in the following format: dd-mm-yyyy, for example, 31-12-2022 <cbc:IssueDate> credit invoice date </cbc:IssueDate> The ‘name’ feature is to denote the payment method (cash,receivable) as displayed below The no. (381) donates it’s a credit invoice The codes illestraded below are only for the income invoices <cbc:InvoiceTypeCode name="payment method">
    '381
    '</cbc:InvoiceTypeCode>
    'Create a new cash invoice <cbc:InvoiceTypeCode name="011">381</cbc:InvoiceTypeCode> Create a new receivable invoice <cbc:InvoiceTypeCode name="021">381</cbc:InvoiceTypeCode>
    'Used for adding any remark or description to the invoice, or any data the seller wishes to document. <cbc:Note> credit invoice description or remark
    '</cbc:Note>
    'The original reference invoice numbeer
    '<cac:BillingReference>
    '<cac:InvoiceDocumentReference> <cbc:ID> original reference invoice no </cbc:ID> The (UUID) no. of the original reference invoice <cbc:UUID> no. of the original reference invoice
    '</cbc:UUID> The total value of the original reference invoice <cbc:DocumentDescription> total value of the original reference invoice </cbc:DocumentDescription> </cac:InvoiceDocumentReference>
    '</cac:BillingReference> The invoice counter is created by the taxpayer.
    'A counter created by the taxpayer for e-invoices starts in sequence from 1 to infinity According to the universal definition) Note: The taxpayer can costumize the sequence as preferred
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID>invoice counter</cbc:UUID>
    '</cac:AdditionalDocumentReference> Example <cbc:ID>EIN00002</cbc:ID> <cbc:UUID>8055b137-a128-46d6-9421-8c2a6de57465</cbc:UUID> <cbc:IssueDate>2023-11-01</cbc:IssueDate> <cbc:InvoiceTypeCode name="011">381</cbc:InvoiceTypeCode> <cbc:Note>Notes</cbc:Note> <cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode> <cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode> <cac:BillingReference>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 24
    '<cac:InvoiceDocumentReference> <cbc:ID>EIN00001</cbc:ID> <cbc:UUID>0043e15e-740b-4e1b-889d-504afdb1d1d</cbc:UUID> <cbc:DocumentDescription>64.000</cbc:DocumentDescription> </cac:InvoiceDocumentReference> </cac:BillingReference> <cac:AdditionalDocumentReference> <cbc:ID>ICV</cbc:ID> <cbc:UUID>2</cbc:UUID> </cac:AdditionalDocumentReference>
    'B. Seller’s information (taxpayer)
    '<cac:AccountingSupplierParty>
    '<cac:Party>
    '<cac:PostalAddress>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme> <cbc:CompanyID> Seller’s TIN </cbc:CompanyID>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity> <cbc:RegistrationName> Seller’s name </cbc:RegistrationName>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '</cac:AccountingSupplierParty> Description XML Element Taxpayer’s (seller’s) TIN <cbc:CompanyID> Seller’s TIN/cbc:CompanyID> Seller’s name as registered in the ISTD <cbc:RegistrationName> Seller’s name</cbc:RegistrationName> Example <cac:AccountingSupplierParty> <cac:Party> <cac:PostalAddress> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cbc:CompanyID>12345678</cbc:CompanyID>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 25
    '<cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> <cbc:RegistrationName>The Technical Company for Supplies </cbc:RegistrationName> </cac:PartyLegalEntity> </cac:Party> </cac:AccountingSupplierParty>
    'C. Buyer’s information (fixed description without any changes or additions)
    '<cac:AccountingCustomerParty>
    '<cac:Party>
    '<cac:PostalAddress>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '</cac:AccountingCustomerParty> Example <cac:AccountingCustomerParty> <cac:Party>` <cac:PostalAddress> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme>
    'The buyer’s information is taken from the original invoice whereas it can not be modified in the credit invoice.
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 26
    '<cac:PartyLegalEntity> </cac:PartyLegalEntity> </cac:Party> </cac:AccountingCustomerParty>
    'D. Seller’s (taxpayer’s) sequence of income source Description XML Element The taxpayer’s (seller’s) sequence of income source (activity)
    '<cac:SellerSupplierParty>
    '<cac:Party>
    '<cac:PartyIdentification> <cbc:ID>Sequence of income source</cbc:ID>
    '</cac:PartyIdentification>
    '</cac:Party>
    '</cac:SellerSupplierParty> Example <cac:SellerSupplierParty> <cac:Party> <cac:PartyIdentification> <cbc:ID>9932895</cbc:ID> </cac:PartyIdentification> </cac:Party> </cac:SellerSupplierParty>
    'E. Reason for return Description XML Element A reason for the return must be provided.
    '<cac:PaymentMeans>
    '<cbc:PaymentMeansCode listID="UN/ECE 4461">10</cbc:PaymentMeansCode> <cbc:InstructionNote>reason for return</cbc:InstructionNote>
    '</cac:PaymentMeans> Example <cac:PaymentMeans> <cbc:PaymentMeansCode listID="UN/ECE 4461">10</cbc:PaymentMeansCode> <cbc:InstructionNote>returned due product defect</cbc:InstructionNote> </cac:PaymentMeans>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 27
    'F. Inputs of the total credit invoice for income tax
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO"> Total discount in JO </cbc:Amount>
    '</cac:AllowanceCharge>
    '<cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">Total credit invoice before discount</cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO"> total credit invoice </cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO"> total discount </cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID="JO">total credit invoice</cbc:PayableAmount>
    '</cac:LegalMonetaryTotal> Description XML Element The total amount of discount on the goods, as the system does not accept discounts on the invoice in general.
    '<cbc:Amount currencyID="JO"> Total discount in JO </cbc:Amount> Total credit invoice before discount
    '<cbc:TaxExclusiveAmount currencyID="JO"> Total credit invoice before discount </cbc:TaxExclusiveAmount> Total credit invoice before discount = sum(price * quantity) for all the goods and services information intended to be returned Total credit invoice
    '<cbc:TaxInclusiveAmount currencyID="JO"> total credit invoice </cbc:TaxInclusiveAmount> Total credit invoice= total credit invoice before discount ̶ total discount Total discount
    '<cbc:AllowanceTotalAmount currencyID="JO">total discount
    '</cbc:AllowanceTotalAmount>
    'Total discount value= total discount on goods and services intended to be returned Total credit invoice
    '<cbc:PayableAmount currencyID="JO"> total credit invoice
    '</cbc:PayableAmount> Total credit invoice = Total credit invoice before discount - Total discount value
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 28
    'Example <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> <cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">66.00</cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">64.00</cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">2.00</cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID="JO">64.00</cbc:PayableAmount> </cac:LegalMonetaryTotal>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 29
    'G. Inputs of the credit invoice for income tax items
    '<cac:InvoiceLine> <cbc:ID> serial no.</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE"> returned quantity</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">(Unit Price * Quantity) – Discount on the good or service </cbc:LineExtensionAmount>
    '<cac:Item> <cbc:Name> Good or service description</cbc:Name>
    '</cac:Item>
    '<cac:Price> <cbc:PriceAmount currencyID="JO">unit price </cbc:PriceAmount>
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO"> amount of discount</cbc:Amount>
    '</cac:AllowanceCharge>
    '</cac:Price>
    '</cac:InvoiceLine> Description XML Element Good or service number as it is found in the original reference invoice <cbc:ID>serial no. </cbc:ID> Quantity of the good or service intended to be returned without exceeding the quantity found in the original invoice
    '<cbc:InvoicedQuantity unitCode="PCE"> returned quantity </cbc:InvoicedQuantity> The total amount of the good or service= unit price* quantity – good or service discount
    '<cbc:LineExtensionAmount currencyID="JO"> (Unit Price * Quantity) – Discount on the good or service</cbc:LineExtensionAmount> The name and description of the good or service as found in the original invoice. <cbc:Name> Good or service description</cbc:Name> The price of the good or services as found in the original invoice
    '<cbc:PriceAmount currencyID="JO"> Unit price</cbc:PriceAmount> The amount of the discount on the good or service, if any, is to be added in JOD from the total price of the returned good or service.
    '<cbc:Amount currencyID="JO"> Amount of discount</cbc:Amount>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 30
    'مثال
    '<cac:InvoiceLine>== Start of the first (good or service) <cbc:ID>1</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">33.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">64.00</cbc:LineExtensionAmount> <cac:Item> <cbc:Name> Biscuit </cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">2.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine> <cac:InvoiceLine> == Start of the second (good or service) <cbc:ID>2</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">33.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">64.00</cbc:LineExtensionAmount> <cac:Item> <cbc:Name> Choclate </cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">2.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine>
    'Note Note Note
    'It is possible to It is possible to It is possible to It is possible to It is possible to return return more than one more than onemore than one more than one good or service by or service by or service by or service by or service by or service by or service by or service by re -enteringentering enteringentering the data of the data of the data of the data of good or good or service, as shown in the example service, as shown in the example service, as shown in the example service, as shown in the example service, as shown in the example service, as shown in the example service, as shown in the example service, as shown in the exampleservice, as shown in the example above above .
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 31
    'Third: The General Sales Invoice
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 32
    'The elements shaded in yellow in the examples below indicate variables to be filled (mandotary) through the seller system. As for the The elements shaded in green indicate variables to be filled (optional) through the seller system. And the rest of the elements are a fixed description (unchangeable).
    'A. Basic information of the invoice <cbc:ID> invoice no.</cbc:ID> <cbc:UUID> serial no.</cbc:UUID> <cbc:IssueDate> invoice date </cbc:IssueDate> <cbc:InvoiceTypeCode name=" payment method ">388</cbc:InvoiceTypeCode> <cbc:Note> Invoice description or remark </cbc:Note>
    '<cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode>
    '<cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode>
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID> Invoice counter </cbc:UUID>
    '</cac:AdditionalDocumentReference> Description XML Element Invoice no. is entered here. <cbc:ID> invoice no. </cbc:ID> UUID (Universal Unique Identifier) is a unique number generated by the taxpayer's system so that the ID and UUID together form a Primary Key to not duplicate the invoice sent on the system. <cbc:UUID> serial no .</cbc:UUID> The invoice date must be in the following format: dd-mm-yyyy, for example, 31-12-2022 <cbc:IssueDate> invoice date </cbc:IssueDate> The ‘name’ feature is to denote the payment method (cash,receivable) The codes contained in this example are for general tax invoices only. The no. (388) denotes a new invoice as described in the table below. <cbc:InvoiceTypeCode name=" payment method "> 388</cbc:InvoiceTypeCode>
    'Create a new cash invoice <cbc:InvoiceTypeCode name="012">388</cbc:InvoiceTypeCode> Create a new receivable invoice <cbc:InvoiceTypeCode name="022">388</cbc:InvoiceTypeCode>
    'Used for adding any remark or description to the invoice, or any data the seller wishes to document <cbc:Note> Invoice description or remark </cbc:Note>
    'The invoice counter is created by the taxpayer.
    'A counter created by the taxpayer for e-invoices starts in sequence from 1 to infinity According to the universal definition) Note: The taxpayer can costumize the sequence as preferred
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID> Invoice counter </cbc:UUID>
    '</cac:AdditionalDocumentReference>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 33
    'Example <cbc:ID>EIN0001</cbc:ID> <cbc:UUID>0043e15e-740b-4e1b-889d-504afdb1d1d</cbc:UUID> <cbc:IssueDate>2023-11-20</cbc:IssueDate> <cbc:InvoiceTypeCode name="012">388</cbc:InvoiceTypeCode> <cbc:Note>notes </cbc:Note> <cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode> <cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode> <cac:AdditionalDocumentReference> <cbc:ID>ICV</cbc:ID> <cbc:UUID>1</cbc:UUID> </cac:AdditionalDocumentReference>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 34
    'B. Seller’s information (taxpayer)
    '<cac:AccountingSupplierParty>
    '<cac:Party>
    '<cac:PostalAddress>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme> <cbc:CompanyID> seller’s TIN </cbc:CompanyID>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity> <cbc:RegistrationName>seller’s name</cbc:RegistrationName>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '</cac:AccountingSupplierParty> Description XML Element Taxpayer’s (seller’s) TIN <cbc:CompanyID> seller’s TIN </cbc:CompanyID> Seller’s name as registered in the ISTD <cbc:RegistrationName> seller’s name</cbc:RegistrationName> Example <cac:AccountingSupplierParty> <cac:Party> <cac:PostalAddress> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cbc:CompanyID>12345678</cbc:CompanyID> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> <cbc:RegistrationName> The Technical Company for Supplies </cbc:RegistrationName> </cac:PartyLegalEntity> </cac:Party> </cac:AccountingSupplierParty>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 35
    'C. Buyer’s information
    '<cac:AccountingCustomerParty>
    '<cac:Party>
    '<cac:PartyIdentification> <cbc:ID schemeID="type">no.</cbc:ID>
    '</cac:PartyIdentification>
    '<cac:PostalAddress> <cbc:PostalZone>postal code</cbc:PostalZone> <cbc:CountrySubentityCode>city</cbc:CountrySubentityCode>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme>
    '<cbc:CompanyID>1</cbc:CompanyID>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity> <cbc:RegistrationName>buyer’s name</cbc:RegistrationName>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '<cac:AccountingContact> <cbc:Telephone>phone no</cbc:Telephone>
    '</cac:AccountingContact>
    '</cac:AccountingCustomerParty> Description XML Element One of the options for the buyer's data is entered according to the following table: <cbc:ID schemeID="type">no.</cbc:ID> Type No.
    'NINBuyer’s national identification numberPN For non Jordanians (passport, residence, ect.) TN Buyer’s TIN
    'ملاحظة
    'The buyer’s name is mandatory The buyer’s name is mandatory The buyer’s name is mandatory The buyer’s name is mandatory The buyer’s name is mandatory The buyer’s name is mandatory The buyer’s name is mandatory The buyer’s name is mandatory The buyer’s name is mandatory only only if the invoice is (receivable) or if the invoice is (receivable) or if the invoice is (receivable) or if the invoice is (receivable) or if the invoice is (receivable) or if the invoice is (receivable) or if the invoice is (receivable) or if the invoice is (receivable) or if the invoice is (receivable) or if the invoice is (receivable) or if the invoice is (receivable) or if the invoice is (receivable) or if the invoice is (receivable) or if the invoice is (receivable) or if the invoice is (receivable) or if the invoice is (receivable) or (cashcash ) invoice invoice invoice value is more than 10000 JOD.value is more than 10000 JOD. value is more than 10000 JOD. value is more than 10000 JOD. value is more than 10000 JOD. value is more than 10000 JOD.
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 36
    'Description XML Element
    'Buyer’s postal code <cbc:PostalZone>postal code</cbc:PostalZone> The buyer’s city is replaced by a code based on the following table:
    'JO-BA BalqaJO-MN Ma’anJO-MD MadabaJO-MA MafraqJO-KA KarakJO-JA JerashJO-IR IrbidJO-AZ ZarqaJO-AT At-TafilahJO-AQ AqabaJO-AM AmmanJO-AJ Ajloun
    '<cbc:CountrySubentityCode>city </cbc:CountrySubentityCode>
    'Buyer’s name
    '<cbc:RegistrationName>buyer’s name</cbc:RegistrationName> Buyer’s phone number
    '<cbc:Telephone>buyer’s phone no.</cbc:Telephone> Example <cac:AccountingCustomerParty> <cac:Party> <cac:PartyIdentification> <cbc:ID schemeID="TN">33445544</cbc:ID> </cac:PartyIdentification> <cac:PostalAddress> <cbc:PostalZone>33554</cbc:PostalZone> <cbc:CountrySubentityCode>JO-AZ</cbc:CountrySubentityCode> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cbc:CompanyID>33445544</cbc:CompanyID> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> <cbc:RegistrationName>ahmad mahmoud</cbc:RegistrationName> </cac:PartyLegalEntity> </cac:Party> <cac:AccountingContact> <cbc:Telephone>324323434</cbc:Telephone> </cac:AccountingContact> </cac:AccountingCustomerParty>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 37
    'D. Seller’s (taxpayer’s) sequence of income source Description XML Element The taxpayer’s (seller’s) sequence of income source (activity)
    '<cac:SellerSupplierParty>
    '<cac:Party>
    '<cac:PartyIdentification> <cbc:ID> Sequence of income source</cbc:ID>
    '</cac:PartyIdentification>
    '</cac:Party>
    '</cac:SellerSupplierParty> Example <cac:SellerSupplierParty> <cac:Party> <cac:PartyIdentification> <cbc:ID>9932895</cbc:ID> </cac:PartyIdentification> </cac:Party> </cac:SellerSupplierParty>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 38
    'E. Inputs of the total general invoice
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">Total discount in JOD</cbc:Amount>
    '</cac:AllowanceCharge>
    '<cac:TaxTotal> <cbc:TaxAmount currencyID="JO">Total amount of general tax</cbc:TaxAmount>
    '</cac:TaxTotal>
    '<cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">Total invoice before discount</cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">Total invoice</cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">Total discount</cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID="JO">Total invoice</cbc:PayableAmount>
    '</cac:LegalMonetaryTotal> Description XML Element The total amount of discount on the goods, as the system does not accept discounts on the invoice in general.
    '<cbc:Amount currencyID="JO"> Total discount in JOD</cbc:Amount> Note: If the taxpayer system calculates the discount on the total invoice, the discount must be distributed to the goods and services before migrating the data to the e-invoicing system .
    'Total amount of general tax = sum ((total amount after discount + the amount of special tax) * general tax rate)
    '<cbc:TaxAmount currencyID="JO"> Total amount of general tax
    '</cbc:TaxAmount>
    'Total invoice before discount
    '<cbc:TaxExclusiveAmount currencyID="JO"> Total invoice before discount </cbc:TaxExclusiveAmount>
    'Total invoice before discount = sum (price * quantity) of all goods and services in the invoice. Total invoice
    '<cbc:TaxInclusiveAmount currencyID="JO"> Total invoice</cbc:TaxInclusiveAmount>
    'Total invoice = Total invoice before discount - Total discount amount + total amount of special tax + total amount of general tax Total discount
    '<cbc:AllowanceTotalAmount currencyID="JO"> Total discount</cbc:AllowanceTotalAmount>
    'Total discount amount = Total discount amount for goods and services Total invoice
    '<cbc:PayableAmount currencyID="JO"> Total invoice</cbc:PayableAmount>
    'Total invoice = Total invoice before discount - Total discount value + total amount of special tax + total amount of general tax
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 39
    'Example <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">4.48</cbc:TaxAmount> </cac:TaxTotal> <cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">66.00</cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">68.48</cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">2.00</cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID="JO">68.48</cbc:PayableAmount> </cac:LegalMonetaryTotal>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 40
    'F. Inputs of the general sales invoice items (goods)
    '<cac:InvoiceLine> <cbc:ID> Serial no.</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE"> Quantity </cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">(Unit Price * Quantity) – Discount on the good or service </cbc:LineExtensionAmount>
    '<cac:TaxTotal> <cbc:TaxAmount currencyID="JO"> tax amount on the good or service </cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO"> Total amount of the good or service including general and special taxes </cbc:RoundingAmount>
    '<cac:TaxSubtotal> <cbc:TaxAmount currencyID="JO"> tax amount on the good or service </cbc:TaxAmount>
    '<cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>percentage of general tax amount on the good or service </cbc:Percent>
    '<cac:TaxScheme>
    '<cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:TaxCategory>
    '</cac:TaxSubtotal>
    '</cac:TaxTotal>
    '<cac:Item> <cbc:Name> Good or service description </cbc:Name>
    '</cac:Item>
    '<cac:Price> <cbc:PriceAmount currencyID="JO"> Unit price before tax </cbc:PriceAmount>
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO"> Amount of discount </cbc:Amount>
    '</cac:AllowanceCharge>
    '</cac:Price>
    '</cac:InvoiceLine> Description XML Element A serial number that is unique for each (good or service). <cbc:ID> Serial no.</cbc:ID> The quantity of the same good or service.
    '<cbc:InvoicedQuantity unitCode="PCE"> Quantity </cbc:InvoicedQuantity> Total amount of the good or service = (Unit price * Quantity) - Discount on the good or service.
    '<cbc:LineExtensionAmount currencyID="JO"> (Unit Price * Quantity) – Discount on the good or service </cbc:LineExtensionAmount>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 41
    'Amount of general tax on the good or service = (Total value of the good or service * the general tax rate
    '<cbc:TaxAmount currencyID="JO"> Amount of tax on the good or service
    '</cbc:TaxAmount>
    'Description XML Element Total amount for the good or service including general and special tax= total value of the good or service + good or service tax value <cbc:RoundingAmount currencyID="JO"> total amount for the good or service including general and special tax </cbc:RoundingAmount> Illustrated in the table below <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID>
    'Value Description (Precent)Percentage of Tax
    'ZIn case the item or service is exempted 0
    'O In case the item or service is subject to a zero percent rate. 0
    'S In case the item or service is subject to a tax rate other than 0% 1,2,3,4,5,7,8,10,16.. The general tax rate on the item or service to be returned, based on the following rates: 1%, 2%, 3%, 4%, 5%, 7%, 8%, 10%, 16%, and the formula should be according to the following examples <cbc:Percent>1</cbc:Percent> <cbc:Percent>4</cbc:Percent> <cbc:Percent>8</cbc:Percent> <cbc:Percent>16</cbc:Percent>
    '<cbc:Percent> General tax percentage on the services or goods
    '</cbc:Percent> The name of good or service, or its description is to be added. <cbc:Name> Good or service description </cbc:Name> The unit price of the good or service before tax
    '<cbc:PriceAmount currencyID="JO"> Unit price before tax
    '</cbc:PriceAmount> The amount of the discount on the good or service, if any, is to be added in JOD from the total price of the good or service. <cbc:Amount currencyID="JO"> Discount amount
    '</cbc:Amount> Example <cac:InvoiceLine>== Start of the first good or service (example on a taxable good) <cbc:ID>1</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">33.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">64.00</cbc:LineExtensionAmount> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">4.48</cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">68.48</cbc:RoundingAmount> <cac:TaxSubtotal> <cbc:TaxAmount currencyID="JO">4.48</cbc:TaxAmount>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 42
    '<cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>7.00</cbc:Percent> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal> <cac:Item> <cbc:Name> Biscuit </cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">2.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine> <cac:InvoiceLine> == Start of the second good or service (example on exempted good) <cbc:ID>2</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">10.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">50.00</cbc:LineExtensionAmount> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">0.00</cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">50.00</cbc:RoundingAmount> <cac:TaxSubtotal> <cbc:TaxAmount currencyID="JO">0.00</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">Z</cbc:ID> <cbc:Percent>0.00</cbc:Percent> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal> <cac:Item> <cbc:Name> Choclate </cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">5.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 43
    '<cbc:Amount currencyID="JO">0.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine>
    'Note Note Note
    'It is possible to add more than one It is possible to add more than one It is possible to add more than one It is possible to add more than one It is possible to add more than one It is possible to add more than one It is possible to add more than one It is possible to add more than oneIt is possible to add more than one It is possible to add more than one (good(good or service or service or service or service ) by by re -enteringentering the data of the data of thethe data of the the data of the data of (good or good or service service service ), as shown in the example , as shown in the example , as shown in the example , as shown in the example, as shown in the example, as shown in the example, as shown in the example above aboveabove .
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 44
    'Fourth: Credit Invoice for General Sales
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 45
    'The elements shaded in yellow in the examples below indicate variables to be filled (mandotary) through the seller system. As for the The elements shaded in green indicate variables to be filled (optional) through the seller system. And the rest of the elements are a fixed description (unchangeable).
    'A. Basic information of the invoice <cbc:ID> credit invoice no.</cbc:ID> <cbc:UUID> credit invoice serial no. </cbc:UUID> <cbc:IssueDate>credit invoice date </cbc:IssueDate> <cbc:InvoiceTypeCode name="payment method ">381</cbc:InvoiceTypeCode>
    '<cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode>
    '<cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode>
    '<cac:BillingReference>
    '<cac:InvoiceDocumentReference> <cbc:ID> original reference invoice no </cbc:ID> <cbc:UUID> no. of the original reference invoice </cbc:UUID> <cbc:DocumentDescription> total value of the original reference invoice
    '</cbc:DocumentDescription>
    '</cac:InvoiceDocumentReference>
    '</cac:BillingReference>
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID> invoice counter </cbc:UUID>
    '</cac:AdditionalDocumentReference> Description XML Element Invoice no. is entered here. <cbc:ID>credit invoice no. </cbc:ID> UUID (Universal Unique Identifier) is a unique number generated by the taxpayer's system so that the ID and UUID together form a Primary Key to not duplicate the invoice sent on the system. <cbc:UUID> credit invoice serial no. </cbc:UUID> The invoice date must be in the following format: dd-mm-yyyy, for example, 31-12-2022 <cbc:IssueDate> credit invoice date </cbc:IssueDate> The ‘name’ feature is to denote the payment method (cash,receivable) The codes contained in this example are for income invoices only. The no. (381) denotes a credit invoice, as described in the table below. <cbc:InvoiceTypeCode name="payment method"> 381
    '</cbc:InvoiceTypeCode>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 46
    'Create a new cash invoice <cbc:InvoiceTypeCode name="012">381</cbc:InvoiceTypeCode> Create a new receivable invoice <cbc:InvoiceTypeCode name="022">381</cbc:InvoiceTypeCode>
    'B. Information of the reference invoice
    '<cac:BillingReference>
    '<cac:InvoiceDocumentReference> <cbc:ID> total value of the original reference invoice </cbc:ID> <cbc:UUID>original reference invoice serial no.</cbc:UUID> <cbc:DocumentDescription> total value of the original reference invoice </cbc:DocumentDescription>
    '</cac:InvoiceDocumentReference>
    '</cac:BillingReference> Description XML Element The original refrence invoice <cbc:ID> no. of the original reference invoice </cbc:ID> The original refrence invpoice serial no. <cbc:UUID> original reference invoice serial no </cbc:UUID>
    'The total value of the original refrence invoice <cbc:DocumentDescription> total value of the original reference invoice </cbc:DocumentDescription> The invoice counter is created by the taxpayer.
    'A counter created by the taxpayer for e-invoices starts in sequence from 1 to infinity According to the universal definition) Note: The taxpayer can customize the sequence as preferred
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID>invoice counter</cbc:UUID>
    '</cac:AdditionalDocumentReference> Example <cbc:ID>EIN0002</cbc:ID> <cbc:UUID>8055b137-a128-46d6-9421-8c2a6de57465</cbc:UUID> <cbc:IssueDate>2023-11-20</cbc:IssueDate> <cbc:InvoiceTypeCode name="012">381</cbc:InvoiceTypeCode> <cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode> <cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode> <cac:BillingReference> <cac:InvoiceDocumentReference> <cbc:ID>EIN0001</cbc:ID> <cbc:UUID>0043e15e-740b-4e1b-889d-8504afdb1d1d2</cbc:UUID>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 47
    '<cbc:DocumentDescription>68.48</cbc:DocumentDescription> </cac:InvoiceDocumentReference> </cac:BillingReference> <cac:AdditionalDocumentReference> <cbc:ID>ICV</cbc:ID> <cbc:UUID>2</cbc:UUID> </cac:AdditionalDocumentReference>
    'C. Seller's (Taxpayer's) Data
    '<cac:AccountingSupplierParty>
    '<cac:Party>
    '<cac:PostalAddress>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme> <cbc:CompanyID> Seller’s TIN</cbc:CompanyID>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity> <cbc:RegistrationName> Seller's Name</cbc:RegistrationName>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '</cac:AccountingSupplierParty> Description:XML Element Tax Identification Number for the taxpayer (seller) <cbc:CompanyID>> Seller’s TIN </cbc:CompanyID> The seller's name as registered in ISTD <cbc:RegistrationName>Seller’s Name</cbc:RegistrationName> Example:
    '<cac:AccountingSupplierParty> <cac:Party> <cac:PostalAddress> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cbc:CompanyID>12345678</cbc:CompanyID> <cac:TaxScheme>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 48
    '<cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> <cbc:RegistrationName> The Technical Company for Supplies </cbc:RegistrationName> </cac:PartyLegalEntity> </cac:Party> </cac:AccountingSupplierParty>
    'D. The buyer's information (description remains unchanged or added).
    'Example <cac:AccountingCustomerParty> <cac:Party> <cac:PostalAddress> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> </cac:PartyLegalEntity>
    '<cac:AccountingCustomerParty>
    '<cac:Party>
    '<cac:PostalAddress>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '</cac:AccountingCustomerParty>
    'The buyer's information should be taken from the original invoice without any modifications in the credit invoice.
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 49
    '</cac:Party> </cac:AccountingCustomerParty>
    'E. Seller’s (taxpayer’s) sequence of income source Description XML Element The taxpayer’s (seller’s) sequence of income source (activity)
    '<cac:SellerSupplierParty>
    '<cac:Party>
    '<cac:PartyIdentification> <cbc:ID> Sequence of income source</cbc:ID>
    '</cac:PartyIdentification>
    '</cac:Party>
    '</cac:SellerSupplierParty> Example <cac:SellerSupplierParty> <cac:Party> <cac:PartyIdentification> <cbc:ID>9932895</cbc:ID> </cac:PartyIdentification> </cac:Party> </cac:SellerSupplierParty>
    'F. Reason for return
    '<cac:PaymentMeans>
    '<cbc:PaymentMeansCode listID="UN/ECE 4461">10</cbc:PaymentMeansCode> <cbc:InstructionNote>Reason for return</cbc:InstructionNote>
    '</cac:PaymentMeans> DescriptionXML Element A reason for the return must be provided. <cbc:InstructionNote> Reason for return </cbc:InstructionNote> Example
    '<cac:PaymentMeans> <cbc:PaymentMeansCode listID="UN/ECE 4461">10</cbc:PaymentMeansCode> <cbc:InstructionNote>Items Expire</cbc:InstructionNote> </cac:PaymentMeans>
    'G. Total Discount
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 50
    '<cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO"> Total discount </cbc:Amount>
    '</cac:AllowanceCharge> DescriptionXML Element Total discount value for all items to be returned or partially returned. <cbc:Amount currencyID="JO"> Total discount </cbc:Amount> Example
    '<cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">25.00</cbc:Amount> </cac:AllowanceCharge>
    'H. Total tax value intended to be returned.
    '<cac:TaxTotal> <cbc:TaxAmount currencyID="JO"> Total value of the tax to be refunded from the invoice
    '</cbc:TaxAmount>
    '<cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO"> Total value of tax to be returned
    '</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO"> The value of the tax to be refunded for the item
    '</cbc:TaxAmount>
    '<cac:TaxCategory>
    '<cbc:ID schemeID="UN/ECE 5305" schemeAgencyID="6">S</cbc:ID> <cbc:Percent> The tax percentage for the item to be refunded
    '</cbc:Percent>
    '<cac:TaxScheme>
    '<cbc:ID schemeID="UN/ECE 5153" schemeAgencyID="6">VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:TaxCategory>
    '</cac:TaxSubtotal>
    '</cac:TaxTotal>
    'Description XML Element Total tax amount for all items to be refunded from the original invoice or refunding a portion of it. <cbc:TaxAmount currencyID="JO"> Total tax amount for all items to be refunded from the original invoice </cbc:TaxAmount> Total invoice amount to be refunded before tax. <cbc:TaxableAmount currencyID="JO"> Total invoice amount to be refunded </cbc:TaxableAmount> The value of the tax to be refunded for a single item or partial refund. <cbc:TaxAmount currencyID="JO"> The value of the tax to be refunded for a single item </cbc:TaxAmount>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 51
    'The tax percentage for the item to be returned or partially returned. <cbc:Percent> The tax percentage for the item to be returned </cbc:Percent> Example <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">160</cbc:TaxAmount> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">1000</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">160</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeID="UN/ECE 5305" schemeAgencyID="6">S</cbc:ID> <cbc:Percent>16.000</cbc:Percent> <cac:TaxScheme> <cbc:ID schemeID="UN/ECE 5153" schemeAgencyID="6">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal> Example for multiple items, each with a different tax percentage: <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">260</cbc:TaxAmount>== Tax Amount for Item 1 + Tax Amount for Item 2 <cac:TaxSubtotal>== of Item 1 <cbc:TaxableAmount currencyID="JO">1000</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">160</cbc:TaxAmount>==Tax Value of Item 1 <cac:TaxCategory> <cbc:ID schemeID="UN/ECE 5305" schemeAgencyID="6">S</cbc:ID> <cbc:Percent>16.000</cbc:Percent>==Tax Percentage of Item 1 <cac:TaxScheme> <cbc:ID schemeID="UN/ECE 5153" schemeAgencyID="6">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> <cac:TaxSubtotal>== of Item 2 <cbc:TaxableAmount currencyID="JO">1000</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">100</cbc:TaxAmount>== Tax Value of Item 2 <cac:TaxCategory> <cbc:ID schemeID="UN/ECE 5305" schemeAgencyID="6">S</cbc:ID> <cbc:Percent>10.000</cbc:Percent>== Tax Percentage of Item 2
    'Note:
    'In the case of returning more than one item, each with a different tax percentage, the <cac:TaxSubtotal> is repeated for each item, as shown in the following example:
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 52
    '<cac:TaxScheme> <cbc:ID schemeID="UN/ECE 5153" schemeAgencyID="6">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 53
    'I. Inputs of the total credit invoice.
    '<cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO"> Total invoice before discount </cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO"> Total invoice </cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO"> Total discount amount </cbc:AllowanceTotalAmount>
    '<cbc:PrepaidAmount currencyID="JO">0</cbc:PrepaidAmount> <cbc:PayableAmount currencyID="JO"> Total invoice </cbc:PayableAmount>
    '</cac:LegalMonetaryTotal> Description XML Element Total invoice (for the part to be returned) before discount
    '<cbc:TaxExclusiveAmount currencyID="JO"> Total invoice before discount </cbc:TaxExclusiveAmount>
    'Total invoice before discount = Sum of (Price * Quantity) for all items and services on the invoice Total invoice (for the portion to be returned)
    '<cbc:TaxInclusiveAmount currencyID="JO"> Total invoice </cbc:TaxInclusiveAmount> Total invoice amount = (Total invoice before discount - Total discount amount + Total general tax amount) Total discount amount (for the portion to be returned).
    '<cbc:AllowanceTotalAmount currencyID="JO"> Total discount amount </cbc:AllowanceTotalAmount>
    'Total discount amount = Sum of the discount value for goods and services Total invoice amount (for the portion to be returned)
    '<cbc:PayableAmount currencyID="JO"> Total invoice
    '</cbc:PayableAmount> Total invoice amount = (Total invoice before discount - Total discount amount + Total general tax amount)
    'Example <cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">1000</cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">1160</cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">0.00</cbc:AllowanceTotalAmount> <cbc:PrepaidAmount currencyID="JO">0</cbc:PrepaidAmount> <cbc:PayableAmount currencyID="JO">1160</cbc:PayableAmount> </cac:LegalMonetaryTotal>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 54
    'J. Inputs of the credit invoice items.
    '<cac:InvoiceLine> <cbc:ID> Serial no. </cbc:ID> <cbc:InvoicedQuantity unitCode="PCE"> Quantity </cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">(Unit Price * Quantity) – Discount on the good or service </cbc:LineExtensionAmount>
    '<cac:TaxTotal> <cbc:TaxAmount currencyID="JO">Tax value on services or goods</cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">Total amount of services or goods including tax </cbc:RoundingAmount>
    '<cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">(Unit Price * Quantity) – Discount on the good or service </cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO"> Tax value on services or goods </cbc:TaxAmount>
    '<cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>General tax percentage on the services or goods</cbc:Percent>
    '<cac:TaxScheme>
    '<cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:TaxCategory>
    '</cac:TaxSubtotal>
    '</cac:TaxTotal>
    '<cac:Item> <cbc:Name> Good or service description </cbc:Name>
    '</cac:Item>
    '<cac:Price> <cbc:PriceAmount currencyID="JO"> Unit price before tax</cbc:PriceAmount>
    '<cbc:BaseQuantity unitCode="C62">1</cbc:BaseQuantity>
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO"> discount value </cbc:Amount>
    '</cac:AllowanceCharge>
    '</cac:Price>
    '</cac:InvoiceLine>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 55
    'Description XML Element It is a unique serial number for each (item or service) <cbc:ID> Serial no</cbc:ID> The quantity for the specific item or service to be returned <cbc:InvoicedQuantity unitCode="PCE">Quantity
    '</cbc:InvoicedQuantity> The total amount for the item or service to be returned = Unit Price * Quantity - Item or Service Discount
    '<cbc:LineExtensionAmount currencyID="JO"> (Unit Price * Quantity) – Discount on the good or service </cbc:LineExtensionAmount> The tax value for the item or service to be returned = (Total amount for the item or service * Tax rate)
    '<cbc:TaxAmount currencyID="JO"> Tax value on services or goods </cbc:TaxAmount> The total amount for the item or service, inclusive of tax (to be returned) = Total amount for the item or service + Tax value for the item or service <cbc:RoundingAmount currencyID="JO"> Total amount of services or goods including tax </cbc:RoundingAmount> The total amount for the item or service to be returned = Unit Price * Quantity - Item or Service Discount <cbc:TaxableAmount currencyID="JO">(Unit Price * Quantity) – Discount on the good or service </cbc:TaxableAmount> The tax value for the item or service to be returned = (Total amount for the item or service * Tax rate) <cbc:TaxAmount currencyID="JO"> Tax value on services or goods </cbc:TaxAmount> Illustrated in the table below <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID>
    'Value Description (Precent)Percentage of Tax Z In case the item or service is exempt 0 O In case the item or service is subject to a zero percent rate. 0 S In case the item or service is subject to a tax rate other than 0% 1,2,3,4,5,7,8,10,16.. The general tax rate on the item or service to be returned, based on the following rates: 1%, 2%, 3%, 4%, 5%, 7%, 8%, 10%, 16%, and the formula should be according to the following examples <cbc:Percent>1</cbc:Percent> <cbc:Percent>2</cbc:Percent> <cbc:Percent>8</cbc:Percent> <cbc:Percent>16</cbc:Percent>
    '<cbc:Percent> General tax percentage on the services or goods </cbc:Percent> The name of the item or service or its description (to be returned) is specified <cbc:Name> Good or service description </cbc:Name> The price of the item or service before tax (to be returned)
    '<cbc:PriceAmount currencyID="JO"> Unit price before tax
    '</cbc:PriceAmount>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 56
    'The discount value for the item or service, if any, is added in Jordanian Dinars to the total price of the item or service (to be returned) <cbc:Amount currencyID="JO"> Value of discount
    '</cbc:Amount> Example: <cac:InvoiceLine>== Start of the first (good or service) <cbc:ID>1</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">33.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">64.00</cbc:LineExtensionAmount> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">4.48</cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">68.48</cbc:RoundingAmount> <cac:TaxSubtotal> <cbc:TaxAmount currencyID="JO">4.48</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>7.00</cbc:Percent> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal> <cac:Item> <cbc:Name> Biscuit </cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">2.00</cbc:PriceAmount> <cbc:BaseQuantity unitCode="C62">1</cbc:BaseQuantity> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine> <cac:InvoiceLine> == Start of the second (good or service) <cbc:ID>2</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">10.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">50.00</cbc:LineExtensionAmount> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">5.00</cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">55.00</cbc:RoundingAmount> <cac:TaxSubtotal> <cbc:TaxAmount currencyID="JO">5.00</cbc:TaxAmount> <cac:TaxCategory>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 57
    '<cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>10.00</cbc:Percent> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal> <cac:Item> <cbc:Name> Choclate </cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">5.00</cbc:PriceAmount> <cbc:BaseQuantity unitCode="C62">1</cbc:BaseQuantity> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">0.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine>
    'Note: Note:Note:
    'It is possible to It is possible to It is possible to It is possible to It is possible to It is possible to It is possible to It is possible to It is possible to return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of return more than one (item or service) by repeating the data of service to be returned, as shown in the example aboveservice to be returned, as shown in the example above service to be returned, as shown in the example aboveservice to be returned, as shown in the example above service to be returned, as shown in the example aboveservice to be returned, as shown in the example above service to be returned, as shown in the example aboveservice to be returned, as shown in the example aboveservice to be returned, as shown in the example aboveservice to be returned, as shown in the example aboveservice to be returned, as shown in the example above service to be returned, as shown in the example above service to be returned, as shown in the example above service to be returned, as shown in the example aboveservice to be returned, as shown in the example above service to be returned, as shown in the example above service to be returned, as shown in the example above service to be returned, as shown in the example aboveservice to be returned, as shown in the example above service to be returned, as shown in the example above service to be returned, as shown in the example aboveservice to be returned, as shown in the example above
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 58
    'Fifth: The Special Sales Invoice
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 59
    'The elements shaded in yellow in the examples below indicate variables to be filled through the seller system (mandatory) While element shaded in green indicate variables to be filled through the seller system (optional). The rest of the elements are a fixed description without changes.
    'A. Basic information of the main invoice <cbc:ID> invoice no. </cbc:ID> <cbc:UUID> Unduplicated serial no.</cbc:UUID> <cbc:IssueDate>2022-09-27</cbc:IssueDate> <cbc:InvoiceTypeCode name=" payment method">new/return </cbc:InvoiceTypeCode> <cbc:Note> Invoice description or remark </cbc:Note>
    '<cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode>
    '<cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode>
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID> Invoice counter </cbc:UUID>
    '</cac:AdditionalDocumentReference> Description XML Element Invoice no. is entered here.
    '<cbc:ID> invoice no.</cbc:ID> UUID (Universal Unique Identifier) is a unique number generated by the taxpayer's system so that the ID and UUID together form a Primary Key to not duplicate the invoice sent on the system.
    '<cbc:UUID> Unduplicated serial no.</cbc:UUID> The invoice date must be in the following format: dd-mm-yyyy, for example, 31-12-2022
    '<cbc:IssueDate> invoice date</cbc:IssueDate> The ‘name’ feature is to denote the payment method (cash,receivable) The codes contained in this example are for income invoices only. The no. (388) denotes a new invoice and the no. (381) denotes a credit invoice, as described in the table below.
    '<cbc:InvoiceTypeCode name=" payment method "> new/return </cbc:InvoiceTypeCode>
    'Create a new cash invoice <cbc:InvoiceTypeCode name="013">388</cbc:InvoiceTypeCode> Create a new receivable invoice <cbc:InvoiceTypeCode name="023">388</cbc:InvoiceTypeCode>
    'Used for adding any remark or description to the invoice, or any data the seller wishes to document.
    '<cbc:Note> Invoice description or remark </cbc:Note>
    'The invoice counter is created by the taxpayer. (A counter created by the taxpayer for electronic invoices, starting
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID> Invoice counter</cbc:UUID>
    '</cac:AdditionalDocumentReference>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 60
    'sequentially from 1 to infinity, according to the universal definition.) Note: The taxpayer can create the sequence as preferred
    'Example: <cbc:ID>EIN00090</cbc:ID> <cbc:UUID>0043e15e-740b-4e1b-889d-504afdb1d1d</cbc:UUID> <cbc:IssueDate>2022-09-27</cbc:IssueDate> <cbc:InvoiceTypeCode name="013">388</cbc:InvoiceTypeCode> <cbc:Note>Remarks 22</cbc:Note> <cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode> <cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode> <cac:AdditionalDocumentReference> <cbc:ID>ICV</cbc:ID> <cbc:UUID>1</cbc:UUID> </cac:AdditionalDocumentReference>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 61
    'B. Seller’s information (taxpayer)
    '<cac:AccountingSupplierParty>
    '<cac:Party>
    '<cac:PostalAddress>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme> <cbc:CompanyID> Seller’s TIN</cbc:CompanyID>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity> <cbc:RegistrationName> Seller’s name </cbc:RegistrationName>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '</cac:AccountingSupplierParty> Description XML Element Taxpayer’s (seller’s) tax ID
    '<cbc:CompanyID> Seller’s TIN </cbc:CompanyID> Seller’s name as registered in the ISTD
    '<cbc:RegistrationName> Seller’s name </cbc:RegistrationName> Example <cac:AccountingSupplierParty> <cac:Party> <cac:PostalAddress> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cbc:CompanyID>12345678</cbc:CompanyID> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> <cbc:RegistrationName> The Industrial Tobacco Production Company </cbc:RegistrationName> </cac:PartyLegalEntity> </cac:Party> </cac:AccountingSupplierParty>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 62
    'C. Buyer’s information
    '<cac:AccountingCustomerParty>
    '<cac:Party>
    '<cac:PartyIdentification> <cbc:ID schemeID=" Type">No.</cbc:ID>
    '</cac:PartyIdentification>
    '<cac:PostalAddress> <cbc:PostalZone> Postal Code </cbc:PostalZone> <cbc:CountrySubentityCode>City</cbc:CountrySubentityCode>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme>
    '<cbc:CompanyID>1</cbc:CompanyID>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity> <cbc:RegistrationName> Buyer’s name </cbc:RegistrationName>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '<cac:AccountingContact> <cbc:Telephone> Phone no.</cbc:Telephone>
    '</cac:AccountingContact>
    '</cac:AccountingCustomerParty> Description XML Element One of the options for the buyer's data is entered according to the following table:
    '<cbc:ID schemeID=" Type">No </cbc:ID> Type No. NIN Buyer’s national identification number PN Document no. (passport, residence, ect.) TN Buyer’s tax ID
    'Note: Note:Note:
    'The The The buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more buyer’s name is mandatory if the invoice receivable or cash value more than 10000 JOD. than 10000 JOD.
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 63
    'Description XML Element
    'Buyer’s postal code
    '<cbc:PostalZone>Postal Code</cbc:PostalZone> The buyer’s city is replaced by a code based on the following table: JO-BA BalqaJO-MN Ma’anJO-MD MadabaJO-MA MafraqJO-KA KarakJO-JA JerashJO-IR IrbidJO-AZ ZarqaJO-AT At-TafilahJO-AQ AqabaJO-AM AmmanJO-AJ Ajloun
    '<cbc:CountrySubentityCode>City
    '</cbc:CountrySubentityCode>
    'Buyer’s name
    '<cbc:RegistrationName>Buyer’s name</cbc:RegistrationName> Buyer’s phone number
    '<cbc:Telephone>Buyer’s phone no.</cbc:Telephone>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 64
    'Example <cac:AccountingCustomerParty> <cac:Party> <cac:PartyIdentification> <cbc:ID schemeID="TN">33445544</cbc:ID> </cac:PartyIdentification> <cac:PostalAddress> <cbc:PostalZone>33554</cbc:PostalZone> <cbc:CountrySubentityCode>JO-AZ</cbc:CountrySubentityCode> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cbc:CompanyID>33445544</cbc:CompanyID> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> <cbc:RegistrationName>Ahmad Mohammad</cbc:RegistrationName> </cac:PartyLegalEntity> </cac:Party> <cac:AccountingContact> <cbc:Telephone>324323434</cbc:Telephone> </cac:AccountingContact> </cac:AccountingCustomerParty>
    'D. Seller’s (taxpayer’s) sequence of income source Description XML Element The taxpayer’s (seller’s) sequence of income source (activity)
    '<cac:SellerSupplierParty>
    '<cac:Party>
    '<cac:PartyIdentification> <cbc:ID>Sequence of income source</cbc:ID>
    '</cac:PartyIdentification>
    '</cac:Party>
    '</cac:SellerSupplierParty> Example <cac:SellerSupplierParty> <cac:Party> <cac:PartyIdentification> <cbc:ID>9932895</cbc:ID> </cac:PartyIdentification> </cac:Party>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 65
    '</cac:SellerSupplierParty>
    'E. Inputes of the total special invoice
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">Total discount in JOD</cbc:Amount>
    '</cac:AllowanceCharge>
    '<cac:TaxTotal> <cbc:TaxAmount currencyID="JO">Total amount of general tax</cbc:TaxAmount>
    '</cac:TaxTotal>
    '<cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">Total invoice before discount</cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">Total invoice</cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">Total discount</cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID="JO">Total invoice</cbc:PayableAmount>
    '</cac:LegalMonetaryTotal>
    'Description XML Element The total amount of discount on the goods, as the system does not accept discounts on the invoice in general.
    '<cbc:Amount currencyID="JO"> Total discount in JOD</cbc:Amount> Note: If the taxpayer system calculates the discount on the total invoice, the discount must be distributed to the goods and services before migrating the data to the e-invoicing system .
    'Total amount of general tax = sum ((total amount after discount + the amount of special tax) * general tax rate)
    '<cbc:TaxAmount currencyID="JO"> Total amount of general tax
    '</cbc:TaxAmount>
    'Total invoice before discount
    '<cbc:TaxExclusiveAmount currencyID="JO"> Total invoice before discount </cbc:TaxExclusiveAmount>
    'Total invoice before discount = sum (price * quantity) of all goods and services in the invoice. Total invoice
    '<cbc:TaxInclusiveAmount currencyID="JO"> Total invoice</cbc:TaxInclusiveAmount>
    'Total invoice = Total invoice before discount - Total discount amount + total amount of special tax + total amount of general tax Total discount
    '<cbc:AllowanceTotalAmount currencyID="JO"> Total discount</cbc:AllowanceTotalAmount>
    'Total discount amount = Total discount amount for goods and services
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 66
    'Total invoice
    '<cbc:PayableAmount currencyID="JO"> Total invoice</cbc:PayableAmount>
    'Total invoice = Total invoice before discount - Total discount value + total amount of special tax + total amount of general tax Example <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID=""JO"">2.00</cbc:Amount> </cac:AllowanceCharge> <cac:TaxTotal> <cbc:TaxAmount currencyID=""JO"">144.48</cbc:TaxAmount> </cac:TaxTotal> <cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID=""JO"">1800.00</cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID=""JO"">1950.48</cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID=""JO"">3.00</cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID=""JO"">1950.48</cbc:PayableAmount> </cac:LegalMonetaryTotal>
    'Example <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">144.48</cbc:TaxAmount> </cac:TaxTotal> <cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">1800.00</cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">1950.48</cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">2.00</cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID="JO">1950.48</cbc:PayableAmount> </cac:LegalMonetaryTotal>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 67
    'F. Inputs of the special sales invoice items
    '<cac:InvoiceLine> <cbc:ID>Serial no.</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">Quantity</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">(Unit Price * Quantity) – Discount on the good or service
    '</cbc:LineExtensionAmount>
    '<cac:TaxTotal> <cbc:TaxAmount currencyID="JO">General tax amount on the good or service</cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">Total amount of the good or service including general and special taxes</cbc:RoundingAmount>
    '<cac:TaxSubtotal> <cbc:TaxableAmount currencyID=""JO"">(Unit Price * Quantity) – Discount on the good or service
    '</cbc:TaxableAmount> <cbc:TaxAmount currencyID=""JO"">Special tax amount on the good or service </cbc:TaxAmount>
    '<cac:TaxCategory> <cbc:ID schemeAgencyID=""6"" schemeID=""UN/ECE 5305"">S</cbc:ID>
    '<cac:TaxScheme>
    '<cbc:ID schemeAgencyID=""6"" schemeID=""UN/ECE 5153"">OTH</cbc:ID>
    '</cac:TaxScheme>
    '</cac:TaxCategory>
    '</cac:TaxSubtotal> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID=""JO"">(Unit Price * Quantity) – Discount on the good or service
    '</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">General tax amount on the good or service</cbc:TaxAmount>
    '<cac:TaxCategory>
    '<cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>General tax rate</cbc:Percent>
    '<cac:TaxScheme>
    '<cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:TaxCategory>
    '</cac:TaxSubtotal>
    '</cac:TaxTotal>
    '<cac:Item> <cbc:Name>Good or service name</cbc:Name>
    '</cac:Item>
    '<cac:Price> <cbc:PriceAmount currencyID="JO">Unit price before tax</cbc:PriceAmount>
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 68
    '<cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">Amount of discount</cbc:Amount>
    '</cac:AllowanceCharge>
    '</cac:Price>
    '</cac:InvoiceLine>
    'Description XML Element A serial number that is unique for each good or service. <cbc:ID> Serial no </cbc:ID> The quantity of the same good or service.
    '<cbc:InvoicedQuantity unitCode="PCE"> Quantity </cbc:InvoicedQuantity> Total amount of the good or service = (Unit price * Quantity) - Discount on the good or service.
    '<cbc:LineExtensionAmount currencyID="JO"> (Unit Price * Quantity) – Discount on the good or service </cbc:LineExtensionAmount> Amount of general tax on the good or service = (Total value of the good or service + the special tax amount) * the general tax rate
    '<cbc:TaxAmount currencyID="JO"> Amount of general tax on the good or service
    '</cbc:TaxAmount> Total value of the good or service that includes tax = total value of the good or service + amount of special tax on the good or service + amount of general tax on the good or service <cbc:RoundingAmount currencyID="JO"> Total value of the good or service including tax </cbc:RoundingAmount> Total amount of the good or service = Unit price * Quantity – Discount on the good or service <cbc:TaxableAmount currencyID=""JO"">(Unit Price * Quantity) – Discount on the good or service </cbc:TaxableAmount> The amount of special tax on the good or service <cbc:TaxAmount currencyID=""JO"">The amount of special tax on the good or service</cbc:TaxAmount> Total amount of the good or service = Unit price * Quantity – Discount on the good or service <cbc:TaxableAmount currencyID=""JO"">(Unit Price * Quantity) – Discount on the good or service </cbc:TaxableAmount> The amount of general tax on the good or service <cbc:TaxAmount currencyID="JO">The amount of general tax on the good or service</cbc:TaxAmount> As illustrated below: : <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 69
    'Value Description (Precent)Percentage of Tax Z In case the item or service is exempt 0 O In case the item or service is subject to a zero percent rate. 0 S In case the item or service is subject to a tax rate other than 0% 1,2,3,4,5,7,8,10,16.. The general tax rate on the good or service, based on the following rates: 0% (exempt), 1%, 2%, 3%, 4%, 5%, 7%, 8%, 10%, 16%. The format is based on the following examples: <cbc:Percent>0</cbc:Percent> <cbc:Percent>1</cbc:Percent> <cbc:Percent>8</cbc:Percent> <cbc:Percent>16</cbc:Percent>
    '<cbc:Percent> General tax rate on the good or service
    '</cbc:Percent> The name of good or service, or its description is to be added. <cbc:Name>Good or service description</cbc:Name> The unit price of the good or service before tax
    '<cbc:PriceAmount currencyID="JO"> Unit price before tax</cbc:PriceAmount> The amount of the discount on the good or service, if any, is to be added in JOD from the total price of the good or service. <cbc:Amount currencyID="JO"> Discount amount</cbc:Amount> Example: <cac:InvoiceLine>== Start of the first (good or service) <cbc:ID>1</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">10.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">495.00</cbc:LineExtensionAmount> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">50.500</cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">555.500</cbc:RoundingAmount> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">495.000</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">10.00</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 70
    '<cac:TaxScheme> <cbc:ID schemeAgencyID=""6"" schemeID=""UN/ECE 5153"">OTH</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">495.00</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">50.500</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>10.00</cbc:Percent> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal> <cac:Item> <cbc:Name>Malboro</cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">50.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">5.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine> <cac:InvoiceLine> == Start of the second (good or service) <cbc:ID>2</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">10.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">495.00</cbc:LineExtensionAmount> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">50.500</cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">555.500</cbc:RoundingAmount> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">495</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">10.00</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">OTH</cbc:ID>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 71
    '</cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">495.00</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">50.500</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>10.00</cbc:Percent> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal> <cac:Item> <cbc:Name>Malboro2 </cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">50.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">5.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine>
    'It is possible to add more than one good or service by re-entering the data of the good or service, as shown in the example above.
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 72
    'Sixth: The Credit Invoice for Special Sales
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 73
    'The elements shaded in yellow in the examples below indicate variables to be filled through the seller system (mandatory) While element shaded in green indicate variables to be filled through the seller system (optional). The rest of the elements are a fixed description without changes.
    'A. Basic Invoice Information <cbc:ID>Credit invoice no.</cbc:ID> <cbc:UUID>credit invoice serial no.</cbc:UUID> <cbc:IssueDate>Credit invoice date</cbc:IssueDate> <cbc:InvoiceTypeCode name=" Payment Method ">381</cbc:InvoiceTypeCode>
    '<cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode>
    '<cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode>
    '<cac:BillingReference>
    '<cac:InvoiceDocumentReference> <cbc:ID> The original refrence invoice no. </cbc:ID> <cbc:UUID> original refrence invoice serial no. </cbc:UUID> <cbc:DocumentDescription> The total value of the original refrence invoice </cbc:DocumentDescription>
    '</cac:InvoiceDocumentReference>
    '</cac:BillingReference>
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID> invoice counter </cbc:UUID>
    '</cac:AdditionalDocumentReference> Description XML Element Invoice no. is entered here.<cbc:ID> Credit invoice no .</cbc:ID>UUID (Universal Unique Identifier) is a unique number generated by the taxpayer's system so that the ID and UUID together form a Primary Key to not duplicate the invoice sent on the system.<cbc:UUID> Return invoive serial </cbc:UUID> The invoice date must be in the following format: dd-mm-yyyy, for example, 31-12-2022<cbc:IssueDate> Credit invoice date </cbc:IssueDate> The ‘name’ feature is to denote the payment method (cash,receivable) The codes contained in this example are for income invoices only. <cbc:InvoiceTypeCode name=" Payment Method "> 381
    '</cbc:InvoiceTypeCode>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 74
    'The no. (388) denotes a new invoice and the no. (381) denotes a credit invoice, as described in the table below.Create a cash refund invoice <cbc:InvoiceTypeCode name="013">381</cbc:InvoiceTypeCode> Create a receivable invoice <cbc:InvoiceTypeCode name="023">381</cbc:InvoiceTypeCode>
    'Invoice no. is entered here.<cbc:ID> Credit invoice no </cbc:ID>UUID (Universal Unique Identifier) is a unique number generated by the taxpayer's system so that the ID and UUID together form a Primary Key to not duplicate the invoice sent on the system. <cbc:UUID> credit invoice serial no.</cbc:UUID>
    'B. Information of the refrence invoice
    '<cac:BillingReference>
    '<cac:InvoiceDocumentReference> <cbc:ID> The original refrence invoice no. </cbc:ID> <cbc:UUID> original refrence invoice serial no.</cbc:UUID> <cbc:DocumentDescription> The total value of the original refrence invoice </cbc:DocumentDescription>
    '</cac:InvoiceDocumentReference>
    '</cac:BillingReference> Desciption XML Element The original refrence invoice no. <cbc:ID>The original refrence invoice </cbc:ID> The serial number of the original refrence <cbc:UUID> original refrence invoice serial no.</cbc:UUID>
    'The total amount of the original refrence invoice <cbc:DocumentDescription> The total amount of the original refrence </cbc:DocumentDescription> The invoice counter is created by the taxpayer. (A counter created by the taxpayer for electronic invoices, starting sequentially from 1 to infinity, according to the universal definition.) Note: The taxpayer can create the sequence as pereferd
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID> invoice counter</cbc:UUID>
    '</cac:AdditionalDocumentReference>
    'Example:
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 75
    '<cbc:ID>EIN0002</cbc:ID> <cbc:UUID>8055b137-a128-46d6-9421-8c2a6de57465</cbc:UUID> <cbc:IssueDate>2023-11-20</cbc:IssueDate> <cbc:InvoiceTypeCode name="013">381</cbc:InvoiceTypeCode> <cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode> <cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode> <cac:BillingReference> <cac:InvoiceDocumentReference> <cbc:ID>EIN0001</cbc:ID> <cbc:UUID>0043e15e-740b-4e1b-889d-8504afdb1d1d2</cbc:UUID> <cbc:DocumentDescription>68.48</cbc:DocumentDescription> </cac:InvoiceDocumentReference> </cac:BillingReference> <cac:AdditionalDocumentReference> <cbc:ID>ICV</cbc:ID> <cbc:UUID>2</cbc:UUID> </cac:AdditionalDocumentReference>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 76
    'C. Seller’s information (taxpayer)
    '<cac:AccountingSupplierParty>
    '<cac:Party>
    '<cac:PostalAddress>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme> <cbc:CompanyID> Seller’s TIN </cbc:CompanyID>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity> <cbc:RegistrationName> Seller’s name </cbc:RegistrationName>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '</cac:AccountingSupplierParty> Description XML Element Taxpayer’s (seller’s) tax ID<cbc:CompanyID>Seller’s TIN</cbc:CompanyID>Seller’s name as registered in the ISTD<cbc:RegistrationName>Seller’s name</cbc:RegistrationName> Example: <cac:AccountingSupplierParty> <cac:Party> <cac:PostalAddress> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cbc:CompanyID>12345678</cbc:CompanyID> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> <cbc:RegistrationName> The Industrial Tobacco Production Company </cbc:RegistrationName> </cac:PartyLegalEntity> </cac:Party> </cac:AccountingSupplierParty>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 77
    'D. The buyer's information (description remains unchanged or added).
    'Example <cac:AccountingCustomerParty> <cac:Party> <cac:PostalAddress> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> </cac:PartyLegalEntity> </cac:Party> </cac:AccountingCustomerParty>
    '<cac:AccountingCustomerParty>
    '<cac:Party>
    '<cac:PostalAddress>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '</cac:AccountingCustomerParty>
    'The buyer's information should be taken from the original invoice without any modifications in the credit invoice.
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 78
    'E. Seller’s (taxpayer’s) sequence of income source Description XML Element The taxpayer’s (seller’s) sequence of income source (activity)
    '<cac:SellerSupplierParty>
    '<cac:Party>
    '<cac:PartyIdentification>
    '<cbc:ID> sequence of income source </cbc:ID>
    '</cac:PartyIdentification>
    '</cac:Party>
    '</cac:SellerSupplierParty> Example <cac:SellerSupplierParty> <cac:Party> <cac:PartyIdentification> <cbc:ID>9932895</cbc:ID> </cac:PartyIdentification> </cac:Party> </cac:SellerSupplierParty>
    'F. Reason for return
    '<cac:PaymentMeans>
    '<cbc:PaymentMeansCode listID="UN/ECE 4461">10</cbc:PaymentMeansCode> <cbc:InstructionNote>Reason for return </cbc:InstructionNote>
    '</cac:PaymentMeans> Description XML Element A cause for the return must be provided. <cbc:InstructionNote> Reason for return
    '</cbc:InstructionNote> Example <cac:PaymentMeans> <cbc:PaymentMeansCode listID="UN/ECE 4461">10</cbc:PaymentMeansCode> <cbc:InstructionNote>Items Expire</cbc:InstructionNote> </cac:PaymentMeans>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 79
    'G. Inputs of the total credit invoice for special sales
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">Total discount in JOD</cbc:Amount>
    '</cac:AllowanceCharge>
    '<cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">Total invoice before discount</cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">Total invoice</cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">Total discount</cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID="JO">Total invoice</cbc:PayableAmount>
    '</cac:LegalMonetaryTotal>
    'Description XML Element The total amount of discount on the goods, as the system does not accept discounts on the invoice in general.
    '<cbc:Amount currencyID="JO"> Total discount in JOD</cbc:Amount> Note: If the taxpayer system calculates the discount on the total invoice, the discount must be distributed to the goods and services before migrating the data to the e-invoicing system .
    'The total value of general tax to be refunded = Sum of (Total amount after discount + Special tax value) * General tax rate
    '<cbc:TaxAmount currencyID="JO"> Total of amount of general tax
    '</cbc:TaxAmount> Total invoice before discount
    '<cbc:TaxExclusiveAmount currencyID="JO"> Total invoice before discount </cbc:TaxExclusiveAmount>
    'Total invoice before discount = sum (price * quantity) of all goods and services in the invoice. Total of invoice (to be returned)
    '<cbc:TaxInclusiveAmount currencyID="JO"> Total Inclusive Amount
    '</cbc:TaxInclusiveAmount> The total invoice amount = (Total invoice before discount – Total discount amount + Total special tax + Total general tax) The total discount amount to be refunded
    '<cbc:AllowanceTotalAmount currencyID="JO"> Total of discount
    '</cbc:AllowanceTotalAmount>
    'The total discount amount = Sum of the discount value for goods and services. The total invoice amount (to be refunded).
    '<cbc:PayableAmount currencyID="JO"> Total of invoice
    '</cbc:PayableAmount> The total invoice amount = (Total invoice before discount – Total discount amount + Total special tax + Total general tax).
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 80
    'Example <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">144.48</cbc:TaxAmount> </cac:TaxTotal> <cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">1800.00</cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">1950.48</cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">2.00</cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID="JO">1950.48</cbc:PayableAmount> </cac:LegalMonetaryTotal>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 81
    'H. Inputs of the credit invoice for special sales items
    '<cac:InvoiceLine> <cbc:ID> Serial no.</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE"> Quantity</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">(Unit Price * Quantity) – Discount on the good or service
    '</cbc:LineExtensionAmount>
    '<cac:TaxTotal> <cbc:TaxAmount currencyID="JO"> General tax amount on the good or service </cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO"> Total amount of the good or service including general and special taxes </cbc:RoundingAmount>
    '<cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">(Unit Price * Quantity) – Discount on the good or service </cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO"> Special tax amount on the good or service </cbc:TaxAmount>
    '<cac:TaxCategory>
    '<cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID>
    '<cac:TaxScheme>
    '<cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">OTH</cbc:ID>
    '</cac:TaxScheme>
    '</cac:TaxCategory>
    '</cac:TaxSubtotal> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">(Unit Price * Quantity) – Discount on the good or service </cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO"> General tax amount on the good or service </cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent> General tax rate </cbc:Percent>
    '<cac:TaxScheme>
    '<cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:TaxCategory>
    '</cac:TaxSubtotal>
    '</cac:TaxTotal> <cac:Item> <cbc:Name> Good or service name </cbc:Name>
    '</cac:Item>
    '<cac:Price> <cbc:PriceAmount currencyID="JO"> Unit price before tax </cbc:PriceAmount>
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO"> Amount of discount </cbc:Amount>
    '</cac:AllowanceCharge>
    '</cac:Price>
    '</cac:InvoiceLine>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 82
    '</Invoice> Description XML Element A serial number that is unique for each good or service. <cbc:ID>Serial no.</cbc:ID> The quantity of the same good or service(to be returned)
    '<cbc:InvoicedQuantity unitCode="PCE"> Quantity </cbc:InvoicedQuantity> Total amount of the good or service = (Unit price * Quantity) - Discount on the good or service.
    '<cbc:LineExtensionAmount currencyID="JO"> (Unit Price * Quantity) – Discount on the good or service</cbc:LineExtensionAmount> Amount of general tax on the good or service = (Total value of the good or service + the special tax amount) * the general tax rate<cbc:TaxAmount currencyID="JO"> Amount of general tax on the good or service
    '</cbc:TaxAmount> Total value of the good or service that includes tax = total value of the good or service + amount of special tax on the good or service + amount of general tax on the good or service <cbc:RoundingAmount currencyID="JO"> Total value of the good or service including tax </cbc:RoundingAmount> Total amount of the good or service = Unit price * Quantity – Discount on the good or service<cbc:TaxableAmount currencyID=""JO"">(Unit Price * Quantity) – Discount on the good or service </cbc:TaxableAmount> The amount of special tax on the good or service <cbc:TaxAmount currencyID="JO">The amount of special tax on the good or service</cbc:TaxAmount> Total amount of the good or service = Unit price * Quantity – Discount on the good or service<cbc:TaxableAmount currencyID=""JO"">(Unit Price * Quantity) – Discount on the good or service </cbc:TaxableAmount> The amount of general tax on the good or service <cbc:TaxAmount currencyID="JO">The amount of general tax on the good or service</cbc:TaxAmount> Illustrated in the table below <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID>
    'Value Description (Precent)Percentage of Tax Z In case the item or service is exempt 0 O In case the item or service is subject to a zero percent rate. 0 S In case the item or service is subject to a tax rate other than 0% 1,2,3,4,5,7,8,10,16..
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 83
    'The general tax rate on the good or service, based on the following rates: 0% (exempt), 1%, 2%, 3%, 4%, 5%, 7%, 8%, 10%, 16%. The format is based on the following examples: <cbc:Percent>0</cbc:Percent> <cbc:Percent>1</cbc:Percent> <cbc:Percent>8</cbc:Percent> <cbc:Percent>16</cbc:Percent>
    'The general tax rate on the good or service, based on the following rates:
    '0% (exempt), 1%, 2%, 3%, 4%, 5%, 7%, 8%, 10%, 16%.
    'The format is based on the following examples:
    '<cbc:Percent>0</cbc:Percent>
    '<cbc:Percent>1</cbc:Percent>
    '<cbc:Percent>8</cbc:Percent>
    '<cbc:Percent>16</cbc:Percent>
    'The name of good or service, or its description is to be added.
    'The name of good or service, or its description is to be added.
    'The unit price of the good or service before tax
    'The unit price of the good or service before tax
    'The amount of the discount on the good or service, if any, is to be added in JOD from the total price of the good or service. The amount of the discount on the good or service, if any, is to be added in JOD from the total price of the good or service. Example: <cac:InvoiceLine>== Start of the first (good or service) <cbc:ID>1</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">10.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">495.00</cbc:LineExtensionAmount> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">50.500</cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">555.500</cbc:RoundingAmount> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">495.000</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">10.00</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cac:TaxScheme> <cbc:ID schemeAgencyID=""6"" schemeID=""UN/ECE 5153"">OTH</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> <cac:TaxSubtotal>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 84
    '<cbc:TaxableAmount currencyID="JO">495.00</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">50.500</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>10.00</cbc:Percent> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal> <cac:Item> <cbc:Name>Malboro</cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">50.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">5.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine> <cac:InvoiceLine>== Start of the second (good or service) <cbc:ID>2</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">10.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">495.00</cbc:LineExtensionAmount> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">50.500</cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">555.500</cbc:RoundingAmount> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">495</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">10.00</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">OTH</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">495.00</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">50.500</cbc:TaxAmount>
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 85
    '<cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>10.00</cbc:Percent> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal> <cac:Item> <cbc:Name>Malboro2 </cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">50.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">5.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine>
    'It is possible to return more than one (item or service) by repeating the data of the item or service to intended for return, as shown in the example above
    'Income & Sales Tax Department
    'THE TECHNICAL GUIDE ON INTEGRATION WITH THE NATIONAL E-INVOICING SYSTEM (JOFOTARA) 86
    'I. Preparing and sending the JSON file
    '- After preparing the invoice in the (XML) format, the file is encrypted on the (Base64) system and included in a JSON file with the addition of the Client ID and the Secret Key, as shown in the example below:
    'An example showing how the invoice is integrated with the Client ID and the Secret Key after encrypting it using C# ResetSharp language var client = new RestClient("https://backend.jofotara.gov.jo/core/invoices/"); client.Timeout = -1; var request = new RestRequest(Method.POST); request.AddHeader("Client-Id", " Client-Id "); request.AddHeader("Secret-Key", " Secret-Key "); request.AddHeader("Content-Type", "application/json"); request.AddHeader("Cookie", "stickounet=4fdb7136e666916d0e373058e9e5c44e|7480c8b0e4ce7933ee164081a50488f1"); var body = @"{" + "\n" + @" ""invoice"": ""Encrypted XML Code""" + "\n" + @"}"; request.AddParameter("application/json", body, ParameterType.RequestBody); IRestResponse response = client.Execute(request); Console.WriteLine(response.Content);
    '- The JSON file is sent on the following API: https://backend.jofotara.gov.jo/core/invoices/ - After the sending process, the server responds with a JSON file that contains messages indicating the success of the process and its conformity with the requirements or indicating the failure of the process. - If the process is successful, the file contains a QR Code that must be shown on the seller’s invoice.
    'Note: Note:Note:
    'For more For more For more information information information , you , you , you may contact thecontact the contact the ‘JoFotara’ ‘JoFotara’ ‘JoFotara’ ‘JoFotara’ ‘JoFotara’ Technical Support Committee at the Technical Support Committee at the Technical Support Committee at the Technical Support Committee at the Technical Support Committee at the Technical Support Committee at the Technical Support Committee at the Technical Support Committee at the Technical Support Committee at the Technical Support Committee at the Technical Support Committee at the Technical Support Committee at the Technical Support Committee at the Income and Sales Tax Department Income and Sales Tax Department Income and Sales Tax Department Income and Sales Tax Department Income and Sales Tax Department Income and Sales Tax Department Income and Sales Tax Department Income and Sales Tax Department Income and Sales Tax Department Income and Sales Tax Department Income and Sales Tax Department Income and Sales Tax Department Income and Sales Tax Department using the following link: https://istd.gov.jo the following link: https://istd.gov.jo the following link: https://istd.gov.jo the following link: https://istd.gov.jo the following link: https://istd.gov.jothe following link: https://istd.gov.jo the following link: https://istd.gov.jo the following link: https://istd.gov.jo the following link: https://istd.gov.jothe following link: https://istd.gov.jo .
End Class
