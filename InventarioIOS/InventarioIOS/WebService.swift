//
//  WebService.swift
//  InventarioIOS
//
//  Created by Douglas on 12/6/20.
//  Copyright © 2020 Douglas. All rights reserved.
//

import UIKit

class WebService: NSObject {
    
    static func requestIndex(completed: @escaping (Any?) -> Void )
    {
        
        let url = URL(string: "http://192.168.1.5:8090/api/Productos/Expiration?dateInit=23/05/2020&dateEnd=23/10/2020")
        /*
        let url = URL(string: "http://cristiantorresalfaro.somee.com/api/Productos/Expiration?dateInit=23/05/2020&dateEnd=23/10/2020")
        */
        var request = URLRequest(url: url!)
        request.httpMethod = "GET"
        request.addValue("application/json", forHTTPHeaderField: "Accept")
        request.addValue("application/json", forHTTPHeaderField: "Content-Type")
        
        let task = URLSession.shared.dataTask(with: request){(data,response,error) in
            let jsonObject = try? JSONSerialization.jsonObject(with: data!, options: .allowFragments)
            print(jsonObject!)
            
            completed(jsonObject)
        }
        task.resume()
    }
    
    
    static func requestBodegas(completed: @escaping (Any?) -> Void )
    {
        let url = URL(string: "http://192.168.1.5:8090/api/Bodega/GetBodegas")
        var request = URLRequest(url: url!)
        request.httpMethod = "GET"
        request.addValue("application/json", forHTTPHeaderField: "Accept")
        request.addValue("application/json", forHTTPHeaderField: "Content-Type")
        
        let task = URLSession.shared.dataTask(with: request){(data,response,error) in
            let jsonObject = try? JSONSerialization.jsonObject(with: data!, options: .allowFragments)
            print(jsonObject!)
            
            completed(jsonObject)
        }
        task.resume()
    }
    
}
