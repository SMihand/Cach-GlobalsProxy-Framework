//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:2.0.50727.5485
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EXTREMEAccessTESTS.Generated
{
    using CacheEXTREME2.WMetaGlobal;
    using CacheEXTREME2.WProxyGlobal;
    using InterSystems.Globals;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class WowsTestContext : CacheEXTREME2.WProxyGlobal.CacheEXTREMEcontext
    {
        
        public ProxyManager<classinfoProxy, classinfoProxyKey> classinfoManager;
        
        public ProxyManager<stuffProxy, stuffProxyKey> stuffManager;
        
        public ProxyManager<shipinfoProxy, shipinfoProxyKey> shipinfoManager;
        
        public WowsTestContext(InterSystems.Globals.Connection conn , string global = "wowsTest") : 
                base(conn, global, "wowsTestMeta",new MetaReader(conn))
        {
            this.classinfoManager = new ProxyManager<classinfoProxy, classinfoProxyKey>(base.entitiesMeta[typeof(classinfoProxy).Name], base.globalRef, base.structsManagers);
            this.stuffManager = new ProxyManager<stuffProxy, stuffProxyKey>(base.entitiesMeta[typeof(stuffProxy).Name], base.globalRef, base.structsManagers);
            this.shipinfoManager = new ProxyManager<shipinfoProxy, shipinfoProxyKey>(base.entitiesMeta[typeof(shipinfoProxy).Name], base.globalRef, base.structsManagers);
        }
    }
    
    public class classinfoProxy
    {
        
        // name: shipclass(String), min: 0, max: 255, def: null
        public String shipclass;
        
        // name: shipsCount(Int32), min: 0, max: 1000, def: 0
        public Int32 shipsCount;
        
        public classinfoProxy(String shipclass, Int32 shipsCount)
        {
            this.shipclass = shipclass;
            this.shipsCount = shipsCount;
        }
        
        public classinfoProxy()
        {
            this.shipclass = "null";
            this.shipsCount = 0;
        }
        
        public virtual bool classinfoValidator(classinfoProxy entity)
        {
            return true;
        }
    }
    
    public class classinfoProxyKey
    {
        
        // name: shipclass(String), min: 0, max: 255, def: null
        public String shipclass;
        
        public classinfoProxyKey(String shipclass)
        {
            this.shipclass = shipclass;
        }

        public classinfoProxyKey()
        {
        }
    }
    
    public class stuffProxy
    {
        
        // name: shipclass(String), min: 0, max: 255, def: null
        public String shipclass;
        
        // name: shiprank(Int32), min: 0, max: 1000000, def: 5
        public Int32? shiprank;
        
        // name: workers(List<StringValMeta>), min: 0, max: 100
        public List<String> workers;
        
        // name: officers(List<StringValMeta>), min: 0, max: 100
        public List<String> officers;
        
        // name: workerSalary(Int32), min: 1, max: 2000, def: 0
        public Int32 workerSalary;
        
        // name: photo(byte[]), max: 200000
        public Byte[] photo;
        
        public stuffProxy(String shipclass, Int32? shiprank, List<String> workers, List<String> officers, Int32 workerSalary, Byte[] photo)
        {
            this.shipclass = shipclass;
            this.shiprank = shiprank;
            this.workers = workers;
            this.officers = officers;
            this.workerSalary = workerSalary;
            this.photo = photo;
        }
        
        public stuffProxy()
        {
            this.shipclass = "null";
            this.shiprank = 5;
            this.workers = new List<String>();
            this.officers = new List<String>();
            this.workerSalary = 0;
            this.photo = null;
        }
        
        public virtual bool stuffValidator(stuffProxy entity)
        {
            return true;
        }
    }
    
    public class stuffProxyKey
    {
        
        // name: shipclass(String), min: 0, max: 255, def: null
        public String shipclass;
        
        // name: shiprank(Int32), min: 0, max: 1000000, def: 5
        public Int32? shiprank;
        
        public stuffProxyKey(String shipclass, Int32? shiprank)
        {
            this.shipclass = shipclass;
            this.shiprank = shiprank;
        }

        public stuffProxyKey()
        {
        }
    }
    
    public class shipinfoProxy
    {
        
        // name: shipclass(String), min: 0, max: 255, def: null
        public String shipclass;
        
        // name: shiprank(Int32), min: 0, max: 1000000, def: 5
        public Int32? shiprank;
        
        // name: shipname(String), min: 0, max: 50, def: 5
        public String shipname;
        
        // name: captains(List<StringValMeta>), min: 0, max: 100
        public List<String> captains;
        
        public shipinfoProxy(String shipclass, Int32? shiprank, String shipname, List<String> captains)
        {
            this.shipclass = shipclass;
            this.shiprank = shiprank;
            this.shipname = shipname;
            this.captains = captains;
        }
        
        public shipinfoProxy()
        {
            this.shipclass = "null";
            this.shiprank = 5;
            this.shipname = "5";
            this.captains = new List<String>();
        }
        
        public virtual bool shipinfoValidator(shipinfoProxy entity)
        {
            return true;
        }
    }
    
    public class shipinfoProxyKey
    {
        
        // name: shipclass(String), min: 0, max: 255, def: null
        public String shipclass;
        
        // name: shiprank(Int32), min: 0, max: 1000000, def: 5
        public Int32? shiprank;
        
        // name: shipname(String), min: 0, max: 50, def: 5
        public String shipname;
        
        public shipinfoProxyKey(String shipclass, Int32? shiprank, String shipname)
        {
            this.shipclass = shipclass;
            this.shiprank = shiprank;
            this.shipname = shipname;
        }
    }
}