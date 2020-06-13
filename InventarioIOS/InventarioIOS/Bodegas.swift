//
//  Bodegas.swift
//  InventarioIOS
//
//  Created by Douglas on 12/6/20.
//  Copyright © 2020 Douglas. All rights reserved.
//

import UIKit

class Bodegas: NSObject {
    var idBodega: Int?
    var nombre: String?
    var bodegas = [Bodegas]()
    
    static var arrayBodegas = [Bodegas]()
    
    static func all()
    {
        WebService.requestBodegas{ json in
            let objects = json as? [Dictionary<String,AnyObject>]
            for object in objects!{
                arrayBodegas.append(Bodegas(dictionary:object))
            }
        }
    }
    
    init(dictionary: [String:AnyObject]){
        self.idBodega = dictionary["Id_Bodega"] as? Int
        self.nombre = dictionary["Nombre"] as? String

    }
    
}
