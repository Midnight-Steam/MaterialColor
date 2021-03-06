﻿namespace Common.Json
{
    public abstract class BaseManager
    {
        protected BaseManager(JsonManager manager, IO.Logger logger = null)
        {
            _logger = logger;
            _manager = manager;
        }

        protected IO.Logger _logger;
        protected JsonManager _manager;
    }
}
