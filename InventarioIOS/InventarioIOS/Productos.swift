//
//  Productos.swift
//  InventarioIOS
//
//  Created by Douglas on 12/6/20.
//  Copyright © 2020 Douglas. All rights reserved.
//

import UIKit

class Productos: NSObject {
    var producto: String?
    var stock: Double?
    var costoUnitario: Double?
    
    var productos = [Productos]()
    
    init(producto: String, stock: Double)
    {
        self.producto = producto
        self.stock = stock
    }
}
