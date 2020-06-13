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
    
    static var community = [Productos]()
    
    init(producto: String, stock: Double)
    {
        self.producto = producto
        self.stock = stock
    }
    
    static func all()
    {
        WebService.requestIndex{ json in
            let objects = json as? [Dictionary<String,AnyObject>]
            for object in objects!{
                community.append(Productos(dictionary:object))
            }
        }
    }
    
    init(dictionary: [String:AnyObject]){
        self.producto = dictionary["Producto"] as? String
        self.stock = dictionary["Stock"] as? Double
        self.costoUnitario = dictionary["Costo_Unitario"] as? Double
    }
}
