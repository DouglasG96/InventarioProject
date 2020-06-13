//
//  WebService.swift
//  InventarioIOS
//
//  Created by Douglas on 12/6/20.
//  Copyright © 2020 Douglas. All rights reserved.
//

import UIKit

class WebService: NSObject {
    
    static func requestIndex()
    {
        let url = URL(string: "https://192.168.1.5:44356/api/")
        var request = URLRequest(url: url!)
        request.httpMethod = "GET"
        request.addValue("application/json", forHTTPHeaderField: "Accept")
        request.addValue("application/json", forHTTPHeaderField: "Content-Type")
        
        
        let task = URLSession.shared.dataTask(with: request){(data,response,error) in let jsonObject = try? JSONSerialization.jsonObject(with: data!, options: .allowFragments)
            print(jsonObject!)
        }
    
}
