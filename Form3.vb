Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'مرفق ملفات بي دي اف
    End Sub
    'BY: FADI AL-HAMAD, KHALDOON ABUYAMAN
    'E-INVOICING TECHNICAL GUIDE APPENDEX 2/21/2024
    '1 . طريقة الاحتساب ) Calculation Method :)
    '•يتم احتساب القيم في ملف XML حسب المعادلات الآتية:
    'Invoice Line : 
    'lineExtensionAmount
    'ROUND (quantity * unitPrice - Discount; 9)
    'taxAmount (Line)
    'ROUND ((quantity * unitPrice - discount) * taxPercent; 9)
    'RoundingAmount
    'ROUND ((quantity * unitPrice - discount) + TaxAmount; 9)
    'AllowanceCharge.Amount
    '9 Digits
    'Invoice:
    'AllowanceCharge.Amount
    'Sum (AllowanceCharge.Amount (Line))
    'TaxAmount
    'Sum (taxAmount (Line))
    'TaxExclusiveAmount
    'ROUND (Sum (quantity * unitPrice); 9)
    'TaxInclusiveAmount
    'Sum (RoundingAmount)
    'BY: FADI AL-HAMAD, KHALDOON ABUYAMAN
    'E-INVOICING TECHNICAL GUIDE APPENDEX 2/21/2024
    '2 . أنواع الفواتير) Invoices Types:)
    '1 - الفاتورة المحلية ) Local Invoice )
    '2 - فاتورة تصدير ) Export Invoice )
    '3 - فاتورة مناطق تنموية ) Development Area Invoice )
    '<cbc:InvoiceTypeCode name = "022" >
    '0 2 2
    'محلية ) 0 ) تصدير ) 1 ) تنموية ) 2 ) نقدية ) 1 ذمم ) ( 2 ) دخل ) 1 ) مبيعات ) 2 ) خاصة) 3 )
    '•يتم تغيير القيمة في ملف XML حسب نوع الفاتورة وطريقة الدفع ونوع المكلف كما في الجدول الآتي
    'فاتورة دخل نقدية محلية
    '<cbc:InvoiceTypeCode name = "011" >
    'فاتورة دخل ذمم محلية
    '<cbc:InvoiceTypeCode name = "021" >
    'فاتورة دخل نقدية تصدير
    '<cbc:InvoiceTypeCode name = "111" >
    'فاتورة دخل ذمم تصدير
    '<cbc:InvoiceTypeCode name = "121" >
    'فاتورة مبيعات عامة نقدية محلية
    '<cbc:InvoiceTypeCode name = "012" >
    'فاتورة مبيعات عامة ذمم محلية
    '<cbc:InvoiceTypeCode name = "022" >
    'فاتورة مبيعات عامة نقدية تصدير
    '<cbc:InvoiceTypeCode name = "112" >
    'فاتورة مبيعات عامة ذمم تصدير
    '<cbc:InvoiceTypeCode name = "122" >
    'فاتورة مبيعات عامة نقدية مناطق تنموية <cbc:InvoiceTypeCode name = "212" >
    'فاتورة مبيعات عامة ذمم تصدير مناطق تنموية
    '<cbc:InvoiceTypeCode name = "222" >
    'فاتورة مبيعات خاصة نقدية محلية
    '<cbc:InvoiceTypeCode name = "013" >
    'فاتورة مبيعات خاصة ذمم محلية
    '<cbc:InvoiceTypeCode name = "023" >
    'فاتورة مبيعات خاصة نقدية تصدير
    '<cbc:InvoiceTypeCode name = "113" >
    'فاتورة مبيعات خاصة ذمم تصدير
    '<cbc:InvoiceTypeCode name = "123" >
    'فاتورة مبيعات خاصة نقدية مناطق تنموية <cbc:InvoiceTypeCode name = "213" >
    'فاتورة مبيعات خاصة ذمم تصدير مناطق تنموية
    '<cbc:InvoiceTypeCode name = "223" >
    'BY: FADI AL-HAMAD, KHALDOON ABUYAMAN
    'E-INVOICING TECHNICAL GUIDE APPENDEX 2/21/2024
    '3 . العملات الأجنبية ) Currencies :)
    '<cbc: DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode>
    '<cbc: TaxCurrencyCode>JOD</cbc:TaxCurrencyCode>
    '•يتم تغيير نوع العملة في ملف XML حسب العملة المطلوبة كما في الجدول الآتي
    '# Currency Description Arabic description
    '1
    'USD
    'United States Dollar
    'دولار امري ك
    '2
    'EUR
    'Euro
    'يورو
    '3
    'SAR
    'Saudi Riyal
    'ريال سعودي
    '4
    'AED
    'UAE Dirham
    'درهم امارا ت
    '5
    'OMR
    'Rial Omani
    'ريال عما ت
    '6
    'GBP
    'Pound Sterling
    'جنيه
    'اس تلي ن
    '7
    'QAR
    'Qatari Rial
    'ريال قطري
    '8
    'KWD
    'Kuwaiti Dinar
    'دينار كوي ن
    '9
    'BHD
    'Bahraini Dinar
    'دينار بحري ن
    '10
    'AUD
    'Australian Dollar
    'دولار اس تا ل
    '11
    'CAD
    'Cadian Dollar
    'دولار كندي
    '12
    'JPY
    'Japanese Yen
    'ين يابا ت
    '13
    'CHF
    'Swiss Franc
    'فرنك سويسري
    '14
    'Try
    'Turkish Lira
    'ل رتة تر ك
    '15
    'SYP
    'Syrian Pound
    'ل رتة سوري
    '16
    'EGP
    'Egyptian Pound
    'جنيه مصري
    '• Dollar Example
    '<cbc: DocumentCurrencyCode>USD</cbc:DocumentCurrencyCode>
    '<cbc: TaxCurrencyCode>USD</cbc:TaxCurrencyCode>
    'With Best Regards
End Class